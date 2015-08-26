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
            Dim sql = "SELECT tasks.task_id,tasks.task_name,tasks.task_duration,tasks.task_remaining  FROM tasks"
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects, project_task, tasks, user_task, users")
            datatable = dataset.Tables("projects, project_task, tasks, user_task, users")
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
    Public Function createTask(ByVal taskName As String, ByVal taskDesc As String, taskStart As String, taskEnd As String, hour As String)
        Try
            Dim dataSet As New DataSet
            Dim sql = "INSERT INTO tasks(task_name,task_description,task_start,task_end,task_duration,task_status) VALUES('" & taskName & "','" & taskDesc & "' ,'" & taskStart & "','" & taskEnd & "', " & hour & " ,'OG')"
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

    '
    Public Function getAllTaskWithoutMilestone() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT t.`task_id`, m.`milestone_id`,m.`milestone_name`,t.`task_name`, p.`project_name` ,t.`task_duration`,t.`task_remaining`,t.task_start,t.task_end , CONCAT( u.`user_fname`, CONCAT(' ',u.user_lname)) FROM projects p LEFT JOIN milestone m ON p.`project_id` = m.`milestone_project_id` LEFT JOIN milestone_task mt ON m.milestone_id = mt.milestone_id RIGHT JOIN tasks t ON mt.task_id = t.task_id LEFT JOIN user_task ut ON t.`task_id` = ut.`task_id` LEFT JOIN users u ON ut.`user_id` = u.`user_id` WHERE m.`milestone_name` IS NULL"
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


    Public Function getTaskAndMileStoneByID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT t.`task_id`, m.`milestone_id`,m.`milestone_name`,t.`task_name`, p.`project_name` ,t.`task_duration`,t.`task_remaining`,t.task_start,t.task_end , CONCAT( u.`user_fname`, CONCAT(' ',u.user_lname)) FROM projects p LEFT JOIN milestone m ON p.`project_id` = m.`milestone_project_id` LEFT JOIN milestone_task mt ON m.milestone_id = mt.milestone_id RIGHT JOIN tasks t ON mt.task_id = t.task_id LEFT JOIN user_task ut ON t.`task_id` = ut.`task_id` LEFT JOIN users u ON ut.`user_id` = u.`user_id` WHERE t.`task_id` = " & id
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

    Public Function getAllTaskAndMileStone() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT t.`task_id`, m.`milestone_id`,m.`milestone_name`,t.`task_name`, p.`project_name` ,t.`task_duration`,t.`task_remaining`,m.`milestone_duration_start`,m.`milestone_duration_end` , CONCAT( u.`user_fname`, CONCAT(' ',u.user_lname)) FROM projects p LEFT JOIN milestone m ON p.`project_id` = m.`milestone_project_id` LEFT JOIN milestone_task mt ON m.milestone_id = mt.milestone_id RIGHT JOIN tasks t ON mt.task_id = t.task_id LEFT JOIN user_task ut ON t.`task_id` = ut.`task_id` LEFT JOIN users u ON ut.`user_id` = u.`user_id`"
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

    Public Function getTaskAndMileStoneByM_ID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT t.`task_id`, m.`milestone_id`,m.`milestone_name`,t.`task_name`, p.`project_name` ,t.`task_duration`,t.`task_remaining`,m.`milestone_duration_start`,m.`milestone_duration_end` , CONCAT( u.`user_fname`, CONCAT(' ',u.user_lname)) FROM projects p LEFT JOIN milestone m ON p.`project_id` = m.`milestone_project_id` LEFT JOIN milestone_task mt ON m.milestone_id = mt.milestone_id RIGHT JOIN tasks t ON mt.task_id = t.task_id LEFT JOIN user_task ut ON t.`task_id` = ut.`task_id` LEFT JOIN users u ON ut.`user_id` = u.`user_id` WHERE m.`milestone_id` =" & id
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

    Public Function getAllMilestone() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = " SELECT milestone_id,milestone_name,milestone_hours,milestone_dependency,milestone_duration_start,milestone_duration_end,milestone_hours,milestone_status FROM milestone"
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

    Public Function getMilestoneByName(ByVal name As String) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = " SELECT milestone_id,milestone_hours FROM milestone WHERE milestone_name = '" & name & "'"

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

    Public Function getMileStoneHoursFromDependencyByID(ByVal id) As ArrayList
        Dim myArray As New ArrayList
        Try
            Dim dataset As New DataSet
            Dim sql = " CALL `getHoursFromDependency`(@milestoneID,@hours,@milestone); SELECT @hours ,@milestone;"
            mysqlcon.Open()
            sqlCmd = New MySqlCommand()
            sqlCmd.Connection = mysqlcon
            sqlCmd.CommandText = "getHoursFromDependency"
            sqlCmd.CommandType = CommandType.StoredProcedure

            sqlCmd.Parameters.AddWithValue("@milestoneID", CInt(id))
            sqlCmd.Parameters("@milestoneID").Direction = ParameterDirection.Input

            'sqlCmd.Parameters.AddWithValue("@hours", MySqlDbType.Int64)
            sqlCmd.Parameters.Add("@hours", MySqlDbType.Int64).Direction = ParameterDirection.Output

            'sqlCmd.Parameters.AddWithValue("@m_name", MySqlDbType.String)
            sqlCmd.Parameters.Add("@m_name", MySqlDbType.VarChar).Direction = ParameterDirection.Output

            sqlCmd.ExecuteNonQuery()
            myArray.Add(sqlCmd.Parameters("@hours").Value.ToString)
            myArray.Add(sqlCmd.Parameters("@m_name").Value.ToString)
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return myArray
    End Function
    Public Function getTaskIDbyName(ByVal name As String) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = " SELECT task_id FROM tasks WHERE task_name = '" & name & "'"

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

    Public Function createMilestone(name As String, id As Integer, start As String, endD As String, hours As Integer, dependency As Integer)
        Try
            Dim dataSet As New DataSet
            Dim sql = "INSERT INTO `milestone`(`milestone_name`, `milestone_project_id`, `milestone_duration_start`, `milestone_duration_end`, `milestone_hours`, `milestone_dependency`, `milestone_status`) VALUES" &
                " ('" & name & "'," & id & ",'" & start & "','" & endD & "'," & hours & "," & dependency & ",'OG')"
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

    Public Function assignTaskToMilestone(ByVal id As Integer, ByVal items As ArrayList)
        Try
            Dim dataSet As New DataSet
            Dim sql = " INSERT INTO milestone_task "
            For j As Integer = 0 To items.Count - 1
                If j < 1 Then
                    sql += " VALUES(" & id & "," & items(j) & ")"
                Else
                    sql += ", (" & id & ", " & items(j) & ")"
                End If
            Next
            mysqlcon.Open()
            Dim dataAdapter = New MySqlDataAdapter

            sqlCmd = New MySqlCommand(sql, mysqlcon)
            Dim i = sqlCmd.ExecuteNonQuery()
            If i > 0 Then
                Return True
            End If
        Catch sqlEx As MySqlException
            mysqlcon.Close()
            MessageBox.Show(sqlEx.Message)
            deleteMilestone(getLastInsertedMilestone.Rows(0).Item(0))
            Return False
        Finally

            mysqlcon.Close()
        End Try
    End Function

    Public Function getLastInsertedMilestone() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = " SELECT LAST_INSERT_ID(); "

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

    Public Function getLastInsertedTask() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = " SELECT LAST_INSERT_ID(); "

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

    Public Function deleteMilestone(ByVal id As Integer)
        Try
            Dim dataSet As New DataSet
            Dim sql = "DELETE FROM milestone where milestone_id = " & id

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

    Public Function createLinkBetweenTaskAndPorject(ByVal taskID As Integer, projectID As Integer)
        Try
            Dim dataSet As New DataSet
            Dim sql = "INSERT INTO project_task VALUES(" & projectID & "," & taskID & ")"
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

    Public Function createLinkBetweenTaskAndMilestone(ByVal taskID As Integer, milestoneID As Integer)
        Try
            Dim dataSet As New DataSet
            Dim sql = "INSERT INTO milestone_task VALUES(" & milestoneID & "," & taskID & ")"
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

    Public Function createLinkBetweenTaskAndUser(ByVal taskID As Integer, userID As Integer)
        Try
            Dim dataSet As New DataSet
            Dim sql = "INSERT INTO user_task VALUES(" & userID & "," & taskID & ")"
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
