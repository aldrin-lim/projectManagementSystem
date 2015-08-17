<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserView
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
        Me.timeDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.panelBox = New System.Windows.Forms.Panel()
        Me.iconCreateUser = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAddUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSortA = New System.Windows.Forms.PictureBox()
        Me.btnSortD = New System.Windows.Forms.PictureBox()
        CType(Me.iconCreateUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSortA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSortD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBox
        '
        Me.panelBox.AutoScroll = True
        Me.panelBox.Location = New System.Drawing.Point(169, 140)
        Me.panelBox.Name = "panelBox"
        Me.panelBox.Size = New System.Drawing.Size(668, 497)
        Me.panelBox.TabIndex = 23
        '
        'iconCreateUser
        '
        Me.iconCreateUser.BackColor = System.Drawing.Color.Transparent
        Me.iconCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconCreateUser.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_user_11_icon_128
        Me.iconCreateUser.Location = New System.Drawing.Point(29, 140)
        Me.iconCreateUser.Name = "iconCreateUser"
        Me.iconCreateUser.Size = New System.Drawing.Size(90, 90)
        Me.iconCreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconCreateUser.TabIndex = 24
        Me.iconCreateUser.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Location = New System.Drawing.Point(648, 96)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(179, 22)
        Me.txtSearch.TabIndex = 20
        Me.txtSearch.TabStop = False
        Me.txtSearch.Text = "Search User"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox2.Location = New System.Drawing.Point(169, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(658, 1)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'btnAddUser
        '
        Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUser.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddUser.Location = New System.Drawing.Point(12, 224)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(131, 32)
        Me.btnAddUser.TabIndex = 25
        Me.btnAddUser.Text = "Create New User"
        Me.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(166, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "All User"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(561, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 14)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Sort:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSortA
        '
        Me.btnSortA.BackColor = System.Drawing.Color.Transparent
        Me.btnSortA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortA.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_sort_14_icon_48
        Me.btnSortA.Location = New System.Drawing.Point(591, 96)
        Me.btnSortA.Name = "btnSortA"
        Me.btnSortA.Size = New System.Drawing.Size(21, 21)
        Me.btnSortA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSortA.TabIndex = 27
        Me.btnSortA.TabStop = False
        '
        'btnSortD
        '
        Me.btnSortD.BackColor = System.Drawing.Color.Transparent
        Me.btnSortD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortD.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_sort_16_icon_48
        Me.btnSortD.Location = New System.Drawing.Point(618, 96)
        Me.btnSortD.Name = "btnSortD"
        Me.btnSortD.Size = New System.Drawing.Size(21, 21)
        Me.btnSortD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSortD.TabIndex = 26
        Me.btnSortD.TabStop = False
        '
        'UserView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 657)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSortA)
        Me.Controls.Add(Me.btnSortD)
        Me.Controls.Add(Me.panelBox)
        Me.Controls.Add(Me.iconCreateUser)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserView"
        Me.Text = "User"
        CType(Me.iconCreateUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSortA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSortD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timeDisplay As System.Windows.Forms.Timer
    Friend WithEvents panelBox As System.Windows.Forms.Panel
    Friend WithEvents iconCreateUser As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddUser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSortA As System.Windows.Forms.PictureBox
    Friend WithEvents btnSortD As System.Windows.Forms.PictureBox
End Class
