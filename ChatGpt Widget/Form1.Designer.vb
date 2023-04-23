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
        components = New ComponentModel.Container()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        input = New Guna.UI2.WinForms.Guna2TextBox()
        GunaPanel1 = New Guna.UI2.WinForms.Guna2Panel()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ExitToolStripMenuItem = New ToolStripMenuItem()
        btnAPI = New Guna.UI2.WinForms.Guna2Button()
        btnCopy = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        output = New RichTextBox()
        btn = New Guna.UI2.WinForms.Guna2Button()
        NotifyIcon1 = New NotifyIcon(components)
        GunaPanel1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.ShadowColor = Color.FromArgb(CByte(26), CByte(140), CByte(216))
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' input
        ' 
        input.BorderColor = Color.FromArgb(CByte(26), CByte(140), CByte(216))
        input.BorderRadius = 10
        input.CustomizableEdges = CustomizableEdges13
        input.DefaultText = ""
        input.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        input.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        input.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        input.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        input.FillColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        input.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        input.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        input.ForeColor = Color.White
        input.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        input.Location = New Point(12, 219)
        input.Name = "input"
        input.PasswordChar = ChrW(0)
        input.PlaceholderText = "Write a message"
        input.SelectedText = ""
        input.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        input.Size = New Size(504, 51)
        input.TabIndex = 0
        ' 
        ' GunaPanel1
        ' 
        GunaPanel1.BackColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        GunaPanel1.ContextMenuStrip = ContextMenuStrip1
        GunaPanel1.Controls.Add(btnAPI)
        GunaPanel1.Controls.Add(btnCopy)
        GunaPanel1.Controls.Add(Guna2Button3)
        GunaPanel1.Controls.Add(Guna2Button2)
        GunaPanel1.Controls.Add(Label1)
        GunaPanel1.CustomizableEdges = CustomizableEdges11
        GunaPanel1.Location = New Point(-90, -6)
        GunaPanel1.Name = "GunaPanel1"
        GunaPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        GunaPanel1.Size = New Size(690, 38)
        GunaPanel1.TabIndex = 1
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(94, 26)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.BackColor = Color.FromArgb(CByte(26), CByte(140), CByte(216))
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(93, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' btnAPI
        ' 
        btnAPI.BackColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btnAPI.BorderColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btnAPI.BorderRadius = 10
        btnAPI.CustomizableEdges = CustomizableEdges3
        btnAPI.DisabledState.BorderColor = Color.DarkGray
        btnAPI.DisabledState.CustomBorderColor = Color.DarkGray
        btnAPI.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAPI.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAPI.FillColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btnAPI.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAPI.ForeColor = Color.White
        btnAPI.Image = CType(resources.GetObject("btnAPI.Image"), Image)
        btnAPI.Location = New Point(130, 10)
        btnAPI.Name = "btnAPI"
        btnAPI.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnAPI.Size = New Size(26, 25)
        btnAPI.TabIndex = 5
        ' 
        ' btnCopy
        ' 
        btnCopy.Animated = True
        btnCopy.BackColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btnCopy.BorderRadius = 10
        btnCopy.CustomizableEdges = CustomizableEdges5
        btnCopy.DisabledState.BorderColor = Color.DarkGray
        btnCopy.DisabledState.CustomBorderColor = Color.DarkGray
        btnCopy.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCopy.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCopy.FillColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btnCopy.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCopy.ForeColor = Color.White
        btnCopy.HoverState.Image = My.Resources.Resources.icons8_coche_34
        btnCopy.Image = My.Resources.Resources.icons8_copie_32
        btnCopy.ImageAlign = HorizontalAlignment.Left
        btnCopy.Location = New Point(478, 10)
        btnCopy.Name = "btnCopy"
        btnCopy.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnCopy.Size = New Size(99, 25)
        btnCopy.TabIndex = 4
        btnCopy.Text = "Copy"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BackColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        Guna2Button3.BorderColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        Guna2Button3.BorderRadius = 10
        Guna2Button3.CustomizableEdges = CustomizableEdges7
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        Guna2Button3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button3.ForeColor = Color.White
        Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), Image)
        Guna2Button3.Location = New Point(95, 10)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button3.Size = New Size(29, 25)
        Guna2Button3.TabIndex = 4
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BackColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        Guna2Button2.BorderColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        Guna2Button2.BorderRadius = 10
        Guna2Button2.CustomizableEdges = CustomizableEdges9
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        Guna2Button2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), Image)
        Guna2Button2.Location = New Point(583, 8)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button2.Size = New Size(38, 27)
        Guna2Button2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(289, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 21)
        Label1.TabIndex = 0
        Label1.Text = "ChatGpt Widget"
        ' 
        ' output
        ' 
        output.BackColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        output.BorderStyle = BorderStyle.FixedSingle
        output.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        output.ForeColor = SystemColors.Window
        output.Location = New Point(12, 41)
        output.Name = "output"
        output.Size = New Size(504, 170)
        output.TabIndex = 2
        output.Text = ""
        ' 
        ' btn
        ' 
        btn.Animated = True
        btn.BackColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btn.BorderColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btn.BorderRadius = 10
        btn.CustomizableEdges = CustomizableEdges1
        btn.DisabledState.BorderColor = Color.DarkGray
        btn.DisabledState.CustomBorderColor = Color.DarkGray
        btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn.FillColor = Color.FromArgb(CByte(28), CByte(39), CByte(50))
        btn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btn.ForeColor = Color.White
        btn.Image = My.Resources.Resources.icons8_envoyer_49
        btn.Location = New Point(469, 227)
        btn.Name = "btn"
        btn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn.Size = New Size(38, 34)
        btn.TabIndex = 3
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "NotifyIcon1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(32), CByte(43))
        ClientSize = New Size(528, 280)
        ControlBox = False
        Controls.Add(btn)
        Controls.Add(output)
        Controls.Add(GunaPanel1)
        Controls.Add(input)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form1"
        GunaPanel1.ResumeLayout(False)
        GunaPanel1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents input As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents output As RichTextBox
    Friend WithEvents GunaPanel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCopy As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btnAPI As Guna.UI2.WinForms.Guna2Button
End Class
