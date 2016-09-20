using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTM.Classes;

namespace CTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variaveis

        private int estagio_trafo = 0;
        private int estagio_motor = 10;

        public Transformador CalculaTrafo;
        public Motor CalculaMotor;

        TipoCalculo AtualCalculo;

        #endregion

        #region Controles de menu

        private void bt_Transformador_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            ControleBotão(true);
            AtualCalculo = TipoCalculo.Trafo;
            estagio_trafo = 1;
            MenuTrafo();
        }

        private void bt_motor_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            ControleBotão(true);
            AtualCalculo = TipoCalculo.Motor;
            estagio_motor = 11;
            MenuMotor();
        }

        private void bt_avancar_Click(object sender, EventArgs e)
        {
            if (AtualCalculo == TipoCalculo.Trafo)
            {
                estagio_trafo++;
                MenuTrafo();
            }
            else
            {
                estagio_motor++;
                MenuMotor();
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            if (AtualCalculo == TipoCalculo.Trafo)
            {
                if (estagio_trafo == 1)
                {
                    bt_cancelar_Click(this, e);
                }
                else
                {
                    estagio_trafo--;
                }
            }

            if (AtualCalculo == TipoCalculo.Motor)
            {
                if (estagio_motor == 11)
                {
                    bt_cancelar_Click(this, e);
                }
                else
                {
                    estagio_motor--;
                }
            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            estagio_motor = estagio_trafo = 0;
            ControleBotão(false);
            OcultarPanels();
            panel1.Visible = true;
        }

        private void ControleBotão(bool estatus)
        {
            bt_avancar.Visible = estatus;
            bt_cancelar.Visible = estatus;
            bt_voltar.Visible = estatus;
        }

        private void OcultarPanels()
        {
            panel2.Visible = false;
        }

        #endregion

        #region Menu Transformador

        private void MenuTrafo()
        {
            switch (estagio_trafo)
            {
                case 1:
                    {
                        panel2.Visible = true;

                        MessageBox.Show("panel 1");
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("panel 2");
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("panel 3");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Erro, sistema reiniciado!");
                        OcultarPanels();
                        panel1.Visible = true;
                        ControleBotão(false);
                        break;
                    }
                    
            }
        }
        #endregion

        #region Menu Motor

        private void MenuMotor()
        {
            switch (estagio_motor)
            {
                case 11:
                    {
                        MessageBox.Show("panel 11");
                        break;
                    }
                case 12:
                    {
                        MessageBox.Show("panel 12");
                        break;
                    }
                case 13:
                    {
                        MessageBox.Show("panel 13");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Erro, sistema reiniciado!");
                        OcultarPanels();
                        panel1.Visible = true;
                        ControleBotão(false);
                        break;
                    }
            }
        }
        #endregion


    }
}
