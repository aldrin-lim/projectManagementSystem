Public Class TaskBox
    Private form As Panel
    Private currentID
    Public Sub New(ByVal form As Panel)
        Me.form = form
        'createThumbnail(1, "Wew", 12, 6, "Jeru Balondo Pajulas")
    End Sub

    Public Sub createThumbnail(ByVal height_ As String, milestone_id As String, id As String, titleParams As String, projectParams As String, durationParams As String, remainingParams As String, member As String, gbox As GroupBox)
        
        Dim title, project, projectVal, duration, durationVal, remaining, remainingVal, assigned, assignedVal, txtid As New Label
        Dim box As New Panel
        'If height_ = Nothing Then
        '    MessageBox.Show("height")
        'ElseIf String.IsNullOrEmpty(milestone_id) = True Then
        '    MessageBox.Show("dataTable.Rows(i).Item(1).ToString")
        'ElseIf String.IsNullOrEmpty(id) = True Then
        '    MessageBox.Show("dataTable.Rows(i).Item(0).ToString")
        'ElseIf String.IsNullOrEmpty(titleParams) = True Then
        '    MessageBox.Show("dataTable.Rows(i).Item(3).ToString")
        'ElseIf String.IsNullOrEmpty(projectParams) = True Then
        '    MessageBox.Show("dataTable.Rows(i).Item(4).ToString")
        'ElseIf String.IsNullOrEmpty(durationParams) = True Then
        '    MessageBox.Show("dataTable.Rows(i).Item(5).ToString")
        'ElseIf String.IsNullOrEmpty(remainingParams) = True = Nothing Then
        '    MessageBox.Show("dataTable.Rows(i).Item(6).ToString")
        'ElseIf String.IsNullOrEmpty(member) = True = Nothing Then
        '    MessageBox.Show("dataTable.Rows(i).Item(9).ToString")
        'End If
        'MessageBox.Show(remainingParams)




        gbox.Controls.Add(box)
        box.Controls.Add(title)
        box.Controls.Add(project)
        box.Controls.Add(projectVal)
        box.Controls.Add(duration)
        box.Controls.Add(durationVal)
        box.Controls.Add(assigned)
        box.Controls.Add(assignedVal)
        box.Controls.Add(remaining)
        box.Controls.Add(remainingVal)
        box.Controls.Add(txtid)


        txtid.Text = id
        txtid.Tag = "id"
        txtid.Visible = False



        box.Location = New Point(10, height_)
        box.Size = New Point(638, 80) '798 ,67
        box.BackColor = Color.FromArgb(240, 240, 240)
        box.BorderStyle = BorderStyle.FixedSingle
        box.Cursor = Cursors.Hand

        title.Size = New Point(630, 28) '734
        title.Location = New Point(1, 5)
        title.Font = New Font("Arial", 16, FontStyle.Bold)
        title.ForeColor = Color.FromArgb(70, 70, 70)
        title.Text = titleParams
        title.Cursor = Cursors.Hand

        project.AutoSize = True
        project.Location = New Point(3, 32)
        project.Font = New Font("Arial", 9, FontStyle.Bold)
        project.ForeColor = Color.FromArgb(120, 120, 120)
        project.Text = "Project: "
        project.Cursor = Cursors.Hand

        projectVal.AutoSize = True
        projectVal.Location = New Point(61, 32)
        projectVal.Size = New Point(65, 15)
        projectVal.Font = New Font("Arial", 9, FontStyle.Regular)
        projectVal.ForeColor = Color.FromArgb(120, 120, 120)
        If String.IsNullOrEmpty(projectParams) = False Then
            '    MessageBox.Show("dataTable.Rows(i).Item(4).ToString")
            projectVal.Text = projectParams
        Else
            projectVal.Text = "( No Project Assigned )"
        End If


        duration.AutoSize = True
        duration.Location = New Point(3, 47)
        duration.Font = New Font("Arial", 9, FontStyle.Bold)
        duration.ForeColor = Color.FromArgb(120, 120, 120)
        duration.Text = "Duration: "
        duration.Cursor = Cursors.Hand

        durationVal.AutoSize = False
        durationVal.Location = New Point(61, 47)
        durationVal.Size = New Point(65, 15)
        durationVal.Font = New Font("Arial", 9, FontStyle.Regular)
        durationVal.ForeColor = Color.FromArgb(120, 120, 120)
        durationVal.Text = durationParams & " Hours"
        durationVal.Cursor = Cursors.Hand


        remaining.AutoSize = False
        remaining.Size = New Point(70, 15)
        remaining.Location = New Point(128, 47)
        remaining.Font = New Font("Arial", 9, FontStyle.Bold)
        remaining.ForeColor = Color.FromArgb(120, 120, 120)
        remaining.Text = "Remaining:"
        remaining.Cursor = Cursors.Hand

        remainingVal.AutoSize = True
        remainingVal.Location = New Point(199, 47)
        remainingVal.Font = New Font("Arial", 9, FontStyle.Regular)
        remainingVal.ForeColor = Color.FromArgb(120, 120, 120)
        remainingVal.Text = remainingParams & " Hours"
        remainingVal.Cursor = Cursors.Hand



        assigned.AutoSize = False
        assigned.Size = New Point(77, 15)
        assigned.Location = New Point(3, 62)
        assigned.Font = New Font("Arial", 9, FontStyle.Bold)
        assigned.ForeColor = Color.FromArgb(120, 120, 120)
        assigned.Text = "Assigned to:"
        assigned.Cursor = Cursors.Hand

        assignedVal.AutoSize = True
        assignedVal.Location = New Point(77, 62)
        assignedVal.Font = New Font("Arial", 9, FontStyle.Regular)
        assignedVal.ForeColor = Color.FromArgb(120, 120, 120)
        assignedVal.Text = member
        assignedVal.Cursor = Cursors.Hand

        If String.IsNullOrEmpty(member) = False Then
            '    MessageBox.Show("dataTable.Rows(i).Item(4).ToString")
            assignedVal.Text = member
        Else
            assignedVal.Text = "( No Person Involved )"
        End If
        Static Dim x = 0
        x += 1
        'MessageBox.Show(x)
    End Sub

    Private Function createGroupBox(ByVal height_ As Integer, ByVal id As Integer, ByVal name As String, ByVal dateStart As Date, ByVal dateEnd As Date, ByVal hours As Integer, ByVal status As String)
        Dim groupBox As New GroupBox
        Dim lblHrs, txtHrs, lblDuration, txtDuration, lblStatus, txtStatus As New Label
        Dim height
        Dim tModel = New TaskModel
        'MessageBox.Show(dateStart.ToString("MMM dd, yyyy"))
        Me.form.Controls.Add(groupBox)
        groupBox.Controls.Add(lblHrs)
        groupBox.Controls.Add(txtHrs)
        groupBox.Controls.Add(lblDuration)
        groupBox.Controls.Add(txtDuration)
        groupBox.Controls.Add(lblStatus)
        groupBox.Controls.Add(txtStatus)

        txtHrs.Font = New Font("Arial", 9, FontStyle.Bold)
        txtHrs.ForeColor = Color.FromArgb(120, 120, 120)
        txtHrs.Location = New Point(6, 36)
        txtHrs.Text = "Hours Allocated:"
        txtHrs.AutoSize = True

        lblHrs.Font = New Font("Arial", 8.75, FontStyle.Regular)
        lblHrs.ForeColor = Color.FromArgb(120, 120, 120)
        lblHrs.Location = New Point(108, 36)
        lblHrs.Text = hours & " Hr(s)"
        lblHrs.AutoSize = True
        'Dim x = tModel.getMileStoneHoursFromDependencyByID(id)
        'MessageBox.Show(tModel.getMileStoneHoursFromDependencyByID(id)(0) & " - " & tModel.getMileStoneHoursFromDependencyByID(id)(1))



        lblDuration.Font = New Font("Arial", 8.75, FontStyle.Bold)
        lblDuration.ForeColor = Color.FromArgb(120, 120, 120)
        lblDuration.Location = New Point(179, 35)
        lblDuration.Text = "Duration:"
        lblDuration.AutoSize = True

        txtDuration.Font = New Font("Arial", 8.75, FontStyle.Regular)
        txtDuration.ForeColor = Color.FromArgb(120, 120, 120)
        txtDuration.Location = New Point(243, 35)
        txtDuration.Size = New Point(168, 15)
        txtDuration.Text = dateStart.ToString("MMM dd, yyyy") & " & " & dateEnd.ToString("MMM dd, yyyy")
        txtDuration.AutoSize = False

        lblStatus.Font = New Font("Arial", 8.75, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(120, 120, 120)
        lblStatus.Location = New Point(417, 35)
        lblStatus.Text = "Status:"
        lblStatus.AutoSize = True

        txtStatus.Font = New Font("Arial", 8.75, FontStyle.Regular)
        txtStatus.ForeColor = Color.FromArgb(120, 120, 120)
        txtStatus.Location = New Point(470, 35)
        txtStatus.Size = New Point(95, 15)
        If status = "OG" Then
            txtStatus.Text = "On-going"
        ElseIf status = "F" Then
            txtStatus.Text = "Finished"
        End If
        txtStatus.AutoSize = False


        groupBox.Font = New Font("Arial", 14.25, FontStyle.Bold)
        groupBox.ForeColor = Color.FromArgb(70, 70, 70)
        groupBox.Size = New Point(653, 73)
        groupBox.Location = New Point(3, height_)
        groupBox.Text = name


        Try
            createList(tModel.getTaskAndMileStoneByM_ID(id), groupBox)
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
        Return groupBox.Height


    End Function

    Public Sub createGroupBoxList(ByVal dataTable As DataTable)
        Dim height = 0
        For i = 0 To dataTable.Rows.Count - 1
            height += createGroupBox(height, dataTable.Rows(i).Item(0), dataTable.Rows(i).Item(1), dataTable.Rows(i).Item(4), dataTable.Rows(i).Item(5), dataTable.Rows(i).Item(6), dataTable.Rows(i).Item(7)) + 10
        Next
        'For Each row As DataRow In dataTable.Rows
        '    MessageBox.Show(row.Item(1))
        'Next
    End Sub


    Public Sub createList(ByVal dataTable As DataTable, gbox As GroupBox)
        Dim heightInterval = 62

        For i = 0 To dataTable.Rows.Count - 1
            createThumbnail(heightInterval, dataTable.Rows(i).Item(1), dataTable.Rows(i).Item(0).ToString, dataTable.Rows(i).Item(3).ToString, dataTable.Rows(i).Item(4).ToString, dataTable.Rows(i).Item(5).ToString, dataTable.Rows(i).Item(6).ToString, dataTable.Rows(i).Item(9).ToString, gbox)
            


            heightInterval += 85 '75
            gbox.Height += 85
        Next
    End Sub

    Public Sub clear()
        Me.form.Controls.Clear()
    End Sub

End Class
