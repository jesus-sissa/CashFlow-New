using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CashFlow.Tools.Keyboard;

namespace CashFlow.Tools
{
    public static class Global
    {
         
        public  struct KeyboardProperties
        {
            public static Size DesktopSize;
            public static int ScreenWidth;
            public static int ScreenHeight;
                    
            public static int LocationX;
            public static int LocationY;
            public static Point NewPoint;
        }
        public static void ResetKeyboardShape( Control Y )
        {
            // 1.- Siempre hay que mandar la forma del teclado si es la 1ra Vez.
            // 2.- Si se cambia la forma de teclado entoces se debe Redimensionar.
            // 3.- Enviar ancho y alto de nuevo monitor si se redimensiono.
            // 4.- SI el Teclado es el mismo solo Reubicar Posicion.
            if (_Keyboardtype != kbcustom.Tecladocontrol.TipoTeclado.NUMEROS)
            {
                _Keyboardtype = kbcustom.Tecladocontrol.TipoTeclado.NUMEROS;
                _Keyboard.RedimensionarForm(_Keyboardtype, KeyboardProperties.ScreenWidth, KeyboardProperties.ScreenHeight);
                _Keyboard.Size = new Size(_Keyboard.Width, _Keyboard.Height);
            }

            _Keyboard.formaTeclado = _Keyboardtype;
            KeyboardProperties.LocationX = KeyboardProperties.ScreenWidth - _Keyboard.Width; // Las 2 lineas son para centrarlos
            KeyboardProperties.LocationX = KeyboardProperties.LocationX / 2;

            KeyboardProperties.LocationY = Y.Location.Y + Y.Height + 10;
            KeyboardProperties.NewPoint = new Point(KeyboardProperties.LocationX, KeyboardProperties.LocationY);
            _Keyboard.Show();
        }

        public static  void ResetDesktopSize(Control Y,Form frm)
        {

            KeyboardProperties.DesktopSize = SystemInformation.PrimaryMonitorSize;
            KeyboardProperties.ScreenWidth = KeyboardProperties.DesktopSize.Width; // 1280
            KeyboardProperties.ScreenHeight = KeyboardProperties.DesktopSize.Height; // 1024            

            _Keyboard.RedimensionarForm(_Keyboardtype, KeyboardProperties.ScreenWidth, KeyboardProperties.ScreenHeight);
            _Keyboard.Size = new Size(_Keyboard.Width, _Keyboard.Height);

            KeyboardProperties.LocationX = KeyboardProperties.ScreenWidth - _Keyboard.Width; // Las 2 lineas son para centrarlos
            KeyboardProperties.LocationX = KeyboardProperties.LocationX / 2;
            KeyboardProperties.LocationY = Y.Location.Y + Y.Height + 10;
            KeyboardProperties.NewPoint = new Point(KeyboardProperties.LocationX, KeyboardProperties.LocationY);

            frm.Refresh();

            _Keyboard.Hide();
            _Keyboard.Show();
           // Y.Focus();
        }
        public static int Integer(object Value)
        {
            return Convert.ToInt32(Value.ToString());
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
