Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Public Class FormMain
    Private _path As String

    Private namePDF_JSON As String
    Private fullName, contactNo, address, email, objective, college, collegeDetail1, collegeDetail2, highschool, elementary, skill1, skill2, skill3, skill4, notes As String

    Private isReadingJson As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnLoadJSON_Click(sender As Object, e As EventArgs) Handles btnLoadJSON.Click
        For Each txtBx As TextBox In panelFields.Controls.OfType(Of TextBox)
            txtBx.Text = ""
            txtBx.ReadOnly = True
        Next

        btnSaveToJSON.Visible = False

        Try
            Dim jsonFromFile As String

            Dim openFileDialog As OpenFileDialog = New OpenFileDialog
            Dim result As DialogResult = openFileDialog.ShowDialog
            If result = DialogResult.OK Then
                _path = openFileDialog.FileName
                Try
                    jsonFromFile = File.ReadAllText(_path)
                    Dim person As Person = JsonConvert.DeserializeObject(Of Person)(jsonFromFile)

                    Dim nameParts() As String = SplitName(person.FullName)
                    nameParts(0) = nameParts(0).Replace(" ", "-")
                    nameParts(1) = nameParts(1).ToUpper()
                    Name = nameParts(1) + "_" + nameParts(0)

                    txtBxFullName.Text = person.FullName
                    txtBxContactNo.Text = person.ContactNo
                    txtBxAddress.Text = person.Address
                    txtbxEmail.Text = person.Email

                    txtBxObjective.Text = person.Objective

                    txtBxCollege.Text = person.College
                    txtBxDegree.Text = "• " + person.CollegeDetail1
                    txtBxAchievements.Text = "• " + person.CollegeDetail2

                    txtBxSkillOne.Text = "• " + person.Skill1
                    txtBxSkillTwo.Text = "• " + person.Skill2
                    txtBxSkillThree.Text = "• " + person.Skill3

                    txtBxNotes.Text = person.Closing

                    fullName = person.FullName
                    contactNo = person.ContactNo
                    address = person.Address
                    email = person.Email

                    objective = person.Objective

                    college = person.College
                    collegeDetail1 = person.CollegeDetail1
                    collegeDetail2 = person.CollegeDetail2

                    skill1 = person.Skill1
                    skill2 = person.Skill2
                    skill3 = person.Skill3

                    notes = person.Closing

                    panelPlaceholder.Visible = False
                    panelFields.Visible = True

                    btnCancel.Visible = False

                    isReadingJson = True
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function SplitName(ByVal fullName As String)

    End Function
End Class
