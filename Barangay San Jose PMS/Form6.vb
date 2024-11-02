Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click

        Me.Hide()
        Dim form8 As New Form8()
        form8.WindowState = Me.WindowState ' Set Form8's WindowState to the current form's WindowState
        form8.Size = Me.Size ' Optional: Set the size if the state is Normal
        form8.Location = Me.Location ' Optional: Set the location if the state is Normal

        form8.Show()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click

        Me.Hide()
        Dim form5 As New Form5()
        form5.WindowState = Me.WindowState ' Set Form5's WindowState to the current form's WindowState
        form5.Size = Me.Size ' Optional: Set the size if the state is Normal
        form5.Location = Me.Location ' Optional: Set the location if the state is Normal

        form5.Show()
    End Sub


    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click

        Me.Hide()
        Dim form10 As New Form10()
        form10.WindowState = Me.WindowState ' Set Form10's WindowState to the current form's WindowState
        form10.Size = Me.Size ' Optional: Set the size if the state is Normal
        form10.Location = Me.Location ' Optional: Set the location if the state is Normal

        form10.Show()
    End Sub
    Public Sub load_data()
        ' Connect to MongoDB
        Dim client = New MongoClient(conn.Server)
        Dim db = client.GetDatabase(conn.Db)
        Dim collectionEmployee = db.GetCollection(Of Employee)(conn.collectionEmployee)

        ' Retrieve all employees (no filtering criteria for now)
        Dim filter = Builders(Of Employee).Filter.Empty

        ' Optionally exclude ProfilePic from the data to avoid loading images in the grid
        Dim projection = Builders(Of Employee).Projection.Exclude("ProfilePic").Exclude("Fingerprint")

        ' Fetch the list of employees and project the fields (excluding ProfilePic)
        Dim listEmployee = collectionEmployee.Find(filter).Project(Of Employee)(projection).ToList()
        DataGridView1.DataSource = listEmployee
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        load_data()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to MongoDB
        Dim client = New MongoClient(conn.Server)
        Dim db = client.GetDatabase(conn.Db)
        Dim collectionEmployee = db.GetCollection(Of Employee)(conn.collectionEmployee)

        ' Retrieve all employees (no filtering criteria for now)
        Dim filter = Builders(Of Employee).Filter.Empty

        ' Optionally exclude ProfilePic from the data to avoid loading images in the grid
        Dim projection = Builders(Of Employee).Projection.Exclude("ProfilePic").Exclude("Fingerprint")

        ' Fetch the list of employees and project the fields (excluding ProfilePic)
        Dim listEmployee = collectionEmployee.Find(filter).Project(Of Employee)(projection).ToList()
    End Sub
End Class