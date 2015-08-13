Imports System.Drawing.Text

Public Class myCustomFont
    Private ubuntuRegPFC As New PrivateFontCollection
    Private ubuntuBoldPFC As New PrivateFontCollection
    Private ubuntuLightPFC As New PrivateFontCollection
    Private ubuntuLight, ubuntuBold, ubuntuReg As Font
    Public Sub New()
        ubuntuLightPFC.AddFontFile(Application.StartupPath + "\OpenSans-Light.ttf")
        ubuntuBoldPFC.AddFontFile(Application.StartupPath + "\OpenSans-Bold.ttf")
        ubuntuRegPFC.AddFontFile(Application.StartupPath + "\OpenSans-Regular.ttf")
        ubuntuLight = New Font(ubuntuLightPFC.Families(0), 12, FontStyle.Bold)
        ubuntuReg = New Font(ubuntuRegPFC.Families(0), 12, FontStyle.Bold)
        ubuntuBold = New Font(ubuntuBoldPFC.Families(0), 12, FontStyle.Bold)
    End Sub

    Public Function light() As Font
        Return ubuntuLight
    End Function

    Public Function reg() As Font
        Return ubuntuReg
    End Function

    Public Function bold() As Font
        Return ubuntuBold
    End Function
End Class
