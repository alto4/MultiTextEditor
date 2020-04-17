' Author:           Scott Alton
' Last Modified:    April 16, 2020
' Description:      This multi-form application brings together three small applications using a MDI parent form. The first application is a simple text editor with
'                   clipboard functionality And may be opened In various instances within the main parent form. The second application is an Average Units Shipped 
'                   calculator that takes In the number Of units sold per day For a week, And Then outputs the average number of units shipped per day, and is able 
'                   to perform these operations for up to three employees before all input is cleared. Finally, the Car Inventory application manages the inventory 
'                   of the car sales lot, and tracks basic information about each car using objects. Both the Average Units Shipped and the Car Inventory applications
'                   may only be opened In a Single instance, And all three Of these child forms are easy accessible Using the toolstrip menu buttons, keyboard shortcuts,
'                   and through the File and Window menu tabs. 

Option Strict On

Public Class frmMain

    ' VARIABLE DECLARATIONS

    ' Variable to store the file path
    Dim openFilePath As String

    ''' <summary>
    ''' Event Handler for ShowNewTextEditor - when the user clicks on the toolstrip icon or selects the menu option under the Window menu, open a new instance of 
    ''' the Text Editor application and allow multiple instances.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowNewTextEditor(sender As Object, e As EventArgs) Handles btnToolStripNewTextEditor.Click, mnuMainFileNew.Click

        ' Create a new text editor form
        Dim myTextEditor As New frmTextEditor

        ' Set the new text editor form be a child of the main form
        myTextEditor.MdiParent = Me
        myTextEditor.Show()

    End Sub

    ''' <summary>
    ''' Event Handler for ShowCarInventory - when the user clicks on the toolstrip icon or selects the menu option under the Window menu, open the car inventory list, or
    ''' if it is already open, bring it to the forefront of the main form container. This only allows for a single instance of the Car Inventory child form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowCarInventory(sender As Object, e As EventArgs) Handles btnToolStripShowCarInventory.Click, mnuWindowOpenCarList.Click

        ' Retrieve the instance of the car inventory form if it exists, or create a new instance if not
        Dim myCarInventory As frmCarInventory = frmCarInventory.Instance

        ' Set the new car inventory form be the child of the main form
        myCarInventory.MdiParent = Me
        myCarInventory.Show()
        myCarInventory.Focus()

    End Sub

    ''' <summary>
    ''' Event Handler for ShowAverageUnitsShipped - dispay the AveragUnits Shipped By Employee Application when the toolstrip button is clicked, or the Window
    ''' menu option is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowAverageUnitsShipped(sender As Object, e As EventArgs) Handles btnToolstripShowAverageUnitsShipped.Click, mnuWindowOpenAverageUnitsShipped.Click

        ' Retrieve the instance of the car inventory form if it exists, or create a new instance if not
        Dim myAverageUnitsShipped As frmAverageUnitsShippedByEmployee = frmAverageUnitsShippedByEmployee.Instance

        ' Set the new car inventory form be the child of the main form
        myAverageUnitsShipped.MdiParent = Me
        myAverageUnitsShipped.Show()
        myAverageUnitsShipped.Focus()

    End Sub

    ''' <summary>
    ''' Event Handler for Save Button - saves an open text editor window using the FileSave procedure when the user clicks on the Menu button or on the corresponding 
    ''' toolstrip button. If the application that is in focus within the parent container is not a text editor window, a message will be displayed to the user declaring
    ''' that Car Inventory and Average Units Shipped windows cannot be saved.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuMainFileSave_Click(sender As Object, e As EventArgs) Handles mnuMainFileSave.Click, btnToolStripSave.Click

        ' Check if the active MDI child form is a text editor window
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            ' If it is a text editor window, save changes made to the file 
            CType(ActiveMdiChild, frmTextEditor).FileSave()

        Else

            ' If the MDI child form is not a text editor window, warn the user that changes can not be saved
            MessageBox.Show("Please enter the Text Editor window to save a file.")

        End If
    End Sub

    ''' <summary>
    ''' Event Handler for Open Button - opens an existing file by searching through system directories, and once selected,providing output within 
    ''' main textbox for viewing and editing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuMainFileOpen_Click(sender As Object, e As EventArgs) Handles mnuMainFileOpen.Click, btnToolStripOpen.Click

        ' Check if the active MDI child form is a text editor window
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            ' If it is a text editor window, open the file selection menu 
            CType(ActiveMdiChild, frmTextEditor).FileOpen()

        Else

            ' If it is not a text editor form, create a new text editor window and then prompt the user to select a file to open in this new editor window
            ShowNewTextEditor(sender, e)
            CType(ActiveMdiChild, frmTextEditor).FileOpen()

        End If

    End Sub

    ''' <summary>
    ''' Event Handler for SaveAs Button - this handles events when the user clicks on the SaveAs button, within the file menu and saves all changes 
    ''' made to the file if it is a Text Editor window, or otherwise warns the user that only Text Editor windows allow changes to be saved.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuMainFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuMainFileSaveAs.Click

        ' Check if the active MDI child form is a text editor window
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            ' If it is a text editor window, call on the save function to write changes
            CType(ActiveMdiChild, frmTextEditor).FileSaveAs()

        Else

            ' If it is not a text editor form, warn the user that changes can not be saved
            MessageBox.Show("Please enter the Text Editor window to save a text file.")

        End If

    End Sub

    ''' <summary>
    ''' Event Handler Close Button - this handles events when the user clicks on the Close button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuMainFileClose_Click(sender As Object, e As EventArgs) Handles mnuMainFileClose.Click

        ' Check if the active MDI child form is a text editor window
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            ' Close the window
            CType(ActiveMdiChild, frmTextEditor).Close()

            ' Check if the active MDI child form is a car inventory window
        ElseIf TypeOf (ActiveMdiChild) Is frmCarInventory Then

            ' Close the window
            CType(ActiveMdiChild, frmCarInventory).Close()

            ' Check if the active MDI child form is a average units shipped window
        ElseIf TypeOf (ActiveMdiChild) Is frmAverageUnitsShippedByEmployee Then

            ' Close the window 
            CType(ActiveMdiChild, frmAverageUnitsShippedByEmployee).Close()

        End If

    End Sub

    ''' <summary>
    ''' Event Handler for Exit Button - exit the application and close all active child forms.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuMainFileExit_Click(sender As Object, e As EventArgs) Handles mnuMainFileExit.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' Event Handler for Copy Button - this handles events when the user clicks on the Copy button, or triggers the button using a shortcut, which then will write
    ''' the selected text to the clipboard, as highlighted by the user.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click

        ' Check if the active MDI child form is a text editor window
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            ' If it is, copy the text 
            CType(ActiveMdiChild, frmTextEditor).EditCopy()

        Else

            ' If it is not a text editor form, warn the user that copying text is not allowed unless a text editor form is active
            MessageBox.Show("Sorry, you may only copy text from a Text Editor window.")

        End If

    End Sub

    ''' <summary>
    ''' Event Handler for Cut Button - this handles events when the user clicks on the Cut button, and removes the selected text from the textbox after writing
    ''' it to the clipboard.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click

        ' Check if the active MDI child form is a text editor window
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            ' If it is, cut the text 
            CType(ActiveMdiChild, frmTextEditor).EditCut()

        Else

            ' If it is not a text editor form, warn the user that cutting text is not allowed unless a text editor form is active
            MessageBox.Show("Sorry, you may only cut text from a Text Editor window.")

        End If

    End Sub

    ''' <summary>
    ''' Event Handler for Paste Button - this handles events when the user clicks on the Paste button, or triggers the button using a shortcut, which then will write the
    ''' text copied to the clipboard to wherever the user has selected with the editor textbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        ' Check if the active MDI child form is a text editor window
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then

            ' If it is, paste the text 
            CType(ActiveMdiChild, frmTextEditor).PasteText()

        Else

            ' If it is not a text editor form, warn the user that pasting text is not allowed unless a text editor form is active
            MessageBox.Show("Sorry, you may only paste text inside of a Text Editor window.")

        End If

    End Sub

    ''' <summary>
    ''' Event Handler for About Text Editor - displays basic information about the Multi Text Editor application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuHelpAboutMultiTextEditor_Click(sender As Object, e As EventArgs) Handles mnuHelpAboutMultiTextEditor.Click

        ' Output basic program information in a messagebox
        MessageBox.Show("Multi Text Editor" & vbCrLf & vbCrLf & "By Scott Alton" & vbCrLf & vbCrLf & "April 10, 2020")

    End Sub


    ''' <summary>
    ''' Event Handler for Window Cascade - display all MDI child form windows in a cascaded format.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click

        ' Change the MDI layout to cascaded 
        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    ''' <summary>
    ''' Event Handler for Window Tile Horizontal - display all MDI child form windows in a horizontal tile display.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontal.Click

        ' Change the MDI layout to tile horizonally
        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    ''' <summary>
    ''' Event Handler for Window Tile Vertical - display all MDI child form windows in a vertical tile display.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertical.Click

        ' Change the MDI layout to tile vertically
        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

End Class
