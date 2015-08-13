Imports MySql.Data.MySqlClient
Public Class UserView
    '--------------VARIABLES & INITIALIZATION-----------------
    Public selectedID
    Private createProjectThumbnailCount = 0
    Private ctr
    Public Delegate Sub MyDelegate(sender As System.Object, e As System.EventArgs)
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim px = New ProjectModel
        'Dim x = px.getAllProject()
        'MessageBox.Show(x.Rows(0).Item(0))
        init()
    End Sub

    Private Sub viewUserDetails(ByVal idx As String)
        selectedID = idx
        detailsDialog.ShowDialog()
    End Sub

    '--------------FUNCTIONS-----------------


    Public Sub init()
        timeDisplay.Start()
        Dim dt As Date = Date.Today


        Dim ubox As New UserBox(panelBox)
        Dim user As New UserModel


        ubox.clearAllBox()
        ubox.createList(user.getAllUser())
        ' MessageBox.Show(user.getAllUser.Rows(0).Item(2))
        'pbox.clearAllBox()
        'If (project.createProject("Name", "2015-08-20", "2015-08-30")) Then
        '    pbox.clearAllBox()
        '    pbox.createList(project.getAllProject)
        'Else
        '    MessageBox.Show("ERROR")
        'End If        
        attachHandlers()
    End Sub

    Public Sub userBoxClick(ByVal id)
        MessageBox.Show(id)
    End Sub

    Public Sub attachHandlers()
        For Each ctrl As Control In panelBox.Controls
            If TypeOf ctrl Is System.Windows.Forms.Panel Then
                Dim userID

                For Each panelCtrl As Control In ctrl.Controls
                    If panelCtrl.Tag = "id" Then
                        userID = panelCtrl.Text
                    End If
                Next


                AddHandler ctrl.Click, Sub(sender, e) userBoxClick(userID)
                For Each panelCtrl As Control In ctrl.Controls
                    AddHandler panelCtrl.Click, Sub(sender, e) userBoxClick(userID)
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

    'Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click, iconCreateProject.Click
    '    AddDialog.ShowDialog()
    'End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

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