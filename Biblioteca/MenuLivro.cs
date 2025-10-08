using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class MenuLivro : Form
    {
        public MenuLivro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }//Botão Cadastrar Livro

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CadastrarLivro cadastrarLivro = new CadastrarLivro();
            cadastrarLivro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarLivro consultarLivro = new ConsultarLivro();
            consultarLivro.ShowDialog();
        }//Botão Consultar Livro

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarLivro atualizarLivro = new AtualizarLivro();
            atualizarLivro.ShowDialog();
        }//Botão Atualizar Livro

        private void button4_Click(object sender, EventArgs e)
        {
            ExcluirLivro excluirLivro = new ExcluirLivro();
            excluirLivro.ShowDialog(); 
        }//Botão Excluir Livro

        private void MenuLivro_Load(object sender, EventArgs e)
        {

        }
    }
}
