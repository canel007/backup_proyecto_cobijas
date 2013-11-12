/***************************************************************
FECHA: GUATEMALA 12 DE NOVIEMBRE 2013
CREADOR: GUILLERMO CANEL 0901-09-12084- UMG
DESCRIPCIÓN: FUNCIONES PARA LOS FORMULARIOS

***************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ODBCConnect;
using Navegador;
namespace Compras2
{
    class funciones
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
            retorno = string.Format(formato, "{0:0.0000}",suma);
            return retorno;
        }

        public String f1_sum_column(DataGridView dataGridView, String nombreColumna)
        {
            var formato = System.Globalization.CultureInfo.GetCultureInfo("es-GT");
            string retorno;
            double suma = 0;
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                String info = Convert.ToString(fila.Cells[nombreColumna].Value.ToString());
                suma = Convert.ToDouble(info) + suma;
            }
            retorno = string.Format(formato, "{0:0.0000}", suma);
            return retorno;
        }


        public void color_tabla(DataGridView datagridview)
        {
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }

        //**************************************************************************************************
        public void desactivarLibropaginas(TabControl libro)
        {
            foreach (TabPage pagina in libro.TabPages)
            {
                pagina.UseVisualStyleBackColor = false;
                pagina.BackColor = Color.Transparent;
            }
        }

        public void Letras(Form formulario)
        {
            foreach (Control controles in formulario.Controls)            
            {
                if (controles is DataGridView)
                {
                    controles.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                }
                else
                if ((controles is DateTimePicker))
                {
                    controles.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                }
                else
                if (!(controles is Barra))
                {
                 controles.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
            }
        }
        public void ActivarDesactivarControlesT(Control panel,String opcion)
        {
            if (opcion.Equals("D"))
            {
                foreach (Control controles in panel.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Enabled = false;
                        
                    }
                    if (controles is ComboBox)
                    {
                        controles.Enabled = false;
                    }
                    if (controles is DataGridView)
                    {
                        controles.Enabled = false;
                    }
                    if (controles is DateTimePicker)
                    {
                        controles.Enabled = false;
                    }
                    if (controles is Button)
                    {
                        controles.Enabled = false;
                    }
                }
            }
            else if (opcion.Equals("A"))
            {
                foreach (Control controles in panel.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Enabled = true;
                        
                    }
                    if (controles is ComboBox)
                    {
                        controles.Enabled = true;
                    }
                    if (controles is DataGridView)
                    {
                        controles.Enabled = true;
                    }
                    if (controles is DateTimePicker)
                    {
                        controles.Enabled = true;
                    }
                    if (controles is Button)
                    {
                        controles.Enabled = true;
                    }
                }
            }
        }




        //**************************************************************************************************
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



    