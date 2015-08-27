Imports System.Text.RegularExpressions
Public Class EditUserNameDialog
    Private selectedID

    Private Sub EditUserNameDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Public Sub init()
        selectedID = UserDetail.getUserID
        Dim uModel As New UserModel
        Dim result = uModel.getUserBySelectedID(selectedID).Rows(0)
        txtFirstName.Text = result.Item(1).ToString
        txtMiddleName.Text = result.Item(2).ToString
        txtLastName.Text = result.Item(3).ToString
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim uModel As New UserModel
        Dim reg As New Regex("^[0-9_\~\`\!\@\#\$\%\^\&\*\(\)\-\+\=\|\]\[\{\}\:\;\'\,\.\<\>\?\/]")
        Dim prompt = MessageBox.Show("Edit Name?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If prompt = Windows.Forms.DialogResult.Yes Then
            If (reg.IsMatch(txtFirstName.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf (reg.IsMatch(txtMiddleName.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf (reg.IsMatch(txtLastName.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                uModel.updateUserName(selectedID, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text)
                MessageBox.Show("Name edited successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UserDetail.init()
                UserView.init()
                Me.Close()
            End If
        End If
    End Sub
End Class