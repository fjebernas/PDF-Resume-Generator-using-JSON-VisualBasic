<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.panelPlaceholder = New System.Windows.Forms.Panel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelFields = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtBxContactNo = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtBxSkillThree = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtBxSkillTwo = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtBxSkillOne = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtBxAchievements = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtBxDegree = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtBxCollege = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtBxObjective = New System.Windows.Forms.TextBox()
        Me.txtBxFullName = New System.Windows.Forms.TextBox()
        Me.txtBxNotes = New System.Windows.Forms.TextBox()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnLoadJSON = New System.Windows.Forms.Button()
        Me.btnWriteJSON = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveToJSON = New System.Windows.Forms.Button()
        Me.btnGeneratePDF = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panelPlaceholder.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFields.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelPlaceholder
        '
        Me.panelPlaceholder.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panelPlaceholder.Controls.Add(Me.label12)
        Me.panelPlaceholder.Controls.Add(Me.pictureBox1)
        Me.panelPlaceholder.Location = New System.Drawing.Point(367, 226)
        Me.panelPlaceholder.Name = "panelPlaceholder"
        Me.panelPlaceholder.Size = New System.Drawing.Size(432, 303)
        Me.panelPlaceholder.TabIndex = 14
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.label12.Location = New System.Drawing.Point(3, 209)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(422, 22)
        Me.label12.TabIndex = 10
        Me.label12.Text = "Load or Write a JSON file to start working now"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(148, 52)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(143, 141)
        Me.pictureBox1.TabIndex = 9
        Me.pictureBox1.TabStop = False
        '
        'panelFields
        '
        Me.panelFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panelFields.Controls.Add(Me.label2)
        Me.panelFields.Controls.Add(Me.label4)
        Me.panelFields.Controls.Add(Me.txtbxEmail)
        Me.panelFields.Controls.Add(Me.label6)
        Me.panelFields.Controls.Add(Me.txtBxContactNo)
        Me.panelFields.Controls.Add(Me.label7)
        Me.panelFields.Controls.Add(Me.txtBxSkillThree)
        Me.panelFields.Controls.Add(Me.label10)
        Me.panelFields.Controls.Add(Me.txtBxSkillTwo)
        Me.panelFields.Controls.Add(Me.label11)
        Me.panelFields.Controls.Add(Me.txtBxSkillOne)
        Me.panelFields.Controls.Add(Me.label9)
        Me.panelFields.Controls.Add(Me.txtBxAchievements)
        Me.panelFields.Controls.Add(Me.label8)
        Me.panelFields.Controls.Add(Me.txtBxDegree)
        Me.panelFields.Controls.Add(Me.label3)
        Me.panelFields.Controls.Add(Me.txtBxCollege)
        Me.panelFields.Controls.Add(Me.label5)
        Me.panelFields.Controls.Add(Me.txtBxObjective)
        Me.panelFields.Controls.Add(Me.txtBxFullName)
        Me.panelFields.Controls.Add(Me.txtBxNotes)
        Me.panelFields.Controls.Add(Me.txtBxAddress)
        Me.panelFields.Location = New System.Drawing.Point(227, 82)
        Me.panelFields.Name = "panelFields"
        Me.panelFields.Size = New System.Drawing.Size(722, 621)
        Me.panelFields.TabIndex = 13
        Me.panelFields.Visible = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(57, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 21)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Full name:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(69, 85)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(76, 21)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Address:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.Location = New System.Drawing.Point(480, 83)
        Me.txtbxEmail.Multiline = True
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.ReadOnly = True
        Me.txtbxEmail.Size = New System.Drawing.Size(226, 32)
        Me.txtbxEmail.TabIndex = 5
        Me.txtbxEmail.Tag = "textBox"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(51, 147)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(92, 21)
        Me.label6.TabIndex = 4
        Me.label6.Text = "Objective:"
        '
        'txtBxContactNo
        '
        Me.txtBxContactNo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxContactNo.Location = New System.Drawing.Point(537, 21)
        Me.txtBxContactNo.Multiline = True
        Me.txtBxContactNo.Name = "txtBxContactNo"
        Me.txtBxContactNo.ReadOnly = True
        Me.txtBxContactNo.Size = New System.Drawing.Size(169, 32)
        Me.txtBxContactNo.TabIndex = 5
        Me.txtBxContactNo.Tag = "textBox"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(72, 275)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(74, 21)
        Me.label7.TabIndex = 4
        Me.label7.Text = "College:"
        '
        'txtBxSkillThree
        '
        Me.txtBxSkillThree.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxSkillThree.Location = New System.Drawing.Point(152, 483)
        Me.txtBxSkillThree.Multiline = True
        Me.txtBxSkillThree.Name = "txtBxSkillThree"
        Me.txtBxSkillThree.ReadOnly = True
        Me.txtBxSkillThree.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBxSkillThree.Size = New System.Drawing.Size(554, 32)
        Me.txtBxSkillThree.TabIndex = 5
        Me.txtBxSkillThree.Tag = "textBox"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(74, 313)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(72, 21)
        Me.label10.TabIndex = 4
        Me.label10.Text = "Degree:"
        '
        'txtBxSkillTwo
        '
        Me.txtBxSkillTwo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxSkillTwo.Location = New System.Drawing.Point(152, 445)
        Me.txtBxSkillTwo.Multiline = True
        Me.txtBxSkillTwo.Name = "txtBxSkillTwo"
        Me.txtBxSkillTwo.ReadOnly = True
        Me.txtBxSkillTwo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBxSkillTwo.Size = New System.Drawing.Size(554, 32)
        Me.txtBxSkillTwo.TabIndex = 5
        Me.txtBxSkillTwo.Tag = "textBox"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(18, 351)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(128, 21)
        Me.label11.TabIndex = 4
        Me.label11.Text = "Achievements:"
        '
        'txtBxSkillOne
        '
        Me.txtBxSkillOne.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxSkillOne.Location = New System.Drawing.Point(152, 407)
        Me.txtBxSkillOne.Multiline = True
        Me.txtBxSkillOne.Name = "txtBxSkillOne"
        Me.txtBxSkillOne.ReadOnly = True
        Me.txtBxSkillOne.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBxSkillOne.Size = New System.Drawing.Size(554, 32)
        Me.txtBxSkillOne.TabIndex = 5
        Me.txtBxSkillOne.Tag = "textBox"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(87, 542)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(59, 21)
        Me.label9.TabIndex = 4
        Me.label9.Text = "Notes:"
        '
        'txtBxAchievements
        '
        Me.txtBxAchievements.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAchievements.Location = New System.Drawing.Point(152, 347)
        Me.txtBxAchievements.Multiline = True
        Me.txtBxAchievements.Name = "txtBxAchievements"
        Me.txtBxAchievements.ReadOnly = True
        Me.txtBxAchievements.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBxAchievements.Size = New System.Drawing.Size(554, 32)
        Me.txtBxAchievements.TabIndex = 5
        Me.txtBxAchievements.Tag = "textBox"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(101, 409)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(45, 21)
        Me.label8.TabIndex = 4
        Me.label8.Text = "Skills:"
        '
        'txtBxDegree
        '
        Me.txtBxDegree.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxDegree.Location = New System.Drawing.Point(152, 309)
        Me.txtBxDegree.Multiline = True
        Me.txtBxDegree.Name = "txtBxDegree"
        Me.txtBxDegree.ReadOnly = True
        Me.txtBxDegree.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBxDegree.Size = New System.Drawing.Size(554, 32)
        Me.txtBxDegree.TabIndex = 5
        Me.txtBxDegree.Tag = "textBox"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(419, 23)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(112, 21)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Contact No.:"
        '
        'txtBxCollege
        '
        Me.txtBxCollege.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCollege.Location = New System.Drawing.Point(152, 271)
        Me.txtBxCollege.Multiline = True
        Me.txtBxCollege.Name = "txtBxCollege"
        Me.txtBxCollege.ReadOnly = True
        Me.txtBxCollege.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBxCollege.Size = New System.Drawing.Size(554, 32)
        Me.txtBxCollege.TabIndex = 5
        Me.txtBxCollege.Tag = "textBox"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(419, 85)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 21)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Email:"
        '
        'txtBxObjective
        '
        Me.txtBxObjective.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxObjective.Location = New System.Drawing.Point(152, 147)
        Me.txtBxObjective.Multiline = True
        Me.txtBxObjective.Name = "txtBxObjective"
        Me.txtBxObjective.ReadOnly = True
        Me.txtBxObjective.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBxObjective.Size = New System.Drawing.Size(554, 97)
        Me.txtBxObjective.TabIndex = 5
        Me.txtBxObjective.Tag = "textBox"
        '
        'txtBxFullName
        '
        Me.txtBxFullName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxFullName.Location = New System.Drawing.Point(152, 21)
        Me.txtBxFullName.Multiline = True
        Me.txtBxFullName.Name = "txtBxFullName"
        Me.txtBxFullName.ReadOnly = True
        Me.txtBxFullName.Size = New System.Drawing.Size(247, 32)
        Me.txtBxFullName.TabIndex = 5
        Me.txtBxFullName.Tag = "textBox"
        '
        'txtBxNotes
        '
        Me.txtBxNotes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNotes.Location = New System.Drawing.Point(152, 542)
        Me.txtBxNotes.Multiline = True
        Me.txtBxNotes.Name = "txtBxNotes"
        Me.txtBxNotes.ReadOnly = True
        Me.txtBxNotes.Size = New System.Drawing.Size(554, 63)
        Me.txtBxNotes.TabIndex = 5
        Me.txtBxNotes.Tag = "textBox"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAddress.Location = New System.Drawing.Point(152, 83)
        Me.txtBxAddress.Multiline = True
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.ReadOnly = True
        Me.txtBxAddress.Size = New System.Drawing.Size(247, 32)
        Me.txtBxAddress.TabIndex = 5
        Me.txtBxAddress.Tag = "textBox"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.panel1.Controls.Add(Me.btnLoadJSON)
        Me.panel1.Controls.Add(Me.btnWriteJSON)
        Me.panel1.Controls.Add(Me.btnCancel)
        Me.panel1.Controls.Add(Me.btnSaveToJSON)
        Me.panel1.Controls.Add(Me.btnGeneratePDF)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 76)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(211, 643)
        Me.panel1.TabIndex = 11
        '
        'btnLoadJSON
        '
        Me.btnLoadJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnLoadJSON.FlatAppearance.BorderSize = 0
        Me.btnLoadJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadJSON.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadJSON.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnLoadJSON.Image = CType(resources.GetObject("btnLoadJSON.Image"), System.Drawing.Image)
        Me.btnLoadJSON.Location = New System.Drawing.Point(0, 150)
        Me.btnLoadJSON.Name = "btnLoadJSON"
        Me.btnLoadJSON.Size = New System.Drawing.Size(208, 75)
        Me.btnLoadJSON.TabIndex = 0
        Me.btnLoadJSON.Text = "  &Load JSON file"
        Me.btnLoadJSON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoadJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoadJSON.UseVisualStyleBackColor = False
        '
        'btnWriteJSON
        '
        Me.btnWriteJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnWriteJSON.FlatAppearance.BorderSize = 0
        Me.btnWriteJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWriteJSON.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWriteJSON.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnWriteJSON.Image = CType(resources.GetObject("btnWriteJSON.Image"), System.Drawing.Image)
        Me.btnWriteJSON.Location = New System.Drawing.Point(0, 226)
        Me.btnWriteJSON.Name = "btnWriteJSON"
        Me.btnWriteJSON.Size = New System.Drawing.Size(208, 75)
        Me.btnWriteJSON.TabIndex = 0
        Me.btnWriteJSON.Text = "  &Write to JSON"
        Me.btnWriteJSON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWriteJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWriteJSON.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(0, 489)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(208, 75)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnSaveToJSON
        '
        Me.btnSaveToJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSaveToJSON.FlatAppearance.BorderSize = 0
        Me.btnSaveToJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveToJSON.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToJSON.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnSaveToJSON.Image = CType(resources.GetObject("btnSaveToJSON.Image"), System.Drawing.Image)
        Me.btnSaveToJSON.Location = New System.Drawing.Point(0, 411)
        Me.btnSaveToJSON.Name = "btnSaveToJSON"
        Me.btnSaveToJSON.Size = New System.Drawing.Size(208, 75)
        Me.btnSaveToJSON.TabIndex = 1
        Me.btnSaveToJSON.Text = "  &Save to JSON"
        Me.btnSaveToJSON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveToJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveToJSON.UseVisualStyleBackColor = False
        Me.btnSaveToJSON.Visible = False
        '
        'btnGeneratePDF
        '
        Me.btnGeneratePDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnGeneratePDF.FlatAppearance.BorderSize = 0
        Me.btnGeneratePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePDF.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneratePDF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnGeneratePDF.Image = CType(resources.GetObject("btnGeneratePDF.Image"), System.Drawing.Image)
        Me.btnGeneratePDF.Location = New System.Drawing.Point(0, 302)
        Me.btnGeneratePDF.Name = "btnGeneratePDF"
        Me.btnGeneratePDF.Size = New System.Drawing.Size(208, 75)
        Me.btnGeneratePDF.TabIndex = 1
        Me.btnGeneratePDF.Text = "  &Generate PDF"
        Me.btnGeneratePDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGeneratePDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGeneratePDF.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(965, 76)
        Me.panel2.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(258, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(468, 32)
        Me.label1.TabIndex = 3
        Me.label1.Text = "PDF Resume Generator using JSON"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 719)
        Me.Controls.Add(Me.panelPlaceholder)
        Me.Controls.Add(Me.panelFields)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDF Resume Generator using JSON"
        Me.panelPlaceholder.ResumeLayout(False)
        Me.panelPlaceholder.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFields.ResumeLayout(False)
        Me.panelFields.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelPlaceholder As Panel
    Private WithEvents label12 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents panelFields As Panel
    Private WithEvents label2 As Label
    Private WithEvents label4 As Label
    Private WithEvents txtbxEmail As TextBox
    Private WithEvents label6 As Label
    Private WithEvents txtBxContactNo As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtBxSkillThree As TextBox
    Private WithEvents label10 As Label
    Private WithEvents txtBxSkillTwo As TextBox
    Private WithEvents label11 As Label
    Private WithEvents txtBxSkillOne As TextBox
    Private WithEvents label9 As Label
    Private WithEvents txtBxAchievements As TextBox
    Private WithEvents label8 As Label
    Private WithEvents txtBxDegree As TextBox
    Private WithEvents label3 As Label
    Private WithEvents txtBxCollege As TextBox
    Private WithEvents label5 As Label
    Private WithEvents txtBxObjective As TextBox
    Private WithEvents txtBxFullName As TextBox
    Private WithEvents txtBxNotes As TextBox
    Private WithEvents txtBxAddress As TextBox
    Private WithEvents panel1 As Panel
    Private WithEvents btnLoadJSON As Button
    Private WithEvents btnWriteJSON As Button
    Private WithEvents btnCancel As Button
    Private WithEvents btnSaveToJSON As Button
    Private WithEvents btnGeneratePDF As Button
    Private WithEvents panel2 As Panel
    Private WithEvents label1 As Label
End Class
