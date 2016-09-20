using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTM
{
    public partial class Form1 : Form
    {

        private int estagio_trafo = 0;
        private int estagio_motor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Transformador_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            ControleBotão(true);
            MenuTrafo();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            estagio_motor = estagio_trafo = 0;
            ControleBotão(false);
            panel2.Visible = false;

            panel1.Visible = true;
        }

        private void ControleBotão(bool estatus)
        {
            bt_avancar.Visible = estatus;
            bt_cancelar.Visible = estatus;
            bt_voltar.Visible = estatus;
        }

        #region Menu Transformador

        private void MenuTrafo()
        {
            switch (estagio_trafo)
            {
                case 0:
                    {
                        panel2.Visible = true;
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion
    }
}
