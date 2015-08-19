<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detailsDialog
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
        Me.components = New System.ComponentModel.Container()
        Me.txtProjectTitle = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.txtProjectDesc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTaskCount = New System.Windows.Forms.Label()
        Me.txtMemberCount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDurationDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEditTitle = New System.Windows.Forms.RichTextBox()
        Me.toolTipEdit = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEditDuration = New System.Windows.Forms.PictureBox()
        Me.btnEditTitle = New System.Windows.Forms.PictureBox()
        Me.btnEditDesc = New System.Windows.Forms.PictureBox()
        Me.txtEditDesc = New System.Windows.Forms.RichTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.btnEditDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProjectTitle
        '
        Me.txtProjectTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtProjectTitle.Location = New System.Drawing.Point(26, 20)
        Me.txtProjectTitle.Name = "txtProjectTitle"
        Me.txtProjectTitle.Size = New System.Drawing.Size(676, 75)
        Me.txtProjectTitle.TabIndex = 1
        Me.txtProjectTitle.Text = "Empolyee Information and Management System"
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(720, 170)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 16)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete This Project"
        '
        'txtProjectDesc
        '
        Me.txtProjectDesc.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtProjectDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtProjectDesc.Location = New System.Drawing.Point(33, 117)
        Me.txtProjectDesc.Name = "txtProjectDesc"
        Me.txtProjectDesc.Size = New System.Drawing.Size(779, 42)
        Me.txtProjectDesc.TabIndex = 5
        Me.txtProjectDesc.Text = "( No Description Available )"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(19, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.Panel1.Size = New System.Drawing.Size(819, 400)
        Me.Panel1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(19, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "All Tasks: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTaskCount
        '
        Me.txtTaskCount.AutoSize = True
        Me.txtTaskCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTaskCount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskCount.ForeColor = System.Drawing.Color.Gray
        Me.txtTaskCount.Location = New System.Drawing.Point(85, 170)
        Me.txtTaskCount.Name = "txtTaskCount"
        Me.txtTaskCount.Size = New System.Drawing.Size(98, 16)
        Me.txtTaskCount.TabIndex = 9
        Me.txtTaskCount.Text = "Total of 8 Tasks"
        Me.txtTaskCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMemberCount
        '
        Me.txtMemberCount.AutoSize = True
        Me.txtMemberCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtMemberCount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberCount.ForeColor = System.Drawing.Color.Gray
        Me.txtMemberCount.Location = New System.Drawing.Point(255, 170)
        Me.txtMemberCount.Name = "txtMemberCount"
        Me.txtMemberCount.Size = New System.Drawing.Size(59, 16)
        Me.txtMemberCount.TabIndex = 11
        Me.txtMemberCount.Text = "3 People"
        Me.txtMemberCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(189, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Members:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDurationDate
        '
        Me.txtDurationDate.AutoSize = True
        Me.txtDurationDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtDurationDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDurationDate.ForeColor = System.Drawing.Color.Gray
        Me.txtDurationDate.Location = New System.Drawing.Point(397, 170)
        Me.txtDurationDate.Name = "txtDurationDate"
        Me.txtDurationDate.Size = New System.Drawing.Size(151, 16)
        Me.txtDurationDate.TabIndex = 13
        Me.txtDurationDate.Text = "Aug 3,2015 - Aug 9,2015"
        Me.txtDurationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(331, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Duration:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEditTitle
        '
        Me.txtEditTitle.BackColor = System.Drawing.Color.White
        Me.txtEditTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEditTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.txtEditTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtEditTitle.Location = New System.Drawing.Point(31, 20)
        Me.txtEditTitle.Name = "txtEditTitle"
        Me.txtEditTitle.Size = New System.Drawing.Size(606, 75)
        Me.txtEditTitle.TabIndex = 15
        Me.txtEditTitle.Text = ""
        Me.txtEditTitle.Visible = False
        '
        'toolTipEdit
        '
        Me.toolTipEdit.AutomaticDelay = 1
        Me.toolTipEdit.AutoPopDelay = 50000
        Me.toolTipEdit.InitialDelay = 1
        Me.toolTipEdit.ReshowDelay = 0
        '
        'btnEditDuration
        '
        Me.btnEditDuration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDuration.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_edit_7_icon_24
        Me.btnEditDuration.Location = New System.Drawing.Point(567, 167)
        Me.btnEditDuration.Name = "btnEditDuration"
        Me.btnEditDuration.Size = New System.Drawing.Size(18, 18)
        Me.btnEditDuration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditDuration.TabIndex = 20
        Me.btnEditDuration.TabStop = False
        Me.toolTipEdit.SetToolTip(Me.btnEditDuration, "Edit Duration of this Project")
        '
        'btnEditTitle
        '
        Me.btnEditTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditTitle.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_edit_7_icon_24__1_
        Me.btnEditTitle.Location = New System.Drawing.Point(6, 1)
        Me.btnEditTitle.Name = "btnEditTitle"
        Me.btnEditTitle.Size = New System.Drawing.Size(18, 18)
        Me.btnEditTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditTitle.TabIndex = 18
        Me.btnEditTitle.TabStop = False
        Me.toolTipEdit.SetToolTip(Me.btnEditTitle, "Edit Title of this Project")
        '
        'btnEditDesc
        '
        Me.btnEditDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDesc.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_edit_7_icon_24__1_
        Me.btnEditDesc.Location = New System.Drawing.Point(6, 93)
        Me.btnEditDesc.Name = "btnEditDesc"
        Me.btnEditDesc.Size = New System.Drawing.Size(18, 18)
        Me.btnEditDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditDesc.TabIndex = 17
        Me.btnEditDesc.TabStop = False
        Me.toolTipEdit.SetToolTip(Me.btnEditDesc, "Edit Description of this Project")
        '
        'txtEditDesc
        '
        Me.txtEditDesc.BackColor = System.Drawing.Color.White
        Me.txtEditDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditDesc.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtEditDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtEditDesc.Location = New System.Drawing.Point(33, 117)
        Me.txtEditDesc.Name = "txtEditDesc"
        Me.txtEditDesc.Size = New System.Drawing.Size(701, 42)
        Me.txtEditDesc.TabIndex = 19
        Me.txtEditDesc.Text = ""
        Me.txtEditDesc.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(19, 163)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(819, 1)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(19, 190)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(819, 1)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(33, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Description:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(28, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Project Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'detailsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 600)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditDuration)
        Me.Controls.Add(Me.btnEditTitle)
        Me.Controls.Add(Me.btnEditDesc)
        Me.Controls.Add(Me.txtDurationDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMemberCount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTaskCount)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtEditDesc)
        Me.Controls.Add(Me.txtProjectDesc)
        Me.Controls.Add(Me.txtEditTitle)
        Me.Controls.Add(Me.txtProjectTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(866, 634)
        Me.Name = "detailsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Project Information"
        CType(Me.btnEditDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProjectTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.Label
    Friend WithEvents txtProjectDesc As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTaskCount As System.Windows.Forms.Label
    Friend WithEvents txtMemberCount As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDurationDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEditTitle As System.Windows.Forms.RichTextBox
    Friend WithEvents btnEditDesc As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditTitle As System.Windows.Forms.PictureBox
    Friend WithEvents toolTipEdit As System.Windows.Forms.ToolTip
    Friend WithEvents txtEditDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents btnEditDuration As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
