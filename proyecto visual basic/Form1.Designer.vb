<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.TEXTBOX = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Gold
        Me.button2.Location = New System.Drawing.Point(122, 358)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(139, 55)
        Me.button2.TabIndex = 13
        Me.button2.Text = "ingresar nuevo cliente al sistema"
        Me.button2.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Blazed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Orange
        Me.label1.Location = New System.Drawing.Point(195, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(421, 67)
        Me.label1.TabIndex = 11
        Me.label1.Text = "GYM INSANO "
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Blazed", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Gold
        Me.button1.Location = New System.Drawing.Point(424, 177)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(139, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Registro del dia"
        Me.button1.UseVisualStyleBackColor = False
        '
        'TEXTBOX
        '
        Me.TEXTBOX.BackColor = System.Drawing.SystemColors.InfoText
        Me.TEXTBOX.Font = New System.Drawing.Font("Blazed", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEXTBOX.ForeColor = System.Drawing.Color.Gold
        Me.TEXTBOX.Location = New System.Drawing.Point(94, 142)
        Me.TEXTBOX.Multiline = True
        Me.TEXTBOX.Name = "TEXTBOX"
        Me.TEXTBOX.Size = New System.Drawing.Size(167, 74)
        Me.TEXTBOX.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.TEXTBOX)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Public WithEvents label1 As Label
    Private WithEvents button1 As Button
    Private WithEvents TEXTBOX As TextBox
End Class
