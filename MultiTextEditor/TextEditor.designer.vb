<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.txtTextEditorInput = New System.Windows.Forms.TextBox()
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.ttpTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtTextEditorInput
        '
        Me.txtTextEditorInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTextEditorInput.Location = New System.Drawing.Point(0, 0)
        Me.txtTextEditorInput.Multiline = True
        Me.txtTextEditorInput.Name = "txtTextEditorInput"
        Me.txtTextEditorInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTextEditorInput.Size = New System.Drawing.Size(800, 450)
        Me.txtTextEditorInput.TabIndex = 0
        '
        'opdOpen
        '
        Me.opdOpen.FileName = "OpenFileDialog1"
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTextEditorInput)
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTextEditorInput As TextBox
    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents ttpTextEditor As ToolTip
End Class
