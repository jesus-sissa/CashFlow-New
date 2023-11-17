using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CashFlow.Vista
{
    public partial class frm_Server : Form
    {
        public frm_Server()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_conexion.Text.Trim() != "")
            {
                Properties.Settings.Default.Conection = txt_conexion.Text.Trim();
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
