'Program Name:              Selfie Selection
'developer:                 Robert Herbert
'Date:                      September 12, 2018
'Purpose:                   This application displays two selfies 
'                           (Cheer And Connect). The user can select a selfie




Public Class Form1
    Private Sub btnCheer_Click(sender As Object, e As EventArgs) Handles btnCheer.Click
        'This code is executed when the user taps or clicks the Finalist Cheer button. 
        'It displays the Cheer picture, Hides the Connect picture, and enables the
        'Select Selfie button

        picCheer.Visible = True           'Shows Cheer picture
        picConnect.Visible = False        'Hides Connect picture
        btnSelectSelfie.Enabled = True    'Enables Select Selfie button

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        'This code is executed when the user taps or clicks the Finalist Connect button. 
        'It displays the Cheer picture, Hides the Cheer picture, and enables the
        'Select Selfie button

        picConnect.Visible = True          'Shows Connect picture
        picCheer.Visible = False           'Hides Cheer picture
        btnSelectSelfie.Enabled = True     'Enables Select Selfie button

    End Sub

    Private Sub btnSelectSelfie_Click(sender As Object, e As EventArgs) Handles btnSelectSelfie.Click
        'This code is executed when the user taps or clicks the Select Selfie Button.
        'it disables the Cheer button, the Connect button, the Select Selfie button.
        'It hides the Instuctions lable, Displays the confirmation lable, and
        'enables the Exit Window button.

        btnConnect.Enabled = False         'Disables Connect button
        btnCheer.Enabled = False           'Disables Cheer button
        btnSelectSelfie.Enabled = False    'Disables Select Selfie button
        lblInstructions.Visible = False    'Hides Instuctions lable
        lblConfirmation.Visible = True     'Shows Confirmation lable
        btnExitWindow.Enabled = True       'Enables Exit Window button

    End Sub

    Private Sub btnExitWindow_Click(sender As Object, e As EventArgs) Handles btnExitWindow.Click
        'This code is executed when the user taps or clicks the Exit Window
        'Button. It closes the window and terminates the program execution.

        Close()
    End Sub
End Class
