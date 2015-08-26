<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskView
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelBox = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHrs = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddTask = New System.Windows.Forms.Label()
        Me.lblCreateMilestone = New System.Windows.Forms.Label()
        Me.pboxCreateMilestone = New System.Windows.Forms.PictureBox()
        Me.iconCreateUser = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pboxCreateMilestone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconCreateUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(166, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "All Task"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelBox
        '
        Me.panelBox.AutoScroll = True
        Me.panelBox.Controls.Add(Me.GroupBox1)
        Me.panelBox.Location = New System.Drawing.Point(160, 140)
        Me.panelBox.Name = "panelBox"
        Me.panelBox.Size = New System.Drawing.Size(677, 497)
        Me.panelBox.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtHrs)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UI Development"
        '
        'Label7
        '
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(470, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "On-going"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(417, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Status:"
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(243, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 15)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Aug 20, 2015 - Aug 25, 2015"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(179, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Duration:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(9, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 80)
        Me.Panel1.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 24)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Allocated Hours:"
        '
        'txtHrs
        '
        Me.txtHrs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtHrs.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtHrs.Location = New System.Drawing.Point(112, 35)
        Me.txtHrs.Name = "txtHrs"
        Me.txtHrs.Size = New System.Drawing.Size(64, 15)
        Me.txtHrs.TabIndex = 56
        Me.txtHrs.Text = "20 Hr(s)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(6, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Allocated Hours:"
        '
        'btnAddTask
        '
        Me.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTask.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddTask.Location = New System.Drawing.Point(12, 224)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(131, 32)
        Me.btnAddTask.TabIndex = 25
        Me.btnAddTask.Text = "Create New Task"
        Me.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCreateMilestone
        '
        Me.lblCreateMilestone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCreateMilestone.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateMilestone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblCreateMilestone.Location = New System.Drawing.Point(4, 358)
        Me.lblCreateMilestone.Name = "lblCreateMilestone"
        Me.lblCreateMilestone.Size = New System.Drawing.Size(151, 32)
        Me.lblCreateMilestone.TabIndex = 27
        Me.lblCreateMilestone.Text = "Create New Milestone"
        Me.lblCreateMilestone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboxCreateMilestone
        '
        Me.pboxCreateMilestone.BackColor = System.Drawing.Color.Transparent
        Me.pboxCreateMilestone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxCreateMilestone.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_flag_18_icon_128
        Me.pboxCreateMilestone.Location = New System.Drawing.Point(29, 272)
        Me.pboxCreateMilestone.Name = "pboxCreateMilestone"
        Me.pboxCreateMilestone.Size = New System.Drawing.Size(112, 90)
        Me.pboxCreateMilestone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxCreateMilestone.TabIndex = 26
        Me.pboxCreateMilestone.TabStop = False
        '
        'iconCreateUser
        '
        Me.iconCreateUser.BackColor = System.Drawing.Color.Transparent
        Me.iconCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconCreateUser.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_clipboard_5_icon_128__1_
        Me.iconCreateUser.Location = New System.Drawing.Point(29, 140)
        Me.iconCreateUser.Name = "iconCreateUser"
        Me.iconCreateUser.Size = New System.Drawing.Size(90, 90)
        Me.iconCreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconCreateUser.TabIndex = 25
        Me.iconCreateUser.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox2.Location = New System.Drawing.Point(169, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(658, 1)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'TaskView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 657)
        Me.Controls.Add(Me.pboxCreateMilestone)
        Me.Controls.Add(Me.lblCreateMilestone)
        Me.Controls.Add(Me.iconCreateUser)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.panelBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddTask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TaskView"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Text = "TaskView"
        Me.panelBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pboxCreateMilestone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconCreateUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelBox As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    '<<<<<<< .merge_file_a05684
    '=======
    Friend WithEvents iconCreateUser As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddTask As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHrs As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pboxCreateMilestone As System.Windows.Forms.PictureBox
    Friend WithEvents lblCreateMilestone As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    '>>>>>>> .merge_file_a06588
End Class
