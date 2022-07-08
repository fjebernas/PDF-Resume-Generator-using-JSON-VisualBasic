Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Public Class FormMain
    Private Const PATH_FOLDER_PDFS As String = "C:\Users\franc\Documents\School\ELECTIVE 3\repos\PDFResumeGeneratorUsingJSON-folder\PDFResumeGeneratorUsingJSON\created-pdfs\"
    Private Const PATH_FOLDER_JSONS As String = "C:\Users\franc\Documents\School\ELECTIVE 3\repos\PDFResumeGeneratorUsingJSON-folder\PDFResumeGeneratorUsingJSON\json-files\"
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
                    namePDF_JSON = nameParts(1) + "_" + nameParts(0)


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

                    txtBxNotes.Text = person.notes

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

                    notes = person.notes

                    panelPlaceholder.Visible = False
                    panelFields.Visible = True

                    btnCancel.Visible = False

                    isReadingJson = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnWriteJSON_Click(sender As Object, e As EventArgs) Handles btnWriteJSON.Click
        MessageBox.Show("Please fill out the fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)

        btnCancel.Visible = True

        panelPlaceholder.Visible = False
        panelFields.Visible = True

        For Each txtBx As TextBox In panelFields.Controls.OfType(Of TextBox)
            txtBx.Text = ""
            txtBx.ReadOnly = False
        Next

        btnSaveToJSON.Visible = True
    End Sub

    Private Sub btnSaveToJSON_Click(sender As Object, e As EventArgs) Handles btnSaveToJSON.Click
        Dim newPerson As Person = New Person(
            txtBxFullName.Text,
            txtBxAddress.Text,
            txtBxContactNo.Text,
            txtbxEmail.Text,
            txtBxObjective.Text,
            txtBxCollege.Text,
            txtBxDegree.Text,
            txtBxAchievements.Text,
            txtBxSkillOne.Text,
            txtBxSkillTwo.Text,
            txtBxSkillThree.Text,
            txtBxNotes.Text
        )

        namePDF_JSON = "JSON-" & newPerson.FullName

        Dim jsonToWrite = JsonConvert.SerializeObject(newPerson, Formatting.Indented)

        Dim createJSON As StreamWriter
        createJSON = File.CreateText(PATH_FOLDER_JSONS & namePDF_JSON & ".json")

        createJSON.Write(jsonToWrite)
        createJSON.Close()

        MessageBox.Show("New JSON file successfully created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        For Each txtBx As TextBox In panelFields.Controls.OfType(Of TextBox)
            txtBx.Text = ""
            txtBx.ReadOnly = True
        Next

        btnSaveToJSON.Visible = False

        panelPlaceholder.Visible = True
        panelFields.Visible = False

        btnCancel.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        For Each txtBx As TextBox In panelFields.Controls.OfType(Of TextBox)
            txtBx.Text = ""
            txtBx.ReadOnly = True
        Next

        panelPlaceholder.Visible = True
        panelFields.Visible = False

        btnCancel.Visible = False
        btnSaveToJSON.Visible = False
    End Sub

    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        If isReadingJson Then
            Dim destination As FileStream = New FileStream(PATH_FOLDER_PDFS & namePDF_JSON & ".pdf", FileMode.Create)

            Dim arial As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
            Dim biggest As iTextSharp.text.Font = New iTextSharp.text.Font(arial, 28, iTextSharp.text.Font.BOLD)
            Dim big As iTextSharp.text.Font = New iTextSharp.text.Font(arial, 20, iTextSharp.text.Font.BOLD)
            Dim normal As iTextSharp.text.Font = New iTextSharp.text.Font(arial, 14, iTextSharp.text.Font.NORMAL)
            Dim small As iTextSharp.text.Font = New iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL)

            Dim doc As Document = New Document(PageSize.A4, 60, 75, 60, 75)
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, destination)
            doc.AddAuthor("Francis Bernas")
            doc.AddCreator("Francis Bernas")
            doc.AddKeywords("PDF Resume")
            doc.AddTitle("Resume - PDF creation using iTextSharp")

            doc.Open()

            Dim paragraph As Paragraph = New Paragraph
            paragraph.Add(New Phrase(fullName + vbCrLf + vbCrLf, biggest))
            paragraph.Add(New Phrase(address + vbCrLf, normal))
            paragraph.Add(New Phrase(contactNo + vbCrLf, normal))
            paragraph.Add(New Phrase(email + vbCrLf + vbCrLf + vbCrLf + vbCrLf, normal))

            paragraph.Add(New Phrase("Objective" + vbCrLf + vbCrLf, big))
            paragraph.Add(New Phrase(objective + vbCrLf + vbCrLf + vbCrLf, normal))

            paragraph.Add(New Phrase("Education" + vbCrLf + vbCrLf, big))
            paragraph.Add(New Phrase(college + vbCrLf, normal))
            paragraph.Add(New Phrase("• " + collegeDetail1 + vbCrLf, small))
            paragraph.Add(New Phrase("• " + collegeDetail2 + vbCrLf + vbCrLf + vbCrLf + vbCrLf, small))

            paragraph.Add(New Phrase("Skills" + vbCrLf + vbCrLf, big))
            paragraph.Add(New Phrase("• " + skill1 + vbCrLf, normal))
            paragraph.Add(New Phrase("• " + skill2 + vbCrLf, normal))
            paragraph.Add(New Phrase("• " + skill3 + vbCrLf + vbCrLf, normal))

            paragraph.Add(New Phrase(notes + vbCrLf + vbCrLf + vbCrLf, normal))

            doc.Add(paragraph)
            doc.Close()
            writer.Close()
            destination.Close()
            MessageBox.Show("PDF successfully created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            For Each txtBx As TextBox In panelFields.Controls.OfType(Of TextBox)
                txtBx.Text = ""
                txtBx.ReadOnly = True
            Next

            panelPlaceholder.Visible = True
            panelFields.Visible = False

            isReadingJson = False
        Else
            MessageBox.Show("Load a JSON file first", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Function SplitName(ByVal fullName As String) As String()
        Dim nameSurname(2) As String
        Dim nameSurnameTemp() As String = fullName.Split(" ")
        For i = 0 To nameSurnameTemp.Length - 1
            If i < nameSurnameTemp.Length - 1 Then
                If Not (String.IsNullOrEmpty(nameSurname(0))) Then
                    nameSurname(0) += " " & nameSurnameTemp(i)
                Else
                    nameSurname(0) += nameSurnameTemp(i)
                End If
            Else
                nameSurname(1) = nameSurnameTemp(i)
            End If
        Next
        Return nameSurname
    End Function
End Class
