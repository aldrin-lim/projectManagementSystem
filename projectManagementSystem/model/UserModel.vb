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


    Public Function searchUser(ByVal text) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT user_id, CONCAT(user_fname,CONCAT(' ',user_mname,CONCAT(' ',user_lname)) )'User Name', user_description,user_image FROM users WHERE  CONCAT(user_fname,CONCAT(' ',user_mname,CONCAT(' ',user_lname)) ) LIKE '%" & text & "%'  "
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

    Public Function sortUser(Optional ByVal sort As String = "asc") As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql
            If sort = "asc" Then
                sql = "SELECT user_id, CONCAT(user_fname,CONCAT(' ',user_mname,CONCAT(' ',user_lname)) )'User Name', user_description,user_image FROM users ORDER BY user_fname ASC"
            ElseIf sort = "desc" Then
                sql = "SELECT user_id, CONCAT(user_fname,CONCAT(' ',user_mname,CONCAT(' ',user_lname)) )'User Name', user_description,user_image FROM users ORDER BY user_fname DESC"
            End If
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(Sql, mysqlcon)
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


    Public Function getAllAvailableUser() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT u.user_id, CONCAT(u.user_fname,CONCAT(' ',u.user_lname) )'User Name', u.user_description,u.user_image FROM tasks t LEFT JOIN user_task ut ON t.task_id = ut.task_id RIGHT JOIN users u ON ut.user_id = u.user_id WHERE t.`task_id` IS NULL"
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

    Public Function getUserProjectAndTaskByUserID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT p.project_name, t.`task_name` FROM projects p, project_task pt, tasks t, user_task ut, users u WHERE p.`project_id` = pt.`project_id` AND pt.`task_id` = t.`task_id` AND t.`task_id` = ut.`user_id` AND ut.`user_id` = u.`user_id` AND u.user_id = " & id
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

    Public Function deleteProject(ByVal id)
        Try
            Dim dataSet As New DataSet
            Dim sql = "DELETE FROM users WHERE user_id = " & id
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

End Class
