<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim ListViewItem1 As ListViewItem = New ListViewItem(New String() {"Tailer"}, -1, SystemColors.HotTrack, SystemColors.ControlLightLight, New Font("Segoe UI", 12F))
        Dim ListViewItem2 As ListViewItem = New ListViewItem(New String() {"Acteur"}, -1, SystemColors.HotTrack, Color.Empty, New Font("Segoe UI", 12F))
        Dim ListViewItem3 As ListViewItem = New ListViewItem(New String() {"Policier"}, -1, SystemColors.HotTrack, Color.Empty, New Font("Segoe UI", 12F))
        Dim ListViewItem4 As ListViewItem = New ListViewItem(New String() {"Juge"}, -1, SystemColors.HotTrack, Color.Empty, New Font("Segoe UI", 12F))
        Dim ListViewItem5 As ListViewItem = New ListViewItem(New String() {"Boucher"}, -1, SystemColors.HotTrack, Color.Empty, New Font("Segoe UI", 12F))
        Dim ListViewItem6 As ListViewItem = New ListViewItem(New String() {"Pilote"}, -1, SystemColors.HotTrack, Color.Empty, New Font("Segoe UI", 12F))
        Dim ListViewItem7 As ListViewItem = New ListViewItem(New String() {"Docteur"}, -1, SystemColors.HotTrack, Color.Empty, New Font("Segoe UI", 12F))
        btngo = New Button()
        txtFirstname = New TextBox()
        lblFirstname = New Label()
        Txtlastname = New TextBox()
        lblLastname = New Label()
        TxtGender = New TextBox()
        Lblgender = New Label()
        Lstoccupation = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        Lbloccupation = New Label()
        SuspendLayout()
        ' 
        ' btngo
        ' 
        btngo.BackColor = SystemColors.GradientActiveCaption
        btngo.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        btngo.Location = New Point(260, 346)
        btngo.Name = "btngo"
        btngo.Size = New Size(178, 92)
        btngo.TabIndex = 0
        btngo.Text = "Go"
        btngo.UseVisualStyleBackColor = False
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(294, 101)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(125, 27)
        txtFirstname.TabIndex = 1
        ' 
        ' lblFirstname
        ' 
        lblFirstname.AutoSize = True
        lblFirstname.BackColor = SystemColors.ActiveCaption
        lblFirstname.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        lblFirstname.Location = New Point(70, 101)
        lblFirstname.Name = "lblFirstname"
        lblFirstname.Size = New Size(187, 46)
        lblFirstname.TabIndex = 2
        lblFirstname.Text = "FirstName"
        ' 
        ' Txtlastname
        ' 
        Txtlastname.Location = New Point(294, 186)
        Txtlastname.Name = "Txtlastname"
        Txtlastname.Size = New Size(125, 27)
        Txtlastname.TabIndex = 3
        ' 
        ' lblLastname
        ' 
        lblLastname.AutoSize = True
        lblLastname.BackColor = SystemColors.ActiveCaption
        lblLastname.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        lblLastname.Location = New Point(67, 169)
        lblLastname.Name = "lblLastname"
        lblLastname.Size = New Size(190, 46)
        lblLastname.TabIndex = 4
        lblLastname.Text = "Last Name"
        ' 
        ' TxtGender
        ' 
        TxtGender.Location = New Point(294, 266)
        TxtGender.Name = "TxtGender"
        TxtGender.Size = New Size(125, 27)
        TxtGender.TabIndex = 5
        ' 
        ' Lblgender
        ' 
        Lblgender.AutoSize = True
        Lblgender.BackColor = SystemColors.ActiveCaption
        Lblgender.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        Lblgender.Location = New Point(67, 247)
        Lblgender.Name = "Lblgender"
        Lblgender.Size = New Size(134, 46)
        Lblgender.TabIndex = 6
        Lblgender.Text = "Gender"
        ' 
        ' Lstoccupation
        ' 
        Lstoccupation.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        Lstoccupation.Font = New Font("Segoe UI", 11F)
        ListViewItem1.ToolTipText = "Tailer"
        ListViewItem2.IndentCount = 1
        ListViewItem2.ToolTipText = "Acteur"
        ListViewItem3.IndentCount = 2
        ListViewItem3.ToolTipText = "Policier"
        ListViewItem4.IndentCount = 3
        ListViewItem4.ToolTipText = "Juge"
        ListViewItem5.IndentCount = 4
        ListViewItem5.ToolTipText = "Boucher"
        ListViewItem6.IndentCount = 5
        ListViewItem6.ToolTipText = "Pilote"
        ListViewItem7.IndentCount = 6
        ListViewItem7.ToolTipText = "Docteur"
        Lstoccupation.Items.AddRange(New ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
        Lstoccupation.Location = New Point(526, 81)
        Lstoccupation.Name = "Lstoccupation"
        Lstoccupation.Size = New Size(82, 333)
        Lstoccupation.TabIndex = 11
        Lstoccupation.UseCompatibleStateImageBehavior = False
        ' 
        ' Lbloccupation
        ' 
        Lbloccupation.AutoSize = True
        Lbloccupation.BackColor = SystemColors.ActiveCaption
        Lbloccupation.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Italic)
        Lbloccupation.Location = New Point(477, 9)
        Lbloccupation.Name = "Lbloccupation"
        Lbloccupation.Size = New Size(196, 46)
        Lbloccupation.TabIndex = 8
        Lbloccupation.Text = "occupation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Capture_d_écran_2025_11_17_184453
        ClientSize = New Size(1109, 450)
        Controls.Add(Lbloccupation)
        Controls.Add(Lstoccupation)
        Controls.Add(Lblgender)
        Controls.Add(TxtGender)
        Controls.Add(lblLastname)
        Controls.Add(Txtlastname)
        Controls.Add(lblFirstname)
        Controls.Add(txtFirstname)
        Controls.Add(btngo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btngo As Button
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents Txtlastname As TextBox
    Friend WithEvents lblLastname As Label
    Friend WithEvents TxtGender As TextBox
    Friend WithEvents Lblgender As Label
    Friend WithEvents Lstoccupation As ListView
    Friend WithEvents Lbloccupation As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader

End Class
