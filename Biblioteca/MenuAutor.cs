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
    public partial class MenuAutor : Form
    {
        public MenuAutor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcluirAutor excluirAutor = new ExcluirAutor();
            excluirAutor.ShowDialog();
        }//Botão Excluir Autor 

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarAutor cadastrarAutor = new CadastrarAutor();
            cadastrarAutor.ShowDialog();
        }//Botão Cadastrar Autor

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarAutor consultarAutor = new ConsultarAutor();
            consultarAutor.ShowDialog();
        }//Botão Consultar Autor

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarAutor atualizarAutor = new AtualizarAutor();
            atualizarAutor.ShowDialog();
        }//Botão Atualizar Autor
    }
}
