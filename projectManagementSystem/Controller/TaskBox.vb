Public Class TaskBox
    Private form As Panel

    Public Sub New(ByVal form As Panel)
        Me.form = form
    End Sub

    Public Sub createThumbnail(ByVal height_, titleParams, durationParams, remainingParams, member)

        Dim title, duration, durationVal, remaining, remainingVal, assigned, assignedVal As New Label
        Dim box As New Panel

        Me.form.Controls.Add(box)
        box.Controls.Add(title)
        box.Controls.Add(duration)
        box.Controls.Add(durationVal)
        box.Controls.Add(assigned)
        box.Controls.Add(assignedVal)
        box.Controls.Add(remaining)
        box.Controls.Add(remainingVal)


        box.Location = New Point(1, height_)
        box.Size = New Point(798, 67)
        box.BackColor = Color.FromArgb(240, 240, 240)
        box.BorderStyle = BorderStyle.FixedSingle

        title.Size = New Point(734, 28)
        title.Location = New Point(1, 5)
        title.Font = New Font("Arial", 16, FontStyle.Bold)
        title.ForeColor = Color.FromArgb(70, 70, 70)
        title.Text = titleParams

        duration.AutoSize = True
        duration.Location = New Point(3, 32)
        duration.Font = New Font("Arial", 9, FontStyle.Bold)
        duration.ForeColor = Color.FromArgb(120, 120, 120)
        duration.Text = "Duration: "

        durationVal.AutoSize = False
        durationVal.Location = New Point(61, 32)
        durationVal.Size = New Point(65, 15)
        durationVal.Font = New Font("Arial", 9, FontStyle.Regular)
        durationVal.ForeColor = Color.FromArgb(120, 120, 120)
        durationVal.Text = durationParams & " Hours"




        remaining.AutoSize = False
        remaining.Size = New Point(70, 15)
        remaining.Location = New Point(128, 32)
        remaining.Font = New Font("Arial", 9, FontStyle.Bold)
        remaining.ForeColor = Color.FromArgb(120, 120, 120)
        remaining.Text = "Remaining:"

        remainingVal.AutoSize = True
        remainingVal.Location = New Point(199, 32)
        remainingVal.Font = New Font("Arial", 9, FontStyle.Regular)
        remainingVal.ForeColor = Color.FromArgb(120, 120, 120)
        remainingVal.Text = remainingParams & " Hours"


        assigned.AutoSize = False
        assigned.Size = New Point(77, 15)
        assigned.Location = New Point(3, 47)
        assigned.Font = New Font("Arial", 9, FontStyle.Bold)
        assigned.ForeColor = Color.FromArgb(120, 120, 120)
        assigned.Text = "Assigned to:"

        assignedVal.AutoSize = True
        assignedVal.Location = New Point(77, 47)
        assignedVal.Font = New Font("Arial", 9, FontStyle.Regular)
        assignedVal.ForeColor = Color.FromArgb(120, 120, 120)
        assignedVal.Text = member
    End Sub

    Public Sub createList(ByVal dataTable As DataTable)
        Dim heightInterval = 0

        For i = 0 To dataTable.Rows.Count - 1
            createThumbnail(heightInterval, dataTable.Rows(i).Item(1).ToString, dataTable.Rows(i).Item(2).ToString, dataTable.Rows(i).Item(3).ToString, dataTable.Rows(i).Item(0).ToString)
            heightInterval += 75
        Next
    End Sub

    Public Sub clear()
        Me.form.Controls.Clear()
    End Sub

End Class
