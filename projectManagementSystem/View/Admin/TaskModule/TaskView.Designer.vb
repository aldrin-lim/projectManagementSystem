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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.iconCreateUser = New System.Windows.Forms.PictureBox()
        Me.btnAddTask = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconCreateUser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelBox.Location = New System.Drawing.Point(169, 140)
        Me.panelBox.Name = "panelBox"
        Me.panelBox.Size = New System.Drawing.Size(668, 497)
        Me.panelBox.TabIndex = 5
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
        'iconCreateUser
        '
        Me.iconCreateUser.BackColor = System.Drawing.Color.Transparent
        Me.iconCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconCreateUser.Image = Global.projectManagementSystem.My.Resources.Resources.add_task
        Me.iconCreateUser.Location = New System.Drawing.Point(29, 140)
        Me.iconCreateUser.Name = "iconCreateUser"
        Me.iconCreateUser.Size = New System.Drawing.Size(90, 90)
        Me.iconCreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconCreateUser.TabIndex = 25
        Me.iconCreateUser.TabStop = False
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
        'TaskView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 657)
        Me.Controls.Add(Me.iconCreateUser)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.panelBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddTask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TaskView"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Text = "TaskView"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconCreateUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelBox As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents iconCreateUser As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddTask As System.Windows.Forms.Label
End Class
