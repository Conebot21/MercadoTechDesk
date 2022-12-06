using Negocio;
using Negocio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoTech2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                MercadoTechDbContext contextoBanco = new MercadoTechDbContext();
                Funcionario novoFuncionario = new Funcionario();
                novoFuncionario.Nome = txNomeCadastrar.Text;
                novoFuncionario.Salario = float.Parse(txSalarioCadastrar.Text);
                contextoBanco.Funcionario.Add(novoFuncionario);
                contextoBanco.SaveChanges();
                txNomeCadastrar.Clear();
                txSalarioCadastrar.Clear();
                MessageBox.Show("Funcionário Cadastrado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados " + ex);
            }

        }

       
    }
}
