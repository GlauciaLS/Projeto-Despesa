using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PDesp
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=apolo; Initial Catalog=LP2; Persist Security Info=True; User ID=BD1911011; PASSWORD=10473378Glaucia.");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de Banco de Dados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void membroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembro frmMembro = new frmMembro();
            frmMembro.Show();
        }

        private void tipoDeDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDespesa tipodespesa = new frmTipoDespesa();
            tipodespesa.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDespesa despesa = new frmDespesa();
            despesa.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {                        
            this.Close();
        }

        
    }
}
