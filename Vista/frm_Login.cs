using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashFlow.Tools;
using static CashFlow.Tools.Global;
using static CashFlow.Tools.Keyboard;
using CashFlow.Model.Repository;
using System.Configuration;
using static CashFlow.Model.Request;

namespace CashFlow.Vista
{
    public partial class frm_Login : Form
    {
        int ClickCount = 0;
        DataTable _Table;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_Enter(object sender, EventArgs e)
        {
            _Keyboard.Location = KeyboardProperties.NewPoint;
            _Keyboard.Show();
            Teclado_RecibirControl(Txt_User);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuTextBox1_Leave(object sender, EventArgs e)
        {
            _Keyboard.Hide();
        }

        private void bunifuTextBox2_Enter(object sender, EventArgs e)
        {
            _Keyboard.Location = KeyboardProperties.NewPoint;
            _Keyboard.Show();
            Teclado_RecibirControl(txt_contraseña);
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            _Keyboardtype = kbcustom.Tecladocontrol.TipoTeclado.NUMEROS;
            txt_contraseña.Select();
            ResetDesktopSize(txt_contraseña, new frm_Login());
            Txt_User.Focus();
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(e);
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {
            ClickCount += 1;
            if (ClickCount == 10)
            {
                _Keyboard.Hide();
                frm_Server frmConfigServer = new frm_Server();
                frmConfigServer.ShowDialog();
                if (Properties.Settings.Default.Conection==string.Empty)
                {
                    Application.Exit();                    
                }
                Txt_User.Focus();
            }
        }

        private void Txt_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(e);
        }


        void EnterKey(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ValidateForm())
                {
                    if (Login())
                    {
                        _Keyboard.Hide();
                        this.Close();
                        frm_Main frm = new frm_Main();
                        frm.ShowDialog();
                    }
                }
                else
                {

                    //
                }
            }
        }
        bool ValidateForm()
        {
            if (Txt_User.Text.Trim() != string.Empty && txt_contraseña.Text.Trim() != string.Empty)
            {
                return true;
            }
            else
            {
                if (Txt_User.Text == string.Empty)
                {
                    Txt_User.Focus();
                    return false;
                }
                if (txt_contraseña.Text == string.Empty)
                {
                    txt_contraseña.Focus();
                    return false;
                }
            }
            return false;
        }
        bool Login()
        {
            _Table = new DataTable();
            LoginRequest _Model = new LoginRequest { User = Convert.ToInt32(Txt_User.Text.Trim()) };
            _Table = LoginRepository.Usuarios_Read(_Model);
            if (GetSHA256(txt_contraseña.Text.Trim()) == _Table.Rows[0]["Contrasena_Usuario"].ToString())
            {
                return true;
            }
            else
            {

            }
            return false;
        }
    }
}
