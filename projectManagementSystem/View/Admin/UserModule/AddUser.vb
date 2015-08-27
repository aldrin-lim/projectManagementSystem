Imports System.Text.RegularExpressions
Public Class AddUser
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        'Dim value = txtFirstName.Text
        'Dim m As Match = Regex.Match(value, "[\']", RegexOptions.IgnoreCase)
        'If m.Success Then
        '    MessageBox.Show("correct")
        'End If
        Dim ubox As New UserBox(UserView.panelBox)
        Dim uModel As New UserModel
        Try
            Dim reg As New Regex("^[0-9_\~\`\!\@\#\$\%\^\&\*\(\)\-\+\=\|\]\[\{\}\:\;\'\,\.\<\>\?\/]")
            If (reg.IsMatch(txtFirstName.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf (reg.IsMatch(txtMiddleName.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf (reg.IsMatch(txtLastName.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf (reg.IsMatch(txtPosition.Text)) Then
                MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim result = MessageBox.Show("""" & txtFirstName.Text & " " & txtMiddleName.Text & " " & txtLastName.Text & """ will be added as a new user" & vbCrLf &
                                         "Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If result = Windows.Forms.DialogResult.Yes Then
                If uModel.createUser(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtPosition.Text) Then
                    MessageBox.Show("Successfully Added New User", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ubox.clearAllBox()
                    ubox.createList(uModel.getAllUser)
                    UserView.attachHandlers()
                    Me.Hide()
                Else
                    MessageBox.Show("Something went wrong. Please Try Again", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class