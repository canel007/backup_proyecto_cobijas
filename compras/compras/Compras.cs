using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
using System.Collections;

namespace compras
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            iniciar();
            
        }
        DBConnect db = new DBConnect("cobijas");
        funciones_canel fun = new funciones_canel();
        DataGridViewColumn columna;
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }
        public void iniciar()
        {
            desactivar_master();
            //MASTEER
            //combo de tipo de compra
            cmbtipodecompra.DataSource = db.consulta_ComboBox("select idtbm_tipo_compra,nombre_tipo_compra from tbm_tipo_compra");
            cmbtipodecompra.DisplayMember = "nombre_tipo_compra";
            cmbtipodecompra.ValueMember = "idtbm_tipo_compra";            
            //combo de proveedor
            cmbproveedor.DataSource = db.consulta_ComboBox("select idtbm_proveedor,nombre_proveedor from tbm_proveedor");
            cmbproveedor.DisplayMember = "nombre_proveedor";
            cmbproveedor.ValueMember = "idtbm_proveedor";
            //combo de moneda
            cmbmoneda.DataSource = db.consulta_ComboBox("select idtbm_moneda,nombre_moneda from tbm_moneda");
            cmbmoneda.DisplayMember = "nombre_moneda";
            cmbmoneda.ValueMember = "idtbm_moneda";

            //combo de tipo de pago
            cmbtipopago.DataSource = db.consulta_ComboBox("select idtbm_tipo_pago,nombre_tipo_pago from tbm_tipo_pago");
            cmbtipopago.DisplayMember = "nombre_tipo_pago";
            cmbtipopago.ValueMember = "idtbm_tipo_pago";

            //combo de bodega
            cmbbodega.DataSource = db.consulta_ComboBox("select idtbm_bodega,nombre_bodega from tbm_bodega");
            cmbbodega.DisplayMember = "nombre_bodega";
            cmbbodega.ValueMember = "idtbm_bodega";
           
        }

       
        public void detalle(String tcompra)
        {
            tbldetalle.Columns.Clear();
          
            if (tcompra.Equals("Materia Prima"))
            {
                //String[] encabezados = { "nocompra", "idtbmbodega", "Fecha_compra", "idtbm_tipo_pago", "idtbm_moneda", "idtbm_tipo_compra", "idtbm_proveedor" };
                               
                //combo de producto
                cmbproducto.DataSource = db.consulta_ComboBox("select idtbm_producto,nombre_producto from tbm_producto");
                cmbproducto.DisplayMember = "nombre_producto";
                cmbproducto.ValueMember = "idtbm_producto"; 

                String[] encabezados = { " no_compra", " idbodega", "idproducto", "NOMBRE PRODUCTO", "CANTIDAD", "COSTO","TOTAL"};
                

                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false ; //convertirlo en false
                    tbldetalle.Columns.Add(columna);
                }
                
            }
            else if (tcompra.Equals("Producto Finalizado"))
            {
                //combo de producto               
                cmbproducto.DataSource = db.consulta_ComboBox("select idproducto_finalizado,nombre_producto_finalizado from producto_finalizado");
                cmbproducto.DisplayMember = "nombre_producto_finalizado";
                cmbproducto.ValueMember = "idproducto_finalizado";

                String[] encabezados = { "no_compra", " idbodega", "idproducto_finalizado", "NOMBRE PRODUCTO", "CANTIDAD", "PRECIO", "TOTAL" };
                

                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false; //convertirlo en false
                    tbldetalle.Columns.Add(columna);
                }
                  
            }
            else if(tcompra.Equals("Servicios Varios"))
            {
                //combo de producto
                cmbproducto.DataSource = db.consulta_ComboBox("select idtbm_servicio,nombre_servicio from tbm_servicio");
                cmbproducto.DisplayMember = "nombre_servicio";
                cmbproducto.ValueMember = "idtbm_servicio";

                String[] encabezados = { "no_compra", " idbodega", "idproducto", "NOMBRE PRODUCTO", "PRECIO" };
                

                for (int i = 0; i < encabezados.Length; i++)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.Name = encabezados[i];
                    if (i <= 2)
                        columna.Visible = false; //convertirlo en false
                    tbldetalle.Columns.Add(columna);
                }
               
            }
            
        }

        private void cmbtipodecompra_SelectedValueChanged(object sender, EventArgs e)
        {
            String  tipo_servicio = cmbtipodecompra.GetItemText(cmbtipodecompra.SelectedItem);
            detalle(tipo_servicio);
        }

        
        public void insertarPrincipal(int nocompra, int idbodega, string fecha, int idtipopago, int idmoneda, int idtipocompra, int idproveedor)
        {            
            tbldetalle.Rows.Add(nocompra, idbodega, fecha, idtipopago, idmoneda, idtipocompra, idproveedor);
        }

       //opcion 1-MATERIA PRIMA
        //opcion 2 PRODUCTO FINALIZADO
        //opcion 3 COMPRA DE SERVICIO

        public void insertar_detalle_materia_prima_y_finalizado(int opcion,int no_compra,int idbodega,int cantidad,int idproducto)
        {
            String query=null;
            if (opcion==1)
            query = "select nombre_producto as 'nombre', costo_producto as 'costo' from tbm_producto where idtbm_producto=" + idproducto;
            if(opcion==2)
            query = "select nombre_producto_finalizado as 'nombre', precio as 'costo' from producto_finalizado where idproducto_finalizado=" + idproducto;
            if(opcion==3)
            query = "select nombre_servicio as 'nombre' from tbm_servicio where idtbm_servicio=" + idproducto;

            String nombreProducto = null;
            String costo=null;
            
            ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dic in array)
            {
                nombreProducto=dic["nombre"];            
                costo = dic["costo"];                
            }
            double total = Convert.ToDouble(costo )* cantidad;
            tbldetalle.Rows.Add(no_compra, idbodega,idproducto,nombreProducto, cantidad,costo,total);
            int indice = tbldetalle.RowCount - 1;
            tbldetalle.FirstDisplayedScrollingRowIndex = indice;
        }

        public void insertar_detalle_servicio(int no_compra, int idbodega, int precio, int idproducto)
        {
           
            string query = "select nombre_servicio as 'nombre' from tbm_servicio where idtbm_servicio=" + idproducto;

            String nombreProducto = null;
            String costo = null;

            ArrayList array = db.consultar(query);
            foreach (Dictionary<string, string> dic in array)
            {
                nombreProducto = dic["nombre"];              
            }
            costo = txtcantidad.Text;
            double total = Convert.ToDouble(costo);
            tbldetalle.Rows.Add(no_compra, idbodega, idproducto, nombreProducto, total);
            int indice = tbldetalle.RowCount - 1;
            tbldetalle.FirstDisplayedScrollingRowIndex = indice;

        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //insertarPrincipal(cod_compra,id_bodega,"",idtipPago,id_moneda,tipocompra,idproveedor);
          Dictionary<string, string> dic = db.consultar_un_registro("select MAX(no_compra) as 'codigo' from tbm_compra");          
          int cod_compra  =Convert.ToInt32(dic["codigo"].ToString())+1; //incrementamos FOREIGN KEY
           
            int id_bodega=Convert.ToInt32(cmbbodega.SelectedValue.ToString());

            int idtipPago=Convert.ToInt32(cmbtipopago.SelectedValue.ToString());

            int id_moneda=Convert.ToInt32(cmbmoneda.SelectedValue.ToString());

            int tipocompra=Convert.ToInt32(cmbtipodecompra.SelectedValue.ToString());

            int idproveedor=Convert.ToInt32(cmbproveedor.SelectedValue.ToString());

            int idproducto=Convert.ToInt32(cmbproducto.SelectedValue.ToString());
            
            int cantidad = Convert.ToInt32(txtcantidad.Text);
       
            String tipo_compra = cmbtipodecompra.GetItemText(cmbtipodecompra.SelectedItem); //OBTENEMOS EL TIPO DE COMPRA


            if (tipo_compra.Equals("Materia Prima"))
            {
                insertar_detalle_materia_prima_y_finalizado(1,cod_compra, id_bodega, cantidad, idproducto);
            }
            else if (tipo_compra.Equals("Producto Finalizado"))
            {
                insertar_detalle_materia_prima_y_finalizado(2, cod_compra, id_bodega, cantidad, idproducto);
            }
            else if (tipo_compra.Equals("Servicios Varios"))
            {
                
                insertar_detalle_servicio(cod_compra, id_bodega, cantidad, idproducto);

            }
            else
            {
                // panelprimero.Visible = false;
            }



        }

        private void tbldetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            String tipo_compra = cmbtipodecompra.GetItemText(cmbtipodecompra.SelectedItem); //OBTENEMOS EL TIPO DE COMPRA
            if (tipo_compra.Equals("Materia Prima"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (tipo_compra.Equals("Producto Finalizado"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (tipo_compra.Equals("Servicios Varios"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "PRECIO");               

            }

        }

        private void tbldetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            String tipo_compra = cmbtipodecompra.GetItemText(cmbtipodecompra.SelectedItem); //OBTENEMOS EL TIPO DE COMPRA
            if (tipo_compra.Equals("Materia Prima"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (tipo_compra.Equals("Producto Finalizado"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "TOTAL");
            }
            else if (tipo_compra.Equals("Servicios Varios"))
            {
                txtsumatotal.Text = fun.f2_sum_column(tbldetalle, "PRECIO");
            }

            
        }

        private void barra1_click_guardar_button()
        {

            //Recordatorio
            //OBTENER LOS VALORES IMPORTANTES DE ARRIBA

            //RECORRER EL DATAGRIDVIEW 

            //********PARA LA INSERCION--.
        }

        private void tbldetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.fun.color_tabla(tbldetalle);
        }

        private void barra1_click_nuevo_button()
        {
            activar_master();
        }

        public void activar_master()
        {
            foreach (Control combo in panel1.Controls)
            {

                if (combo is ComboBox)
                {
                    combo.Enabled=true;

                }
                
            }

        }
        public void activar_detalle()
        {

        }
        public void desactivar_master()
        {
            foreach (Control combo in panel1.Controls)
            {

                if (combo is ComboBox)
                {
                    
                    combo.Enabled = false;
                }
            }

        }
        public void desactivar_detalle()
        {

        }
        
    }     
}

