Public Class TaskDetails

    Private Sub TaskDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tModel = New TaskModel
        Dim data = tModel.getTaskAndMileStoneByID(TaskView.getTaskID).Rows(0)
        Dim mileStoneID = data.Item(1)
        txtMilestone.Text = data.Item(2)
        txtTask.Text = data.Item(3)
        txtHrs.Text = data.Item(5) & " Hr(s)"
        txtChrs.Text = data.Item(6) & " Hr(s)"
        Dim taskStart As Date = data.Item(7).ToString() 'taskStart.ToString("MMM dd, yyyy")
        Dim taskEnd As Date = data.Item(8).ToString()
        txtUser.Text = data.Item(9)
        txtDurationDate.Text = taskStart.ToString("MMM dd, yyyy") & " to " & taskEnd.ToString("MMM dd, yyyy")

    End Sub
End Class