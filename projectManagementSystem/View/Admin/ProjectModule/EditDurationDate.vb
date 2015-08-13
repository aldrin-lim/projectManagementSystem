Public Class EditDurationDate

    Private Sub EditDurationDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateStart.Value = detailsDialog.getStartDate
        dateEnd.Value = detailsDialog.getEndDate
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim startDate = dateStart.Value.ToString("yyyy-MM-dd")
        Dim endDate = dateEnd.Value.ToString("yyyy-MM-dd")
        Dim project As New ProjectModel
        If project.updateProjectDate(detailsDialog.getProjectID, startDate, endDate) Then
            detailsDialog.txtDurationDate.Text = dateStart.Value.ToString("MMM dd yyyy") & "  -  " & dateEnd.Value.ToString("MMM dd yyyy")
            ProjectView.init()
            Me.Close()
        Else
            MessageBox.Show("Something Wrong. Try Again")
        End If
    End Sub
End Class