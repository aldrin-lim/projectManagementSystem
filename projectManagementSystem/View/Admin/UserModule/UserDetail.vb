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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim uModel = New UserModel
        Dim result = MessageBox.Show("Are you sure you want to remove this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            If uModel.deleteProject(selectedID) Then

                Dim uBox As New UserBox(UserView.panelBox)
                uBox.clearAllBox()
                uBox.createList(uModel.getAllUser)
                UserView.attachHandlers()
                Me.Hide()
            Else
                MessageBox.Show("Somethin went wrong. Try Again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

        End If
    End Sub
End Class