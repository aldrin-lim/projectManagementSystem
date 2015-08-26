Imports MySql.Data.MySqlClient
Public Class TaskView
    '--------------VARIABLES & INITIALIZATION-----------------
    Public selectedID
    'Private createProjectThumbnailCount = 0
    Private ctr
    'Public Delegate Sub MyDelegate(sender As System.Object, e As System.EventArgs)
    Private Sub Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        'Dim groupBox As New GroupBox
        'panelBox.Controls.Add(groupBox)
        'groupBox.Font = New Font("Arial", 14.25, FontStyle.Bold)
        'groupBox.ForeColor = Color.FromArgb(120, 120, 120)
        'groupBox.Size = New Point(653, 258)
        'groupBox.Location = New Point(3, 267)
        'groupBox.Text = "Some Nigga shit"
        'groupBox.BackColor = Color.Transparent
    End Sub
    Public Sub init()
        'timeDisplay.Start()
        'Dim dt As Date = Date.Today

        Dim tbox As New TaskBox(panelBox)
        Dim task As New TaskModel
        tbox.clear()
        tbox.createGroupBoxList(task.getAllMilestone)
        'tbox.createList(task.getAllTaskAndMileStone())
        attachHandlers()
    End Sub

    Public Sub setTaskID(ByVal id)
        selectedID = id
    End Sub

    Public Function getTaskID()
        Return selectedID
    End Function
    Public Sub taskBoxClick(ByVal id)
        setTaskID(id)
        TaskDetails.ShowDialog()
    End Sub
    Public Sub attachHandlers()
        For Each ctrl As Control In panelBox.Controls
            

            If TypeOf ctrl Is GroupBox Then

                For Each ctrlChild As Control In ctrl.Controls
                    If TypeOf ctrlChild Is System.Windows.Forms.Panel Then
                        Dim taskID

                        For Each panelCtrl As Control In ctrlChild.Controls
                            If panelCtrl.Tag = "id" Then
                                taskID = panelCtrl.Text

                            End If
                        Next

                        AddHandler ctrlChild.Click, Sub(sender, e) taskBoxClick(taskID)
                        For Each panelCtrl As Control In ctrlChild.Controls
                            AddHandler panelCtrl.Click, Sub(sender, e) taskBoxClick(taskID)
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub iconCreateUser_Click(sender As Object, e As EventArgs) Handles iconCreateUser.Click, btnAddTask.Click
        Dim atd = New AddTaskDialog
        atd.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblCreateMilestone.Click, pboxCreateMilestone.Click
        Dim admd = New AddMilestoneDialog
        admd.ShowDialog()
    End Sub

    
End Class