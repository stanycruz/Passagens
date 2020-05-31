using System;
using System.Windows.Forms;
using ConsumindoServico.ServiceReference1;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                var servico = new ClienteServiceClient();

                var cliente = new Cliente
                {
                    Nome = nome,
                    Cpf = cpf
                };

                servico.Add(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                var servico = new ClienteServiceClient();
                var resultado = servico.Buscar(nome);
                txtCpf.Text = resultado.Cpf;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
