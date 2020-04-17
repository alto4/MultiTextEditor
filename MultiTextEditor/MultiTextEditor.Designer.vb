<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.btnToolStripNewTextEditor = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripShowCarInventory = New System.Windows.Forms.ToolStripButton()
        Me.btnToolstripShowAverageUnitsShipped = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripSave = New System.Windows.Forms.ToolStripButton()
        Me.ttpMultiTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMainFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowOpenCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowOpenAverageUnitsShipped = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAboutMultiTextEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopMenu = New System.Windows.Forms.MenuStrip()
        Me.tsTools.SuspendLayout()
        Me.mnuTopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsTools
        '
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStripNewTextEditor, Me.btnToolStripShowCarInventory, Me.btnToolstripShowAverageUnitsShipped, Me.btnToolStripOpen, Me.btnToolStripSave})
        Me.tsTools.Location = New System.Drawing.Point(0, 24)
        Me.tsTools.Name = "tsTools"
        Me.tsTools.Size = New System.Drawing.Size(657, 25)
        Me.tsTools.TabIndex = 1
        '
        'btnToolStripNewTextEditor
        '
        Me.btnToolStripNewTextEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewTextEditor.Image = CType(resources.GetObject("btnToolStripNewTextEditor.Image"), System.Drawing.Image)
        Me.btnToolStripNewTextEditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewTextEditor.Name = "btnToolStripNewTextEditor"
        Me.btnToolStripNewTextEditor.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripNewTextEditor.Text = "New Text Editor File"
        Me.btnToolStripNewTextEditor.ToolTipText = "Click this button to create a new text editor window."
        '
        'btnToolStripShowCarInventory
        '
        Me.btnToolStripShowCarInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripShowCarInventory.Image = CType(resources.GetObject("btnToolStripShowCarInventory.Image"), System.Drawing.Image)
        Me.btnToolStripShowCarInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripShowCarInventory.Name = "btnToolStripShowCarInventory"
        Me.btnToolStripShowCarInventory.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripShowCarInventory.Text = "Show Car Inventory Window"
        Me.btnToolStripShowCarInventory.ToolTipText = "Click on this button to show the car inventory window."
        '
        'btnToolstripShowAverageUnitsShipped
        '
        Me.btnToolstripShowAverageUnitsShipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolstripShowAverageUnitsShipped.Image = CType(resources.GetObject("btnToolstripShowAverageUnitsShipped.Image"), System.Drawing.Image)
        Me.btnToolstripShowAverageUnitsShipped.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolstripShowAverageUnitsShipped.Name = "btnToolstripShowAverageUnitsShipped"
        Me.btnToolstripShowAverageUnitsShipped.Size = New System.Drawing.Size(23, 22)
        Me.btnToolstripShowAverageUnitsShipped.ToolTipText = "Click on this button to open the Average Units Shipped window."
        '
        'btnToolStripOpen
        '
        Me.btnToolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripOpen.Image = CType(resources.GetObject("btnToolStripOpen.Image"), System.Drawing.Image)
        Me.btnToolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripOpen.Name = "btnToolStripOpen"
        Me.btnToolStripOpen.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripOpen.ToolTipText = "Click this button to open an existing file for editing."
        '
        'btnToolStripSave
        '
        Me.btnToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripSave.Image = CType(resources.GetObject("btnToolStripSave.Image"), System.Drawing.Image)
        Me.btnToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripSave.Name = "btnToolStripSave"
        Me.btnToolStripSave.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripSave.ToolTipText = "Click on this button to save changes made in a Text Editor file."
        '
        'mnuMainFile
        '
        Me.mnuMainFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainFileNew, Me.mnuMainFileOpen, Me.mnuMainFileSave, Me.mnuMainFileSaveAs, Me.mnuMainFileClose, Me.mnuMainFileExit})
        Me.mnuMainFile.Name = "mnuMainFile"
        Me.mnuMainFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuMainFile.Text = "&File"
        Me.mnuMainFile.ToolTipText = "Click this button to see a menu of file options, including new, open, save, savea" &
    "s, close, and exit."
        '
        'mnuMainFileNew
        '
        Me.mnuMainFileNew.Name = "mnuMainFileNew"
        Me.mnuMainFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuMainFileNew.Size = New System.Drawing.Size(146, 22)
        Me.mnuMainFileNew.Text = "&New"
        Me.mnuMainFileNew.ToolTipText = "Click this button to create a new file. Make sure you save your work first."
        '
        'mnuMainFileOpen
        '
        Me.mnuMainFileOpen.Name = "mnuMainFileOpen"
        Me.mnuMainFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuMainFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.mnuMainFileOpen.Text = "&Open"
        Me.mnuMainFileOpen.ToolTipText = "Click this button to Open a file that already exists. Make sure you save your wor" &
    "k first."
        '
        'mnuMainFileSave
        '
        Me.mnuMainFileSave.Name = "mnuMainFileSave"
        Me.mnuMainFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuMainFileSave.Size = New System.Drawing.Size(146, 22)
        Me.mnuMainFileSave.Text = "&Save"
        Me.mnuMainFileSave.ToolTipText = "Click this button to save changes made to your file. I the file has not yet been " &
    "saved, you will be prompted to enter a filename. "
        '
        'mnuMainFileSaveAs
        '
        Me.mnuMainFileSaveAs.Name = "mnuMainFileSaveAs"
        Me.mnuMainFileSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.mnuMainFileSaveAs.Text = "S&ave As"
        Me.mnuMainFileSaveAs.ToolTipText = "Click this button to create or alter the name of the file that you are currently " &
    "editing."
        '
        'mnuMainFileClose
        '
        Me.mnuMainFileClose.Name = "mnuMainFileClose"
        Me.mnuMainFileClose.Size = New System.Drawing.Size(146, 22)
        Me.mnuMainFileClose.Text = "Clos&e"
        Me.mnuMainFileClose.ToolTipText = "Click this button to close the current file. Make sure that you save your work fi" &
    "rst."
        '
        'mnuMainFileExit
        '
        Me.mnuMainFileExit.Name = "mnuMainFileExit"
        Me.mnuMainFileExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuMainFileExit.Text = "E&xit"
        Me.mnuMainFileExit.ToolTipText = "Click this button to exit the application. "
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Click this button to see a menu of editing options for the text editor, including" &
    " copy, paste, and cut."
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditCopy.Text = "&Copy"
        Me.mnuEditCopy.ToolTipText = "Click this item to copy the highlighted text to your clipboard."
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditCut.Text = "Cu&t"
        Me.mnuEditCut.ToolTipText = "Click this item to delete highlighted text and copy its contents to your clipboar" &
    "d."
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditPaste.Text = "&Paste"
        Me.mnuEditPaste.ToolTipText = "Click this option to write text that is saved on the clipboard to the location th" &
    "at the cursor is currently placed."
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.mnuWindowTileHorizontal, Me.mnuWindowTileVertical, Me.mnuWindowOpenCarList, Me.mnuWindowOpenAverageUnitsShipped})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(63, 20)
        Me.mnuWindow.Text = "&Window"
        Me.mnuWindow.ToolTipText = "Click this button to see a menu of window display options."
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(296, 22)
        Me.mnuWindowCascade.Text = "&Cascade"
        Me.mnuWindowCascade.ToolTipText = "Click this button to cascade the layout of windows."
        '
        'mnuWindowTileHorizontal
        '
        Me.mnuWindowTileHorizontal.Name = "mnuWindowTileHorizontal"
        Me.mnuWindowTileHorizontal.Size = New System.Drawing.Size(296, 22)
        Me.mnuWindowTileHorizontal.Text = "Tile &Horizontal"
        Me.mnuWindowTileHorizontal.ToolTipText = "Click this button to tile the windows horizontally."
        '
        'mnuWindowTileVertical
        '
        Me.mnuWindowTileVertical.Name = "mnuWindowTileVertical"
        Me.mnuWindowTileVertical.Size = New System.Drawing.Size(296, 22)
        Me.mnuWindowTileVertical.Text = "Tile &Vertical"
        Me.mnuWindowTileVertical.ToolTipText = "Click this button to tile the windows vertically."
        '
        'mnuWindowOpenCarList
        '
        Me.mnuWindowOpenCarList.Name = "mnuWindowOpenCarList"
        Me.mnuWindowOpenCarList.Size = New System.Drawing.Size(296, 22)
        Me.mnuWindowOpenCarList.Text = "Open Car &List"
        Me.mnuWindowOpenCarList.ToolTipText = "Click on this button to show the car inventory window."
        '
        'mnuWindowOpenAverageUnitsShipped
        '
        Me.mnuWindowOpenAverageUnitsShipped.Name = "mnuWindowOpenAverageUnitsShipped"
        Me.mnuWindowOpenAverageUnitsShipped.Size = New System.Drawing.Size(296, 22)
        Me.mnuWindowOpenAverageUnitsShipped.Text = "Open &Average Units Shipped By Employee"
        Me.mnuWindowOpenAverageUnitsShipped.ToolTipText = "Click on this button to open the Average Units Shipped window."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAboutMultiTextEditor})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Click this button to see a menu of help options that are available for this appli" &
    "cation."
        '
        'mnuHelpAboutMultiTextEditor
        '
        Me.mnuHelpAboutMultiTextEditor.Name = "mnuHelpAboutMultiTextEditor"
        Me.mnuHelpAboutMultiTextEditor.Size = New System.Drawing.Size(196, 22)
        Me.mnuHelpAboutMultiTextEditor.Text = "&About Multi Text Editor"
        Me.mnuHelpAboutMultiTextEditor.ToolTipText = "Click this to view general information about the Text Editor application."
        '
        'mnuTopMenu
        '
        Me.mnuTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainFile, Me.mnuEdit, Me.mnuWindow, Me.mnuHelp})
        Me.mnuTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopMenu.Name = "mnuTopMenu"
        Me.mnuTopMenu.Size = New System.Drawing.Size(657, 24)
        Me.mnuTopMenu.TabIndex = 0
        Me.mnuTopMenu.Text = "MenuStrip1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 541)
        Me.Controls.Add(Me.tsTools)
        Me.Controls.Add(Me.mnuTopMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuTopMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Text Editor"
        Me.ttpMultiTextEditor.SetToolTip(Me, "This application allows the simoltaneous use of the Text Editor, Car Inventory, a" &
        "nd Average Units Shipped applications.")
        Me.tsTools.ResumeLayout(False)
        Me.tsTools.PerformLayout()
        Me.mnuTopMenu.ResumeLayout(False)
        Me.mnuTopMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsTools As ToolStrip
    Friend WithEvents btnToolStripNewTextEditor As ToolStripButton
    Friend WithEvents btnToolStripShowCarInventory As ToolStripButton
    Friend WithEvents btnToolstripShowAverageUnitsShipped As ToolStripButton
    Friend WithEvents ttpMultiTextEditor As ToolTip
    Friend WithEvents btnToolStripOpen As ToolStripButton
    Friend WithEvents btnToolStripSave As ToolStripButton
    Friend WithEvents mnuMainFile As ToolStripMenuItem
    Friend WithEvents mnuMainFileNew As ToolStripMenuItem
    Friend WithEvents mnuMainFileOpen As ToolStripMenuItem
    Friend WithEvents mnuMainFileSave As ToolStripMenuItem
    Friend WithEvents mnuMainFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuMainFileClose As ToolStripMenuItem
    Friend WithEvents mnuMainFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuWindow As ToolStripMenuItem
    Friend WithEvents mnuWindowCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowTileHorizontal As ToolStripMenuItem
    Friend WithEvents mnuWindowTileVertical As ToolStripMenuItem
    Friend WithEvents mnuWindowOpenCarList As ToolStripMenuItem
    Friend WithEvents mnuWindowOpenAverageUnitsShipped As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAboutMultiTextEditor As ToolStripMenuItem
    Friend WithEvents mnuTopMenu As MenuStrip
End Class
