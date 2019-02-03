<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUsers
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUsers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvwUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboQues = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAns = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnDel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.txtConfirm = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Administrators Account"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 10)
        Me.Panel1.TabIndex = 1
        '
        'lvwUsers
        '
        Me.lvwUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwUsers.FullRowSelect = True
        Me.lvwUsers.GridLines = True
        Me.lvwUsers.Location = New System.Drawing.Point(19, 97)
        Me.lvwUsers.Name = "lvwUsers"
        Me.lvwUsers.Size = New System.Drawing.Size(524, 473)
        Me.lvwUsers.TabIndex = 2
        Me.lvwUsers.UseCompatibleStateImageBehavior = False
        Me.lvwUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User ID"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Name"
        Me.ColumnHeader2.Width = 208
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Department"
        Me.ColumnHeader3.Width = 189
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "List of Administrators:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.cboDept)
        Me.GroupBox1.Controls.Add(Me.txtConfirm)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(549, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 473)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Configuration"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboQues)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAns)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forgot Password"
        '
        'cboQues
        '
        Me.cboQues.BackColor = System.Drawing.Color.Coral
        Me.cboQues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboQues.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQues.FormattingEnabled = True
        Me.cboQues.Items.AddRange(New Object() {"Accounting & Finance", "Human Resources", "Sales & Production"})
        Me.cboQues.Location = New System.Drawing.Point(89, 28)
        Me.cboQues.Name = "cboQues"
        Me.cboQues.Size = New System.Drawing.Size(329, 25)
        Me.cboQues.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(5, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Question:"
        '
        'txtAns
        '
        Me.txtAns.BorderColorFocused = System.Drawing.Color.Coral
        Me.txtAns.BorderColorIdle = System.Drawing.Color.OrangeRed
        Me.txtAns.BorderColorMouseHover = System.Drawing.Color.Coral
        Me.txtAns.BorderThickness = 1
        Me.txtAns.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAns.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAns.isPassword = False
        Me.txtAns.Location = New System.Drawing.Point(89, 59)
        Me.txtAns.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(329, 29)
        Me.txtAns.TabIndex = 7
        Me.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(9, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Answer:"
        '
        'btnSave
        '
        Me.btnSave.ActiveBorderThickness = 2
        Me.btnSave.ActiveCornerRadius = 30
        Me.btnSave.ActiveFillColor = System.Drawing.Color.Coral
        Me.btnSave.ActiveForecolor = System.Drawing.Color.White
        Me.btnSave.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSave.IdleBorderThickness = 2
        Me.btnSave.IdleCornerRadius = 30
        Me.btnSave.IdleFillColor = System.Drawing.Color.OrangeRed
        Me.btnSave.IdleForecolor = System.Drawing.Color.White
        Me.btnSave.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btnSave.Location = New System.Drawing.Point(414, 418)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 44)
        Me.btnSave.TabIndex = 8
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.ActiveBorderThickness = 2
        Me.btnEdit.ActiveCornerRadius = 30
        Me.btnEdit.ActiveFillColor = System.Drawing.Color.Coral
        Me.btnEdit.ActiveForecolor = System.Drawing.Color.White
        Me.btnEdit.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.ButtonText = "Edit"
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.IdleBorderThickness = 2
        Me.btnEdit.IdleCornerRadius = 30
        Me.btnEdit.IdleFillColor = System.Drawing.Color.OrangeRed
        Me.btnEdit.IdleForecolor = System.Drawing.Color.White
        Me.btnEdit.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btnEdit.Location = New System.Drawing.Point(312, 418)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(97, 44)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDel
        '
        Me.btnDel.ActiveBorderThickness = 2
        Me.btnDel.ActiveCornerRadius = 30
        Me.btnDel.ActiveFillColor = System.Drawing.Color.Coral
        Me.btnDel.ActiveForecolor = System.Drawing.Color.White
        Me.btnDel.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btnDel.BackColor = System.Drawing.SystemColors.Control
        Me.btnDel.BackgroundImage = CType(resources.GetObject("btnDel.BackgroundImage"), System.Drawing.Image)
        Me.btnDel.ButtonText = "Delete"
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDel.IdleBorderThickness = 2
        Me.btnDel.IdleCornerRadius = 30
        Me.btnDel.IdleFillColor = System.Drawing.Color.OrangeRed
        Me.btnDel.IdleForecolor = System.Drawing.Color.White
        Me.btnDel.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btnDel.Location = New System.Drawing.Point(211, 418)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(97, 44)
        Me.btnDel.TabIndex = 4
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.ActiveBorderThickness = 2
        Me.btnCancel.ActiveCornerRadius = 30
        Me.btnCancel.ActiveFillColor = System.Drawing.Color.Coral
        Me.btnCancel.ActiveForecolor = System.Drawing.Color.White
        Me.btnCancel.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.ButtonText = "Cancel"
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnCancel.IdleBorderThickness = 2
        Me.btnCancel.IdleCornerRadius = 30
        Me.btnCancel.IdleFillColor = System.Drawing.SystemColors.Control
        Me.btnCancel.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btnCancel.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.Location = New System.Drawing.Point(109, 418)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 44)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.ActiveBorderThickness = 2
        Me.btnAdd.ActiveCornerRadius = 30
        Me.btnAdd.ActiveFillColor = System.Drawing.Color.Coral
        Me.btnAdd.ActiveForecolor = System.Drawing.Color.White
        Me.btnAdd.ActiveLineColor = System.Drawing.Color.OrangeRed
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.ButtonText = "Add"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.IdleBorderThickness = 2
        Me.btnAdd.IdleCornerRadius = 30
        Me.btnAdd.IdleFillColor = System.Drawing.SystemColors.Control
        Me.btnAdd.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.btnAdd.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.btnAdd.Location = New System.Drawing.Point(8, 418)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 44)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboDept
        '
        Me.cboDept.BackColor = System.Drawing.Color.Coral
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDept.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Items.AddRange(New Object() {"Accounting & Finance", "Human Resources", "Sales & Production"})
        Me.cboDept.Location = New System.Drawing.Point(137, 78)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(329, 25)
        Me.cboDept.TabIndex = 1
        '
        'txtConfirm
        '
        Me.txtConfirm.BorderColorFocused = System.Drawing.Color.Coral
        Me.txtConfirm.BorderColorIdle = System.Drawing.Color.OrangeRed
        Me.txtConfirm.BorderColorMouseHover = System.Drawing.Color.Coral
        Me.txtConfirm.BorderThickness = 1
        Me.txtConfirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConfirm.isPassword = False
        Me.txtConfirm.Location = New System.Drawing.Point(181, 232)
        Me.txtConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(285, 29)
        Me.txtConfirm.TabIndex = 5
        Me.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPass
        '
        Me.txtPass.BorderColorFocused = System.Drawing.Color.Coral
        Me.txtPass.BorderColorIdle = System.Drawing.Color.OrangeRed
        Me.txtPass.BorderColorMouseHover = System.Drawing.Color.Coral
        Me.txtPass.BorderThickness = 1
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.isPassword = False
        Me.txtPass.Location = New System.Drawing.Point(137, 194)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(329, 29)
        Me.txtPass.TabIndex = 4
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUser
        '
        Me.txtUser.BorderColorFocused = System.Drawing.Color.Coral
        Me.txtUser.BorderColorIdle = System.Drawing.Color.OrangeRed
        Me.txtUser.BorderColorMouseHover = System.Drawing.Color.Coral
        Me.txtUser.BorderThickness = 1
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.isPassword = False
        Me.txtUser.Location = New System.Drawing.Point(137, 157)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(329, 29)
        Me.txtUser.TabIndex = 3
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtID
        '
        Me.txtID.BorderColorFocused = System.Drawing.Color.Coral
        Me.txtID.BorderColorIdle = System.Drawing.Color.OrangeRed
        Me.txtID.BorderColorMouseHover = System.Drawing.Color.Coral
        Me.txtID.BorderThickness = 1
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtID.isPassword = False
        Me.txtID.Location = New System.Drawing.Point(137, 41)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(329, 29)
        Me.txtID.TabIndex = 0
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtName
        '
        Me.txtName.BorderColorFocused = System.Drawing.Color.Coral
        Me.txtName.BorderColorIdle = System.Drawing.Color.OrangeRed
        Me.txtName.BorderColorMouseHover = System.Drawing.Color.Coral
        Me.txtName.BorderThickness = 1
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.isPassword = False
        Me.txtName.Location = New System.Drawing.Point(137, 116)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(329, 29)
        Me.txtName.TabIndex = 2
        Me.txtName.Tag = ""
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(30, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Confirm Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(30, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(30, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Username:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(30, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(30, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Full Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "User ID:"
        '
        'ucUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvwUsers)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucUsers"
        Me.Size = New System.Drawing.Size(1085, 589)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lvwUsers As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtConfirm As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboDept As ComboBox
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboQues As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAns As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
End Class
