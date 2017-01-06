Public Class BuscarFoto
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Try
            If IsNumeric(TextBox_Get_Foto.Text) Then
                VisorImagenes.numFoto = TextBox_Get_Foto.Text
                If (VisorImagenes.numFoto >= 1 And VisorImagenes.numFoto <= VisorImagenes.vGrande.Num_Fotos) Then
                    VisorImagenes.PictureBoxGrande.Image = VisorImagenes.vGrande.Get_Foto(VisorImagenes.numFoto - 1)
                    VisorImagenes.PictureBoxMiniatura.Image = VisorImagenes.vMiniatura.Get_Foto(VisorImagenes.numFoto - 1)
                    VisorImagenes.vGrande.Num_Actual = VisorImagenes.numFoto - 1
                    VisorImagenes.Label_Num_Foto_Actual.Text = VisorImagenes.vGrande.Num_Actual + 1 & "/" & VisorImagenes.vGrande.Num_Fotos
                Else
                    MsgBox("El número indicado no está dentro de la colección", MsgBoxStyle.Exclamation, "AVISO")
                End If
            Else
                MsgBox("No han indicado un número en dígitos", MsgBoxStyle.Exclamation, "AVISO")
                VisorImagenes.PictureBoxGrande.Image = VisorImagenes.vGrande.Foto_Actual()
                VisorImagenes.PictureBoxMiniatura.Image = VisorImagenes.vMiniatura.Foto_Actual()
                VisorImagenes.Label_Num_Foto_Actual.Text = VisorImagenes.vGrande.Num_Actual + 1 & "/" & VisorImagenes.vGrande.Num_Fotos
            End If
        Catch ex As Exception
            MsgBox("Todavía no se agregaron fotos a la colección", MsgBoxStyle.Exclamation, "AVISO")
        End Try
        Me.Close()
    End Sub
End Class