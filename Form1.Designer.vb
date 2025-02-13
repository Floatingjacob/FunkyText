<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form replaces Dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtInput = New TextBox()
        cmbMode = New ComboBox()
        lblOutput = New Label()
        btnConvert = New Button()
        btnCopy = New Button()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtInput.Location = New Point(12, 12)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(260, 23)
        txtInput.TabIndex = 0
        ' 
        ' cmbMode
        ' 
        cmbMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMode.FormattingEnabled = True
        cmbMode.Items.AddRange(New Object() {"Leet Speak", "Symbolic", "Reverse"})
        cmbMode.Location = New Point(12, 38)
        cmbMode.Name = "cmbMode"
        cmbMode.Size = New Size(121, 23)
        cmbMode.TabIndex = 1
        ' 
        ' lblOutput
        ' 
        lblOutput.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblOutput.AutoSize = True
        lblOutput.Font = New Font("Segoe UI", 12.0F)
        lblOutput.Location = New Point(12, 68)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(68, 21)
        lblOutput.TabIndex = 2
        lblOutput.Text = "Output..."
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(139, 36)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 3
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnCopy
        ' 
        btnCopy.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCopy.Location = New Point(220, 63)
        btnCopy.Name = "btnCopy"
        btnCopy.Size = New Size(52, 23)
        btnCopy.TabIndex = 4
        btnCopy.Text = "Copy"
        btnCopy.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        ClientSize = New Size(284, 100)
        Controls.Add(btnCopy)
        Controls.Add(btnConvert)
        Controls.Add(lblOutput)
        Controls.Add(cmbMode)
        Controls.Add(txtInput)
        Name = "Form1"
        Text = "Funky Text"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnCopy As Button
End Class
