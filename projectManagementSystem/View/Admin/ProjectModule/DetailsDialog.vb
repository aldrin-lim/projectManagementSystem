Public Class detailsDialog
    Private ProjectId
    Private Sub detailsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub init()
        Dim box = New TaskBox(Panel1)
        Dim uModel = New UserModel
        Dim pModel = New ProjectModel
        ProjectId = ProjectView.selectedID
        box.clear()
        box.createList(uModel.getUserByProjectID(ProjectId))
        txtProjectTitle.Text = pModel.getProjectByID(ProjectId).Rows(0).Item(1).ToString
        txtEditTitle.Text = pModel.getProjectByID(ProjectId).Rows(0).Item(1)
        If String.IsNullOrEmpty(pModel.getProjectByID(ProjectId).Rows(0).Item(2).ToString) Then
            txtProjectDesc.Text = " (No Description Available) "
        Else
            txtProjectDesc.Text = pModel.getProjectByID(ProjectId).Rows(0).Item(2).ToString
        End If
        '

        txtEditTitle.Visible = False

    End Sub
    
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
   
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedID = ProjectView.selectedID
        Dim pModel = New ProjectModel
        Dim result = MessageBox.Show("Are you sure you want to delete this project?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            If pModel.deleteProject(selectedID) Then
                MessageBox.Show("Successfully deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim pBox As New ProjectBox(ProjectView.panelBox)
                pBox.clearAllBox()
                pBox.createList(pModel.getAllProject)
                ProjectView.attachHandlers()
                Me.Hide()
            Else
                MessageBox.Show("Somethin went wrong. Try Again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

        End If
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        txtEditTitle.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub



    '----------------EDIT TITLE

    Private Sub btnEditTitle_Click(sender As Object, e As EventArgs) Handles btnEditTitle.Click
        Dim prompt = MessageBox.Show("Edit Title?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If prompt = Windows.Forms.DialogResult.Yes Then
            txtEditTitle.Text = txtProjectTitle.Text
            txtEditTitle.Visible = True
            txtEditTitle.Focus()
            txtEditTitle.SelectAll()
            btnEditTitle.Enabled = False
            txtEditTitle.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub txtEditTitle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditTitle.KeyDown
        If e.KeyCode = 13 Then
            Dim pModel = New ProjectModel
            If pModel.updateProjectName(ProjectId, txtEditTitle.Text) Then
                txtProjectTitle.Text = txtEditTitle.Text
                txtEditTitle.Visible = False
                btnEditTitle.Enabled = True
                e.SuppressKeyPress = True
                ProjectView.init()
            Else
                MessageBox.Show("Error")
                txtEditTitle.Text = txtProjectTitle.Text
                txtEditTitle.Visible = False
                btnEditTitle.Enabled = True
                e.SuppressKeyPress = True
            End If
            
        End If
    End Sub



    '--------------------EDIT DESC

    Private Sub btnEditDesc_Click(sender As Object, e As EventArgs) Handles btnEditDesc.Click
        Dim prompt = MessageBox.Show("Edit Title?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If prompt = Windows.Forms.DialogResult.Yes Then
            txtEditDesc.Text = txtProjectDesc.Text
            txtEditDesc.Visible = True
            txtEditDesc.Focus()
            txtEditDesc.SelectAll()
            btnEditDesc.Enabled = False
        End If
    End Sub

    Private Sub txtEditDesc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditDesc.KeyDown
        If e.KeyCode = 13 Then
            Dim pModel = New ProjectModel
            If pModel.updateProjectDesc(ProjectId, txtEditDesc.Text) Then
                txtProjectDesc.Text = txtEditDesc.Text
                txtEditDesc.Visible = False
                btnEditDesc.Enabled = True
                e.SuppressKeyPress = True
                ProjectView.init()
            Else
                MessageBox.Show("Error")
                txtEditDesc.Visible = False
                btnEditDesc.Enabled = True
                e.SuppressKeyPress = True
            End If
            
        End If
    End Sub
End Class