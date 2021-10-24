using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17 {
    public partial class Form1 : Form {

        double consulta, exame, internacao, total;
        public Form1() {
            InitializeComponent();
        }

        private void cbkConsulta_CheckedChanged(object sender, EventArgs e) {
            if (cbkConsulta.Checked == true) {
                lblConsulta.Visible = true;
                consulta = 75;
            } else {
                lblConsulta.Visible = false;
                consulta = 0;
            }
        }

     private void cbkInternacao_CheckedChanged(object sender, EventArgs e) {
            if(cbkInternacao.Checked == true) {
                lblInternacao.Visible = true;
                internacao = 510;
            }
            else {
                lblInternacao.Visible = false;
                internacao = 0;
            }
        }

        private void cbkExames_CheckedChanged(object sender, EventArgs e) {
            if(cbkExames.Checked == true) {
                lblExames.Visible = true;
                exame = 150;
            }
            else {
                lblExames.Visible = false;
                exame = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            foreach(Control item in this.Controls) {
                if(item is TextBox) {
                    (item as TextBox).Clear();
                }
                if(item is RadioButton) {
                    (item as RadioButton).Checked = false;
                }
                if(item is CheckBox) {
                    (item as CheckBox).Checked = false;
                }
            }

            lblConsulta.Visible = false;
            lblInternacao.Visible = false;
            lblExames.Visible = false;
            lblTotalservico.Visible = false;
            lblTotalpg.Visible = false;
            lblTotalPlano.Visible = false;
            lblTotalFormaPagar.Visible = false;

        }

        private void rdPrazo_CheckedChanged(object sender, EventArgs e) {
            if(rdPrazo.Checked) {
                total = total * 1.15;
                lblTotalFormaPagar.Text = "R$ " + Math.Round(total);
                lblTotalFormaPagar.Visible = true;
            }
            else {
                lblTotalFormaPagar.Visible = false;
                total = consulta + exame + internacao;
            }

        }

        private void rbdPrivado_CheckedChanged(object sender, EventArgs e) {
            if(rbdPrivado.Checked == true) {
                total = consulta + exame + internacao;
                lblTotalservico.Text = "R$" + Math.Round(total, 2);
                lblTotalservico.Visible = true;
            }
            else {
                lblTotalservico.Visible = false;
            }
        }

        
        private void rbdParticular_CheckedChanged(object sender, EventArgs e) {
            if(rbdParticular.Checked == true) {
                total = consulta + exame + internacao;
                lblTotalservico.Text = "R$" + Math.Round(total, 2);
                lblTotalservico.Visible = true;
                rdVista.Enabled = true;
                rdPrazo.Enabled = true;
            }
            else {
                lblTotalservico.Visible = false;
                rdVista.Enabled = false;
                rdPrazo.Enabled = false;
            }
        }


        private void rbdSus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdSus.Checked == true)
            {
                total = consulta + exame + internacao;
                lblTotalservico.Text = "R$" + Math.Round(total, 2);
                lblTotalservico.Visible = true;
            }
            else
            {
                lblTotalservico.Visible = false;
            }
        }


    }
    }

