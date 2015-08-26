Public Class AddMilestoneDialog
    Private selectedProject
    Private selectedMilestone
    Private additionalHours

    Private Sub AddMilestoneDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Public Sub init()


        Dim pModel = New ProjectModel
        Dim allProjects = pModel.getAllProject.Rows
        Dim tModel = New TaskModel
        Dim allMilestone = tModel.getAllMilestone.Rows
        Dim allTaskWOmilestone = tModel.getAllTaskWithoutMilestone.Rows
        For Each item As DataRow In allProjects
            cbxProject.Items.Add(item.Item(1))
        Next

        For Each item As DataRow In allMilestone
            cboxDependency.Items.Add(item.Item(1))
        Next

        For Each item As DataRow In allTaskWOmilestone
            lbxTaskList.Items.Add(item.Item(3))
        Next

        cboxDependency.SelectedIndex = 0
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If cbxProject.SelectedIndex < 0 Then
            MessageBox.Show("Milestone must be assiociated to a project", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Dim hours = Convert.ToInt16(txtHours.Text)
        If String.IsNullOrEmpty(txtHours.Text) = True Then
            MessageBox.Show("Invalid Hour. Try Again", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Convert.ToInt16(txtHours.Text) <= 0 Then
            MessageBox.Show("Invalid Hour. Try Again", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim totalHours = CInt(txtHours.Text) + additionalHours
        Dim name = txtName.Text
        Dim startD = dateStart.Value.Date.ToString("yyyy-MM-dd")
        Dim endD = dateEnd.Value.Date.ToString("yyyy-MM-dd")
        Dim array = New ArrayList
        Dim tModel = New TaskModel
        If tModel.createMilestone(txtName.Text, selectedProject, startD, endD, totalHours, selectedMilestone) Then

            If lbxTaskList.SelectedItems.Count > 0 Then
                For Each item In lbxTaskList.SelectedItems
                    array.Add(tModel.getTaskIDbyName(item.ToString).Rows(0).Item(0))
                Next
                tModel.assignTaskToMilestone(tModel.getLastInsertedMilestone.Rows(0).Item(0), array)
                Dim tbox = New TaskBox(TaskView.panelBox)
                tbox.clear()
                TaskView.init()
                MessageBox.Show("Milestone Created")
                Me.Close()
            Else
               

            End If
        Else

        End If

        




    End Sub

    Private Sub cbxProject_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxProject.SelectedIndexChanged
        Dim pModel = New ProjectModel
        selectedProject = pModel.getProjectByName(cbxProject.Text).Rows(0).Item(0)

    End Sub

    Private Sub cboxDependency_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboxDependency.SelectedIndexChanged
        If cboxDependency.SelectedIndex = 0 Then
            selectedMilestone = 0
        End If
        
        Dim tModel = New TaskModel
        selectedMilestone = tModel.getMilestoneByName(cboxDependency.Text).Rows(0).Item(0)
        additionalHours = tModel.getMilestoneByName(cboxDependency.Text).Rows(0).Item(1)

    End Sub
End Class