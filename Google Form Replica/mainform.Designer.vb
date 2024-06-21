<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.Anchor = AnchorStyles.None
        btnViewSubmissions.BackColor = Color.Yellow
        btnViewSubmissions.FlatAppearance.BorderColor = Color.Yellow
        btnViewSubmissions.FlatAppearance.BorderSize = 0
        btnViewSubmissions.Font = New Font("Segoe UI", 16.0F)
        btnViewSubmissions.ForeColor = Color.Black
        btnViewSubmissions.Location = New Point(12, 98)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(448, 62)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.Anchor = AnchorStyles.None
        btnCreateSubmission.BackColor = Color.LightBlue
        btnCreateSubmission.FlatAppearance.BorderColor = Color.LightBlue
        btnCreateSubmission.FlatAppearance.BorderSize = 0
        btnCreateSubmission.Font = New Font("Segoe UI", 16.0F)
        btnCreateSubmission.Location = New Point(12, 188)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(448, 62)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION ( CTRL + N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label7
        Label7.AutoSize = True
        Label7.BackColor = Color.PapayaWhip
        Label7.Font = New Font("Segoe UI", 15.0F)
        Label7.Location = New Point(12, 19)
        Label7.MinimumSize = New Size(440, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(440, 30)
        Label7.TabIndex = 27
        Label7.Text = "Sumit Kumar, Slidely Task 2 - Slidely Form App"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' mainform
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(472, 341)
        Controls.Add(Label7)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Name = "mainform"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button

    ' Set KeyPreview to True when the form loads
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    ' Handle KeyDown event for the form
    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
            e.SuppressKeyPress = True ' Prevent further processing of this key event
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
            e.SuppressKeyPress = True ' Prevent further processing of this key event
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Friend WithEvents Label7 As Label

End Class
