Public Class UserDetail
    Private selectedID
  
    Private Sub UserDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Public Sub init()
        selectedID = UserView.getUserID
        Dim uModel As New UserModel
        Dim result = uModel.getUserByID(selectedID).Rows(0)
        pboxUserImage.ImageLocation = "http://localhost/pms_images/" & result.Item(3).ToString
        txtUserName.Text = result.Item(1).ToString
        If uModel.getUserProjectAndTaskByUserID(selectedID).Rows.Count > 0 Then
            txtProject.Text = uModel.getUserProjectAndTaskByUserID(selectedID).Rows(0).Item(0).ToString
            txtTask.Text = uModel.getUserProjectAndTaskByUserID(selectedID).Rows(0).Item(1).ToString
        Else
            txtProject.Text = " (No Project Related) "
            txtTask.Text = " (No Task Assigned) "
        End If

        If String.IsNullOrEmpty(result.Item(2).ToString) = False Then

            txtUserPosition.Text = result.Item(2).ToString
        Else

            txtUserPosition.Text = "No Position"
        End If
    End Sub

    Private Sub btnEditPic_Click(sender As Object, e As EventArgs) Handles btnEditPic.Click
        dialogProfilePicture.ShowDialog()
    End Sub
End Class