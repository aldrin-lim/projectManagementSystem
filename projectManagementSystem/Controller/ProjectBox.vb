Public Class ProjectBox
    
    Private titleString, ddstring, member1String, member2String, member3String
    Private panel As Panel
    Private width, height As Integer


    ''Public Sub New(ByVal width As Integer, ByVal height As Integer, ByVal title As String, ByVal duration As String, ByVal member1 As String, ByVal member2 As String, ByVal member3 As String, ByVal formParams As Form)
    Public Sub New(ByVal formParams As Panel)
        'Me.titleString = title
        'Me.ddstring = duration
        'Me.member1String = member1
        'Me.member2String = member2
        'Me.member3String = member3
        Me.panel = formParams
        'Me.width = width
        'Me.height = height
    End Sub

    Public Sub createThumbnail(ByVal widthParams As Integer, ByVal heightParams As Integer, ByVal projectparams As String, ByVal titleParams As String, ByVal durationParams As String, ByVal memberParams As String, ByVal memberCountParams As Integer)
        Dim title, durationDate, members, viewDetails, projectid, memberCount, x As New Label
        Dim box As New Panel

        Me.panel.Controls.Add(box)
        box.Controls.Add(title)
        box.Controls.Add(durationDate)
        box.Controls.Add(members)
        box.Controls.Add(memberCount)
        box.Controls.Add(viewDetails)
        box.Controls.Add(projectid)
        box.Controls.Add(x)
        projectid.Text = projectparams
        projectid.Visible = False
        projectid.Tag = "id"


        box.ForeColor = Color.FromArgb(50, 50, 50)
        box.Size = New Point(203, 221)
        box.Location = New Point(widthParams, heightParams)

        box.BackColor = Color.FromArgb(240, 240, 240)
        box.BorderStyle = BorderStyle.FixedSingle

        title.AutoSize = False
        title.Size = New Point(196, 71)
        title.Text = titleParams
        title.Location = New Point(4, 16)
        title.Font = New Font("Arial", 14.25, FontStyle.Bold)
        title.ForeColor = Color.FromArgb(70, 70, 70)

        durationDate.Location = New Point(5, 87)
        durationDate.Text = "Duration date:  " & vbCrLf & durationParams
        durationDate.Tag = "date"
        durationDate.AutoSize = True
        durationDate.Font = New Font("Microsoft Sans Serif", 8.25)



        members.Location = New Point(5, 118)
        members.Size = New Point(200, 52)
        If memberCountParams > 0 Then

            If memberCountParams = 3 Then
                Dim mems = memberParams.ToString.Split(",")
                members.Text = "Members:" + vbCrLf + mems(0) + vbCrLf + mems(1) + vbCrLf +
                    mems(2).ToString
            ElseIf memberCountParams = 2 Then
                Dim mems = memberParams.ToString.Split(",")
                members.Text = "Members:" + vbCrLf + mems(0) + vbCrLf + mems(1)

            ElseIf memberCountParams = 1 Then
                Dim mems = memberParams.ToString.Split(",")
                members.Text = "Members:" + vbCrLf + mems(0)
            End If
        ElseIf memberCountParams > 1 Then

        ElseIf memberCountParams > 2 Then


        Else
            members.Text = "Members:" + vbCrLf + "No members Assigned"
        End If

        If memberCountParams > 3 Then
            memberCount.Font = New Font("Microsoft Sans Serif", 8.25)
            memberCount.Location = New Point(5, 170)
            memberCount.Text = "and " & memberCountParams - 3 & " more ..."
            memberCount.AutoSize = True
        End If

        viewDetails.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Underline)
        viewDetails.Location = New Point(61, 185)
        viewDetails.AutoSize = True
        viewDetails.ForeColor = Color.FromArgb(13, 119, 179)
        viewDetails.Text = "View Details"
        viewDetails.Cursor = Cursors.Hand


        x.Location = New Point(182, 2)
        x.Font = New Font("Arial", 8, FontStyle.Regular)
        x.ForeColor = Color.FromArgb(70, 70, 70)
        x.Text = "x"
        x.Cursor = Cursors.Hand
    End Sub

    Public Sub createList(ByVal datatable As DataTable)

        'Dim formWidth = Me.form.Size.Width
        'Dim formHeight = Me.form.Size.Height
        Try
            Dim startingHeight = 2
            Dim intervalHeight = 234
            Dim startingWidth = 2
            Dim intervalwidth = 220
            'Dim members() As String
            For i As Integer = 0 To datatable.Rows.Count - 1 Step 1


                'MessageBox.Show("")
                Dim width_
                If i > 2 Then
                    If i Mod 3 = 0 Then
                        width_ = startingWidth
                        startingHeight += intervalHeight
                    ElseIf i Mod 3 = 1 Then
                        width_ = startingWidth + intervalwidth
                    ElseIf i Mod 3 = 2 Then
                        width_ = startingWidth + intervalwidth * 2
                    End If
                Else
                    If i Mod 3 = 0 Then
                        width_ = startingWidth
                    ElseIf i Mod 3 = 1 Then
                        width_ = startingWidth + intervalwidth
                    ElseIf i Mod 3 = 2 Then
                        width_ = startingWidth + intervalwidth * 2
                    End If
                End If
                'MessageBox.Show(datatable.Rows(i).Item(3))

                createThumbnail(width_, startingHeight, datatable.Rows(i).Item(0), datatable.Rows(i).Item(1), datatable.Rows(i).Item(2), datatable.Rows(i).Item(3).ToString, datatable.Rows(i).Item(4))


            Next
            'Me.form.Width = Me.form.Width + 28
            'MainForm.Width = MainForm.Width + 22
            'MessageBox.Show(Me.form.Name & ": " & Me.form.Width & vbCrLf & MainForm.Name & ": " & MainForm.Width)
            Dim marginPanel As New PictureBox
            Me.panel.Controls.Add(marginPanel)
            marginPanel.Location = New Point(104, startingHeight + intervalHeight)
            marginPanel.Size = New Point(100, 20)
            marginPanel.BackColor = Color.White
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub clearAllBox()
        Me.panel.Controls.Clear()
    End Sub




End Class
