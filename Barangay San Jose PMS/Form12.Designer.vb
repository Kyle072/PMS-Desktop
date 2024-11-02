<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form12))
        MenuStrip1 = New MenuStrip()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem1 = New ToolStripMenuItem()
        AddNewEmployeeToolStripMenuItem = New ToolStripMenuItem()
        AttendanceToolStripMenuItem = New ToolStripMenuItem()
        PayrollToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.IndianRed
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EmployeeToolStripMenuItem, EmployeeToolStripMenuItem1, AttendanceToolStripMenuItem, PayrollToolStripMenuItem, LogOutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1247, 26)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.BackColor = Color.IndianRed
        EmployeeToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        EmployeeToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(101, 22)
        EmployeeToolStripMenuItem.Text = "Dashboard"
        ' 
        ' EmployeeToolStripMenuItem1
        ' 
        EmployeeToolStripMenuItem1.BackColor = Color.IndianRed
        EmployeeToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AddNewEmployeeToolStripMenuItem})
        EmployeeToolStripMenuItem1.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        EmployeeToolStripMenuItem1.Name = "EmployeeToolStripMenuItem1"
        EmployeeToolStripMenuItem1.Size = New Size(94, 22)
        EmployeeToolStripMenuItem1.Text = "Employee"
        ' 
        ' AddNewEmployeeToolStripMenuItem
        ' 
        AddNewEmployeeToolStripMenuItem.Name = "AddNewEmployeeToolStripMenuItem"
        AddNewEmployeeToolStripMenuItem.Size = New Size(232, 26)
        AddNewEmployeeToolStripMenuItem.Text = "Add new Employee"
        ' 
        ' AttendanceToolStripMenuItem
        ' 
        AttendanceToolStripMenuItem.BackColor = Color.IndianRed
        AttendanceToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        AttendanceToolStripMenuItem.Size = New Size(106, 22)
        AttendanceToolStripMenuItem.Text = "Attendance"
        ' 
        ' PayrollToolStripMenuItem
        ' 
        PayrollToolStripMenuItem.BackColor = Color.Firebrick
        PayrollToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PayrollToolStripMenuItem.ForeColor = SystemColors.Info
        PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        PayrollToolStripMenuItem.Size = New Size(71, 22)
        PayrollToolStripMenuItem.Text = "Payroll"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.BackColor = Color.IndianRed
        LogOutToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(82, 22)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(890, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(293, 18)
        Label2.TabIndex = 10
        Label2.Text = "Baranagay Payroll Management System"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.LOGO_removebg_preview
        PictureBox2.Location = New Point(1189, 28)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(55, 52)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1247, 655)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form12"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payslip"
        TransparencyKey = Color.Transparent
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
