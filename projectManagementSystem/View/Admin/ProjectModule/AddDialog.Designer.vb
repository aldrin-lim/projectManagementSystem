<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDialog
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
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCreateProject = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProjectDesc = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Create a New Project"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Project Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectName
        '
        Me.txtProjectName.BackColor = System.Drawing.Color.White
        Me.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProjectName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectName.ForeColor = System.Drawing.Color.DimGray
        Me.txtProjectName.Location = New System.Drawing.Point(139, 85)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(328, 19)
        Me.txtProjectName.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox2.Location = New System.Drawing.Point(139, 108)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(328, 1)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Duration "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateStart
        '
        Me.dateStart.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateStart.CustomFormat = "yyyy - MMM - dd"
        Me.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateStart.Location = New System.Drawing.Point(139, 129)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(132, 20)
        Me.dateStart.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(288, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "to"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateEnd
        '
        Me.dateEnd.CalendarFont = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateEnd.CustomFormat = "yyyy - MMM - dd"
        Me.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateEnd.Location = New System.Drawing.Point(322, 129)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(145, 20)
        Me.dateEnd.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Members"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(19, 302)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(187, 159)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(279, 302)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(188, 159)
        Me.ListView2.TabIndex = 12
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(225, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 31)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(225, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCreateProject
        '
        Me.btnCreateProject.AutoSize = True
        Me.btnCreateProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnCreateProject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCreateProject.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon
        Me.btnCreateProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnCreateProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateProject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateProject.ForeColor = System.Drawing.Color.White
        Me.btnCreateProject.Location = New System.Drawing.Point(151, 494)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(192, 30)
        Me.btnCreateProject.TabIndex = 15
        Me.btnCreateProject.Text = "Create Project"
        Me.btnCreateProject.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Description"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectDesc
        '
        Me.txtProjectDesc.BackColor = System.Drawing.Color.White
        Me.txtProjectDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProjectDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectDesc.ForeColor = System.Drawing.Color.DimGray
        Me.txtProjectDesc.Location = New System.Drawing.Point(3, 3)
        Me.txtProjectDesc.Name = "txtProjectDesc"
        Me.txtProjectDesc.Size = New System.Drawing.Size(320, 83)
        Me.txtProjectDesc.TabIndex = 17
        Me.txtProjectDesc.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtProjectDesc)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(139, 176)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(328, 91)
        Me.Panel3.TabIndex = 18
        '
        'AddDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 533)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCreateProject)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dateEnd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(495, 567)
        Me.Name = "AddDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCreateProject As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProjectDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
