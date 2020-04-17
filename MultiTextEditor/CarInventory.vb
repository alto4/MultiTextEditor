' Author: Scott Alton
' Last Modified: March 15, 2020
' Description: This application accepts user entries that represent cars in a dealership's inventory catelogue, and logs details 
'              regarding the cars make, model, the year it was manufactured, list price, as well as whether it is being sold in new or used condition. 

Option Strict On

Public Class frmCarInventory

    ' VARIABLE DECLARATIONS
    Private carList As New SortedList
    Private currentCarIdNumber As String = String.Empty
    Private isCarSelected As Boolean = False
    Private inEditMode As Boolean = False

    ' Create a single instance of the car inventory form
    Private Shared carInventoryInstance As frmCarInventory

    ' EVENT HANDLERS

    ''' <summary>
    ''' Event Handler for Exit Button - exit the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Event Handler for Enter Button - validate all input fields, and once valid, display entry in list of car inventory
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Class variable declarations
        Dim car As Car
        Dim carItem As ListViewItem

        ' Validate input fields using IsValidInput function before creating new car object
        If IsValidInput() = True Then

            ' Turn edit mode on 
            inEditMode = True
            lblOutput.Text = "Editor mode is turned on for this selection"

            ' Ensure that car ID number exists in the list, otherwise create a new car object
            If currentCarIdNumber.Trim.Length = 0 Then

                ' Create new car object with arguments provided in input fields by the user
                car = New Car(cmbMake.Text, txtModel.Text, Convert.ToInt32(cmbYear.Text), Convert.ToDecimal(txtPrice.Text), chkNew.Checked)

                ' Add car to the car inventory list
                carList.Add(car.Id.ToString(), car)

            Else

                ' If the current ID number exists, load data from the car object and reflect updates made by user
                car = CType(carList.Item(currentCarIdNumber), Car)

                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = Convert.ToInt32(cmbYear.Text)
                car.Price = Convert.ToDecimal(txtPrice.Text)
                car.IsNew = chkNew.Checked

            End If

            ' Clear the items from listview control
            lvwInventory.Items.Clear()

            ' Populate list view containing inventory of cars by looping through the list
            For Each carEntry As DictionaryEntry In carList

                ' Create a new item in list view retrive from list 
                carItem = New ListViewItem()
                car = CType(carEntry.Value, Car)

                ' Assign values to controls/subitems
                carItem.SubItems.Add(car.Id.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString())
                carItem.SubItems.Add(FormatCurrency(car.Price).ToString())
                carItem.Checked = car.IsNew

                ' Add instantiated item to listview control
                lvwInventory.Items.Add(carItem)

            Next carEntry

            ' Clear all controls
            Reset()

            ' Turn off edit mode
            inEditMode = False

        End If

    End Sub

    ''' <summary>
    ''' Event Handler for Reset Button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Reset()

    End Sub


    ' FUNCTIONS AND SUBPROCEDURES

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()

        cmbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cmbYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        chkNew.Checked = False

        cmbMake.SelectedIndex = -1
        lblOutput.Text = String.Empty

        currentCarIdNumber = String.Empty

        ' Set focus on first input field 
        cmbMake.Focus()

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data that the user inputs in each form control 
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' Check if the make has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If make has not been selected, display an error message and set returnValue to false
            outputMessage += "Please select the car's make." & vbCrLf
            returnValue = False

        End If

        ' Check if the model has been entered
        If txtModel.Text.Trim.Length = 0 Then

            ' If model has not been entered, display an error message and set returnValue to false
            outputMessage += "Please enter the car's model." & vbCrLf
            returnValue = False

        End If

        ' Check if the year has been selected
        If cmbYear.SelectedIndex = -1 Then

            ' If year has not been selected, display an error message and set returnValue to false
            outputMessage += "Please select the year that the car was manufactured in." & vbCrLf
            returnValue = False

        End If

        ' Check if the price has been entered
        If txtPrice.Text.Trim.Length = 0 Then

            ' If price has not been entered, display an error message and set returnValue to false
            outputMessage += "Please enter the car's price." & vbCrLf
            returnValue = False

        End If

        ' Check if the entered price is numeric
        If Not IsNumeric(txtPrice.Text) Then

            ' If price is not a numeric value, output an error message
            outputMessage += "Please enter a valid numeric value for the car's price"
            returnValue = False

        End If

        ' Check if the entered price is above or equal to 0
        If txtPrice.Text.Trim.Length > 0 And IsNumeric(txtPrice.Text) Then

            ' Parse entered value in txtPrice as a decimal so it can be compared with 0 to test validity
            Dim check As Decimal = Decimal.Parse(txtPrice.Text)

            If check < 0 Then

                ' If the price is less than 0, output an error message 
                outputMessage += "The car's price must be greater than, or at least equal to, 0. Please enter a valid price."
                returnValue = False

                ' Set focus to invalid field
                txtPrice.Focus()

            End If

        End If

        ' Check to see if any field was not validated
        If returnValue = False Then

            ' Display the applicable error message to the user
            lblOutput.Text = "ERRORS" & vbCrLf & outputMessage.ToString()


        End If

        ' Return the status of validation checks, continue displaying appropriate error messages until all 
        ' input Is valid And data is ready to be logged in the list of cars
        Return returnValue

    End Function

    ''' <summary>
    ''' lvwInventory_ItemCheck - ensures that user cannot change the status of the new/used checkbox unless they have selected an entry to be altered in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwInventory_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwInventory.ItemCheck

        ' If not in edit mode
        If inEditMode = False Then

            ' Any changevalue will be assigned to the current value, to avoid unacceptable changes to the new/used status of a car when not in edit view
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwInventory_SelectedIndexChanged - any car in the list can be selected and it's data will fill in the associated input fields and will be available for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwInventory.SelectedIndexChanged

        If lvwInventory.SelectedItems.Count = 1 AndAlso lvwInventory.SelectedIndices(0) >= 0 Then

            ' Constant to store the index of subitem in list that contains the car id number
            Const carIdSubItemIndex As Integer = 1

            ' Get the car identification number 
            currentCarIdNumber = lvwInventory.Items(lvwInventory.FocusedItem.Index).SubItems(carIdSubItemIndex).Text

            ' Use the car identification number to get car from list of car objects
            Dim car As Car = CType(carList.Item(currentCarIdNumber), Car)

            ' Edit and set the form controls, and update changes in inventory list
            cmbMake.Text = car.Make
            txtModel.Text = car.Model
            cmbYear.Text = car.Year.ToString
            txtPrice.Text = car.Price.ToString
            chkNew.Checked = car.IsNew

            ' Output synopsis of car data in output label
            lblOutput.Text = car.GetCarData()

        End If

    End Sub



    ''' <summary>
    ''' Get method that controls the inventory form object to ensure that only a single instance of the form may be opened at once
    ''' </summary>
    ''' <returns></returns>
    Friend Shared ReadOnly Property Instance() As frmCarInventory

        Get
            If carInventoryInstance Is Nothing Then
                carInventoryInstance = New frmCarInventory
            End If
            Return frmCarInventory
        End Get
    End Property


End Class
