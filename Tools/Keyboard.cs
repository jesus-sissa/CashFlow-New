using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashFlow.Tools
{
    public static class Keyboard
    {
        public static kbcustom.Tecladocontrol _Keyboard = new kbcustom.Tecladocontrol();
        private static Control _tbx;

        public static kbcustom.Tecladocontrol.TipoTeclado _Keyboardtype = new kbcustom.Tecladocontrol.TipoTeclado();

        public static bool Teclado_RecibirControl(Control tbx)
        {

            _Keyboard.Letrapasada -= Recibir_TeclaPresionada;
            if (tbx != null)
            {
                _tbx = tbx;
                _Keyboard.Letrapasada += Recibir_TeclaPresionada;
            }
            else
                _tbx = null;
            return true;
        }

        private static void Recibir_TeclaPresionada(string teclaPresionada)
        {
            if (_tbx == null)
                return;
            _tbx.Focus();
            SendKeys.Send(teclaPresionada);
        }

    }
}
