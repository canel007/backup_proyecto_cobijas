namespace Compras2
{
    partial class fr_Compras
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tx_Fecha = new System.Windows.Forms.DateTimePicker();
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.cb_Tipocompra = new System.Windows.Forms.ComboBox();
            this.cb_Proveedor = new System.Windows.Forms.ComboBox();
            this.cb_Tipopago = new System.Windows.Forms.ComboBox();
            this.cb_Bodega = new System.Windows.Forms.ComboBox();
            this.cb_Moneda = new System.Windows.Forms.ComboBox();
            this.lb_Tipocompra = new System.Windows.Forms.Label();
            this.lb_Proveedor = new System.Windows.Forms.Label();
            this.lb_tipopago = new System.Windows.Forms.Label();
            this.lb_Bodega = new System.Windows.Forms.Label();
            this.lb_Moneda = new System.Windows.Forms.Label();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tx_Nocompra = new System.Windows.Forms.TextBox();
            this.lb_nocompra = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Cantidad = new System.Windows.Forms.Label();
            this.lb_Producto = new System.Windows.Forms.Label();
            this.tx_Cantidad = new System.Windows.Forms.TextBox();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.dg_Detalle = new System.Windows.Forms.DataGridView();
            this.barra1 = new Navegador.Barra();
            this.tx_Total = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.tab_Contenedor1 = new System.Windows.Forms.TabControl();
            this.tab_Ingreso = new System.Windows.Forms.TabPage();
            this.tab_Consulta = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).BeginInit();
            this.tab_Contenedor1.SuspendLayout();
            this.tab_Ingreso.SuspendLayout();
            this.tab_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_Fecha
            // 
            this.tx_Fecha.Location = new System.Drawing.Point(78, 20);
            this.tx_Fecha.Name = "tx_Fecha";
            this.tx_Fecha.Size = new System.Drawing.Size(200, 20);
            this.tx_Fecha.TabIndex = 0;
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Location = new System.Drawing.Point(449, 4);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(63, 31);
            this.bt_Agregar.TabIndex = 1;
            this.bt_Agregar.Text = "Agregar";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // cb_Tipocompra
            // 
            this.cb_Tipocompra.FormattingEnabled = true;
            this.cb_Tipocompra.Items.AddRange(new object[] {
            "Materia Prima",
            "Producto Finalizado"});
            this.cb_Tipocompra.Location = new System.Drawing.Point(103, 58);
            this.cb_Tipocompra.Name = "cb_Tipocompra";
            this.cb_Tipocompra.Size = new System.Drawing.Size(175, 21);
            this.cb_Tipocompra.TabIndex = 2;
            this.cb_Tipocompra.SelectionChangeCommitted += new System.EventHandler(this.cb_Tipocompra_SelectionChangeCommitted);
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.Location = new System.Drawing.Point(103, 94);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.Size = new System.Drawing.Size(175, 21);
            this.cb_Proveedor.TabIndex = 3;
            // 
            // cb_Tipopago
            // 
            this.cb_Tipopago.FormattingEnabled = true;
            this.cb_Tipopago.Location = new System.Drawing.Point(103, 129);
            this.cb_Tipopago.Name = "cb_Tipopago";
            this.cb_Tipopago.Size = new System.Drawing.Size(175, 21);
            this.cb_Tipopago.TabIndex = 4;
            // 
            // cb_Bodega
            // 
            this.cb_Bodega.FormattingEnabled = true;
            this.cb_Bodega.Location = new System.Drawing.Point(383, 46);
            this.cb_Bodega.Name = "cb_Bodega";
            this.cb_Bodega.Size = new System.Drawing.Size(140, 21);
            this.cb_Bodega.TabIndex = 5;
            // 
            // cb_Moneda
            // 
            this.cb_Moneda.FormattingEnabled = true;
            this.cb_Moneda.Location = new System.Drawing.Point(383, 83);
            this.cb_Moneda.Name = "cb_Moneda";
            this.cb_Moneda.Size = new System.Drawing.Size(140, 21);
            this.cb_Moneda.TabIndex = 6;
            // 
            // lb_Tipocompra
            // 
            this.lb_Tipocompra.AutoSize = true;
            this.lb_Tipocompra.Location = new System.Drawing.Point(11, 61);
            this.lb_Tipocompra.Name = "lb_Tipocompra";
            this.lb_Tipocompra.Size = new System.Drawing.Size(82, 13);
            this.lb_Tipocompra.TabIndex = 7;
            this.lb_Tipocompra.Text = "Tipo de Compra";
            // 
            // lb_Proveedor
            // 
            this.lb_Proveedor.AutoSize = true;
            this.lb_Proveedor.Location = new System.Drawing.Point(34, 102);
            this.lb_Proveedor.Name = "lb_Proveedor";
            this.lb_Proveedor.Size = new System.Drawing.Size(56, 13);
            this.lb_Proveedor.TabIndex = 8;
            this.lb_Proveedor.Text = "Proveedor";
            // 
            // lb_tipopago
            // 
            this.lb_tipopago.AutoSize = true;
            this.lb_tipopago.Location = new System.Drawing.Point(34, 132);
            this.lb_tipopago.Name = "lb_tipopago";
            this.lb_tipopago.Size = new System.Drawing.Size(56, 13);
            this.lb_tipopago.TabIndex = 9;
            this.lb_tipopago.Text = "Tipo Pago";
            // 
            // lb_Bodega
            // 
            this.lb_Bodega.AutoSize = true;
            this.lb_Bodega.Location = new System.Drawing.Point(310, 49);
            this.lb_Bodega.Name = "lb_Bodega";
            this.lb_Bodega.Size = new System.Drawing.Size(44, 13);
            this.lb_Bodega.TabIndex = 10;
            this.lb_Bodega.Text = "Bodega";
            // 
            // lb_Moneda
            // 
            this.lb_Moneda.AutoSize = true;
            this.lb_Moneda.Location = new System.Drawing.Point(308, 86);
            this.lb_Moneda.Name = "lb_Moneda";
            this.lb_Moneda.Size = new System.Drawing.Size(46, 13);
            this.lb_Moneda.TabIndex = 11;
            this.lb_Moneda.Text = "Moneda";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(11, 26);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lb_Fecha.TabIndex = 12;
            this.lb_Fecha.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tx_Nocompra);
            this.panel1.Controls.Add(this.lb_nocompra);
            this.panel1.Controls.Add(this.tx_Fecha);
            this.panel1.Controls.Add(this.lb_Fecha);
            this.panel1.Controls.Add(this.cb_Tipocompra);
            this.panel1.Controls.Add(this.lb_Moneda);
            this.panel1.Controls.Add(this.cb_Proveedor);
            this.panel1.Controls.Add(this.lb_Bodega);
            this.panel1.Controls.Add(this.cb_Tipopago);
            this.panel1.Controls.Add(this.lb_tipopago);
            this.panel1.Controls.Add(this.cb_Bodega);
            this.panel1.Controls.Add(this.lb_Proveedor);
            this.panel1.Controls.Add(this.cb_Moneda);
            this.panel1.Controls.Add(this.lb_Tipocompra);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 167);
            this.panel1.TabIndex = 13;
            // 
            // tx_Nocompra
            // 
            this.tx_Nocompra.Enabled = false;
            this.tx_Nocompra.Location = new System.Drawing.Point(404, 17);
            this.tx_Nocompra.Name = "tx_Nocompra";
            this.tx_Nocompra.Size = new System.Drawing.Size(119, 20);
            this.tx_Nocompra.TabIndex = 14;
            // 
            // lb_nocompra
            // 
            this.lb_nocompra.AutoSize = true;
            this.lb_nocompra.Location = new System.Drawing.Point(298, 20);
            this.lb_nocompra.Name = "lb_nocompra";
            this.lb_nocompra.Size = new System.Drawing.Size(100, 13);
            this.lb_nocompra.TabIndex = 13;
            this.lb_nocompra.Text = "Orden de Compra #";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_Cantidad);
            this.panel2.Controls.Add(this.lb_Producto);
            this.panel2.Controls.Add(this.tx_Cantidad);
            this.panel2.Controls.Add(this.cb_Producto);
            this.panel2.Controls.Add(this.bt_Agregar);
            this.panel2.Location = new System.Drawing.Point(6, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 38);
            this.panel2.TabIndex = 14;
            // 
            // lb_Cantidad
            // 
            this.lb_Cantidad.AutoSize = true;
            this.lb_Cantidad.Location = new System.Drawing.Point(255, 13);
            this.lb_Cantidad.Name = "lb_Cantidad";
            this.lb_Cantidad.Size = new System.Drawing.Size(62, 13);
            this.lb_Cantidad.TabIndex = 4;
            this.lb_Cantidad.Text = "CANTIDAD";
            // 
            // lb_Producto
            // 
            this.lb_Producto.AutoSize = true;
            this.lb_Producto.Location = new System.Drawing.Point(3, 13);
            this.lb_Producto.Name = "lb_Producto";
            this.lb_Producto.Size = new System.Drawing.Size(50, 13);
            this.lb_Producto.TabIndex = 3;
            this.lb_Producto.Text = "Producto";
            // 
            // tx_Cantidad
            // 
            this.tx_Cantidad.Location = new System.Drawing.Point(325, 9);
            this.tx_Cantidad.Name = "tx_Cantidad";
            this.tx_Cantidad.Size = new System.Drawing.Size(118, 20);
            this.tx_Cantidad.TabIndex = 2;
            // 
            // cb_Producto
            // 
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(63, 9);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(186, 21);
            this.cb_Producto.TabIndex = 0;
            // 
            // dg_Detalle
            // 
            this.dg_Detalle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Detalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Detalle.Location = new System.Drawing.Point(0, 0);
            this.dg_Detalle.Name = "dg_Detalle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Detalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_Detalle.Size = new System.Drawing.Size(566, 209);
            this.dg_Detalle.TabIndex = 15;
            this.dg_Detalle.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dg_Detalle_RowsAdded);
            this.dg_Detalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_Detalle_RowsRemoved);
            // 
            // barra1
            // 
            this.barra1.BackColor = System.Drawing.Color.Transparent;
            this.barra1.Location = new System.Drawing.Point(3, 9);
            this.barra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(266, 42);
            this.barra1.TabIndex = 16;
            this.barra1.click_nuevo_button += new Navegador.Barra.delegadoButton(this.barra1_click_nuevo_button);
            this.barra1.click_guardar_button += new Navegador.Barra.delegadoButton(this.barra1_click_guardar_button);
            this.barra1.click_actualizar_button += new Navegador.Barra.delegadoButton(this.barra1_click_actualizar_button);
            // 
            // tx_Total
            // 
            this.tx_Total.Enabled = false;
            this.tx_Total.Location = new System.Drawing.Point(343, 438);
            this.tx_Total.Name = "tx_Total";
            this.tx_Total.Size = new System.Drawing.Size(100, 20);
            this.tx_Total.TabIndex = 17;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(261, 445);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(42, 13);
            this.lb_Total.TabIndex = 18;
            this.lb_Total.Text = "TOTAL";
            // 
            // tab_Contenedor1
            // 
            this.tab_Contenedor1.Controls.Add(this.tab_Ingreso);
            this.tab_Contenedor1.Controls.Add(this.tab_Consulta);
            this.tab_Contenedor1.Location = new System.Drawing.Point(12, 56);
            this.tab_Contenedor1.Name = "tab_Contenedor1";
            this.tab_Contenedor1.SelectedIndex = 0;
            this.tab_Contenedor1.Size = new System.Drawing.Size(586, 496);
            this.tab_Contenedor1.TabIndex = 19;
            // 
            // tab_Ingreso
            // 
            this.tab_Ingreso.Controls.Add(this.panel3);
            this.tab_Ingreso.Controls.Add(this.panel1);
            this.tab_Ingreso.Controls.Add(this.lb_Total);
            this.tab_Ingreso.Controls.Add(this.panel2);
            this.tab_Ingreso.Controls.Add(this.tx_Total);
            this.tab_Ingreso.Location = new System.Drawing.Point(4, 22);
            this.tab_Ingreso.Name = "tab_Ingreso";
            this.tab_Ingreso.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ingreso.Size = new System.Drawing.Size(578, 470);
            this.tab_Ingreso.TabIndex = 0;
            this.tab_Ingreso.Text = "Ingresos";
            this.tab_Ingreso.UseVisualStyleBackColor = true;
            // 
            // tab_Consulta
            // 
            this.tab_Consulta.Controls.Add(this.dataGridView1);
            this.tab_Consulta.Location = new System.Drawing.Point(4, 22);
            this.tab_Consulta.Name = "tab_Consulta";
            this.tab_Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Consulta.Size = new System.Drawing.Size(542, 470);
            this.tab_Consulta.TabIndex = 1;
            this.tab_Consulta.Text = "Consulta";
            this.tab_Consulta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dg_Detalle);
            this.panel3.Location = new System.Drawing.Point(6, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 209);
            this.panel3.TabIndex = 19;
            // 
            // fr_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 554);
            this.Controls.Add(this.tab_Contenedor1);
            this.Controls.Add(this.barra1);
            this.Name = "fr_Compras";
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).EndInit();
            this.tab_Contenedor1.ResumeLayout(false);
            this.tab_Ingreso.ResumeLayout(false);
            this.tab_Ingreso.PerformLayout();
            this.tab_Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tx_Fecha;
        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.ComboBox cb_Tipocompra;
        private System.Windows.Forms.ComboBox cb_Proveedor;
        private System.Windows.Forms.ComboBox cb_Tipopago;
        private System.Windows.Forms.ComboBox cb_Bodega;
        private System.Windows.Forms.ComboBox cb_Moneda;
        private System.Windows.Forms.Label lb_Tipocompra;
        private System.Windows.Forms.Label lb_Proveedor;
        private System.Windows.Forms.Label lb_tipopago;
        private System.Windows.Forms.Label lb_Bodega;
        private System.Windows.Forms.Label lb_Moneda;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.TextBox tx_Cantidad;
        private System.Windows.Forms.DataGridView dg_Detalle;
        private Navegador.Barra barra1;
        private System.Windows.Forms.TextBox tx_Nocompra;
        private System.Windows.Forms.Label lb_nocompra;
        private System.Windows.Forms.TextBox tx_Total;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lb_Cantidad;
        private System.Windows.Forms.Label lb_Producto;
        private System.Windows.Forms.TabControl tab_Contenedor1;
        private System.Windows.Forms.TabPage tab_Ingreso;
        private System.Windows.Forms.TabPage tab_Consulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
    }
}

