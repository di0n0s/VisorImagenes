<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarFoto
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
        Me.Label_Til_FotoQuieroVer = New System.Windows.Forms.Label()
        Me.TextBox_Get_Foto = New System.Windows.Forms.TextBox()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Til_FotoQuieroVer
        '
        Me.Label_Til_FotoQuieroVer.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Til_FotoQuieroVer.ForeColor = System.Drawing.Color.Transparent
        Me.Label_Til_FotoQuieroVer.Location = New System.Drawing.Point(17, 9)
        Me.Label_Til_FotoQuieroVer.Name = "Label_Til_FotoQuieroVer"
        Me.Label_Til_FotoQuieroVer.Size = New System.Drawing.Size(164, 44)
        Me.Label_Til_FotoQuieroVer.TabIndex = 14
        Me.Label_Til_FotoQuieroVer.Text = "Escribe el Número en Dígitos de la Foto de la Colección que Quieras Ver y Pulsa """ &
    "Aceptar"""
        Me.Label_Til_FotoQuieroVer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox_Get_Foto
        '
        Me.TextBox_Get_Foto.Location = New System.Drawing.Point(62, 77)
        Me.TextBox_Get_Foto.Name = "TextBox_Get_Foto"
        Me.TextBox_Get_Foto.Size = New System.Drawing.Size(77, 20)
        Me.TextBox_Get_Foto.TabIndex = 15
        Me.TextBox_Get_Foto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.Location = New System.Drawing.Point(62, 113)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 16
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'BuscarFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(193, 172)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.TextBox_Get_Foto)
        Me.Controls.Add(Me.Label_Til_FotoQuieroVer)
        Me.Name = "BuscarFoto"
        Me.Text = "Buscar Foto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Til_FotoQuieroVer As Label
    Friend WithEvents TextBox_Get_Foto As TextBox
    Friend WithEvents ButtonAceptar As Button
End Class
