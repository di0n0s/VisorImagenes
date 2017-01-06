<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisorImagenes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisorImagenes))
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Label_Titulo_Num_Coleccion = New System.Windows.Forms.Label()
        Me.Label_Num_Fotos = New System.Windows.Forms.Label()
        Me.Label_Num_Foto_Actual = New System.Windows.Forms.Label()
        Me.Button_Zoom_Restablecer = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirColecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesDeVisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzquierdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DerechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiguienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripAbrir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripAtras = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripIzquierda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDerecha = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripMas = New System.Windows.Forms.ToolStripButton()
        Me.PictureBoxMiniatura = New System.Windows.Forms.PictureBox()
        Me.Button_BuscarFoto = New System.Windows.Forms.Button()
        Me.Button_Zoom_Mas = New System.Windows.Forms.Button()
        Me.Button_Zoom_Menos = New System.Windows.Forms.Button()
        Me.Button_Abrir = New System.Windows.Forms.Button()
        Me.Button_Rot_Izq = New System.Windows.Forms.Button()
        Me.Button_Rotar_Derecha = New System.Windows.Forms.Button()
        Me.Button_Prev = New System.Windows.Forms.Button()
        Me.Button_next = New System.Windows.Forms.Button()
        Me.PictureBoxGrande = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBoxMiniatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Abrir
        '
        Me.Abrir.FileName = "OpenFileDialog1"
        Me.Abrir.Filter = "Fotos|*.jpg; *.gif; *.png|Todo| *.*"
        Me.Abrir.Multiselect = True
        '
        'Label_Titulo_Num_Coleccion
        '
        Me.Label_Titulo_Num_Coleccion.AutoSize = True
        Me.Label_Titulo_Num_Coleccion.Location = New System.Drawing.Point(12, 23)
        Me.Label_Titulo_Num_Coleccion.Name = "Label_Titulo_Num_Coleccion"
        Me.Label_Titulo_Num_Coleccion.Size = New System.Drawing.Size(0, 13)
        Me.Label_Titulo_Num_Coleccion.TabIndex = 6
        '
        'Label_Num_Fotos
        '
        Me.Label_Num_Fotos.AutoSize = True
        Me.Label_Num_Fotos.Location = New System.Drawing.Point(64, 45)
        Me.Label_Num_Fotos.Name = "Label_Num_Fotos"
        Me.Label_Num_Fotos.Size = New System.Drawing.Size(0, 13)
        Me.Label_Num_Fotos.TabIndex = 7
        Me.Label_Num_Fotos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label_Num_Foto_Actual
        '
        Me.Label_Num_Foto_Actual.AutoSize = True
        Me.Label_Num_Foto_Actual.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Num_Foto_Actual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label_Num_Foto_Actual.Location = New System.Drawing.Point(510, 78)
        Me.Label_Num_Foto_Actual.Name = "Label_Num_Foto_Actual"
        Me.Label_Num_Foto_Actual.Size = New System.Drawing.Size(0, 19)
        Me.Label_Num_Foto_Actual.TabIndex = 9
        Me.Label_Num_Foto_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button_Zoom_Restablecer
        '
        Me.Button_Zoom_Restablecer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Zoom_Restablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Zoom_Restablecer.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Zoom_Restablecer.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_Zoom_Restablecer.Location = New System.Drawing.Point(482, 467)
        Me.Button_Zoom_Restablecer.Name = "Button_Zoom_Restablecer"
        Me.Button_Zoom_Restablecer.Size = New System.Drawing.Size(75, 34)
        Me.Button_Zoom_Restablecer.TabIndex = 12
        Me.Button_Zoom_Restablecer.Text = "100%"
        Me.Button_Zoom_Restablecer.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.OpcionesDeVisorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(883, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirColecciónToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'AbrirColecciónToolStripMenuItem
        '
        Me.AbrirColecciónToolStripMenuItem.Image = Global.VisorImagenes.My.Resources.Resources.bmp_formato_de_archivo_abierto
        Me.AbrirColecciónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.AbrirColecciónToolStripMenuItem.Name = "AbrirColecciónToolStripMenuItem"
        Me.AbrirColecciónToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirColecciónToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AbrirColecciónToolStripMenuItem.Text = "&Abrir Colección..."
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CerrarToolStripMenuItem.Text = "&Cerrar Programa"
        '
        'OpcionesDeVisorToolStripMenuItem
        '
        Me.OpcionesDeVisorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFotoToolStripMenuItem, Me.ZoomToolStripMenuItem, Me.RotarToolStripMenuItem, Me.CambiarFotoToolStripMenuItem})
        Me.OpcionesDeVisorToolStripMenuItem.Name = "OpcionesDeVisorToolStripMenuItem"
        Me.OpcionesDeVisorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.OpcionesDeVisorToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.OpcionesDeVisorToolStripMenuItem.Text = "&Opciones de Visor"
        '
        'BuscarFotoToolStripMenuItem
        '
        Me.BuscarFotoToolStripMenuItem.Image = Global.VisorImagenes.My.Resources.Resources.lupa_y_marca_de_ayuda__1_
        Me.BuscarFotoToolStripMenuItem.Name = "BuscarFotoToolStripMenuItem"
        Me.BuscarFotoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarFotoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BuscarFotoToolStripMenuItem.Text = "&Buscar Foto"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem1, Me.ZoomToolStripMenuItem2})
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ZoomToolStripMenuItem.Text = "&Zoom"
        '
        'ZoomToolStripMenuItem1
        '
        Me.ZoomToolStripMenuItem1.Image = Global.VisorImagenes.My.Resources.Resources.menos
        Me.ZoomToolStripMenuItem1.Name = "ZoomToolStripMenuItem1"
        Me.ZoomToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ZoomToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.ZoomToolStripMenuItem1.Text = "&Zoom -"
        '
        'ZoomToolStripMenuItem2
        '
        Me.ZoomToolStripMenuItem2.Image = Global.VisorImagenes.My.Resources.Resources.mas__1_1
        Me.ZoomToolStripMenuItem2.Name = "ZoomToolStripMenuItem2"
        Me.ZoomToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ZoomToolStripMenuItem2.Size = New System.Drawing.Size(155, 22)
        Me.ZoomToolStripMenuItem2.Text = "&Zoom +"
        '
        'RotarToolStripMenuItem
        '
        Me.RotarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IzquierdaToolStripMenuItem, Me.DerechaToolStripMenuItem})
        Me.RotarToolStripMenuItem.Name = "RotarToolStripMenuItem"
        Me.RotarToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RotarToolStripMenuItem.Text = "&Rotar Foto"
        '
        'IzquierdaToolStripMenuItem
        '
        Me.IzquierdaToolStripMenuItem.Image = Global.VisorImagenes.My.Resources.Resources.rotarizq64
        Me.IzquierdaToolStripMenuItem.Name = "IzquierdaToolStripMenuItem"
        Me.IzquierdaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.IzquierdaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.IzquierdaToolStripMenuItem.Text = "&Izquierda"
        '
        'DerechaToolStripMenuItem
        '
        Me.DerechaToolStripMenuItem.Image = Global.VisorImagenes.My.Resources.Resources.rotarderecha64
        Me.DerechaToolStripMenuItem.Name = "DerechaToolStripMenuItem"
        Me.DerechaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.DerechaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DerechaToolStripMenuItem.Text = "&Derecha"
        '
        'CambiarFotoToolStripMenuItem
        '
        Me.CambiarFotoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiguienteToolStripMenuItem, Me.PreviaToolStripMenuItem})
        Me.CambiarFotoToolStripMenuItem.Name = "CambiarFotoToolStripMenuItem"
        Me.CambiarFotoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CambiarFotoToolStripMenuItem.Text = "&Cambiar Foto"
        '
        'SiguienteToolStripMenuItem
        '
        Me.SiguienteToolStripMenuItem.Image = Global.VisorImagenes.My.Resources.Resources.derecha64
        Me.SiguienteToolStripMenuItem.Name = "SiguienteToolStripMenuItem"
        Me.SiguienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SiguienteToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SiguienteToolStripMenuItem.Text = "&Siguiente"
        '
        'PreviaToolStripMenuItem
        '
        Me.PreviaToolStripMenuItem.Image = Global.VisorImagenes.My.Resources.Resources.izquierda1
        Me.PreviaToolStripMenuItem.Name = "PreviaToolStripMenuItem"
        Me.PreviaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.PreviaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PreviaToolStripMenuItem.Text = "&Previa"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAbrir, Me.ToolStripBuscar, Me.ToolStripSeparator1, Me.ToolStripAtras, Me.ToolStripSiguiente, Me.ToolStripSeparator2, Me.ToolStripIzquierda, Me.ToolStripDerecha, Me.ToolStripSeparator4, Me.ToolStripMenos, Me.ToolStripButton4, Me.ToolStripMas})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(883, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripAbrir
        '
        Me.ToolStripAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripAbrir.Image = Global.VisorImagenes.My.Resources.Resources.bmp_formato_de_archivo_abierto
        Me.ToolStripAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAbrir.Name = "ToolStripAbrir"
        Me.ToolStripAbrir.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripAbrir.Text = "ToolStripButton1"
        Me.ToolStripAbrir.ToolTipText = "Seleccionar la Colección de Imagenes"
        '
        'ToolStripBuscar
        '
        Me.ToolStripBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBuscar.Image = Global.VisorImagenes.My.Resources.Resources.lupa_y_marca_de_ayuda__1_
        Me.ToolStripBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBuscar.Name = "ToolStripBuscar"
        Me.ToolStripBuscar.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripBuscar.Text = "ToolStripButton2"
        Me.ToolStripBuscar.ToolTipText = "Busca la foto de la colección que quieras"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripAtras
        '
        Me.ToolStripAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripAtras.Image = Global.VisorImagenes.My.Resources.Resources.izquierda
        Me.ToolStripAtras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAtras.Name = "ToolStripAtras"
        Me.ToolStripAtras.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripAtras.Text = "ToolStripButton1"
        Me.ToolStripAtras.ToolTipText = "Foto Previa"
        '
        'ToolStripSiguiente
        '
        Me.ToolStripSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSiguiente.Image = Global.VisorImagenes.My.Resources.Resources.derecha641
        Me.ToolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSiguiente.Name = "ToolStripSiguiente"
        Me.ToolStripSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripSiguiente.Text = "ToolStripButton1"
        Me.ToolStripSiguiente.ToolTipText = "Foto Siguiente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripIzquierda
        '
        Me.ToolStripIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripIzquierda.Image = Global.VisorImagenes.My.Resources.Resources.rotarizq64
        Me.ToolStripIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripIzquierda.Name = "ToolStripIzquierda"
        Me.ToolStripIzquierda.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripIzquierda.Text = "ToolStripButton1"
        Me.ToolStripIzquierda.ToolTipText = "Rotar izquierda"
        '
        'ToolStripDerecha
        '
        Me.ToolStripDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDerecha.Image = Global.VisorImagenes.My.Resources.Resources.rotarderecha64
        Me.ToolStripDerecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDerecha.Name = "ToolStripDerecha"
        Me.ToolStripDerecha.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripDerecha.Text = "ToolStripButton1"
        Me.ToolStripDerecha.ToolTipText = "Rotar Derecha"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripMenos
        '
        Me.ToolStripMenos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenos.Image = Global.VisorImagenes.My.Resources.Resources.menos
        Me.ToolStripMenos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMenos.Name = "ToolStripMenos"
        Me.ToolStripMenos.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripMenos.Text = "ToolStripButton3"
        Me.ToolStripMenos.ToolTipText = "Zoom -"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.ToolTipText = "Restablece el zoom al 100%"
        '
        'ToolStripMas
        '
        Me.ToolStripMas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMas.Image = Global.VisorImagenes.My.Resources.Resources.mas__1_1
        Me.ToolStripMas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMas.Name = "ToolStripMas"
        Me.ToolStripMas.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripMas.Text = "ToolStripButton5"
        Me.ToolStripMas.ToolTipText = "Zoom +"
        '
        'PictureBoxMiniatura
        '
        Me.PictureBoxMiniatura.Location = New System.Drawing.Point(15, 218)
        Me.PictureBoxMiniatura.Name = "PictureBoxMiniatura"
        Me.PictureBoxMiniatura.Size = New System.Drawing.Size(147, 115)
        Me.PictureBoxMiniatura.TabIndex = 24
        Me.PictureBoxMiniatura.TabStop = False
        '
        'Button_BuscarFoto
        '
        Me.Button_BuscarFoto.BackColor = System.Drawing.Color.Black
        Me.Button_BuscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_BuscarFoto.Image = Global.VisorImagenes.My.Resources.Resources.lupa_y_marca_de_ayuda__1_
        Me.Button_BuscarFoto.Location = New System.Drawing.Point(774, 419)
        Me.Button_BuscarFoto.Name = "Button_BuscarFoto"
        Me.Button_BuscarFoto.Size = New System.Drawing.Size(75, 73)
        Me.Button_BuscarFoto.TabIndex = 15
        Me.Button_BuscarFoto.UseVisualStyleBackColor = False
        '
        'Button_Zoom_Mas
        '
        Me.Button_Zoom_Mas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Zoom_Mas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Zoom_Mas.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Zoom_Mas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Zoom_Mas.Image = Global.VisorImagenes.My.Resources.Resources.signo_mas_en_un_cuadrado
        Me.Button_Zoom_Mas.Location = New System.Drawing.Point(647, 442)
        Me.Button_Zoom_Mas.Name = "Button_Zoom_Mas"
        Me.Button_Zoom_Mas.Size = New System.Drawing.Size(62, 66)
        Me.Button_Zoom_Mas.TabIndex = 11
        Me.Button_Zoom_Mas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_Zoom_Mas.UseVisualStyleBackColor = False
        '
        'Button_Zoom_Menos
        '
        Me.Button_Zoom_Menos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Zoom_Menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Zoom_Menos.Image = Global.VisorImagenes.My.Resources.Resources.menos
        Me.Button_Zoom_Menos.Location = New System.Drawing.Point(350, 467)
        Me.Button_Zoom_Menos.Name = "Button_Zoom_Menos"
        Me.Button_Zoom_Menos.Size = New System.Drawing.Size(72, 34)
        Me.Button_Zoom_Menos.TabIndex = 10
        Me.Button_Zoom_Menos.UseVisualStyleBackColor = True
        '
        'Button_Abrir
        '
        Me.Button_Abrir.BackColor = System.Drawing.Color.Black
        Me.Button_Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Abrir.Image = Global.VisorImagenes.My.Resources.Resources.bmp_formato_de_archivo_abierto
        Me.Button_Abrir.Location = New System.Drawing.Point(203, 419)
        Me.Button_Abrir.Name = "Button_Abrir"
        Me.Button_Abrir.Size = New System.Drawing.Size(89, 73)
        Me.Button_Abrir.TabIndex = 5
        Me.Button_Abrir.UseVisualStyleBackColor = False
        '
        'Button_Rot_Izq
        '
        Me.Button_Rot_Izq.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Rot_Izq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Rot_Izq.Image = Global.VisorImagenes.My.Resources.Resources.rotarizq64
        Me.Button_Rot_Izq.Location = New System.Drawing.Point(203, 267)
        Me.Button_Rot_Izq.Name = "Button_Rot_Izq"
        Me.Button_Rot_Izq.Size = New System.Drawing.Size(89, 75)
        Me.Button_Rot_Izq.TabIndex = 4
        Me.Button_Rot_Izq.UseVisualStyleBackColor = False
        '
        'Button_Rotar_Derecha
        '
        Me.Button_Rotar_Derecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Rotar_Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Rotar_Derecha.Image = CType(resources.GetObject("Button_Rotar_Derecha.Image"), System.Drawing.Image)
        Me.Button_Rotar_Derecha.Location = New System.Drawing.Point(762, 267)
        Me.Button_Rotar_Derecha.Name = "Button_Rotar_Derecha"
        Me.Button_Rotar_Derecha.Size = New System.Drawing.Size(87, 75)
        Me.Button_Rotar_Derecha.TabIndex = 3
        Me.Button_Rotar_Derecha.UseVisualStyleBackColor = False
        '
        'Button_Prev
        '
        Me.Button_Prev.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Prev.Image = Global.VisorImagenes.My.Resources.Resources.izquierda
        Me.Button_Prev.Location = New System.Drawing.Point(218, 175)
        Me.Button_Prev.Name = "Button_Prev"
        Me.Button_Prev.Size = New System.Drawing.Size(65, 52)
        Me.Button_Prev.TabIndex = 2
        Me.Button_Prev.UseVisualStyleBackColor = False
        '
        'Button_next
        '
        Me.Button_next.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_next.Image = CType(resources.GetObject("Button_next.Image"), System.Drawing.Image)
        Me.Button_next.Location = New System.Drawing.Point(762, 175)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(78, 52)
        Me.Button_next.TabIndex = 1
        Me.Button_next.UseVisualStyleBackColor = False
        '
        'PictureBoxGrande
        '
        Me.PictureBoxGrande.Location = New System.Drawing.Point(330, 122)
        Me.PictureBoxGrande.Name = "PictureBoxGrande"
        Me.PictureBoxGrande.Size = New System.Drawing.Size(400, 300)
        Me.PictureBoxGrande.TabIndex = 0
        Me.PictureBoxGrande.TabStop = False
        '
        'VisorImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(883, 541)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBoxMiniatura)
        Me.Controls.Add(Me.Button_BuscarFoto)
        Me.Controls.Add(Me.Button_Zoom_Restablecer)
        Me.Controls.Add(Me.Button_Zoom_Mas)
        Me.Controls.Add(Me.Button_Zoom_Menos)
        Me.Controls.Add(Me.Label_Num_Foto_Actual)
        Me.Controls.Add(Me.Label_Num_Fotos)
        Me.Controls.Add(Me.Label_Titulo_Num_Coleccion)
        Me.Controls.Add(Me.Button_Abrir)
        Me.Controls.Add(Me.Button_Rot_Izq)
        Me.Controls.Add(Me.Button_Rotar_Derecha)
        Me.Controls.Add(Me.Button_Prev)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.PictureBoxGrande)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VisorImagenes"
        Me.Text = "Visor de Fotos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBoxMiniatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxGrande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxGrande As PictureBox
    Friend WithEvents Abrir As OpenFileDialog
    Friend WithEvents Button_next As Button
    Friend WithEvents Button_Prev As Button
    Friend WithEvents Button_Rotar_Derecha As Button
    Friend WithEvents Button_Rot_Izq As Button
    Friend WithEvents Button_Abrir As Button
    Friend WithEvents Label_Titulo_Num_Coleccion As Label
    Friend WithEvents Label_Num_Fotos As Label
    Friend WithEvents Label_Num_Foto_Actual As Label
    Friend WithEvents Button_Zoom_Menos As Button
    Friend WithEvents Button_Zoom_Mas As Button
    Friend WithEvents Button_Zoom_Restablecer As Button
    Friend WithEvents Button_BuscarFoto As Button
    Friend WithEvents PictureBoxMiniatura As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirColecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesDeVisorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarFotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents IzquierdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DerechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarFotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiguienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreviaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripAbrir As ToolStripButton
    Friend WithEvents ToolStripBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripAtras As ToolStripButton
    Friend WithEvents ToolStripSiguiente As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripIzquierda As ToolStripButton
    Friend WithEvents ToolStripDerecha As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripMenos As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripMas As ToolStripButton
End Class
