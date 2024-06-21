<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateSubmission
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        btnToggleStopwatch = New Button()
        txtStopwatch = New TextBox()
        btnSubmit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(379, 63)
        txtName.Name = "txtName"
        txtName.Size = New Size(244, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(379, 126)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(244, 31)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(379, 186)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(244, 31)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(379, 251)
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(244, 31)
        txtGithub.TabIndex = 3
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnToggleStopwatch.Location = New Point(70, 307)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(342, 44)
        btnToggleStopwatch.TabIndex = 4
        btnToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)" & vbLf
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = SystemColors.ActiveCaption
        txtStopwatch.Location = New Point(469, 314)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(111, 31)
        txtStopwatch.TabIndex = 5
        txtStopwatch.Text = "00:00:00"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.GradientActiveCaption
        btnSubmit.Location = New Point(220, 369)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(338, 34)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(120, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 25)
        Label1.TabIndex = 7
        Label1.Text = "Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(120, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 25)
        Label2.TabIndex = 8
        Label2.Text = "Email :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(120, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 9
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(120, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 25)
        Label4.TabIndex = 10
        Label4.Text = "GitHub Link for Task 2"
        ' 
        ' FormCreateSubmission
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(txtStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "FormCreateSubmission"
        Text = "FormCreateSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
