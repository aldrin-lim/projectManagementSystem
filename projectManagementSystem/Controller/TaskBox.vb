Public Class TaskBox
    Private form As Panel
    Private currentID
    Public Sub New(ByVal form As Panel)
        Me.form = form
        'createThumbnail(1, "Wew", 12, 6, "Jeru Balondo Pajulas")
    End Sub

    Public Sub createThumbnail(ByVal height_, milestone_id, id, titleParams, projectParams, durationParams, remainingParams, member)

        Dim title, project, projectVal, duration, durationVal, remaining, remainingVal, assigned, assignedVal, txtid As New Label
        Dim box As New Panel


        Me.form.Controls.Add(box)
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


        box.Location = New Point(1, height_)
        box.Size = New Point(650, 80) '798 ,67
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
        projectVal.Text = projectParams

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
    End Sub

    Public Sub createList(ByVal dataTable As DataTable)
        Dim heightInterval = 0

        For i = 0 To dataTable.Rows.Count - 1
            createThumbnail(heightInterval, dataTable.Rows(i).Item(1), dataTable.Rows(i).Item(0).ToString, dataTable.Rows(i).Item(3).ToString, dataTable.Rows(i).Item(4).ToString, dataTable.Rows(i).Item(5).ToString, dataTable.Rows(i).Item(6).ToString, dataTable.Rows(i).Item(9).ToString)
            heightInterval += 85 '75
        Next
    End Sub

    Public Sub clear()
        Me.form.Controls.Clear()
    End Sub

End Class
