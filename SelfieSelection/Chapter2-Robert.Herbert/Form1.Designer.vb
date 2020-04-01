<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnCheer = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnSelectSelfie = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExitWindow = New System.Windows.Forms.Button()
        Me.picConnect = New System.Windows.Forms.PictureBox()
        Me.picCheer = New System.Windows.Forms.PictureBox()
        CType(Me.picConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(88, 22)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(359, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Vote for the Best Campus Selfie"
        '
        'btnCheer
        '
        Me.btnCheer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheer.Location = New System.Drawing.Point(102, 103)
        Me.btnCheer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheer.Name = "btnCheer"
        Me.btnCheer.Size = New System.Drawing.Size(98, 30)
        Me.btnCheer.TabIndex = 1
        Me.btnCheer.Text = "Finalist ""Cheer"""
        Me.btnCheer.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(338, 103)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(98, 30)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Finalist ""Connect"""
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnSelectSelfie
        '
        Me.btnSelectSelfie.Enabled = False
        Me.btnSelectSelfie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSelfie.Location = New System.Drawing.Point(220, 344)
        Me.btnSelectSelfie.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectSelfie.Name = "btnSelectSelfie"
        Me.btnSelectSelfie.Size = New System.Drawing.Size(98, 30)
        Me.btnSelectSelfie.TabIndex = 5
        Me.btnSelectSelfie.Text = "Select Selfie"
        Me.btnSelectSelfie.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(119, 388)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(345, 14)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose the best selfie and then click the Select Selfie button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(224, 413)
        Me.lblConfirmation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(103, 14)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Thanks for voting"
        Me.lblConfirmation.Visible = False
        '
        'btnExitWindow
        '
        Me.btnExitWindow.Enabled = False
        Me.btnExitWindow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitWindow.Location = New System.Drawing.Point(220, 439)
        Me.btnExitWindow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExitWindow.Name = "btnExitWindow"
        Me.btnExitWindow.Size = New System.Drawing.Size(98, 30)
        Me.btnExitWindow.TabIndex = 8
        Me.btnExitWindow.Text = "Exit Window"
        Me.btnExitWindow.UseVisualStyleBackColor = True
        '
        'picConnect
        '
        Me.picConnect.Image = Global.Chapter2_Robert.Herbert.My.Resources.Resources.Selfie2
        Me.picConnect.Location = New System.Drawing.Point(298, 147)
        Me.picConnect.Margin = New System.Windows.Forms.Padding(2)
        Me.picConnect.Name = "picConnect"
        Me.picConnect.Size = New System.Drawing.Size(181, 180)
        Me.picConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picConnect.TabIndex = 4
        Me.picConnect.TabStop = False
        Me.picConnect.Visible = False
        '
        'picCheer
        '
        Me.picCheer.Image = Global.Chapter2_Robert.Herbert.My.Resources.Resources.Selfie1
        Me.picCheer.Location = New System.Drawing.Point(58, 147)
        Me.picCheer.Margin = New System.Windows.Forms.Padding(2)
        Me.picCheer.Name = "picCheer"
        Me.picCheer.Size = New System.Drawing.Size(181, 180)
        Me.picCheer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheer.TabIndex = 3
        Me.picCheer.TabStop = False
        Me.picCheer.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 527)
        Me.Controls.Add(Me.btnExitWindow)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnSelectSelfie)
        Me.Controls.Add(Me.picConnect)
        Me.Controls.Add(Me.picCheer)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnCheer)
        Me.Controls.Add(Me.lblHeading)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnCheer As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents picConnect As PictureBox
    Friend WithEvents btnSelectSelfie As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExitWindow As Button
    Friend WithEvents picCheer As PictureBox
End Class
