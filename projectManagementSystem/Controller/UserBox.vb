Public Class UserBox
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
        'createThumbnail(15, 13, 1, "Junior Web Developer", "Gabriella Sixto Leonoroa S. Dela Cruz Santiago")
        'Me.width = width
        'Me.height = height
    End Sub

    Public Sub createThumbnail(ByVal widthParams As Integer, ByVal heightParams As Integer, ByVal userparams As String, ByVal userdescParams As String, ByVal usernameParams As String, ByVal imgpath As String)
        Dim userName, userDesc, userid As New Label
        Dim box As New Panel
        Dim picBox As New PictureBox

        Me.panel.Controls.Add(box)
        box.Controls.Add(userDesc)
        box.Controls.Add(userName)
        box.Controls.Add(userid)
        box.Controls.Add(picBox)

        userid.Text = userparams
        userid.Visible = False
        userid.Tag = "id"

        box.ForeColor = Color.FromArgb(50, 50, 50)
        box.Size = New Point(185, 177)
        box.Location = New Point(widthParams, heightParams)
        box.Cursor = Cursors.Hand

        box.BackColor = Color.FromArgb(240, 240, 240)
        box.BorderStyle = BorderStyle.FixedSingle

        userDesc.AutoSize = False
        userDesc.Size = New Point(177, 13)
        'userDesc.Text = userdescParams
        userDesc.Location = New Point(3, 115)
        userDesc.Font = New Font("Arial", 8.25)
        userDesc.ForeColor = Color.FromArgb(120, 120, 120)
        userDesc.TextAlign = ContentAlignment.MiddleCenter
        userDesc.Cursor = Cursors.Hand

        userName.AutoSize = False
        userName.Size = New Point(177, 35)
        userName.Location = New Point(3, 130)
        userName.Text = usernameParams
        userName.Font = New Font("Arial", 9.75, FontStyle.Bold)
        userName.ForeColor = Color.FromArgb(50, 50, 50)
        userName.TextAlign = ContentAlignment.MiddleCenter
        userName.Cursor = Cursors.Hand


        picBox.BorderStyle = BorderStyle.FixedSingle
        picBox.BackColor = Color.Black
        picBox.Size = New Point(100, 100)
        picBox.Location = New Point(41, 12)
        picBox.Cursor = Cursors.Hand
        picBox.SizeMode = PictureBoxSizeMode.Zoom
        picBox.ImageLocation = "http://localhost/pms_images/" & imgpath
        picBox.BackColor = Color.Transparent


        'members.Location = New Point(5, 118)
        'members.Size = New Point(200, 52)

        If String.IsNullOrEmpty(userdescParams) = False Then
            'MessageBox.Show("Pasoks")
            userDesc.Text = userdescParams
        Else
            'MessageBox.Show("HINDE")
            userDesc.Text = "No Position"
        End If
        'If Convert.IsDBNull(userdescParams) Then
        '    userDesc.Text = "No Nothing"
        'Else
        '    userDesc.Text = userdescParams
        'End If
        'If memberCountParams > 3 Then
        '    memberCount.Font = New Font("Microsoft Sans Serif", 8.25)
        '    memberCount.Location = New Point(5, 170)
        '    memberCount.Text = "and " & memberCountParams - 3 & " more ..."
        '    memberCount.AutoSize = True
        'End If

        'viewDetails.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Underline)
        'viewDetails.Location = New Point(61, 185)
        'viewDetails.AutoSize = True
        'viewDetails.ForeColor = Color.FromArgb(13, 119, 179)
        'viewDetails.Text = "View Details"
        'viewDetails.Cursor = Cursors.Hand
    End Sub

    Public Sub createList(ByVal datatable As DataTable)

        'Dim formWidth = Me.form.Size.Width
        'Dim formHeight = Me.form.Size.Height
        Try
            Dim startingHeight = 13
            Dim intervalHeight = 234
            Dim startingWidth = 15
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
                'createThumbnail(width_, startingHeight, datatable.Rows(i).Item(0), datatable.Rows(i).Item(1), datatable.Rows(i).Item(2), datatable.Rows(i).Item(3).ToString, datatable.Rows(i).Item(4))
                'MessageBox.Show(datatable.Rows(i).Item(0).ToString & datatable.Rows(i).Item(2).ToString & datatable.Rows(i).Item(1).ToString & datatable.Rows(i).Item(3).ToString)
                createThumbnail(width_, startingHeight, datatable.Rows(i).Item(0).ToString, datatable.Rows(i).Item(2).ToString, datatable.Rows(i).Item(1).ToString, datatable.Rows(i).Item(3).ToString)

            Next


            'For Each item In Me.panel.Controls
            '    MessageBox.Show(item.GetType.ToString)
            'Next
            'Me.form.Width = Me.form.Width + 28
            'MainForm.Width = MainForm.Width + 22
            'MessageBox.Show(Me.form.Name & ": " & Me.form.Width & vbCrLf & MainForm.Name & ": " & MainForm.Width)
            'Dim marginPanel As New PictureBox
            'Me.panel.Controls.Add(marginPanel)
            'marginPanel.Location = New Point(104, startingHeight + intervalHeight)
            'marginPanel.Size = New Point(100, 20)
            'marginPanel.BackColor = Color.White
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub clearAllBox()
        Me.panel.Controls.Clear()
    End Sub
End Class
