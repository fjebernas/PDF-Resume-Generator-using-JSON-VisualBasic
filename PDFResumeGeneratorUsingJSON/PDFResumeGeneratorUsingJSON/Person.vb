Public Class Person
    Public FullName As String
    Public Address As String
    Public ContactNo As String
    Public Email As String

    Public Objective As String

    Public College As String
    Public CollegeDetail1 As String
    Public CollegeDetail2 As String

    Public Skill1 As String
    Public Skill2 As String
    Public Skill3 As String

    Public notes As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal txtBxFullName As String, ByVal txtBxAddress As String, ByVal txtBxContactNo As String, ByVal txtBxEmail As String, ByVal txtBxObjective As String, ByVal txtBxCollege As String, ByVal txtBxDegree As String, ByVal txtBxAchievements As String, ByVal txtBxSkillOne As String, ByVal txtBxSkillTwo As String, ByVal txtBxSkillThree As String, ByVal txtBxNotes As String)
        FullName = txtBxFullName
        Address = txtBxAddress
        ContactNo = txtBxContactNo
        Email = txtBxEmail
        Objective = txtBxObjective
        College = txtBxCollege
        CollegeDetail1 = txtBxDegree
        CollegeDetail2 = txtBxAchievements
        Skill1 = txtBxSkillOne
        Skill2 = txtBxSkillTwo
        Skill3 = txtBxSkillThree
        notes = txtBxNotes
    End Sub

End Class
