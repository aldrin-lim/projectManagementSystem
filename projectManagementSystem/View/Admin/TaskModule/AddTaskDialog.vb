Public Class AddTaskDialog
    Dim allProjectArray = New ArrayList
    Dim allUserArray = New ArrayList
    Dim allMilestoneArray = New ArrayList
    Dim allTaskArray = New ArrayList

    Private Sub AddTaskDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Public Sub init()
        Dim tModel = New TaskModel
        Dim pModel = New ProjectModel
        Dim uModel = New UserModel
        Dim allProject = pModel.getAllProject.Rows

        Dim allUser = uModel.getAllAvailableUser.Rows

        Dim allMilestone = tModel.getAllMilestone.Rows

        Dim allTask = tModel.getAllTask.Rows


        For Each items As DataRow In allProject
            cbxProject.Items.Add(items.Item(1))
            allProjectArray.Add(items.Item(0))
        Next

        For Each items As DataRow In allUser
            cbxAssigned.Items.Add(items.Item(1))
            allUserArray.Add(items.Item(0))
        Next

        For Each items As DataRow In allMilestone
            cbxMilestone.Items.Add(items.Item(1))
            allMilestoneArray.Add(items.Item(0))
        Next


        For Each items As DataRow In allTask
            cbxDependency.Items.Add(items.Item(1))
            allTaskArray.Add(items.Item(0))
        Next


    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If String.IsNullOrEmpty(txtTaskName.Text) Or String.IsNullOrEmpty(txtProjectDescription.Text) Or String.IsNullOrEmpty(txtTaskDuration.Text) Or dateStart.Value >= dateEnd.Value Or Not IsNumeric(txtTaskDuration.Text) Then
            MessageBox.Show("Invalid input(s)", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim tModel = New TaskModel
        Dim tbox = New TaskBox(TaskView.panelBox)
        Dim taskName = txtTaskName.Text
        Dim startDate = dateStart.Value.ToString("yyyy-MM-dd")
        Dim endDate = dateEnd.Value.ToString("yyyy-MM-dd")
        Dim taskDescription = txtProjectDescription.Text
        Dim hours = CInt(txtTaskDuration.Text)
        Dim test = 1
        
        If tModel.createTask(taskName, taskDescription, startDate, endDate, hours) Then
            Try
                Dim project = allProjectArray(cbxProject.SelectedIndex)
                If Not tModel.createLinkBetweenTaskAndPorject(tModel.getLastInsertedTask.Rows(0).Item(0), project) Then
                    MessageBox.Show("Something went wrong. Try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
            Try
                Dim milestone = allMilestoneArray(cbxMilestone.SelectedIndex)
                If Not tModel.createLinkBetweenTaskAndMilestone(tModel.getLastInsertedTask.Rows(0).Item(0), milestone) Then
                    MessageBox.Show("Something went wrong. Try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
            Try
                Dim user = allUserArray(cbxAssigned.SelectedIndex)
                If Not tModel.createLinkBetweenTaskAndUser(tModel.getLastInsertedTask.Rows(0).Item(0), user) Then
                    MessageBox.Show("Something went wrong. Try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
            MessageBox.Show("Task Created")
            tbox.clear()
            TaskView.init()
            Me.Close()
        Else
            MessageBox.Show("Something went wrong. Try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        

       
        


        'Dim project = allProjectArray(cbxProject.SelectedIndex)
        'Dim assigned = allUserArray(cbxAssigned.SelectedIndex)
        'Dim milestone = allMilestoneArray(cbxMilestone.SelectedIndex)
        'Dim dependency = allTaskArray(cbxDependency.SelectedIndex)

    End Sub

    Private Sub cbxDependency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDependency.SelectedIndexChanged
        Dim tModel = New TaskModel
        Dim taskID = allTaskArray(cbxDependency.SelectedIndex)
        txtAdditional.Text = "+ " & tModel.getTaskAndMileStoneByID(taskID).Rows(0).Item(5) & " Hours"
    End Sub
End Class