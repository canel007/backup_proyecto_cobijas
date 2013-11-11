using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBCConnect;
namespace Compras2
{
    public partial class fr_Compra_Servicio : Form
    {
        public fr_Compra_Servicio()
        {
            InitializeComponent();
            iniciar();
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);

        Dictionary<string, string> d = new Dictionary<string, string>();
        private void barra1_click_guardar_button()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            int bodega =Convert.ToInt32( cb_Bodega.SelectedValue.ToString());
            int concepto = Convert.ToInt32(cb_Concepto.SelectedValue.ToString());
            Console.WriteLine(bodega);
            Console.WriteLine(concepto);
            dic.Add("no_compra",tx_Orden.Text.ToString());
            dic.Add("idtbm_bodega",bodega.ToString());
            dic.Add("idtbm_servicio",concepto.ToString());
            dic.Add("costo", tx_Valor.Text.ToString());
            db.insertar("tbt_detalle_compra_servicio", dic);
            Dictionary<string, string> dic2 = new Dictionary<string, string>();
            dic2.Add("total_cuenta_por_pagar", tx_Valor.ToString());
            dic2.Add("fecha_emision", tx_Fechaactual.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            dic2.Add("fecha_vence", tx_Fechavence.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            dic2.Add("no_compra", tx_Orden.ToString());
            dic2.Add("idtbm_bodega", bodega.ToString());
            db.insertar("tbm_cuenta_por_pagar", dic2);

            

        }
        public void iniciar()
        {
            //proveedor
            cb_Proveedor.DataSource = db.consulta_ComboBox("select idtbm_proveedor,nombre_proveedor from tbm_proveedor");
            cb_Proveedor.DisplayMember = "nombre_proveedor";
            cb_Proveedor.ValueMember = "idtbm_proveedor";
            //concepto
            cb_Concepto.DataSource = db.consulta_ComboBox("select idtbm_servicio,nombre_servicio from tbm_servicio");
            cb_Concepto.DisplayMember = "nombre_servicio";
            cb_Concepto.ValueMember = "idtbm_servicio";

            cb_Bodega.DataSource = db.consulta_ComboBox("select idtbm_bodega,nombre_bodega from tbm_bodega");
            cb_Bodega.DisplayMember = "nombre_bodega";
            cb_Bodega.ValueMember = "idtbm_bodega";
        }

        private void barra1_click_nuevo_button()
        {

            d = db.consultar_un_registro("select MAX(no_compra) as 'No' from tbm_compra");
            int nuevoregistro = 0;
            if (d["No"] != "")
            {
                nuevoregistro = Convert.ToInt32(d["No"]) + 1;
            }
            else
            {
                nuevoregistro++;
            }
            tx_Orden.Text = nuevoregistro.ToString();
            d.Clear();
        }
    }
}
