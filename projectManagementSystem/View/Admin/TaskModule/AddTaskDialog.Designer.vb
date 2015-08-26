<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTaskDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.Label()
        Me.txtTaskDuration = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxProject = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtProjectDescription = New System.Windows.Forms.RichTextBox()
        Me.cbxAssigned = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxMilestone = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxDependency = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAdditional = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Create a New Task"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Task Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTaskName
        '
        Me.txtTaskName.BackColor = System.Drawing.Color.White
        Me.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTaskName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskName.ForeColor = System.Drawing.Color.DimGray
        Me.txtTaskName.Location = New System.Drawing.Point(139, 85)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(328, 19)
        Me.txtTaskName.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox2.Location = New System.Drawing.Point(139, 108)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(328, 1)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Allocated Hours"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(12, 340)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(121, 18)
        Me.txtDescription.TabIndex = 17
        Me.txtDescription.Text = "Description"
        Me.txtDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTaskDuration
        '
        Me.txtTaskDuration.BackColor = System.Drawing.Color.White
        Me.txtTaskDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaskDuration.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTaskDuration.ForeColor = System.Drawing.Color.DimGray
        Me.txtTaskDuration.Location = New System.Drawing.Point(139, 128)
        Me.txtTaskDuration.Name = "txtTaskDuration"
        Me.txtTaskDuration.Size = New System.Drawing.Size(54, 26)
        Me.txtTaskDuration.TabIndex = 20
        '
        'save
        '
        Me.save.AutoSize = True
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.save.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon
        Me.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.Location = New System.Drawing.Point(151, 455)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(192, 30)
        Me.save.TabIndex = 28
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'dateEnd
        '
        Me.dateEnd.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateEnd.CustomFormat = "yyyy - MMM - dd"
        Me.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateEnd.Location = New System.Drawing.Point(322, 168)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(145, 20)
        Me.dateEnd.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(288, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "to"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateStart
        '
        Me.dateStart.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateStart.CustomFormat = "yyyy - MMM - dd"
        Me.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateStart.Location = New System.Drawing.Point(139, 168)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(132, 20)
        Me.dateStart.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Duration "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Project"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxProject
        '
        Me.cbxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProject.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cbxProject.FormattingEnabled = True
        Me.cbxProject.Location = New System.Drawing.Point(139, 199)
        Me.cbxProject.Name = "cbxProject"
        Me.cbxProject.Size = New System.Drawing.Size(328, 26)
        Me.cbxProject.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtProjectDescription)
        Me.Panel1.Location = New System.Drawing.Point(139, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 100)
        Me.Panel1.TabIndex = 42
        '
        'txtProjectDescription
        '
        Me.txtProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProjectDescription.Location = New System.Drawing.Point(3, 2)
        Me.txtProjectDescription.Name = "txtProjectDescription"
        Me.txtProjectDescription.Size = New System.Drawing.Size(320, 93)
        Me.txtProjectDescription.TabIndex = 0
        Me.txtProjectDescription.Text = ""
        '
        'cbxAssigned
        '
        Me.cbxAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAssigned.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cbxAssigned.FormattingEnabled = True
        Me.cbxAssigned.Location = New System.Drawing.Point(139, 234)
        Me.cbxAssigned.Name = "cbxAssigned"
        Me.cbxAssigned.Size = New System.Drawing.Size(328, 26)
        Me.cbxAssigned.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 18)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Assigned to"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxMilestone
        '
        Me.cbxMilestone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMilestone.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cbxMilestone.FormattingEnabled = True
        Me.cbxMilestone.Location = New System.Drawing.Point(139, 266)
        Me.cbxMilestone.Name = "cbxMilestone"
        Me.cbxMilestone.Size = New System.Drawing.Size(328, 26)
        Me.cbxMilestone.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Milestone"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(199, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 18)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Hr(s)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxDependency
        '
        Me.cbxDependency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDependency.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cbxDependency.FormattingEnabled = True
        Me.cbxDependency.Location = New System.Drawing.Point(139, 303)
        Me.cbxDependency.Name = "cbxDependency"
        Me.cbxDependency.Size = New System.Drawing.Size(328, 26)
        Me.cbxDependency.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(12, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 18)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Dependency"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdditional
        '
        Me.txtAdditional.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdditional.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtAdditional.Location = New System.Drawing.Point(254, 131)
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.Size = New System.Drawing.Size(209, 18)
        Me.txtAdditional.TabIndex = 50
        Me.txtAdditional.Text = "+ 20 Hours"
        Me.txtAdditional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddTaskDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 492)
        Me.Controls.Add(Me.txtAdditional)
        Me.Controls.Add(Me.cbxDependency)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxMilestone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxAssigned)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbxProject)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dateEnd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.txtTaskDuration)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtTaskName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(495, 567)
        Me.Name = "AddTaskDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTaskName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.Label
    Friend WithEvents txtTaskDuration As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxProject As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtProjectDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents cbxAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxMilestone As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxDependency As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAdditional As System.Windows.Forms.Label
End Class
