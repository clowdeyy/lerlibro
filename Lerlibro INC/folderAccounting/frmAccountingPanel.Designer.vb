<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountingPanel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountingPanel))
        Me.lblTime = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelMIS = New System.Windows.Forms.Panel()
        Me.btn = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.LightGray
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(911, 682)
        Me.lblTime.Multiline = True
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(413, 33)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "Time Here"
        Me.lblTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 35
        Me.BunifuElipse1.TargetControl = Me.panelMIS
        '
        'panelMIS
        '
        Me.panelMIS.BackColor = System.Drawing.SystemColors.Control
        Me.panelMIS.Location = New System.Drawing.Point(239, 82)
        Me.panelMIS.Name = "panelMIS"
        Me.panelMIS.Size = New System.Drawing.Size(1085, 589)
        Me.panelMIS.TabIndex = 6
        '
        'btn
        '
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn.FlatAppearance.BorderSize = 0
        Me.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral
        Me.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.ForeColor = System.Drawing.Color.White
        Me.btn.Location = New System.Drawing.Point(9, 170)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(188, 55)
        Me.btn.TabIndex = 4
        Me.btn.Text = "None"
        Me.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(9, 246)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(188, 55)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "    Log-out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.Black
        Me.sidePanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sidePanel.Location = New System.Drawing.Point(0, 170)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(10, 55)
        Me.sidePanel.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.sidePanel)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 749)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(197, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1173, 33)
        Me.Panel2.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 27)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(1025, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(143, 19)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Carlo Gatchalian"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer1
        '
        '
        'frmAccountingPanel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMIS)
        Me.Controls.Add(Me.lblTime)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAccountingPanel"
        Me.Text = "Ler Libro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTime As TextBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelMIS As Panel
    Friend WithEvents btn As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblName As Label
    Friend WithEvents Timer1 As Timer
End Class
