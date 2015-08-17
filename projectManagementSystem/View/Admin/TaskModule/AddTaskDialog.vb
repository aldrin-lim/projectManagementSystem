Imports System.Text.RegularExpressions
Public Class AddTaskDialog

    Private Sub btnCreateTask_Click(sender As Object, e As EventArgs) Handles btnCreateTask.Click
        Dim tbox As New TaskBox(TaskView.panelBox)
        Dim tModel As New TaskModel
        Dim reg As New Regex("^[0-9]")
        If reg.IsMatch(txtTaskName.Text) Then
            MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim result = MessageBox.Show("""" & txtTaskName.Text & """ will be added as a new a task" & vbCrLf &
                                     "Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then
            If tModel.createTask(txtTaskName.Text, txtTextDesc.Text, txtTaskDuration.Text) Then
                MessageBox.Show("Successfully Created Task")
                tbox.clear()
                tbox.createList(tModel.getAllTask)
                ProjectView.attachHandlers()
                Me.Hide()
            Else
                MessageBox.Show("Something went wrong. Please Try Again", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

        End If
    End Sub
End Class