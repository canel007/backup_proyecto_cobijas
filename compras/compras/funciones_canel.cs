using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace compras
{
    class funciones_canel
    {
       
        public String f2_sum_column(DataGridView dataGridView, String nombreColumna)
        {
           

            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            string retorno;
            double suma = 0;
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                String info = Convert.ToString(fila.Cells[nombreColumna].Value.ToString());
                suma = double.Parse(info, formato) + suma;
            }
            retorno = string.Format(formato, "{0:0.00}", suma);
            return retorno;
        }

        public void color_tabla(DataGridView datagridview)
        {
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }


        public int estado_insercion(Control panel)
        {
            int estado = 0; //no hay campos vacios

            foreach (Control caja in panel.Controls)
            {
                estado = 0;
                if (caja is TextBox)
                {
                    if (string.IsNullOrEmpty(caja.Text))
                    {
                        estado=1;
                        return 1;
                    }
                }
            }
            return estado;
        }

        public void activar_controles(Panel panel)
        {
            foreach (Control elemento in panel.Controls)
            {

                if (elemento is TextBox)
                {
                    elemento.Enabled = true;
                    elemento.Text = string.Empty;
                }
            }
        
        }


        public void desactivar_controles(Panel panel)
        {
            foreach (Control elemento in panel.Controls)
            {

                if (elemento is TextBox)
                {
                    elemento.Enabled = false;
                }
            }
        }

    }
}
