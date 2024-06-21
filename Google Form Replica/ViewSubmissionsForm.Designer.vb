Imports System.Net.Http
Imports Newtonsoft.Json


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtGithubLink = New TextBox()
        lblStopwatchTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnNext = New Button()
        btnPrevious = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ControlLight
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 12.0F)
        txtName.Location = New Point(143, 58)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(309, 29)
        txtName.TabIndex = 0
        txtName.TabStop = False
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ControlLight
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Segoe UI", 12.0F)
        txtPhone.Location = New Point(143, 150)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(309, 29)
        txtPhone.TabIndex = 1
        txtPhone.TabStop = False
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ControlLight
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 12.0F)
        txtEmail.Location = New Point(143, 101)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(309, 29)
        txtEmail.TabIndex = 2
        txtEmail.TabStop = False
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.ControlLight
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Segoe UI", 12.0F)
        txtGithubLink.Location = New Point(143, 206)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(309, 44)
        txtGithubLink.TabIndex = 3
        txtGithubLink.TabStop = False
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.BackColor = SystemColors.ControlLight
        lblStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        lblStopwatchTime.Font = New Font("Segoe UI", 12.0F)
        lblStopwatchTime.Location = New Point(143, 283)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.ReadOnly = True
        lblStopwatchTime.Size = New Size(309, 29)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.TabStop = False
        lblStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.0F)
        Label1.Location = New Point(28, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 5
        Label1.Text = "Name"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.0F)
        Label2.Location = New Point(28, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 28)
        Label2.TabIndex = 6
        Label2.Text = "Email"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.0F)
        Label3.Location = New Point(11, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 28)
        Label3.TabIndex = 7
        Label3.Text = "Phone Num"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.0F)
        Label4.Location = New Point(11, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 56)
        Label4.TabIndex = 8
        Label4.Text = "Gitthub Link" & vbCrLf & "For Task 2"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.0F)
        Label5.Location = New Point(22, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 50)
        Label5.TabIndex = 9
        Label5.Text = "Stopwatch" & vbCrLf & "Time"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.Font = New Font("Segoe UI", 15.0F)
        btnNext.Location = New Point(234, 380)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(216, 42)
        btnNext.TabIndex = 10
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.Font = New Font("Segoe UI", 15.0F)
        btnPrevious.Location = New Point(11, 380)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(217, 42)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.PapayaWhip
        Label7.Font = New Font("Segoe UI", 15.0F)
        Label7.Location = New Point(22, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(421, 28)
        Label7.TabIndex = 26
        Label7.Text = "Sumit Kumar, Slidely Task 2 - View Submissions" & vbCrLf
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(463, 450)
        Controls.Add(Label7)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Define SubmissionEntry class to match JSON structure
    Public Class SubmissionEntry
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property githubLink As String
        Public Property stopwatchTime As String
    End Class

    Private submissions As New List(Of SubmissionEntry)()
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissionDataFromServer("http://localhost:3000/read?index={currentIndex}")
        LoadSubmissionData(currentIndex)
    End Sub

    Private Async Function LoadSubmissionDataFromServer(apiUrl As String) As Task
        Using client As New HttpClient()
            Try
                Dim response = Await client.GetAsync(apiUrl)
                response.EnsureSuccessStatusCode()
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of SubmissionEntry))(json)
                LoadSubmissionData(currentIndex)
            Catch ex As Exception
                MessageBox.Show("Error loading data from server: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Function

    ' Update LoadSubmissionData function to match JSON structure
    Private Sub LoadSubmissionData(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As SubmissionEntry = submissions(index)
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGithubLink.Text = submission.githubLink
            lblStopwatchTime.Text = submission.stopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        NavigateToPreviousSubmission()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NavigateToNextSubmission()
    End Sub

    Private Sub NavigateToPreviousSubmission()
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmissionData(currentIndex)
        End If
    End Sub

    Private Sub NavigateToNextSubmission()
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            LoadSubmissionData(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.P Then
                NavigateToPreviousSubmission()
            ElseIf e.KeyCode = Keys.N Then
                NavigateToNextSubmission()
            End If
        End If
    End Sub

    Protected WithEvents txtName As TextBox
    Protected WithEvents txtPhone As TextBox
    Protected WithEvents txtEmail As TextBox
    Protected WithEvents txtGithubLink As TextBox
    Protected WithEvents lblStopwatchTime As TextBox
    Protected WithEvents Label1 As Label
    Protected WithEvents Label2 As Label
    Protected WithEvents Label3 As Label
    Protected WithEvents Label4 As Label
    Protected WithEvents Label5 As Label
    Protected WithEvents btnNext As Button
    Protected WithEvents btnPrevious As Button
    Friend WithEvents Label7 As Label
End Class
