<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BotonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(473, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(688, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(449, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(201, 83)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(126, 134)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(305, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 52)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccione tu usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(228, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Felipe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(473, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Maria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(706, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Gustavo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotonToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(839, 276)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(75, 24)
        Me.MenuStrip1.TabIndex = 8
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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(940, 348)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "apagar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BotonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApagarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
End Class
