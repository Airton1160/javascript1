using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.test01DataSet01);
            MessageBox.Show("Salvo !!!" + MessageBoxIcon.Exclamation);
            nomeTextBox.Enabled = false;
            idadeTextBox.Enabled = false;
            endereçoTextBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'test01DataSet01.pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.test01DataSet01.pessoas);

        }

        private void idPessoasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Excluido !!!");
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.test01DataSet01);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            idadeTextBox.Enabled = true;
            endereçoTextBox.Enabled = true;
        }
    }
}
