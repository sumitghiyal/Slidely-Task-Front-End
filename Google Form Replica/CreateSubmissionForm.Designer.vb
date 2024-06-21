Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        Label6 = New Label()
        btnSubmit = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblStopwatchTime = New TextBox()
        txtGithubLink = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtName = New TextBox()
        btnStartStopwatch = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.PapayaWhip
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(22, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(428, 28)
        Label6.TabIndex = 25
        Label6.Text = "Sumit Kumar, Slidely Task 2 - Create Submission"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.Font = New Font("Segoe UI", 15F)
        btnSubmit.Location = New Point(22, 382)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(430, 42)
        btnSubmit.TabIndex = 24
        btnSubmit.Text = "SUBMIT ( CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(11, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 56)
        Label4.TabIndex = 21
        Label4.Text = "Gitthub Link" & vbCrLf & "For Task 2"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(11, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 28)
        Label3.TabIndex = 20
        Label3.Text = "Phone Num"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(28, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 28)
        Label2.TabIndex = 19
        Label2.Text = "Email"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(28, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 18
        Label1.Text = "Name"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.BackColor = SystemColors.ControlLight
        lblStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        lblStopwatchTime.Font = New Font("Segoe UI", 12F)
        lblStopwatchTime.Location = New Point(302, 299)
        lblStopwatchTime.Multiline = True
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.ReadOnly = True
        lblStopwatchTime.Size = New Size(139, 44)
        lblStopwatchTime.TabIndex = 17
        lblStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Segoe UI", 12F)
        txtGithubLink.Location = New Point(143, 208)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(309, 44)
        txtGithubLink.TabIndex = 16
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(143, 103)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(309, 29)
        txtEmail.TabIndex = 15
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Segoe UI", 12F)
        txtPhone.Location = New Point(143, 152)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(309, 29)
        txtPhone.TabIndex = 14
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 12F)
        txtName.Location = New Point(143, 60)
        txtName.Name = "txtName"
        txtName.Size = New Size(309, 29)
        txtName.TabIndex = 13
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.AutoEllipsis = True
        btnStartStopwatch.BackColor = Color.Yellow
        btnStartStopwatch.Font = New Font("Segoe UI", 12F)
        btnStartStopwatch.Location = New Point(22, 299)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(274, 44)
        btnStartStopwatch.TabIndex = 26
        btnStartStopwatch.Text = "TOOGLE STOPWATCH ( CTRL + T)"
        btnStartStopwatch.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(463, 450)
        Controls.Add(btnStartStopwatch)
        Controls.Add(Label6)
        Controls.Add(btnSubmit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Protected WithEvents btnSubmit As Button
    Protected WithEvents Label4 As Label
    Protected WithEvents Label3 As Label
    Protected WithEvents Label2 As Label
    Protected WithEvents Label1 As Label
    Protected WithEvents lblStopwatchTime As TextBox
    Protected WithEvents txtGithubLink As TextBox
    Protected WithEvents txtEmail As TextBox
    Protected WithEvents txtPhone As TextBox
    Protected WithEvents txtName As TextBox
    Friend WithEvents btnStartStopwatch As Button

    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private stopwatchElapsedTime As TimeSpan

    ' Form load event to initialize the timer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Set timer interval to 1 second
        Me.KeyPreview = True ' Enable key preview for the form to catch key events
    End Sub

    ' Timer tick event to update stopwatch display
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatchRunning Then
            Dim currentTime As DateTime = DateTime.Now
            stopwatchElapsedTime = currentTime - stopwatchStartTime
            lblStopwatchTime.Text = stopwatchElapsedTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    ' Toggle stopwatch start/stop
    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        If stopwatchRunning Then
            stopwatchRunning = False
            Timer1.Stop()
        Else
            stopwatchRunning = True
            stopwatchStartTime = DateTime.Now - stopwatchElapsedTime
            Timer1.Start()
        End If
    End Sub

    ' Validate form inputs
    Private Function ValidateForm() As Boolean
        Dim isValid As Boolean = True ' Assume form is initially valid

        ' Validate Name field
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            isValid = False
            MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Validate Email field
        Dim emailRegex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse Not emailRegex.IsMatch(txtEmail.Text) Then
            isValid = False
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Add more validation for other fields as needed...

        Return isValid
    End Function

    ' Clear form inputs
    Private Sub ClearForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGithubLink.Clear()
        lblStopwatchTime.Text = "00:00:00"
        stopwatchElapsedTime = TimeSpan.Zero
        stopwatchRunning = False
        Timer1.Stop()
    End Sub

    ' Submit form data to backend
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate the form before submitting
        If ValidateForm() Then
            Dim name As String = txtName.Text.Trim()
            Dim email As String = txtEmail.Text.Trim()
            Dim phone As String = txtPhone.Text.Trim()
            Dim gitHubLink As String = txtGithubLink.Text.Trim()
            Dim stopwatchTime As String = lblStopwatchTime.Text.Trim()

            ' Create the data object
            Dim data = New With {
                .name = name,
                .email = email,
                .phone = phone,
                .githubLink = gitHubLink,
                .stopwatchTime = stopwatchTime
            }

            ' Convert the data object to JSON
            Dim jsonData As String = JsonConvert.SerializeObject(data)

            ' Send data to Express backend using HttpClient
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:3000/")
                client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

                Dim content = New StringContent(jsonData, Encoding.UTF8, "application/json")

                Try
                    Dim response = client.PostAsync("submit", content).Result
                    response.EnsureSuccessStatusCode()
                    MessageBox.Show("Data submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear the form after submission
                    ClearForm()
                Catch ex As Exception
                    MessageBox.Show("Error submitting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Please fill in all required fields and correct any validation errors.", "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Handle keyboard shortcuts
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartStopwatch.PerformClick()
        End If
    End Sub

    Friend WithEvents Timer1 As Timer
End Class
