using Project.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = ClienteServices.Instance().GetCliente(new Guid());
            txtNome.Text = cliente.Nome;
            txtCPF.Text = cliente.CPF;
            txtDtNasc.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
            txtTipoCliente.Text =  cliente.TipoCliente.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtDtNasc.Clear();
            txtTipoCliente.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lstClientes = ClienteServices.Instance().GetClientes();
            foreach (var item in lstClientes)
            {
                listView1.Items.Add(item.Nome);
            }           
        }
    }
}
