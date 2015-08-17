Imports MySql.Data.MySqlClient
Public Class UserView
    '--------------VARIABLES & INITIALIZATION-----------------
    Private UserID
    Private createProjectThumbnailCount = 0
    Private ctr
    Public Delegate Sub MyDelegate(sender As System.Object, e As System.EventArgs)
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim px = New ProjectModel
        'Dim x = px.getAllProject()
        'MessageBox.Show(x.Rows(0).Item(0))
        init()
    End Sub



    '--------------FUNCTIONS-----------------


    Public Sub init()
        timeDisplay.Start()
        Dim dt As Date = Date.Today

        Dim ubox As New UserBox(panelBox)
        Dim user As New UserModel


        ubox.clearAllBox()
        ubox.createList(user.getAllUser())

        attachHandlers()
    End Sub

    Public Sub setUserID(ByVal id)
        UserID = id
    End Sub

    Public Function getUserID()
        Return UserID
    End Function

    Public Sub userBoxClick(ByVal id)
        setUserID(id)
        UserDetail.ShowDialog()
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
        Dim ubox As New UserBox(panelBox)
        Dim user As New UserModel
        ubox.clearAllBox()
        ubox.createList(user.searchUser(txtSearch.Text))

        attachHandlers()
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

    Private Sub btnSortA_Click(sender As Object, e As EventArgs) Handles btnSortA.Click
        Dim ubox As New UserBox(panelBox)
        Dim user As New UserModel
        ubox.clearAllBox()
        ubox.createList(user.sortUser())

        attachHandlers()
    End Sub

    Private Sub btnSortD_Click(sender As Object, e As EventArgs) Handles btnSortD.Click
        Dim ubox As New UserBox(panelBox)
        Dim user As New UserModel
        ubox.clearAllBox()
        ubox.createList(user.sortUser("desc"))

        attachHandlers()
    End Sub
End Class