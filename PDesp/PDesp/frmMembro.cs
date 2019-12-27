using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDesp
{
    public partial class frmMembro : Form
    {
        private BindingSource bnMembro = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsMembro = new DataSet();

        public frmMembro()
        {
            InitializeComponent();
        }

        private void frmMembro_Load(object sender, EventArgs e)
        {
            bnvSalvar.Enabled = false;
            bnvCancelar.Enabled = false;
            try
            {
                Membro membro = new Membro();
                dsMembro.Tables.Add(membro.Listar());
                bnMembro.DataSource = dsMembro.Tables["Membro"];
                dgvMembro.DataSource = bnMembro;
                bnvMembro.BindingSource = bnMembro;

                txtID.DataBindings.Add("TEXT", bnMembro, "id_membro");
                txtNome.DataBindings.Add("TEXT", bnMembro, "nome_membro");
                txtPapel.DataBindings.Add("TEXT", bnMembro, "papel_membro"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void bnvNovo_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            bnMembro.AddNew();
            txtNome.Enabled = true;
            txtPapel.Enabled = true;
            txtNome.Focus();
            bnvSalvar.Enabled = true;
            bnvAlterar.Enabled = false;
            bnvNovo.Enabled = false;
            bnvExcluir.Enabled = false;
            bnvCancelar.Enabled = true;
            bnvSair.Enabled = true;

            bInclusao = true; 
        }

        private void bnvSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtPapel.Text == "")
            {
                MessageBox.Show("Dado Inválido!");
            }
            else
            {
                Membro RegCid = new Membro();

                RegCid.Idmembro = Convert.ToInt16(txtID.Text);
                RegCid.Nomemembro = txtNome.Text;
                RegCid.Papelmembro = txtPapel.Text;

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Membro adicionado com sucesso!");

                        bnvSalvar.Enabled = false;
                        txtID.Enabled = false;
                        txtNome.Enabled = false;
                        txtPapel.Enabled = false;
                        bnvSalvar.Enabled = false;
                        bnvAlterar.Enabled = true;
                        bnvNovo.Enabled = true;
                        bnvExcluir.Enabled = true;
                        bnvCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(RegCid.Listar());
                        bnMembro.DataSource = dsMembro.Tables["Membro"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Membro alterado com sucesso!");

                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(RegCid.Listar());
                        txtID.Enabled = false;
                        txtNome.Enabled = false;
                        txtPapel.Enabled = false;
                        bnvSalvar.Enabled = false;
                        bnvAlterar.Enabled = true;
                        bnvNovo.Enabled = true;
                        bnvExcluir.Enabled = true;
                        bnvCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
                    }

                }
            }
        }

        private void bnvAlterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtNome.Enabled = true;
            txtPapel.Enabled = true;
            txtNome.Focus();
            bnvSalvar.Enabled = true;
            bnvAlterar.Enabled = false;
            bnvNovo.Enabled = false;
            bnvExcluir.Enabled = false;
            bnvCancelar.Enabled = true;
            bInclusao = false;
        }

        private void bnvExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Membro RegCid = new Membro();

                RegCid.Idmembro = Convert.ToInt16(txtID.Text);
                RegCid.Nomemembro = txtNome.Text;
                RegCid.Papelmembro = txtPapel.Text;

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Membro excluído com sucesso!");
                    Membro R = new Membro();
                    dsMembro.Tables.Clear();
                    dsMembro.Tables.Add(R.Listar());
                    bnMembro.DataSource = dsMembro.Tables["Membro"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir membro!");
                }
            }
        }

        private void bnvCancelar_Click(object sender, EventArgs e)
        {
            bnMembro.CancelEdit();

            bnvSalvar.Enabled = false;
            txtNome.Enabled = false;
            txtPapel.Enabled = false;
            bnvAlterar.Enabled = true;
            bnvNovo.Enabled = true;
            bnvExcluir.Enabled = true;
            bnvCancelar.Enabled = false;
        }

        private void bnvSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
