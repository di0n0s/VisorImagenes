Imports Visor


Public Class VisorImagenes
    Public vGrande As VisorFoto = New VisorFoto(400, 300)
    Public vMiniatura As VisorFoto = New VisorFoto(147, 115)
    Public numFoto As Integer
    Dim arrastando As Boolean
    Dim offset As Point 'Esta variable asegura de que la posición relativa
    'del curso con respecto a la esquina del picturebox se mantiene constante

    Private Sub abrirColeccion()
        Abrir.ShowDialog()
        Try
            For Each ruta In Abrir.FileNames
                vGrande.Agregar_Foto(Bitmap.FromFile(ruta)) 'Agrega las fotos en el visor, pero hasta que no de la orden no se mostrara en el picturebox'
                vMiniatura.Agregar_Foto(Bitmap.FromFile(ruta))
            Next
            PictureBoxGrande.Image = vGrande.Foto_Actual()
            PictureBoxMiniatura.Image = vMiniatura.Foto_Actual()
            Label_Num_Foto_Actual.Text = vGrande.Num_Actual + 1 & "/" & vGrande.Num_Fotos
        Catch ex As Exception
            MsgBox("El archivo seleccionado no es una imagen", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub cerrar()
        If MessageBox.Show("¿Quieres cerrar el Visor de Imagenes?", "CERRANDO EL PROGRAMA...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub fotoSiguiente()
        Try
            vGrande.Next_Foto()
            PictureBoxGrande.Image = vGrande.Foto_Actual()
            Label_Num_Foto_Actual.Text = vGrande.Num_Actual + 1 & "/" & vGrande.Num_Fotos
            vMiniatura.Next_Foto()
            PictureBoxMiniatura.Image = vMiniatura.Foto_Actual()
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
    End Sub

    Private Sub fotoPrevia()
        Try
            vGrande.Prev_Foto()
            PictureBoxGrande.Image = vGrande.Foto_Actual()
            Label_Num_Foto_Actual.Text = vGrande.Num_Actual + 1 & "/" & vGrande.Num_Fotos
            vMiniatura.Prev_Foto()
            PictureBoxMiniatura.Image = vMiniatura.Foto_Actual()
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
    End Sub

    Private Sub rotarIzquierda()
        Try
            vGrande.rotar_antihor()
            PictureBoxGrande.Image = vGrande.Foto_Actual()
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
    End Sub

    Private Sub rotarDerecha()
        Try
            vGrande.rotar_hor()
            PictureBoxGrande.Image = vGrande.Foto_Actual()
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
    End Sub

    Private Sub zoomMenos()
        Try
            PictureBoxGrande.Image = vGrande.Zoom(0.75)
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
    End Sub

    Private Sub zoomMas()
        Try
            PictureBoxGrande.Image = vGrande.Zoom(1.25)
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
    End Sub

    Private Sub reestablecerZoom()
        Try
            PictureBoxGrande.Image = vGrande.Foto_Actual()
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
    End Sub


    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxGrande.MouseClick

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBoxGrande.MouseMove

        If arrastando = True Then
            PictureBoxGrande.Cursor = Cursors.Hand
            Dim x As Integer
            Dim y As Integer
            x = PictureBoxGrande.Location.X + e.X - offset.X 'Posicion de la imagen + movimiento del raton - la posición relativa del raton a la esquina
            y = PictureBoxGrande.Location.Y + e.Y - offset.Y
            PictureBoxGrande.Image = vGrande.Despl(x, y) 'Desplazar la imagen con el raton

        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxGrande.MouseDown
        arrastando = True
        offset = e.Location
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxGrande.MouseUp
        arrastando = False
    End Sub

    Private Sub Button_Prev_MouseEnter(sender As Object, e As EventArgs) Handles Button_Prev.MouseEnter
        Button_Prev.BackColor = Color.LightGray
    End Sub

    Private Sub Button_Prev_MouseLeave(sender As Object, e As EventArgs) Handles Button_Prev.MouseLeave
        Button_Prev.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub VisorImagenes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cerrar()
    End Sub

    Private Sub Button_Abrir_Click(sender As Object, e As EventArgs) Handles Button_Abrir.Click
        abrirColeccion()
    End Sub

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
        fotoSiguiente()
    End Sub

    Private Sub Button_Prev_Click(sender As Object, e As EventArgs) Handles Button_Prev.Click
        fotoPrevia()
    End Sub

    Private Sub Button_Rot_Izq_Click(sender As Object, e As EventArgs) Handles Button_Rot_Izq.Click
        rotarIzquierda()
    End Sub

    Private Sub Button_Rotar_Derecha_Click(sender As Object, e As EventArgs) Handles Button_Rotar_Derecha.Click
        rotarDerecha()
    End Sub

    Private Sub Button_Zoom_Menos_Click(sender As Object, e As EventArgs) Handles Button_Zoom_Menos.Click
        zoomMenos()
    End Sub

    Private Sub Button_Zoom_Mas_Click(sender As Object, e As EventArgs) Handles Button_Zoom_Mas.Click
        zoomMas()
    End Sub

    Private Sub Button_Zoom_Restablecer_Click(sender As Object, e As EventArgs) Handles Button_Zoom_Restablecer.Click
        reestablecerZoom()
    End Sub

    Private Sub Button_BuscarFoto_Click(sender As Object, e As EventArgs) Handles Button_BuscarFoto.Click
        BuscarFoto.ShowDialog()
    End Sub

    'Private Sub Button_Izq_Click(sender As Object, e As EventArgs) Handles Button_Izq.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(10, 0)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    'Private Sub Button_Derecha_Click(sender As Object, e As EventArgs) Handles Button_Derecha.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(-10, 0)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    'Private Sub Button_Arriba_Click(sender As Object, e As EventArgs) Handles Button_Arriba.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(0, 10)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    'Private Sub Button_Abajo_Click(sender As Object, e As EventArgs) Handles Button_Abajo.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(0, -10)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    'Private Sub Button_Arriba_Izq_Click(sender As Object, e As EventArgs) Handles Button_Arriba_Izq.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(10, 10)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    'Private Sub Button_Arriba_Drch_Click(sender As Object, e As EventArgs) Handles Button_Arriba_Drch.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(-10, 10)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    'Private Sub Button_Abajo_Izq_Click(sender As Object, e As EventArgs) Handles Button_Abajo_Izq.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(10, -10)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    'Private Sub Button_Abajo_Derecha_Click(sender As Object, e As EventArgs) Handles Button_Abajo_Derecha.Click
    '    Try
    '        PictureBoxGrande.Image = vGrande.Despl(-10, -10)
    '    Catch ex As Exception
    '        MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
    '    End Try
    'End Sub

    Private Sub BuscarFotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarFotoToolStripMenuItem.Click
        BuscarFoto.ShowDialog()
    End Sub

    Private Sub AbrirColecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirColecciónToolStripMenuItem.Click
        abrirColeccion()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        cerrar()
    End Sub

    Private Sub ZoomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem1.Click
        zoomMenos()
    End Sub

    Private Sub ZoomToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem2.Click
        zoomMas()
    End Sub

    Private Sub IzquierdaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IzquierdaToolStripMenuItem.Click
        rotarIzquierda()
    End Sub

    Private Sub DerechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DerechaToolStripMenuItem.Click
        rotarDerecha()
    End Sub

    Private Sub SiguienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiguienteToolStripMenuItem.Click
        fotoSiguiente()
    End Sub

    Private Sub PreviaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviaToolStripMenuItem.Click
        fotoPrevia()
    End Sub

    Private Sub ToolStripAbrir_Click(sender As Object, e As EventArgs) Handles ToolStripAbrir.Click
        abrirColeccion()
    End Sub

    Private Sub ToolStripBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBuscar.Click
        BuscarFoto.ShowDialog()
    End Sub

    Private Sub ToolStripAtras_Click(sender As Object, e As EventArgs) Handles ToolStripAtras.Click
        fotoPrevia()
    End Sub

    Private Sub ToolStripSiguiente_Click(sender As Object, e As EventArgs) Handles ToolStripSiguiente.Click
        fotoSiguiente()
    End Sub

    Private Sub ToolStripIzquierda_Click(sender As Object, e As EventArgs) Handles ToolStripIzquierda.Click
        rotarIzquierda()
    End Sub

    Private Sub ToolStripDerecha_Click(sender As Object, e As EventArgs) Handles ToolStripDerecha.Click
        rotarDerecha()
    End Sub

    Private Sub ToolStripMenos_Click(sender As Object, e As EventArgs) Handles ToolStripMenos.Click
        zoomMenos()
    End Sub

    Private Sub ToolStripMas_Click(sender As Object, e As EventArgs) Handles ToolStripMas.Click
        zoomMas()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        reestablecerZoom()
    End Sub

End Class
