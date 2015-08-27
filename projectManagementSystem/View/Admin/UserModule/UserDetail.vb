Imports System.IO
Imports System.Text.RegularExpressions
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
    '--------------------- EDIT POSITION --------------------
    Private Sub btnEditUserPosition_Click(sender As Object, e As EventArgs) Handles btnEditUserPosition.Click
        Dim prompt = MessageBox.Show("Edit Position?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If prompt = Windows.Forms.DialogResult.Yes Then
            txtEditPosition.Text = txtUserPosition.Text
            txtEditPosition.Visible = True
            txtEditPosition.Focus()
            txtEditPosition.SelectAll()
            btnEditUserPosition.Visible = False
            txtUserPosition.Visible = False
            txtEditPosition.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub
    Private Sub txtEditPosition_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditPosition.KeyDown
        If e.KeyCode = 13 Then
            Dim uModel = New UserModel
            Dim reg As New Regex("^[0-9_\~\`\!\@\#\$\%\^\&\*\(\)\-\+\=\|\]\[\{\}\:\;\'\,\.\<\>\?\/]")
            If (reg.IsMatch(txtEditPosition.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If uModel.updateUserPosition(selectedID, txtEditPosition.Text) Then
                    txtUserPosition.Text = txtEditPosition.Text
                    txtEditPosition.Visible = False
                    txtUserPosition.Visible = True
                    btnEditUserPosition.Visible = True
                    UserView.init()
                Else
                    MessageBox.Show("Error")
                    txtEditPosition.Visible = False
                    btnEditUserPosition.Enabled = True
                    e.SuppressKeyPress = True
                End If
            End If
        End If
    End Sub
    '-------------------- EDIT PROFILE PIC ---------------------
    Private Sub dialogProfilePicture_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dialogProfilePicture.FileOk
        Dim uModel = New UserModel
        Dim sPath As String
        Dim fileSize As String
        Try
            sPath = dialogProfilePicture.FileName
            MsgBox(sPath)
            'sPath = StrReverse(sPath) 'reverse the string
            'sPath = Mid(sPath, InStr(sPath, "\"), Len(sPath)) 'extract from the first slash
            'sPath = StrReverse(sPath) 'reverse it again
            'MsgBox(sPath) 'voila u have the path now :)
            Dim destPath = "C:\xampp\htdocs\pms_images\"
            If (Not Directory.Exists(destPath)) Then
                Directory.CreateDirectory("C:\xampp\htdocs\pms_images\")
            Else
                Dim file = New FileInfo(sPath)
                fileSize = file.Length.ToString
                MsgBox(fileSize)
                file.CopyTo(Path.Combine(destPath, file.Name), True)
                'MsgBox(file.Name)
                'MsgBox("Successful")
                uModel.updateProfilePic(selectedID, file.Name)
                init()
                UserView.init()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function getUserID()
        Return selectedID
    End Function
End Class