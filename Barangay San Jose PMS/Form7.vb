Imports System.Drawing.Imaging
Imports System.IO

Public Class Form7
    Private fingerprintHandler As New FingerprintHandler()

    Public Sub New()
        ' Initialize components and event handlers
        InitializeComponent()
        AddHandler fingerprintHandler.FingerprintCaptured, AddressOf OnFingerprintCaptured
        AddHandler fingerprintHandler.FingerprintReaderStatus, AddressOf OnFingerprintReaderStatus
    End Sub

    Private Sub StartFingerprintCapture()
        fingerprintHandler.StartCapture()
    End Sub

    ' Event handler for the Capture Fingerprint button
    Private Sub BtnCaptureFingerprint_Click(sender As Object, e As EventArgs) Handles btnCaptureFingerprint.Click
        StartFingerprintCapture() ' Start the fingerprint capture process
    End Sub

    Private Sub OnFingerprintCaptured(ByVal fingerprintImage As Bitmap, ByVal templateBytes As Byte())
        ' Check if the fingerprint image is not null
        If fingerprintImage IsNot Nothing Then
            pbFingerprint.Image = fingerprintImage ' Set the captured fingerprint image to the PictureBox
            Me.FingerprintTemplateBytes = templateBytes ' Store the template bytes for later use
            MessageBox.Show("Fingerprint captured successfully and displayed.") ' Debug message
        Else
            MessageBox.Show("Captured fingerprint image is null.") ' Debug message
        End If

        fingerprintHandler.StopCapture() ' Stop capturing after a fingerprint is captured
    End Sub

    Private Sub OnFingerprintReaderStatus(ByVal message As String)
        MessageBox.Show(message)
    End Sub

    Private Function ConvertBitmapToByteArray(bitmap As Bitmap) As Byte()
        Using ms As New MemoryStream()
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp) ' Save as BMP
            Return ms.ToArray()
        End Using
    End Function

    ' Stores the employee data in MongoDB
    Public Sub StoreUserWithFingerprint()
        Try
            Dim conStore = conn.OpenCollectionEmployee()
            Dim employee As New Employee With {
                .LastName = txtLastName.Text,
                .FirstName = txtFirstName.Text,
                .MiddleName = txtMiddleName.Text,
                .EmployeeId = txtEmployeeID.Text,
                .Birthday = txtBirthday.Text,
                .Age = txtAge.Text,
                .Sex = cbSex.Text,
                .Status = cbStatus.Text,
                .Address = txtAddress.Text,
                .PhoneNum = txtPhoneNum.Text,
                .TelNum = txtTelNum.Text,
                .Position = cbPosition.Text,
                .BasicRate = cbBasicRate.Text,
                .SSS = cbSSS.Text,
                .TimeIn = txtTimeIn.Text,
                .TimeOut = txtTimeOut.Text,
                .ProfilePic = ConvertImageToByteArray(pbProfilePic.Image),
                .Fingerprint = Me.FingerprintTemplateBytes ' Use the stored fingerprint template bytes
            }

            conStore.InsertOne(employee)
            MessageBox.Show("User data with fingerprint successfully saved to MongoDB!")
        Catch ex As Exception
            MessageBox.Show("Error saving data to MongoDB: " & ex.Message)
        End Try
    End Sub

    ' Converts an Image to a Byte Array for MongoDB storage
    Private Function ConvertImageToByteArray(image As Image) As Byte()
        Try
            Using ms As New MemoryStream()
                image.Save(ms, ImageFormat.Png)
                Return ms.ToArray()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error converting image: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Validates that all required fields are filled
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrEmpty(txtLastName.Text) OrElse
           String.IsNullOrEmpty(txtFirstName.Text) OrElse
           String.IsNullOrEmpty(txtMiddleName.Text) OrElse
           String.IsNullOrEmpty(txtEmployeeID.Text) OrElse
           String.IsNullOrEmpty(txtBirthday.Text) OrElse
           String.IsNullOrEmpty(txtAge.Text) OrElse
           String.IsNullOrEmpty(cbSex.Text) OrElse
           String.IsNullOrEmpty(cbStatus.Text) OrElse
           String.IsNullOrEmpty(txtAddress.Text) OrElse
           String.IsNullOrEmpty(txtPhoneNum.Text) OrElse
           String.IsNullOrEmpty(txtTelNum.Text) OrElse
           String.IsNullOrEmpty(cbPosition.Text) OrElse
           String.IsNullOrEmpty(cbBasicRate.Text) OrElse
           String.IsNullOrEmpty(cbSSS.Text) OrElse
           String.IsNullOrEmpty(txtTimeIn.Text) OrElse
           String.IsNullOrEmpty(txtTimeOut.Text) OrElse
           pbProfilePic.Image Is Nothing OrElse
           pbFingerprint.Image Is Nothing Then
            Return False
        End If
        Return True
    End Function

    ' Saves the data when the Save button is clicked
    Public Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateInputs() Then
            Try
                StoreUserWithFingerprint() ' Store user data along with fingerprint
                clearform() ' Clear the form after saving
                Form6.load_data()
            Catch ex As Exception
                MessageBox.Show("Error while saving: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please fill in all the required fields.")
        End If
    End Sub

    Private Sub clearform()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtEmployeeID.Clear()
        txtBirthday.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        txtPhoneNum.Clear()
        txtTelNum.Clear()
        txtTimeIn.Clear()
        txtTimeOut.Clear()

        ' Reset comboboxes
        cbSex.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        cbPosition.SelectedIndex = -1
        cbBasicRate.SelectedIndex = -1
        cbSSS.SelectedIndex = -1

        ' Clear picture boxes
        pbProfilePic.Image = Nothing
        pbFingerprint.Image = Nothing ' Clear the fingerprint PictureBox
    End Sub

    ' Opens a file dialog to select and load an image for the profile picture
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                pbProfilePic.Image = Image.FromFile(openFileDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try
    End Sub

    ' Field to store fingerprint template bytes for later use
    Private FingerprintTemplateBytes As Byte()
End Class
