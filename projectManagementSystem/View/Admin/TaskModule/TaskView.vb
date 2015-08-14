Imports MySql.Data.MySqlClient
Public Class TaskView
    '--------------VARIABLES & INITIALIZATION-----------------
    Public selectedID
    'Private createProjectThumbnailCount = 0
    Private ctr
    'Public Delegate Sub MyDelegate(sender As System.Object, e As System.EventArgs)
    Private Sub Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub
    Public Sub init()
        'timeDisplay.Start()
        'Dim dt As Date = Date.Today

        Dim tbox As New TaskBox(panelBox)
        Dim task As New TaskModel
        tbox.clear()
        tbox.createList(task.getAllTask())
        attachHandlers()
    End Sub
    Public Sub taskBoxClick(ByVal id)
        MessageBox.Show(id)
    End Sub
    Public Sub attachHandlers()
        For Each ctrl As Control In panelBox.Controls
            If TypeOf ctrl Is System.Windows.Forms.Panel Then
                Dim taskID

                For Each panelCtrl As Control In ctrl.Controls
                    If panelCtrl.Tag = "id" Then
                        taskID = panelCtrl.Text
                    End If
                Next


                AddHandler ctrl.Click, Sub(sender, e) taskBoxClick(taskID)
                For Each panelCtrl As Control In ctrl.Controls
                    AddHandler panelCtrl.Click, Sub(sender, e) taskBoxClick(taskID)
                Next
            End If
        Next
    End Sub
End Class