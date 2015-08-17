<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectView
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
        Me.btnAddProject = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timeDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.panelBox = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSortA = New System.Windows.Forms.PictureBox()
        Me.btnSortD = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.iconCreateProject = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btnSortA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSortD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconCreateProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddProject
        '
        Me.btnAddProject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProject.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddProject.Location = New System.Drawing.Point(11, 225)
        Me.btnAddProject.Name = "btnAddProject"
        Me.btnAddProject.Size = New System.Drawing.Size(131, 32)
        Me.btnAddProject.TabIndex = 0
        Me.btnAddProject.Text = "Create New Project"
        Me.btnAddProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(166, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "All Project"
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
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Location = New System.Drawing.Point(648, 96)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(179, 22)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TabStop = False
        Me.txtSearch.Text = "Search Project"
        '
        'btnSortA
        '
        Me.btnSortA.BackColor = System.Drawing.Color.Transparent
        Me.btnSortA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortA.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_sort_14_icon_48
        Me.btnSortA.Location = New System.Drawing.Point(587, 97)
        Me.btnSortA.Name = "btnSortA"
        Me.btnSortA.Size = New System.Drawing.Size(21, 21)
        Me.btnSortA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSortA.TabIndex = 7
        Me.btnSortA.TabStop = False
        '
        'btnSortD
        '
        Me.btnSortD.BackColor = System.Drawing.Color.Transparent
        Me.btnSortD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSortD.Image = Global.projectManagementSystem.My.Resources.Resources.iconmonstr_sort_16_icon_48
        Me.btnSortD.Location = New System.Drawing.Point(614, 97)
        Me.btnSortD.Name = "btnSortD"
        Me.btnSortD.Size = New System.Drawing.Size(21, 21)
        Me.btnSortD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSortD.TabIndex = 6
        Me.btnSortD.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox2.Location = New System.Drawing.Point(169, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(658, 1)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'iconCreateProject
        '
        Me.iconCreateProject.BackColor = System.Drawing.Color.Transparent
        Me.iconCreateProject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconCreateProject.Image = Global.projectManagementSystem.My.Resources.Resources.add_project
        Me.iconCreateProject.Location = New System.Drawing.Point(29, 140)
        Me.iconCreateProject.Name = "iconCreateProject"
        Me.iconCreateProject.Size = New System.Drawing.Size(90, 90)
        Me.iconCreateProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconCreateProject.TabIndex = 1
        Me.iconCreateProject.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(557, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Sort:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProjectView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 657)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSortA)
        Me.Controls.Add(Me.btnSortD)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.panelBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.iconCreateProject)
        Me.Controls.Add(Me.btnAddProject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProjectView"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Text = "Project"
        CType(Me.btnSortA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSortD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconCreateProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddProject As System.Windows.Forms.Label
    Friend WithEvents iconCreateProject As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents timeDisplay As System.Windows.Forms.Timer
    Friend WithEvents panelBox As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSortD As System.Windows.Forms.PictureBox
    Friend WithEvents btnSortA As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
