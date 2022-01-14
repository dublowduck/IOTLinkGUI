﻿Public Class Form1
    'delcare variables
    Dim blnIotLinkIsInstalled As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check for IOTLink service file on startup
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\IOTLink\IOTLinkService.exe") Then
            blnIotLinkIsInstalled = True
        Else
            blnIotLinkIsInstalled = False
        End If

        If blnIotLinkIsInstalled = True Then
            lblIotLinkInstalled.Text = "Installed"
            lblIotLinkInstalled.BackColor = Color.Lime
        ElseIf blnIotLinkIsInstalled = False Then
            lblIotLinkInstalled.Text = "Not Installed"
            lblIotLinkInstalled.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'check for IOTLink service file when refresh button pressed
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\IOTLink\IOTLinkService.exe") Then
            blnIotLinkIsInstalled = True
        Else
            blnIotLinkIsInstalled = False
        End If

        If blnIotLinkIsInstalled = True Then
            lblIotLinkInstalled.Text = "Installed"
            lblIotLinkInstalled.BackColor = Color.Lime
        ElseIf blnIotLinkIsInstalled = False Then
            lblIotLinkInstalled.Text = "Not Installed"
            lblIotLinkInstalled.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        blnIotLinkIsInstalled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form
        Me.Close()
    End Sub

End Class
