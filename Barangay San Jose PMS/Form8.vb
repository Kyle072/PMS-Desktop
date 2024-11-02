Public Class Form8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click

        Me.Hide()
        Form6.WindowState = Me.WindowState ' Set Form6's WindowState to the current form's WindowState
        Form6.Size = Me.Size ' Optional: Set the size if the state is Normal
        Form6.Location = Me.Location ' Optional: Set the location if the state is Normal

        Form6.Show()
    End Sub


    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click

        Me.Hide()
        Form10.WindowState = Me.WindowState ' Set Form10's WindowState to the current form's WindowState
        Form10.Size = Me.Size ' Optional: Set the size if the state is Normal
        Form10.Location = Me.Location ' Optional: Set the location if the state is Normal

        Form10.Show()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click

        Me.Hide()
        Dim form5 As New Form5()
        form5.WindowState = Me.WindowState ' Set Form5's WindowState to the current form's WindowState
        form5.Size = Me.Size ' Optional: Set the size if the state is Normal
        form5.Location = Me.Location ' Optional: Set the location if the state is Normal

        form5.Show()
    End Sub
End Class