
Imports MySql.Data.MySqlClient
Public Class ProjectView

    '--------------VARIABLES & INITIALIZATION-----------------
    Public selectedID
    Private createProjectThumbnailCount = 0
    Private ctr
    Public Delegate Sub MyDelegate(sender As System.Object, e As System.EventArgs)
    Private Sub Project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim px = New ProjectModel
        'Dim x = px.getAllProject()
        'MessageBox.Show(x.Rows(0).Item(0))
        init()
    End Sub

    Private Sub viewProjectDetails(ByVal idx As String)
        selectedID = idx
        detailsDialog.ShowDialog()
    End Sub

    '--------------FUNCTIONS-----------------


    Public Sub init()
        timeDisplay.Start()
        Dim dt As Date = Date.Today


        Dim pbox As New ProjectBox(panelBox)
        Dim project As New ProjectModel
        pbox.clearAllBox()
        pbox.createList(project.getAllProject())
        'pbox.clearAllBox()
        'If (project.createProject("Name", "2015-08-20", "2015-08-30")) Then
        '    pbox.clearAllBox()
        '    pbox.createList(project.getAllProject)
        'Else
        '    MessageBox.Show("ERROR")
        'End If        
        attachHandlers()
    End Sub

    Public Sub attachHandlers()
        For Each ctrl In panelBox.Controls
            If TypeOf ctrl Is System.Windows.Forms.Panel Then
                Dim projectId = Nothing
                For Each pnlctrl As Label In ctrl.Controls
                    If pnlctrl.Tag = "id" Then
                        projectId = pnlctrl.Text
                    End If
                Next
                For Each panelctrl As Label In ctrl.Controls
                    If panelctrl.Text = "View Details" Then
                        AddHandler panelctrl.Click, Sub(sender, e) viewProjectDetails(projectId)
                    End If

                Next
            End If
        Next
    End Sub

    Public Sub searchProject(ByVal pName As String)
        Dim pbox As New ProjectBox(panelBox)
        Dim project As New ProjectModel
        pbox.clearAllBox()
        pbox.createList(project.getProjectByName(pName))
        attachHandlers()
    End Sub


    '--------------EVENTS-----------------

    Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click, iconCreateProject.Click
        AddDialog.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchProject(txtSearch.Text)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Clear()
        txtSearch.ForeColor = Color.DimGray
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        MessageBox.Show("asd")
    End Sub

    Public Sub clearSearch()
        txtSearch.Clear()
    End Sub
End Class