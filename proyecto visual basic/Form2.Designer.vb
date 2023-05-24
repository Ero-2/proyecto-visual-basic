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
        Me.button1 = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.button6 = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Telefonotextbox = New System.Windows.Forms.TextBox()
        Me.Edadtextbox = New System.Windows.Forms.TextBox()
        Me.Nombretextbox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Black
        Me.button1.ForeColor = System.Drawing.Color.Gold
        Me.button1.Location = New System.Drawing.Point(480, -31)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(234, 29)
        Me.button1.TabIndex = 37
        Me.button1.Text = "Guardar y Regresar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreData, Me.EdadData, Me.TelefonoData, Me.SaldoData, Me.FotoData, Me.CodigoData})
        Me.dataGridView1.Location = New System.Drawing.Point(351, 335)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(423, 180)
        Me.dataGridView1.TabIndex = 36
        '
        'NombreData
        '
        Me.NombreData.HeaderText = "Nombre"
        Me.NombreData.Name = "NombreData"
        '
        'EdadData
        '
        Me.EdadData.HeaderText = "Edad"
        Me.EdadData.Name = "EdadData"
        '
        'TelefonoData
        '
        Me.TelefonoData.HeaderText = "Telefono"
        Me.TelefonoData.Name = "TelefonoData"
        '
        'SaldoData
        '
        Me.SaldoData.HeaderText = "Saldo"
        Me.SaldoData.Name = "SaldoData"
        '
        'FotoData
        '
        Me.FotoData.HeaderText = "Foto"
        Me.FotoData.Name = "FotoData"
        '
        'CodigoData
        '
        Me.CodigoData.HeaderText = "Codigo"
        Me.CodigoData.Name = "CodigoData"
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.Black
        Me.button6.ForeColor = System.Drawing.Color.Gold
        Me.button6.Location = New System.Drawing.Point(61, 392)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(197, 67)
        Me.button6.TabIndex = 35
        Me.button6.Text = "REGISTRAR CLIENTE NUEVO"
        Me.button6.UseVisualStyleBackColor = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.Gold
        Me.label7.Location = New System.Drawing.Point(177, 325)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(25, 13)
        Me.label7.TabIndex = 34
        Me.label7.Text = "300"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Gold
        Me.label6.Location = New System.Drawing.Point(274, 325)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(31, 13)
        Me.label6.TabIndex = 33
        Me.label6.Text = "3200"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Gold
        Me.label5.Location = New System.Drawing.Point(47, 325)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(25, 13)
        Me.label5.TabIndex = 32
        Me.label5.Text = "100"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.button5.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.ForeColor = System.Drawing.Color.Gold
        Me.button5.Location = New System.Drawing.Point(250, 295)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(75, 24)
        Me.button5.TabIndex = 31
        Me.button5.Text = "AÑO"
        Me.button5.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.button4.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.ForeColor = System.Drawing.Color.Gold
        Me.button4.Location = New System.Drawing.Point(154, 295)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 23)
        Me.button4.TabIndex = 30
        Me.button4.Text = "MES"
        Me.button4.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.button3.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.Gold
        Me.button3.Location = New System.Drawing.Point(-3, 295)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(133, 23)
        Me.button3.TabIndex = 29
        Me.button3.Text = "SEMANA"
        Me.button3.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(404, 115)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(322, 199)
        Me.pictureBox1.TabIndex = 28
        Me.pictureBox1.TabStop = False
        '
        'button2
        '
        Me.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.button2.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Gold
        Me.button2.Location = New System.Drawing.Point(404, 73)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(322, 23)
        Me.button2.TabIndex = 27
        Me.button2.Text = "Tomar fotografia"
        Me.button2.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.label4.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gold
        Me.label4.Location = New System.Drawing.Point(121, 216)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(137, 13)
        Me.label4.TabIndex = 26
        Me.label4.Text = "TELEFONO"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Gold
        Me.label3.Location = New System.Drawing.Point(152, 115)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 13)
        Me.label3.TabIndex = 25
        Me.label3.Text = "EDAD"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Gold
        Me.label2.Location = New System.Drawing.Point(134, 20)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(109, 13)
        Me.label2.TabIndex = 24
        Me.label2.Text = "NOMBRE"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MineCrafter 3", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gold
        Me.label1.Location = New System.Drawing.Point(73, -31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(267, 34)
        Me.label1.TabIndex = 23
        Me.label1.Text = "REGISTRO INSANO"
        '
        'Telefonotextbox
        '
        Me.Telefonotextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Telefonotextbox.ForeColor = System.Drawing.Color.Gold
        Me.Telefonotextbox.Location = New System.Drawing.Point(79, 232)
        Me.Telefonotextbox.Name = "Telefonotextbox"
        Me.Telefonotextbox.Size = New System.Drawing.Size(220, 20)
        Me.Telefonotextbox.TabIndex = 22
        '
        'Edadtextbox
        '
        Me.Edadtextbox.BackColor = System.Drawing.SystemColors.InfoText
        Me.Edadtextbox.ForeColor = System.Drawing.Color.Gold
        Me.Edadtextbox.Location = New System.Drawing.Point(79, 131)
        Me.Edadtextbox.Name = "Edadtextbox"
        Me.Edadtextbox.Size = New System.Drawing.Size(220, 20)
        Me.Edadtextbox.TabIndex = 21
        '
        'Nombretextbox
        '
        Me.Nombretextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Nombretextbox.ForeColor = System.Drawing.Color.Gold
        Me.Nombretextbox.Location = New System.Drawing.Point(79, 39)
        Me.Nombretextbox.Name = "Nombretextbox"
        Me.Nombretextbox.Size = New System.Drawing.Size(220, 20)
        Me.Nombretextbox.TabIndex = 20
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.ForeColor = System.Drawing.Color.Gold
        Me.Button7.Location = New System.Drawing.Point(448, 20)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(234, 29)
        Me.Button7.TabIndex = 38
        Me.Button7.Text = "Guardar y Regresar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Telefonotextbox)
        Me.Controls.Add(Me.Edadtextbox)
        Me.Controls.Add(Me.Nombretextbox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents NombreData As DataGridViewTextBoxColumn
    Private WithEvents EdadData As DataGridViewTextBoxColumn
    Private WithEvents TelefonoData As DataGridViewTextBoxColumn
    Private WithEvents SaldoData As DataGridViewTextBoxColumn
    Private WithEvents FotoData As DataGridViewTextBoxColumn
    Private WithEvents CodigoData As DataGridViewTextBoxColumn
    Private WithEvents button6 As Button
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button2 As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Telefonotextbox As TextBox
    Private WithEvents Edadtextbox As TextBox
    Private WithEvents Nombretextbox As TextBox
    Private WithEvents Button7 As Button
End Class
