
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
    public partial class fr_Proveedores : Form
    {
        public fr_Proveedores()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        Dictionary<string, string> d;
        private void barra1_click_guardar_button()
        {
            int a;
            bool error = false;
            db.empezar_transaccion();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre_proveedor", tx_Proveedor.Text);
            dict.Add("telefono_nombre_proveedor", tx_Telefono.Text);
            dict.Add("direccion_nombre_proveedor", tx_Direccion.Text);
            a=db.insertar("tbm_proveedor", dict);
            if (a == 0)
            {
                error = true;
            }
            db.terminar_transaccion(error);
        }

        private void barra1_click_nuevo_button()
        {
            d = db.consultar_un_registro("select MAX(idtbm_proveedor) as 'No' from tbm_proveedor");
            int nuevoregistro = 0;
            if (d["No"] != "")
            {
                nuevoregistro =Convert.ToInt32(d["No"]) + 1;                
            }
            else
            {
                nuevoregistro++;
                
            }
            tx_Registro.Text = nuevoregistro.ToString();

            
        }
    }
}
