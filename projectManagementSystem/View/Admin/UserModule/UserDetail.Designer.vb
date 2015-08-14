<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetail
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
        Me.pboxUserImage = New System.Windows.Forms.PictureBox()
        Me.txtUserPosition = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.Label()
        Me.btnEditUserPosition = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEditPic = New System.Windows.Forms.PictureBox()
        Me.dialogProfilePicture = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProject = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.pboxUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditUserPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pboxUserImage
        '
        Me.pboxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboxUserImage.Image = Global.projectManagementSystem.My.Resources.Resources._77_pp_w980_h653_
        Me.pboxUserImage.Location = New System.Drawing.Point(12, 12)
        Me.pboxUserImage.Name = "pboxUserImage"
        Me.pboxUserImage.Size = New System.Drawing.Size(185, 185)
        Me.pboxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxUserImage.TabIndex = 0
        Me.pboxUserImage.TabStop = False
        '
        'txtUserPosition
        '
        Me.txtUserPosition.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtUserPosition.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtUserPosition.Location = New System.Drawing.Point(206, 113)
        Me.txtUserPosition.Name = "txtUserPosition"
        Me.txtUserPosition.Size = New System.Drawing.Size(255, 18)
        Me.txtUserPosition.TabIndex = 17
        Me.txtUserPosition.Text = "Junior Web Developer"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtUserName.Location = New System.Drawing.Point(200, 12)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(404, 75)
        Me.txtUserName.TabIndex = 18
        Me.txtUserName.Text = "Jeru Pajulas"
        Me.txtUserName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnEditUserPosition
        '
        Me.btnEditUserPosition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditUserPosition.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_edit_7_icon_24
        Me.btnEditUserPosition.Location = New System.Drawing.Point(467, 110)
        Me.btnEditUserPosition.Name = "btnEditUserPosition"
        Me.btnEditUserPosition.Size = New System.Drawing.Size(18, 18)
        Me.btnEditUserPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditUserPosition.TabIndex = 31
        Me.btnEditUserPosition.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnEditUserPosition, "Edit Position")
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(491, 111)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 16)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Remove This User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(207, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 1)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnEditPic
        '
        Me.btnEditPic.BackColor = System.Drawing.Color.Transparent
        Me.btnEditPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditPic.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_edit_7_icon_24
        Me.btnEditPic.Location = New System.Drawing.Point(178, 178)
        Me.btnEditPic.Name = "btnEditPic"
        Me.btnEditPic.Size = New System.Drawing.Size(18, 18)
        Me.btnEditPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditPic.TabIndex = 32
        Me.btnEditPic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnEditPic, "Change Picture")
        '
        'dialogProfilePicture
        '
        Me.dialogProfilePicture.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(204, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "On Going Project:"
        '
        'txtProject
        '
        Me.txtProject.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtProject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtProject.Location = New System.Drawing.Point(315, 141)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(289, 32)
        Me.txtProject.TabIndex = 34
        Me.txtProject.Text = "Android Games Online"
        '
        'txtTask
        '
        Me.txtTask.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtTask.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtTask.Location = New System.Drawing.Point(314, 178)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(290, 32)
        Me.txtTask.TabIndex = 36
        Me.txtTask.Text = "Creation of UI on Android Games Online"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(204, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Current Task:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(207, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(397, 1)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.ReshowDelay = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_edit_7_icon_24
        Me.PictureBox3.Location = New System.Drawing.Point(586, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 38
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Edit Name")
        '
        'UserDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(613, 218)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditPic)
        Me.Controls.Add(Me.btnEditUserPosition)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtUserPosition)
        Me.Controls.Add(Me.pboxUserImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UserDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.pboxUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditUserPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxUserImage As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserPosition As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.Label
    Friend WithEvents btnEditUserPosition As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelete As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditPic As System.Windows.Forms.PictureBox
    Friend WithEvents dialogProfilePicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProject As System.Windows.Forms.Label
    Friend WithEvents txtTask As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
