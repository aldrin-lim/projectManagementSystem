Imports MySql.Data.MySqlClient
Public Class TaskModel
    Private mysqlcon As MySqlConnection
    Private sqlCmd As MySqlCommand
    Public Sub New()
        mysqlcon = New MySqlConnection(connectionString)
    End Sub
    Public Function getAllTask() As DataTable
        Dim datatable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT tasks.task_id, tasks.task_name,tasks.task_description,tasks.task_duration,tasks.task_remaining,projects.project_name,users.user_name FROM tasks LEFT JOIN user_task ON tasks.task_id = user_task.task_id LEFT JOIN users ON users.user_id = user_task.user_id LEFT JOIN projects_user ON projects_user.user_id = users.user_id LEFT JOIN projects ON projects.project_id = projects_user.project_id GROUP BY tasks.task_id"
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects, projects_user, tasks, user_task, users")
            datatable = dataset.Tables("projects, projects_user, tasks, user_task, users")
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return datatable
    End Function


    Public Function getAllTaskByID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT projects.project_name,tasks.task_name,tasks.task_duration, users.user_name FROM projects, project_task, tasks, user_task, users where projects.project_id = project_task.project_id AND tasks.task_id = project_task.task_id and tasks.task_id = user_task.task_id and user_task.user_id = users.user_id and projects.project_id = " & id
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects, project_task, tasks, user_task, users")
            dataTable = dataset.Tables("projects, project_task, tasks, user_task, users")
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return dataTable
    End Function
    Public Function createTask(ByVal taskName As String, ByVal taskDesc As String, taskDuration As Integer)
        Try
            Dim dataSet As New DataSet
            Dim sql = "INSERT INTO tasks(task_name,task_description,task_duration) VALUES('" & taskName & "','" & taskDesc & "' ,'" & taskDuration & "')"
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()

            sqlCmd = New MySqlCommand(sql, mysqlcon)
            Dim i = sqlCmd.ExecuteNonQuery()
            If i > 0 Then
                Return True
            End If
        Catch sqlEx As MySqlException
            MessageBox.Show(sqlEx.Message)
            Return False
        Finally
            mysqlcon.Close()
        End Try

    End Function

    Public Function getCountOfTaskByProjectID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT COUNT(t.`task_name`) FROM projects p, project_task pt, tasks t, user_task ut, users u WHERE p.`project_id` = pt.`project_id` AND pt.`task_id` = t.`task_id` AND t.`task_id` = ut.`task_id` AND ut.`user_id` = u.`user_id` AND p.`project_id` = " & id
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects, project_task, tasks, user_task, users")
            dataTable = dataset.Tables("projects, project_task, tasks, user_task, users")
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return dataTable
    End Function

End Class
