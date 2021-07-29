<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Factura
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_rtn = New System.Windows.Forms.Label()
        Me.lbl_tel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_nofac = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_cajero = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_autorizar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.txtgarantia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtimpuesto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nueva_factura = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(302, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(73, 32)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "titulo"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion.Location = New System.Drawing.Point(302, 41)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(124, 32)
        Me.lbl_direccion.TabIndex = 1
        Me.lbl_direccion.Text = "direccion"
        '
        'lbl_rtn
        '
        Me.lbl_rtn.AutoSize = True
        Me.lbl_rtn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rtn.Location = New System.Drawing.Point(302, 73)
        Me.lbl_rtn.Name = "lbl_rtn"
        Me.lbl_rtn.Size = New System.Drawing.Size(70, 32)
        Me.lbl_rtn.TabIndex = 2
        Me.lbl_rtn.Text = "RTN"
        '
        'lbl_tel
        '
        Me.lbl_tel.AutoSize = True
        Me.lbl_tel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel.Location = New System.Drawing.Point(142, 119)
        Me.lbl_tel.Name = "lbl_tel"
        Me.lbl_tel.Size = New System.Drawing.Size(70, 32)
        Me.lbl_tel.TabIndex = 3
        Me.lbl_tel.Text = "RTN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(472, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Factura No."
        '
        'lbl_nofac
        '
        Me.lbl_nofac.AutoSize = True
        Me.lbl_nofac.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nofac.Location = New System.Drawing.Point(636, 119)
        Me.lbl_nofac.Name = "lbl_nofac"
        Me.lbl_nofac.Size = New System.Drawing.Size(70, 32)
        Me.lbl_nofac.TabIndex = 6
        Me.lbl_nofac.Text = "RTN"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(15, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------------------"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtcliente
        '
        Me.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcliente.Enabled = False
        Me.txtcliente.Location = New System.Drawing.Point(148, 174)
        Me.txtcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(119, 19)
        Me.txtcliente.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 174)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Cliente:"
        '
        'txtvendedor
        '
        Me.txtvendedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtvendedor.Enabled = False
        Me.txtvendedor.Location = New System.Drawing.Point(148, 204)
        Me.txtvendedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(119, 19)
        Me.txtvendedor.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 204)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Vendedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 235)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Tipo de Pago:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(148, 232)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(119, 26)
        Me.ComboBox1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 175)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Cajero:"
        '
        'lbl_cajero
        '
        Me.lbl_cajero.AutoSize = True
        Me.lbl_cajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cajero.Location = New System.Drawing.Point(423, 175)
        Me.lbl_cajero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cajero.Name = "lbl_cajero"
        Me.lbl_cajero.Size = New System.Drawing.Size(111, 18)
        Me.lbl_cajero.TabIndex = 32
        Me.lbl_cajero.Text = "Nombre cajero"
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.Location = New System.Drawing.Point(451, 205)
        Me.lbl_desc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(17, 18)
        Me.lbl_desc.TabIndex = 34
        Me.lbl_desc.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(356, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Descuento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(512, 204)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 18)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "%"
        '
        'btn_autorizar
        '
        Me.btn_autorizar.Location = New System.Drawing.Point(541, 202)
        Me.btn_autorizar.Name = "btn_autorizar"
        Me.btn_autorizar.Size = New System.Drawing.Size(79, 23)
        Me.btn_autorizar.TabIndex = 36
        Me.btn_autorizar.Text = "Autorizar"
        Me.btn_autorizar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(15, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(704, 23)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------------------"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(707, 150)
        Me.DataGridView1.TabIndex = 38
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(113, 443)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(95, 50)
        Me.btn_eliminar.TabIndex = 40
        Me.btn_eliminar.Text = "Eliminar Producto"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 443)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(95, 50)
        Me.btn_nuevo.TabIndex = 39
        Me.btn_nuevo.Text = "Agregar Producto"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'txtgarantia
        '
        Me.txtgarantia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtgarantia.Enabled = False
        Me.txtgarantia.Location = New System.Drawing.Point(349, 474)
        Me.txtgarantia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgarantia.Name = "txtgarantia"
        Me.txtgarantia.Size = New System.Drawing.Size(119, 19)
        Me.txtgarantia.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(371, 452)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Garantia:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Location = New System.Drawing.Point(635, 444)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(84, 19)
        Me.txtsubtotal.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(526, 445)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 18)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Sub Total:"
        '
        'txtdescuento
        '
        Me.txtdescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Location = New System.Drawing.Point(635, 471)
        Me.txtdescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(84, 19)
        Me.txtdescuento.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(526, 472)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 18)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Descuento:"
        '
        'txtimpuesto
        '
        Me.txtimpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtimpuesto.Enabled = False
        Me.txtimpuesto.Location = New System.Drawing.Point(635, 498)
        Me.txtimpuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtimpuesto.Name = "txtimpuesto"
        Me.txtimpuesto.Size = New System.Drawing.Size(84, 19)
        Me.txtimpuesto.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(526, 498)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 18)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Impuesto S/V:"
        '
        'txttotal
        '
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(635, 525)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(84, 19)
        Me.txttotal.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(526, 526)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 18)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Total:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Enabled = False
        Me.Label16.Location = New System.Drawing.Point(15, 548)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(704, 23)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------------------"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(249, 574)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(95, 50)
        Me.btn_guardar.TabIndex = 53
        Me.btn_guardar.Text = "Guardar e Imprimir"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_nueva_factura
        '
        Me.btn_nueva_factura.Location = New System.Drawing.Point(148, 574)
        Me.btn_nueva_factura.Name = "btn_nueva_factura"
        Me.btn_nueva_factura.Size = New System.Drawing.Size(95, 50)
        Me.btn_nueva_factura.TabIndex = 52
        Me.btn_nueva_factura.Text = "Nueva Factura"
        Me.btn_nueva_factura.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(451, 574)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(95, 50)
        Me.btn_salir.TabIndex = 55
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(350, 574)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(95, 50)
        Me.btn_cancelar.TabIndex = 54
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Frm_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 648)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nueva_factura)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtimpuesto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtgarantia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_autorizar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_cajero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nofac)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_tel)
        Me.Controls.Add(Me.lbl_rtn)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frm_Factura"
        Me.Text = "Frm_Factura"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents lbl_rtn As Label
    Friend WithEvents lbl_tel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_nofac As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtvendedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_cajero As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_autorizar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents txtgarantia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtimpuesto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_nueva_factura As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
End Class
