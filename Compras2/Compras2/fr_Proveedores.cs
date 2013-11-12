/***************************************************************
FECHA: GUATEMALA 12 DE NOVIEMBRE 2013
CREADOR: GUILLERMO CANEL 0901-09-12084- UMG

***************************************************************/
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
            fun.ActivarDesactivarControlesT(this.panel1,"D");
        }
        DBConnect db = new DBConnect(Properties.Settings.Default.odbc);
        Dictionary<string, string> d;
        funciones fun = new funciones();

        private void barra1_click_guardar_button()
        {
            
            db.empezar_transaccion();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre_proveedor", tx_Proveedor.Text);
            dict.Add("telefono_nombre_proveedor", tx_Telefono.Text);
            dict.Add("direccion_nombre_proveedor", tx_Direccion.Text);
            db.insertar("tbm_proveedor", dict);
        

            fun.ActivarDesactivarControlesT(panel1, "D");

        }

        private void barra1_click_nuevo_button()
        {
            fun.ActivarDesactivarControlesT(panel1, "A");
            tx_Registro.Enabled = false;

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
