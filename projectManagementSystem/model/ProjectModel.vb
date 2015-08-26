Imports MySql.Data.MySqlClient
Public Class ProjectModel
    Private mysqlcon As MySqlConnection
    Private sqlCmd As MySqlCommand




    Public Sub New()
        mysqlcon = New MySqlConnection(connectionString)
        'Dim ds As New DataSet
        'Dim mysqlDataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        'Dim sqlCommand As MySqlCommand
        'Dim dataTable As New DataTable
        'Try
        '    con.Open()
        '    Dim sql As String = "SELECT projects.`project_name`, CONCAT(projects.`start_date`,CONCAT(" - ",projects.`end_date`) )'date', GROUP_CONCAT(users.`user_name`) 'Members' FROM projects,project_user,users WHERE projects.`project_id` = project_user.`pm_id` AND users.`user_id` = project_user.`user_id` GROUP BY projects.`project_id`"
        '    sqlCommand = New MySqlCommand(sql, con)
        '    dataAdapter.SelectCommand = sqlCommand
        '    dataAdapter.Fill(ds, "projects,project_user,users")
        '    dataTable = ds.Tables("projects,project_user,users")
        '    MessageBox.Show(dataTable.Rows.Count)

        'Catch ex As Exception
        '    MessageBox.Show("error")
        'End Try


        'Dim COMMAND As New MySqlCommand
        'Dim SDA As New MySqlDataAdapter
        'Dim dbDataSet As New DataTable
        'Dim bsource As New BindingSource
        'Dim query As String

        'mysqlConnect = New MySqlConnection

        'mysqlConnect.ConnectionString = "server=localhost;userid=root;password='';database=db_sample"
        'Try
        '    mysqlConnect.Open()

        '    ' MessageBox.Show(query)
        '    COMMAND = New MySqlCommand(query, mysqlConnect)


        '    SDA.SelectCommand = COMMAND
        '    SDA.Fill(dbDataSet)

        '    'VIZ: loading of data in datagrid
        '    bsource.DataSource = dbDataSet
        '    'DataGridView1.DataSource = bsource
        '    'SDA.Update(dbDataSet)

        '    mysqlConnect.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    mysqlConnect.Dispose()
        'End Try
    End Sub

    Public Function getAllProject() As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT projects.project_id,projects.`project_name`, CONCAT(DATE_FORMAT(projects.`start_date`,'%b %d %Y'),CONCAT('  -  ',DATE_FORMAT(projects.`end_date`,'%b %d %Y')) )'date', GROUP_CONCAT(users.`user_name`) , COUNT(users.`user_name`) FROM projects LEFT JOIN project_user ON projects.`project_id` = project_user.`pm_id` LEFT JOIN users ON project_user.`user_id` = users.`user_id` GROUP BY projects.`project_id`"
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

    

    Public Function getProjectByID(ByVal id) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT project_id,project_name,project_description,start_date,end_date from projects WHERE project_id = " & id
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects")
            dataTable = dataset.Tables("projects")
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return dataTable
    End Function

    Public Function createProject(ByVal projectName As String, ByVal projectDesc As String, startDate As Date, endDate As Date)
        Try
            Dim dataSet As New DataSet
            Dim sql = "INSERT INTO projects(project_name,projects.`project_description`,start_date,end_date) VALUES('" & projectName & "','" & projectDesc & "' ,'" & startDate.ToString("yyyy-MM-dd") & "','" & endDate.ToString("yyyy-MM-dd") & "')"
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

    Public Function deleteProject(ByVal id)
        Try
            Dim dataSet As New DataSet
            Dim sql = "DELETE FROM projects WHERE project_id = " & id
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



    Public Function getProjectByName(ByVal name) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql = "SELECT projects.project_id,projects.`project_name`, CONCAT(projects.`start_date`,CONCAT(' - ',projects.`end_date`) )'date', GROUP_CONCAT(users.`user_name`) , COUNT(users.`user_name`) FROM projects LEFT JOIN project_user ON projects.`project_id` = project_user.`pm_id` LEFT JOIN users ON project_user.`user_id` = users.`user_id` WHERE projects.`project_name` LIKE '%" & name & "%' GROUP BY projects.`project_id`"
            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects")
            dataTable = dataset.Tables("projects")
        Catch ex1 As MySqlException
            MessageBox.Show(ex1.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlcon.Close()
        End Try
        Return dataTable
    End Function


    Public Function updateProjectName(ByVal id, ByVal Name)
        Try
            Dim dataSet As New DataSet
            Dim sql = "START TRANSACTION; UPDATE projects SET project_name = '" & Name & "' WHERE project_id = " & id & "; COMMIT;"
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

    Public Function updateProjectDesc(ByVal id, ByVal desc)
        Try
            Dim dataSet As New DataSet
            Dim sql = "UPDATE projects SET project_description = '" & desc & "' WHERE project_id = " & id
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


    Public Function updateProjectDate(ByVal id, ByVal date1, ByVal date2)
        Try
            Dim dataSet As New DataSet
            Dim sql = "UPDATE projects SET  projects.`start_date` = '" & date1 & "',projects.`end_date` = '" & date2 & "' WHERE project_id = " & id
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



    Public Function sortProjectByName(ByVal order) As DataTable
        Dim dataTable As New DataTable
        Try
            Dim dataset As New DataSet
            Dim sql
            If order = "asc" Then
                sql = "SELECT projects.project_id,projects.`project_name`, CONCAT(DATE_FORMAT(projects.`start_date`,'%b %d %Y'),CONCAT('  -  ',DATE_FORMAT(projects.`end_date`,'%b %d %Y')) )'date', GROUP_CONCAT(users.`user_name`) , COUNT(users.`user_name`) FROM projects LEFT JOIN project_user ON projects.`project_id` = project_user.`pm_id` LEFT JOIN users ON project_user.`user_id` = users.`user_id` GROUP BY projects.`project_id` ORDER BY project_name"
            ElseIf order = "desc" Then
                sql = "SELECT projects.project_id,projects.`project_name`, CONCAT(DATE_FORMAT(projects.`start_date`,'%b %d %Y'),CONCAT('  -  ',DATE_FORMAT(projects.`end_date`,'%b %d %Y')) )'date', GROUP_CONCAT(users.`user_name`) , COUNT(users.`user_name`) FROM projects LEFT JOIN project_user ON projects.`project_id` = project_user.`pm_id` LEFT JOIN users ON project_user.`user_id` = users.`user_id` GROUP BY projects.`project_id` ORDER BY project_name desc"
            End If

            Dim dataAdapter = New MySqlDataAdapter
            mysqlcon.Open()
            sqlCmd = New MySqlCommand(sql, mysqlcon)
            dataAdapter.SelectCommand = sqlCmd
            dataAdapter.Fill(dataset, "projects")
            dataTable = dataset.Tables("projects")
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
