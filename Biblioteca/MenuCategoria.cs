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
    public partial class MenuCategoria : Form
    {
        public MenuCategoria()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarCategoria atualizarCategoria = new AtualizarCategoria();
            atualizarCategoria.ShowDialog();
        }//Botão Atualizar Categoria

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCategoria cadastrarCategoria = new CadastrarCategoria();
            cadastrarCategoria.ShowDialog();
        }//Botão Cadastrar Categoria

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarCategoria consultarCategoria = new ConsultarCategoria();
            consultarCategoria.ShowDialog();
        }//Botão Consultar Categoria

        private void button4_Click(object sender, EventArgs e)
        {
            ExcluirCategoria excluirCategoria = new ExcluirCategoria();
            excluirCategoria.ShowDialog();
        }//Botão Excluir Categoria
    }
}
