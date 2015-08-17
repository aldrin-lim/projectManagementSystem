Imports System.Text.RegularExpressions

Public Class AddUser


    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim value = txtFirstName.Text
        Dim m As Match = Regex.Match(value, "[\']", RegexOptions.IgnoreCase)
        If m.Success Then
            MessageBox.Show("correct")
        End If
    End Sub
End Class