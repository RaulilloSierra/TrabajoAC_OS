<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BotonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEntrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(446, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(455, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hola, María"
        '
        'Contraseña
        '
        Me.Contraseña.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Contraseña.Location = New System.Drawing.Point(455, 221)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Contraseña.PlaceholderText = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(135, 34)
        Me.Contraseña.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(824, 251)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(75, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BotonToolStripMenuItem
        '
        Me.BotonToolStripMenuItem.BackgroundImage = CType(resources.GetObject("BotonToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.BotonToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BotonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApagarToolStripMenuItem, Me.ReiniciarToolStripMenuItem})
        Me.BotonToolStripMenuItem.ForeColor = System.Drawing.Color.Transparent
        Me.BotonToolStripMenuItem.Image = CType(resources.GetObject("BotonToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BotonToolStripMenuItem.Name = "BotonToolStripMenuItem"
        Me.BotonToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.BotonToolStripMenuItem.Text = "Boton"
        '
        'ApagarToolStripMenuItem
        '
        Me.ApagarToolStripMenuItem.Name = "ApagarToolStripMenuItem"
        Me.ApagarToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ApagarToolStripMenuItem.Text = "Apagar"
        '
        'ReiniciarToolStripMenuItem
        '
        Me.ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        Me.ReiniciarToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ReiniciarToolStripMenuItem.Text = "Reiniciar"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEntrar.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(467, 263)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(105, 34)
        Me.btnEntrar.TabIndex = 10
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 348)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BotonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApagarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnEntrar As Button
End Class
