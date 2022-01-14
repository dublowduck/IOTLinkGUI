<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblIotLink = New System.Windows.Forms.Label()
        Me.lblIotLinkInstalled = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWarningMsg = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDashboard = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tabDashboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIotLink
        '
        Me.lblIotLink.AutoSize = True
        Me.lblIotLink.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIotLink.Location = New System.Drawing.Point(6, 22)
        Me.lblIotLink.Name = "lblIotLink"
        Me.lblIotLink.Size = New System.Drawing.Size(105, 37)
        Me.lblIotLink.TabIndex = 0
        Me.lblIotLink.Text = "IOTLink"
        '
        'lblIotLinkInstalled
        '
        Me.lblIotLinkInstalled.AutoSize = True
        Me.lblIotLinkInstalled.BackColor = System.Drawing.SystemColors.Control
        Me.lblIotLinkInstalled.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIotLinkInstalled.Location = New System.Drawing.Point(130, 22)
        Me.lblIotLinkInstalled.Name = "lblIotLinkInstalled"
        Me.lblIotLinkInstalled.Size = New System.Drawing.Size(130, 37)
        Me.lblIotLinkInstalled.TabIndex = 1
        Me.lblIotLinkInstalled.Text = "Unknown"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(19, 108)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Refresh"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(25, 299)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWarningMsg
        '
        Me.lblWarningMsg.AutoSize = True
        Me.lblWarningMsg.Location = New System.Drawing.Point(19, 59)
        Me.lblWarningMsg.Name = "lblWarningMsg"
        Me.lblWarningMsg.Size = New System.Drawing.Size(219, 15)
        Me.lblWarningMsg.TabIndex = 5
        Me.lblWarningMsg.Text = "(Only checks the default install location)"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDashboard)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(298, 281)
        Me.TabControl1.TabIndex = 6
        '
        'tabDashboard
        '
        Me.tabDashboard.Controls.Add(Me.lblIotLink)
        Me.tabDashboard.Controls.Add(Me.lblWarningMsg)
        Me.tabDashboard.Controls.Add(Me.lblIotLinkInstalled)
        Me.tabDashboard.Controls.Add(Me.btnUpdate)
        Me.tabDashboard.Location = New System.Drawing.Point(4, 24)
        Me.tabDashboard.Name = "tabDashboard"
        Me.tabDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDashboard.Size = New System.Drawing.Size(290, 253)
        Me.tabDashboard.TabIndex = 0
        Me.tabDashboard.Text = "Dashboard"
        Me.tabDashboard.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(290, 253)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 334)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "IOTLink GUI"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDashboard.ResumeLayout(False)
        Me.tabDashboard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblIotLink As Label
    Friend WithEvents lblIotLinkInstalled As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWarningMsg As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDashboard As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
