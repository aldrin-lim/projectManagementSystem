Public Class MainForm
    Private hoverFlag As Integer = 0 'UI purpose
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hoverLine.Location = New Point(-200, 129)
        Dim projectMod As New ProjectView
        'projectMod.MdiParent = Me
        'projectMod.Show()
        'projectMod.Location = New Point(229, 0)
    End Sub

    Public Sub init()
        ProjectView.MdiParent = Me
        ProjectView.Location = New Point(229, 0)
    End Sub

    


    '-----PROJECT MODULE--------

    Private Sub btnProjectModule_MouseEnter(sender As Object, e As EventArgs) Handles btnProjectModule.MouseEnter, iconProject.MouseEnter, txtProjectIcon.MouseEnter
        btnProjectModule.BackColor = Color.FromArgb(13, 119, 179)
     
    End Sub

    Private Sub btnProjectModule_MouseLeave(sender As Object, e As EventArgs) Handles btnProjectModule.MouseLeave, iconProject.MouseLeave, txtProjectIcon.MouseLeave
        btnProjectModule.BackColor = Color.FromArgb(30, 30, 30)

    End Sub


    Private Sub btnProjectModule_Click(sender As Object, e As EventArgs) Handles btnProjectModule.Click, iconProject.Click, txtProjectIcon.Click
        hoverLine.Location = New Point(0, 128)
        ProjectView.MdiParent = Me
        ProjectView.Show()
        ProjectView.Location = New Point(229, 0)
        UserView.Hide()
    End Sub

    '-------Team Module-------


    Private Sub btnTeamModule_Click(sender As Object, e As EventArgs) Handles btnTeamModule.Click, iconTeam.Click, txtTeamIcon.Click
        hoverLine.Location = New Point(0, 170)
        hoverFlag = 2
        UserView.MdiParent = Me
        UserView.Show()
        UserView.Location = New Point(229, 0)
        ProjectView.Hide()
    End Sub

    Private Sub btnTeamModule_MouseEnter(sender As Object, e As EventArgs) Handles btnTeamModule.MouseEnter, iconTeam.MouseEnter, txtTeamIcon.MouseEnter
        btnTeamModule.BackColor = Color.FromArgb(13, 119, 179)
    End Sub

    Private Sub btnTeamModule_MouseLeave(sender As Object, e As EventArgs) Handles btnTeamModule.MouseLeave, iconTeam.MouseLeave, txtTeamIcon.MouseLeave
        btnTeamModule.BackColor = Color.FromArgb(30, 30, 30)
    
    End Sub


    '--------TASK MODULE ------------
    Private Sub btnTaskModule_Click(sender As Object, e As EventArgs) Handles btnTaskModule.Click, iconTask.Click, txtTaskICon.Click
        hoverLine.Location = New Point(0, 211)
    End Sub

    Private Sub btnTaskModule_MouseEnter(sender As Object, e As EventArgs) Handles btnTaskModule.MouseEnter, iconTask.MouseEnter, txtTaskICon.MouseEnter
        btnTaskModule.BackColor = Color.FromArgb(13, 119, 179)
    End Sub

    Private Sub btnTaskModule_MouseLeave(sender As Object, e As EventArgs) Handles btnTaskModule.MouseLeave, iconTask.MouseLeave, txtTaskICon.MouseLeave
        btnTaskModule.BackColor = Color.FromArgb(30, 30, 30)
    End Sub


    '------WORK BREAKDOWN-------


    Private Sub btnIconWork_Click(sender As Object, e As EventArgs) Handles btnIconWork.Click, txtWorkIcon.Click, iconWork.Click
        hoverFlag = 4
        hoverLine.Location = New Point(0, 255)

    End Sub


    Private Sub btnIconWork_MouseEnter(sender As Object, e As EventArgs) Handles btnIconWork.MouseEnter, txtWorkIcon.MouseEnter, iconWork.MouseEnter
        btnIconWork.BackColor = Color.FromArgb(13, 119, 179)
    End Sub

    Private Sub btnIconWork_MouseLeave(sender As Object, e As EventArgs) Handles btnIconWork.MouseLeave, txtWorkIcon.MouseLeave, iconWork.MouseLeave
        btnIconWork.BackColor = Color.FromArgb(30, 30, 30)
    End Sub



    '-----Progress Module-----
    Private Sub btnIconProgress_Click(sender As Object, e As EventArgs) Handles btnIconProgress.Click, btnIconProgress.Click, txtProgressIcon.Click
        hoverFlag = 5
        hoverLine.Location = New Point(0, 298)
    End Sub

    Private Sub btnIconProgress_MouseEnter(sender As Object, e As EventArgs) Handles btnIconProgress.MouseEnter, btnIconProgress.MouseEnter, txtProgressIcon.MouseEnter
        btnIconProgress.BackColor = Color.FromArgb(13, 119, 179)
    End Sub

    Private Sub btnIconProgress_MouseLeave(sender As Object, e As EventArgs) Handles btnIconProgress.MouseLeave, btnIconProgress.MouseLeave, txtProgressIcon.MouseLeave
        btnIconProgress.BackColor = Color.FromArgb(30, 30, 30)
    End Sub


    '------REPORTS MODULE-----





    Private Sub btnReportsIcon_Click(sender As Object, e As EventArgs) Handles btnReportsIcon.Click, btnReportsIcon.Click, txtReportsIcon.Click
        hoverFlag = 6
        hoverLine.Location = New Point(0, 342)
    End Sub

    Private Sub btnReportsIcon_MouseEnter(sender As Object, e As EventArgs) Handles btnReportsIcon.MouseEnter, btnReportsIcon.MouseEnter, txtReportsIcon.MouseEnter
        btnReportsIcon.BackColor = Color.FromArgb(13, 119, 179)
    End Sub

    Private Sub btnReportsIcon_MouseLeave(sender As Object, e As EventArgs) Handles btnReportsIcon.MouseLeave, btnReportsIcon.MouseLeave, txtReportsIcon.MouseLeave
        btnReportsIcon.BackColor = Color.FromArgb(30, 30, 30)
    End Sub


    '-----PROFILE MODULE-----

    Private Sub btnProfileIcon_Click(sender As Object, e As EventArgs) Handles btnProfileIcon.Click, iconProfile.Click, txtProfileIcon.Click
        hoverFlag = 7
        hoverLine.Location = New Point(0, 382)
    End Sub

    Private Sub btnProfileIcon_MouseEnter(sender As Object, e As EventArgs) Handles btnProfileIcon.MouseEnter, iconProfile.MouseEnter, txtProfileIcon.MouseEnter
        btnProfileIcon.BackColor = Color.FromArgb(13, 119, 179)
    End Sub

    Private Sub btnProfileIcon_MouseLeave(sender As Object, e As EventArgs) Handles btnProfileIcon.MouseLeave, iconProfile.MouseLeave, txtProfileIcon.MouseLeave
        btnProfileIcon.BackColor = Color.FromArgb(30, 30, 30)
    End Sub
End Class