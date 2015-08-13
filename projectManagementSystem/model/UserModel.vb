Imports MySql.Data.MySqlClient

Public Class UserModel
    Private mysqlcon As MySqlConnection
    Private sqlCmd As MySqlCommand
    Public Sub New()
        mysqlcon = New MySqlConnection(connectionString)
        'MessageBox.Show(getUserByProjectID(1).Rows(0).Item(0).ToString)
    End Sub

    Public Function getUserByProjectID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT u.`user_name`,t.`task_name`,t.`task_duration`,t.`task_remaining` FROM projects p, project_task pt, tasks t, user_task ut, users u WHERE p.`project_id` = pt.`project_id` AND pt.`task_id` = t.`task_id` AND t.`task_id` = ut.`user_id` AND ut.`user_id` = u.`user_id` AND p.`project_id` = " & id
            Dim dataAdapter = New MySqlDataAdapter

            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects,project_user,users")
            dataTable = dataset.Tables("projects,project_user,users")
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return dataTable
    End Function

    Public Function getAllUser() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT user_id, CONCAT(user_fname,CONCAT(' ',user_mname,CONCAT(' ',user_lname)) )'User Name', user_description,user_image FROM users"
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "users")
            dataTable = dataset.Tables("users")
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return dataTable
    End Function

    Public Function getUserByID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT user_id, CONCAT(user_fname,CONCAT(' ',user_mname,CONCAT(' ',user_lname)) )'User Name', user_description,user_image FROM users WHERE user_id = " & id
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "users")
            dataTable = dataset.Tables("users")
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
