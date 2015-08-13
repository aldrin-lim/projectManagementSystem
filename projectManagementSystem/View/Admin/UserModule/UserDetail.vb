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