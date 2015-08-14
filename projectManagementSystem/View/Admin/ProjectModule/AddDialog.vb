Imports System.Text.RegularExpressions

Public Class AddDialog

    Private Sub AddDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Public Sub init()
        Dim uModel = New UserModel
        Dim result = uModel.getAllAvailableUser
        For i = 0 To result.Rows.Count - 1
            lvAvailablePeople.Items.Add(result.Rows(i).Item(1))
        Next
    End Sub

    Private Sub btnCreateProject_Click(sender As Object, e As EventArgs) Handles btnCreateProject.Click
        Dim pbox As New ProjectBox(ProjectView.panelBox)
        Dim pModel As New ProjectModel
        Dim reg As New Regex("^[0-9]")
        'Dim startDate As DateTime = DateTime.Parse(dateStart.Text)
        'Dim endDate As DateTime = DateTime.Parse(dateEnd.Text)
        Dim startDate As Date = dateStart.Value
        Dim endDate As Date = dateEnd.Value
        If startDate > endDate Then
            MessageBox.Show("Duration date must not overlap", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If (reg.IsMatch(txtProjectName.Text)) Then
            MessageBox.Show("Not a valid text", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        

        Dim result = MessageBox.Show("""" & txtProjectName.Text & """ will be added as a new a project" & vbCrLf &
                                     "Are you sure you want to do this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)



        If result = Windows.Forms.DialogResult.Yes Then
            If pModel.createProject(txtProjectName.Text, txtProjectDesc.Text, dateStart.Value, dateEnd.Value) Then
                MessageBox.Show("Successfully Created Project")
                pbox.clearAllBox()
                pbox.createList(pModel.getAllProject)
                ProjectView.attachHandlers()
                Me.Hide()
            Else
                MessageBox.Show("Something went wrong. Please Try Again", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim selectedIndex = lvAvailablePeople.SelectedIndices(0)
        Dim selectedValue = lvAvailablePeople.Items(selectedIndex).SubItems(0).Text

        lvSelectedPeople.Items.Add(selectedValue)
        lvAvailablePeople.Items.RemoveAt(selectedIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedIndex = lvSelectedPeople.SelectedIndices(0)
        Dim selectedValue = lvSelectedPeople.Items(selectedIndex).SubItems(0).Text

        lvAvailablePeople.Items.Add(selectedValue)
        lvSelectedPeople.Items.RemoveAt(selectedIndex)
    End Sub
End Class