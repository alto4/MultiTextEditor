' Author:       Scott Alton
' Date:         February 25, 2020
' File Name:    AverageUnitsShippedByEmployee.vb
' Description:  This application takes in the daily number of units shipped from a user for three employees. Once a week's worth
'               of data is entered, this application calculates and displays the average number of units 
'               shipped per day for that week by that particular employee, and input begins for the next employee. Once the third employee's 
'               average is calculated and outputted, the overall daily average between all three employees is displayed. 

Option Strict On

Public Class frmAverageUnitsShippedByEmployee

    ' VARIABLE DECLARATIONS 
    Dim day As Integer = 0
    Dim employee As Integer = 0

    Dim weeklyTotalUnitsShipped As Integer
    Dim overallTotalUnitsShipped As Integer

    Dim weeklyAverageUnitsShipped As Double
    Dim overallAverageUnitsShipped As Double

    ' Array of units shipped values
    Dim unitsShippedArray(2, 6) As Integer

    ' Control Arrays that will be initialiazed when the form loads
    Dim textboxArray() As TextBox
    Dim outputLabelArray() As Label

    ' Create a single instance of the Average Units Shipped form
    Private Shared averageUnitsShippedByEmployeeInstance As frmAverageUnitsShippedByEmployee

    ' EVENT HANDLERS

    ''' <summary>
    ''' Event handler for Form Load - populate control arrays with form controls
    ''' </summary>
    Private Sub frmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textboxArray = {txtEnteredUnitsEmployee1, txtEnteredUnitsEmployee2, txtEnteredUnitsEmployee3}
        outputLabelArray = {lblAverageOutputEmployee1, lblAverageOutputEmployee2, lblAverageOutputEmployee3}

        ' Set day label to first day 
        lblDay.Text = "Day 1"
    End Sub

    ''' <summary>
    ''' Event handler for Exit Button - close the application 
    ''' </summary>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Event handler for Reset Button - triggers the SetDefaults function that will reset variables, input and output fields to default state.
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    ''' <summary>
    ''' Validates the user's input and adds it to list of units shipped, then increments the total accordingly, 
    ''' and finally displays the average units shipped before proceeding to input for the next employee. 
    ''' Once values are entered for all three employees, the Enter button is disabled.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Variable Declarations
        Const DaysInWeek = 7
        Const NumberOfEmployees = 3
        Const MinDailyUnitsShipped = 0
        Const MaxDailyUnitsShipped = 5000

        If Integer.TryParse(txtUnitsInput.Text, unitsShippedArray(employee, day)) Then

            ' The entered units value is validated as a number between 0 and 5000
            If unitsShippedArray(employee, day) <= MaxDailyUnitsShipped And unitsShippedArray(employee, day) >= MinDailyUnitsShipped Then

                ' Output units shipped for that day to the list
                textboxArray(employee).Text &= unitsShippedArray(employee, day) & vbCrLf

                ' Increment the day and total units shipped
                day += 1
                lblDay.Text = "Day " & (day + 1)

                txtUnitsInput.Clear()

                ' If 7 days worth of data entered, calculate and display that employee's weekly average in the corresponding label
                If day = DaysInWeek Then

                    ' Loop through array to add up weekly total units shipped 
                    For dayCounter As Integer = 0 To DaysInWeek - 1
                        weeklyTotalUnitsShipped += unitsShippedArray(employee, dayCounter)
                    Next

                    ' Calculate and display the weekly average of that given employee
                    weeklyAverageUnitsShipped = weeklyTotalUnitsShipped / DaysInWeek
                    outputLabelArray(employee).Text = "Average: " & Math.Round(weeklyAverageUnitsShipped, 2)

                    ' Increment the week and reset day to 0
                    employee += 1
                    day = 0
                    lblDay.Text = "Day " & (day + 1)

                    ' Reset Total for that week
                    weeklyTotalUnitsShipped = 0

                    ' Once data has been entered for Employee 3, calculate overall daily average and display
                    If employee = NumberOfEmployees Then

                        ' Gather total units for that week accross all three employees
                        For Each day In unitsShippedArray
                            overallTotalUnitsShipped += day
                        Next

                        ' Calculate average units and display to user
                        overallAverageUnitsShipped = overallTotalUnitsShipped / unitsShippedArray.Length
                        lblOverallAverageOutput.Text = "Average Units Per Day: " & Math.Round(overallAverageUnitsShipped, 2)
                        btnEnter.Focus()

                        ' Disable input controls until Reset triggered
                        txtUnitsInput.Enabled = False
                        btnEnter.Enabled = False
                        btnReset.Focus()

                        lblDay.Text = "Done"

                    End If

                End If

            Else

                ' The entered number is not within the acceptable range.
                MessageBox.Show("Please enter a total between " & MinDailyUnitsShipped & " and " & MaxDailyUnitsShipped & ".")
                txtUnitsInput.SelectAll()
                txtUnitsInput.Focus()

            End If

        Else

            ' The entered number of units is NOT a number
            MessageBox.Show("That's not a whole number. Please try again.")
            txtUnitsInput.SelectAll()
            txtUnitsInput.Focus()

        End If

    End Sub

    ' PROCEDURES

    ''' <summary>
    ''' Procedure that clears all input and output fields, as well as re-enables controls and counters to default state
    ''' </summary>
    Sub SetDefaults()

        ' Reset variables to default state
        day = 0
        employee = 0
        lblDay.Text = "Day " & (day + 1)
        weeklyTotalUnitsShipped = 0
        overallTotalUnitsShipped = 0

        ' Reset all output labels to default state
        lblAverageOutputEmployee1.Text = ""
        lblAverageOutputEmployee2.Text = ""
        lblAverageOutputEmployee3.Text = ""
        lblOverallAverageOutput.Text = ""

        ' Reset all input and output textboxes
        txtUnitsInput.Clear()
        txtEnteredUnitsEmployee1.Clear()
        txtEnteredUnitsEmployee2.Clear()
        txtEnteredUnitsEmployee3.Clear()

        ' Re-enble potentially disable controls
        txtUnitsInput.Enabled = True
        btnEnter.Enabled = True

        ' Set focus back to input textbox
        txtUnitsInput.Focus()

    End Sub

    ''' <summary>
    ''' Get method that controls the Average Units Shipped By Employee form object to ensure that only a single instance of the form may be opened at once
    ''' </summary>
    ''' <returns></returns>
    Friend Shared ReadOnly Property Instance() As frmAverageUnitsShippedByEmployee

        Get
            If averageUnitsShippedByEmployeeInstance Is Nothing Then
                averageUnitsShippedByEmployeeInstance = New frmAverageUnitsShippedByEmployee
            End If
            Return frmAverageUnitsShippedByEmployee
        End Get
    End Property



End Class
