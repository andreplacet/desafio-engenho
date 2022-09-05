using SimuladorDeLanterna.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorDeLanterna
{
    public partial class Form1 : Form
    {
        private Lanterna lanterna = new Lanterna(0, new Bateria());

        public Form1()
        {
            InitializeComponent();
            StatusLabel.Text = lanterna.GetStatus() == 0 ? "Desligado" : "Ligado";
            CargaLabel.Text = lanterna.GetCarga().ToString();
        }

        private void OnOff_Click(object sender, EventArgs e)
        {
            if(StatusLabel.Text == "Desligado")
            {
                StatusLabel.Text = "Ligado";
                this.timer1.Enabled = true;
                OnOff.Text = "DESLIGAR";
                OnOff.BackColor = Color.Red;
            }
            else
            {
                StatusLabel.Text = "Desligado";
                this.timer1.Enabled = false;
                OnOff.Text = "LIGAR";
                OnOff.BackColor = Color.MediumSpringGreen;
            }
        }

        private void ChangeBattery_Click(object sender, EventArgs e)
        {
            Bateria bateria = new Bateria();
            lanterna.TrocarBateria(bateria);
            CargaLabel.Text = lanterna.GetCarga().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(int.Parse(CargaLabel.Text) > 0)
            {
                var carga = int.Parse(CargaLabel.Text) - 1;
                CargaLabel.Text = carga.ToString();
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("A BATERIA ACABOU, CLIQUE NO BOTAO PARA TROCAR A BATERIA");
                OnOff.Text = "LIGAR";
                StatusLabel.Text = "Desligado";
                OnOff.BackColor = Color.MediumSpringGreen;
            }
        }
    }
}
