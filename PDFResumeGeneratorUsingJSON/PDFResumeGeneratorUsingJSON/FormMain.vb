Public Class FormMain
    Private Const PATH_JSON As String = "C:\Users\franc\Documents\School\ELECTIVE 3\repos\PDFResumeGeneratorUsingJSON-folder\PDFResumeGeneratorUsingJSON\json-files"

    Private namePDF_JSON As String
    Private fullName, contactNo, address, email, objective, college, collegeDetail1, collegeDetail2, highschool, elementary, skill1, skill2, skill3, skill4, notes As String
    Private isReadingJson As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        For Each txtBx As TextBox In panelFields.Controls.OfType(Of TextBox)
            txtBx.Text = ""
            txtBx.ReadOnly = True
        Next

        btnSaveToJSON.Visible = False

        Try


        Catch ex As Exception

        End Try
    End Sub

    Private Function SplitName()

    End Function
End Class
