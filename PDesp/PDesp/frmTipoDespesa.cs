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
    public partial class frmTipoDespesa : Form
    {
        private BindingSource bnTipoDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsTipoDespesa = new DataSet();

        public frmTipoDespesa()
        {
            InitializeComponent();
        }

        private void frmTipoDespesa_Load(object sender, EventArgs e)
        {
            bnvSalvar.Enabled = false;
            bnvCancelar.Enabled = false;           

            try
            {
                TipoDespesa tipodespesa = new TipoDespesa();
                
                dsTipoDespesa.Tables.Add(tipodespesa.Listar());
                bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                dgvTipoDespesa.DataSource = bnTipoDespesa;
                bnvTipoDespesa.BindingSource = bnTipoDespesa;

                txtID.DataBindings.Add("TEXT", bnTipoDespesa, "id_tipodespesa");
                txtNome.DataBindings.Add("TEXT", bnTipoDespesa, "nome_tipodespesa");
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

            bnTipoDespesa.AddNew();
            txtNome.Enabled = true;
            txtNome.Focus();
            bnvSalvar.Enabled = true;
            bnvAlterar.Enabled = false;
            bnvNovo.Enabled = false;
            bnvExcluir.Enabled = false;
            bnvCancelar.Enabled = true;
            bnvSair.Enabled = true;

            bInclusao = true; ;
        }

        private void bnvSalvar_Click(object sender, EventArgs e)
        {
             if (txtNome.Text == "")
            {
                MessageBox.Show("Dado Inválido!");
            }
            else
            {
                TipoDespesa RegCid = new TipoDespesa();

                RegCid.Idtipodespesa = Convert.ToInt16(txtID.Text);
                RegCid.Nometipodespesa = txtNome.Text;

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Tipo de Despesa adicionado com sucesso!");

                        bnvSalvar.Enabled = false;
                        txtID.Enabled = false;
                        txtNome.Enabled = false;
                        bnvSalvar.Enabled = false;
                        bnvAlterar.Enabled = true;
                        bnvNovo.Enabled = true;
                        bnvExcluir.Enabled = true;
                        bnvCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegCid.Listar());
                        bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Tipo de Despesa!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Tipo de Despesa alterado com sucesso!");

                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegCid.Listar());
                        txtID.Enabled = false;
                        txtNome.Enabled = false;
                        bnvSalvar.Enabled = false;
                        bnvAlterar.Enabled = true;
                        bnvNovo.Enabled = true;
                        bnvExcluir.Enabled = true;
                        bnvCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Tipo de Despesa!");
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
                TipoDespesa RegCid = new TipoDespesa();

                RegCid.Idtipodespesa = Convert.ToInt16(txtID.Text);
                RegCid.Nometipodespesa = txtNome.Text;

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Tipo de Despesa excluído com sucesso!");
                    TipoDespesa R = new TipoDespesa();
                    dsTipoDespesa.Tables.Clear();
                    dsTipoDespesa.Tables.Add(R.Listar());
                    bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Tipo de Despesa!");
                }
            }
        }

        private void bnvCancelar_Click(object sender, EventArgs e)
        {
            bnTipoDespesa.CancelEdit();

            bnvSalvar.Enabled = false;
            txtNome.Enabled = false;
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

