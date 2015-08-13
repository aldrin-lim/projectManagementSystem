<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.hoverLine = New System.Windows.Forms.PictureBox()
        Me.btnProfileIcon = New System.Windows.Forms.Panel()
        Me.iconProfile = New System.Windows.Forms.PictureBox()
        Me.txtProfileIcon = New System.Windows.Forms.Label()
        Me.btnReportsIcon = New System.Windows.Forms.Panel()
        Me.iconReports = New System.Windows.Forms.PictureBox()
        Me.txtReportsIcon = New System.Windows.Forms.Label()
        Me.btnIconProgress = New System.Windows.Forms.Panel()
        Me.iconProgress = New System.Windows.Forms.PictureBox()
        Me.txtProgressIcon = New System.Windows.Forms.Label()
        Me.btnIconWork = New System.Windows.Forms.Panel()
        Me.iconWork = New System.Windows.Forms.PictureBox()
        Me.txtWorkIcon = New System.Windows.Forms.Label()
        Me.btnTaskModule = New System.Windows.Forms.Panel()
        Me.iconTask = New System.Windows.Forms.PictureBox()
        Me.txtTaskICon = New System.Windows.Forms.Label()
        Me.btnTeamModule = New System.Windows.Forms.Panel()
        Me.iconTeam = New System.Windows.Forms.PictureBox()
        Me.txtTeamIcon = New System.Windows.Forms.Label()
        Me.btnProjectModule = New System.Windows.Forms.Panel()
        Me.iconProject = New System.Windows.Forms.PictureBox()
        Me.txtProjectIcon = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.hoverLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnProfileIcon.SuspendLayout()
        CType(Me.iconProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnReportsIcon.SuspendLayout()
        CType(Me.iconReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnIconProgress.SuspendLayout()
        CType(Me.iconProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnIconWork.SuspendLayout()
        CType(Me.iconWork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnTaskModule.SuspendLayout()
        CType(Me.iconTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnTeamModule.SuspendLayout()
        CType(Me.iconTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnProjectModule.SuspendLayout()
        CType(Me.iconProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.hoverLine)
        Me.Panel1.Controls.Add(Me.btnProfileIcon)
        Me.Panel1.Controls.Add(Me.btnReportsIcon)
        Me.Panel1.Controls.Add(Me.btnIconProgress)
        Me.Panel1.Controls.Add(Me.btnIconWork)
        Me.Panel1.Controls.Add(Me.btnTaskModule)
        Me.Panel1.Controls.Add(Me.btnTeamModule)
        Me.Panel1.Controls.Add(Me.btnProjectModule)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_username)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 700)
        Me.Panel1.TabIndex = 1
        '
        'hoverLine
        '
        Me.hoverLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.hoverLine.Location = New System.Drawing.Point(9, 536)
        Me.hoverLine.Name = "hoverLine"
        Me.hoverLine.Size = New System.Drawing.Size(3, 43)
        Me.hoverLine.TabIndex = 11
        Me.hoverLine.TabStop = False
        '
        'btnProfileIcon
        '
        Me.btnProfileIcon.Controls.Add(Me.iconProfile)
        Me.btnProfileIcon.Controls.Add(Me.txtProfileIcon)
        Me.btnProfileIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfileIcon.Location = New System.Drawing.Point(0, 382)
        Me.btnProfileIcon.Name = "btnProfileIcon"
        Me.btnProfileIcon.Size = New System.Drawing.Size(231, 43)
        Me.btnProfileIcon.TabIndex = 10
        '
        'iconProfile
        '
        Me.iconProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconProfile.Image = Global.projectManagementSystem.My.Resources.Resources.settings_module_icon
        Me.iconProfile.Location = New System.Drawing.Point(24, 7)
        Me.iconProfile.Name = "iconProfile"
        Me.iconProfile.Size = New System.Drawing.Size(29, 28)
        Me.iconProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconProfile.TabIndex = 5
        Me.iconProfile.TabStop = False
        '
        'txtProfileIcon
        '
        Me.txtProfileIcon.AutoSize = True
        Me.txtProfileIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtProfileIcon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileIcon.ForeColor = System.Drawing.Color.White
        Me.txtProfileIcon.Location = New System.Drawing.Point(65, 13)
        Me.txtProfileIcon.Name = "txtProfileIcon"
        Me.txtProfileIcon.Size = New System.Drawing.Size(59, 15)
        Me.txtProfileIcon.TabIndex = 5
        Me.txtProfileIcon.Text = "My Profile"
        '
        'btnReportsIcon
        '
        Me.btnReportsIcon.Controls.Add(Me.iconReports)
        Me.btnReportsIcon.Controls.Add(Me.txtReportsIcon)
        Me.btnReportsIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportsIcon.Location = New System.Drawing.Point(0, 342)
        Me.btnReportsIcon.Name = "btnReportsIcon"
        Me.btnReportsIcon.Size = New System.Drawing.Size(231, 43)
        Me.btnReportsIcon.TabIndex = 10
        '
        'iconReports
        '
        Me.iconReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconReports.Image = Global.projectManagementSystem.My.Resources.Resources.reports_module_icon
        Me.iconReports.Location = New System.Drawing.Point(24, 7)
        Me.iconReports.Name = "iconReports"
        Me.iconReports.Size = New System.Drawing.Size(29, 28)
        Me.iconReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconReports.TabIndex = 5
        Me.iconReports.TabStop = False
        '
        'txtReportsIcon
        '
        Me.txtReportsIcon.AutoSize = True
        Me.txtReportsIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtReportsIcon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportsIcon.ForeColor = System.Drawing.Color.White
        Me.txtReportsIcon.Location = New System.Drawing.Point(65, 13)
        Me.txtReportsIcon.Name = "txtReportsIcon"
        Me.txtReportsIcon.Size = New System.Drawing.Size(51, 15)
        Me.txtReportsIcon.TabIndex = 5
        Me.txtReportsIcon.Text = "Reports"
        '
        'btnIconProgress
        '
        Me.btnIconProgress.Controls.Add(Me.iconProgress)
        Me.btnIconProgress.Controls.Add(Me.txtProgressIcon)
        Me.btnIconProgress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconProgress.Location = New System.Drawing.Point(0, 298)
        Me.btnIconProgress.Name = "btnIconProgress"
        Me.btnIconProgress.Size = New System.Drawing.Size(231, 43)
        Me.btnIconProgress.TabIndex = 9
        '
        'iconProgress
        '
        Me.iconProgress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconProgress.Image = Global.projectManagementSystem.My.Resources.Resources.progress_module_icon
        Me.iconProgress.Location = New System.Drawing.Point(24, 7)
        Me.iconProgress.Name = "iconProgress"
        Me.iconProgress.Size = New System.Drawing.Size(29, 28)
        Me.iconProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconProgress.TabIndex = 5
        Me.iconProgress.TabStop = False
        '
        'txtProgressIcon
        '
        Me.txtProgressIcon.AutoSize = True
        Me.txtProgressIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtProgressIcon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgressIcon.ForeColor = System.Drawing.Color.White
        Me.txtProgressIcon.Location = New System.Drawing.Point(65, 13)
        Me.txtProgressIcon.Name = "txtProgressIcon"
        Me.txtProgressIcon.Size = New System.Drawing.Size(58, 15)
        Me.txtProgressIcon.TabIndex = 5
        Me.txtProgressIcon.Text = "Progress"
        '
        'btnIconWork
        '
        Me.btnIconWork.Controls.Add(Me.iconWork)
        Me.btnIconWork.Controls.Add(Me.txtWorkIcon)
        Me.btnIconWork.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIconWork.Location = New System.Drawing.Point(0, 255)
        Me.btnIconWork.Name = "btnIconWork"
        Me.btnIconWork.Size = New System.Drawing.Size(231, 43)
        Me.btnIconWork.TabIndex = 8
        '
        'iconWork
        '
        Me.iconWork.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconWork.Image = Global.projectManagementSystem.My.Resources.Resources.plan_module_icon
        Me.iconWork.Location = New System.Drawing.Point(24, 7)
        Me.iconWork.Name = "iconWork"
        Me.iconWork.Size = New System.Drawing.Size(29, 28)
        Me.iconWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconWork.TabIndex = 5
        Me.iconWork.TabStop = False
        '
        'txtWorkIcon
        '
        Me.txtWorkIcon.AutoSize = True
        Me.txtWorkIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtWorkIcon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkIcon.ForeColor = System.Drawing.Color.White
        Me.txtWorkIcon.Location = New System.Drawing.Point(65, 13)
        Me.txtWorkIcon.Name = "txtWorkIcon"
        Me.txtWorkIcon.Size = New System.Drawing.Size(100, 15)
        Me.txtWorkIcon.TabIndex = 5
        Me.txtWorkIcon.Text = "Work Breakdown"
        '
        'btnTaskModule
        '
        Me.btnTaskModule.Controls.Add(Me.iconTask)
        Me.btnTaskModule.Controls.Add(Me.txtTaskICon)
        Me.btnTaskModule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTaskModule.Location = New System.Drawing.Point(0, 211)
        Me.btnTaskModule.Name = "btnTaskModule"
        Me.btnTaskModule.Size = New System.Drawing.Size(231, 43)
        Me.btnTaskModule.TabIndex = 7
        '
        'iconTask
        '
        Me.iconTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconTask.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_note_19_icon_64
        Me.iconTask.Location = New System.Drawing.Point(24, 7)
        Me.iconTask.Name = "iconTask"
        Me.iconTask.Size = New System.Drawing.Size(29, 28)
        Me.iconTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconTask.TabIndex = 5
        Me.iconTask.TabStop = False
        '
        'txtTaskICon
        '
        Me.txtTaskICon.AutoSize = True
        Me.txtTaskICon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTaskICon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskICon.ForeColor = System.Drawing.Color.White
        Me.txtTaskICon.Location = New System.Drawing.Point(65, 13)
        Me.txtTaskICon.Name = "txtTaskICon"
        Me.txtTaskICon.Size = New System.Drawing.Size(108, 15)
        Me.txtTaskICon.TabIndex = 5
        Me.txtTaskICon.Text = "Task Management"
        '
        'btnTeamModule
        '
        Me.btnTeamModule.Controls.Add(Me.iconTeam)
        Me.btnTeamModule.Controls.Add(Me.txtTeamIcon)
        Me.btnTeamModule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeamModule.Location = New System.Drawing.Point(0, 170)
        Me.btnTeamModule.Name = "btnTeamModule"
        Me.btnTeamModule.Size = New System.Drawing.Size(231, 43)
        Me.btnTeamModule.TabIndex = 6
        '
        'iconTeam
        '
        Me.iconTeam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconTeam.Image = Global.projectManagementSystem.My.Resources.Resources.team_module_icon
        Me.iconTeam.Location = New System.Drawing.Point(24, 7)
        Me.iconTeam.Name = "iconTeam"
        Me.iconTeam.Size = New System.Drawing.Size(29, 28)
        Me.iconTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconTeam.TabIndex = 5
        Me.iconTeam.TabStop = False
        '
        'txtTeamIcon
        '
        Me.txtTeamIcon.AutoSize = True
        Me.txtTeamIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtTeamIcon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamIcon.ForeColor = System.Drawing.Color.White
        Me.txtTeamIcon.Location = New System.Drawing.Point(65, 13)
        Me.txtTeamIcon.Name = "txtTeamIcon"
        Me.txtTeamIcon.Size = New System.Drawing.Size(38, 15)
        Me.txtTeamIcon.TabIndex = 5
        Me.txtTeamIcon.Text = "Team"
        '
        'btnProjectModule
        '
        Me.btnProjectModule.Controls.Add(Me.iconProject)
        Me.btnProjectModule.Controls.Add(Me.txtProjectIcon)
        Me.btnProjectModule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProjectModule.Location = New System.Drawing.Point(0, 128)
        Me.btnProjectModule.Name = "btnProjectModule"
        Me.btnProjectModule.Size = New System.Drawing.Size(231, 43)
        Me.btnProjectModule.TabIndex = 4
        '
        'iconProject
        '
        Me.iconProject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconProject.Image = Global.projectManagementSystem.My.Resources.Resources.project_module_icon
        Me.iconProject.Location = New System.Drawing.Point(24, 7)
        Me.iconProject.Name = "iconProject"
        Me.iconProject.Size = New System.Drawing.Size(29, 28)
        Me.iconProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconProject.TabIndex = 5
        Me.iconProject.TabStop = False
        '
        'txtProjectIcon
        '
        Me.txtProjectIcon.AutoSize = True
        Me.txtProjectIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtProjectIcon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectIcon.ForeColor = System.Drawing.Color.White
        Me.txtProjectIcon.Location = New System.Drawing.Point(65, 13)
        Me.txtProjectIcon.Name = "txtProjectIcon"
        Me.txtProjectIcon.Size = New System.Drawing.Size(45, 15)
        Me.txtProjectIcon.TabIndex = 5
        Me.txtProjectIcon.Text = "Project"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Junior Developer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.projectManagementSystem.My.Resources.Resources._77_pp_w980_h653_
        Me.PictureBox1.Location = New System.Drawing.Point(89, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.Location = New System.Drawing.Point(12, 81)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(203, 44)
        Me.lbl_username.TabIndex = 1
        Me.lbl_username.Text = "Aldrin Barrera Lim "
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox3.Image = Global.projectManagementSystem.My.Resources.Resources.title1
        Me.PictureBox3.Location = New System.Drawing.Point(50, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(423, 57)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.txtTime)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(231, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 82)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(25, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(828, 1)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'txtTime
        '
        Me.txtTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTime.Location = New System.Drawing.Point(692, 29)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(180, 13)
        Me.txtTime.TabIndex = 19
        Me.txtTime.Text = "10:30:26 PM"
        Me.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDate
        '
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDate.Location = New System.Drawing.Point(692, 16)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(180, 13)
        Me.txtDate.TabIndex = 18
        Me.txtDate.Text = "Sunday, July 26, 2015"
        Me.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1108, 661)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1128, 703)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Management System"
        Me.Panel1.ResumeLayout(False)
        CType(Me.hoverLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnProfileIcon.ResumeLayout(False)
        Me.btnProfileIcon.PerformLayout()
        CType(Me.iconProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnReportsIcon.ResumeLayout(False)
        Me.btnReportsIcon.PerformLayout()
        CType(Me.iconReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnIconProgress.ResumeLayout(False)
        Me.btnIconProgress.PerformLayout()
        CType(Me.iconProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnIconWork.ResumeLayout(False)
        Me.btnIconWork.PerformLayout()
        CType(Me.iconWork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnTaskModule.ResumeLayout(False)
        Me.btnTaskModule.PerformLayout()
        CType(Me.iconTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnTeamModule.ResumeLayout(False)
        Me.btnTeamModule.PerformLayout()
        CType(Me.iconTeam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnProjectModule.ResumeLayout(False)
        Me.btnProjectModule.PerformLayout()
        CType(Me.iconProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProjectModule As System.Windows.Forms.Panel
    Friend WithEvents txtProjectIcon As System.Windows.Forms.Label
    Friend WithEvents iconProject As System.Windows.Forms.PictureBox
    Friend WithEvents btnTeamModule As System.Windows.Forms.Panel
    Friend WithEvents iconTeam As System.Windows.Forms.PictureBox
    Friend WithEvents txtTeamIcon As System.Windows.Forms.Label
    Friend WithEvents btnTaskModule As System.Windows.Forms.Panel
    Friend WithEvents iconTask As System.Windows.Forms.PictureBox
    Friend WithEvents txtTaskICon As System.Windows.Forms.Label
    Friend WithEvents btnIconWork As System.Windows.Forms.Panel
    Friend WithEvents iconWork As System.Windows.Forms.PictureBox
    Friend WithEvents txtWorkIcon As System.Windows.Forms.Label
    Friend WithEvents btnIconProgress As System.Windows.Forms.Panel
    Friend WithEvents iconProgress As System.Windows.Forms.PictureBox
    Friend WithEvents txtProgressIcon As System.Windows.Forms.Label
    Friend WithEvents btnReportsIcon As System.Windows.Forms.Panel
    Friend WithEvents iconReports As System.Windows.Forms.PictureBox
    Friend WithEvents txtReportsIcon As System.Windows.Forms.Label
    Friend WithEvents btnProfileIcon As System.Windows.Forms.Panel
    Friend WithEvents iconProfile As System.Windows.Forms.PictureBox
    Friend WithEvents txtProfileIcon As System.Windows.Forms.Label
    Friend WithEvents hoverLine As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
