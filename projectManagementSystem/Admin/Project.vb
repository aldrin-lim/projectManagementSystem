Public Class Project
    Private createProjectThumbnailCount = 0
    Private ctr
    Private Sub Project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'createProjectThumbnail()
        timeDisplay.Start()
        Dim dt As Date = Date.Today
        txtDate.Text = dt.ToString("dddd MMM dd, yyyy")
        createProjectList()
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is System.Windows.Forms.Panel Then
                For Each panelctrl As Label In ctrl.Controls
                    If panelctrl.Text = "View Details" Then
                        AddHandler panelctrl.Click, AddressOf viewProjectDetails
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub viewProjectDetails()
        MessageBox.Show("lol")
    End Sub


    Private Sub createProjectList()
        Dim Count = 7
        Dim formWidth = Me.Size.Width
        Dim formHeight = Me.Size.Height
        Dim startingHeight = 140
        Dim intervalHeight = 234
        Dim startingWidth = 169
        Dim intervalwidth = 229
        For i As Integer = 0 To Count - 1 Step 1
            Dim width
            If i > 2 Then
                If i Mod 3 = 0 Then
                    width = startingWidth
                    startingHeight += intervalHeight
                ElseIf i Mod 3 = 1 Then
                    width = startingWidth + intervalwidth
                ElseIf i Mod 3 = 2 Then
                    width = startingWidth + intervalwidth * 2
                End If
            Else
                If i Mod 3 = 0 Then
                    width = startingWidth
                ElseIf i Mod 3 = 1 Then
                    width = startingWidth + intervalwidth
                ElseIf i Mod 3 = 2 Then
                    width = startingWidth + intervalwidth * 2
                End If
            End If
            Dim pbox = New ProjectBox(width, startingHeight, "Some shit nigga system", "Jul 10, 2015 - Sep 23, 2015", "Yeng Constantino", "Isabell Daza", "Anne Hathaway", Me)
            Me.Width = Me.Width + 2
            MainForm.Width = MainForm.Width + 2
        Next

        Dim marginPanel As New PictureBox
        Me.Controls.Add(marginPanel)
        marginPanel.Location = New Point(104, startingHeight + intervalHeight)
        marginPanel.Size = New Point(100, 20)
        marginPanel.BackColor = Color.White

    End Sub

   
    Private Sub timeDisplay_Tick(sender As Object, e As EventArgs) Handles timeDisplay.Tick

        txtTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub
End Class