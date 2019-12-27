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
    public partial class frmDespesa : Form
    {
        private BindingSource bnDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsDespesa = new DataSet();
        private DataSet dsMembro = new DataSet();
        private DataSet dsTipoDespesa = new DataSet();
        
        public frmDespesa()
        {
            InitializeComponent();
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {

            bnvSalvar.Enabled = false;
            bnvCancelar.Enabled = false;

            try
            {
                Despesa Desp = new Despesa();
                dsDespesa.Tables.Add(Desp.Listar());
                bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                dgvDespesa.DataSource = bnDespesa;
                bnvDespesa.BindingSource = bnDespesa;

                txtIdDespesa.DataBindings.Add("TEXT", bnDespesa, "id_despesa");
                mskData.DataBindings.Add("TEXT", bnDespesa, "data_despesa");
                txtValor.DataBindings.Add("TEXT", bnDespesa, "valor_despesa");
                txtObs.DataBindings.Add("TEXT", bnDespesa, "obs_despesa");
                
                Membro mem = new Membro();
                dsMembro.Tables.Add(mem.Listar());

                cbxIdMembro.DataSource = dsMembro.Tables["Membro"];

                cbxIdMembro.DisplayMember = "nome_membro";


                cbxIdMembro.ValueMember = "id_Membro";

                cbxIdMembro.DataBindings.Add("SelectedValue", bnDespesa, "membro_id_membro");

                TipoDespesa tipo = new TipoDespesa();
                dsTipoDespesa.Tables.Add(tipo.Listar());

                cbxTipoDespesa.DataSource = dsTipoDespesa.Tables["TipoDespesa"];

                cbxTipoDespesa.DisplayMember = "nome_tipodespesa";


                cbxTipoDespesa.ValueMember = "id_tipodespesa";

                cbxTipoDespesa.DataBindings.Add("SelectedValue", bnDespesa, "tipodespesa_id_tipodespesa");

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

            bnDespesa.AddNew();
            txtValor.Enabled = true;
            txtObs.Enabled = true;
            mskData.Enabled = true;
            cbxTipoDespesa.Enabled = true;
            cbxIdMembro.Enabled = true;
            cbxIdMembro.Focus();
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

            int dataOk = 0;
            string entrada = mskData.Text.ToString();
            entrada.Replace("System.Windows.Forms.MaskedTextBox, Text: ", "");
            string[] data = entrada.Split('/');
            int dia = int.Parse(data[0]);
            int mes = int.Parse(data[1]);
            int ano = int.Parse(data[2]);
            
            int diaAtual = (int)DateTime.Now.Day;
            int mesAtual = (int)DateTime.Now.Month;
            int anoAtual = (int)DateTime.Now.Year;

            if ((ano == anoAtual && mes == mesAtual && dia <= diaAtual) || (ano == anoAtual && mes < mesAtual) || (ano < anoAtual))
                dataOk = 1;

            if (txtValor.Text == "" || txtObs.Text == "" || mskData.Text == "" || cbxIdMembro.Text == "" || cbxTipoDespesa.Text == "" || dataOk == 0)
            {
                int valor;
                if (int.TryParse(txtValor.Text, out valor)){
                MessageBox.Show("Dado Inválido!");
                }
            }
            else
            {
                Despesa RegCid = new Despesa();               

                RegCid.Iddespesa = Convert.ToInt16(txtIdDespesa.Text);
                RegCid.Idmembro = Convert.ToInt16(cbxIdMembro.SelectedValue);
                RegCid.Idtipodespesa = Convert.ToInt16(cbxTipoDespesa.SelectedValue);
                RegCid.Datadepesa = Convert.ToDateTime(mskData.Text);
                RegCid.Valordespesa = float.Parse(txtValor.Text);
                RegCid.Obsdespesa = txtObs.Text;

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Despesa adicionada com sucesso!");

                        bnvSalvar.Enabled = false;
                        txtValor.Enabled = false;
                        txtObs.Enabled = false;
                        mskData.Enabled = false;
                        cbxTipoDespesa.Enabled = false;
                        cbxIdMembro.Enabled = false;
                        bnvSalvar.Enabled = false;
                        bnvAlterar.Enabled = true;
                        bnvNovo.Enabled = true;
                        bnvExcluir.Enabled = true;
                        bnvCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegCid.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Despesa!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Despesa alterada com sucesso!");

                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegCid.Listar());
                        txtValor.Enabled = false;
                        txtObs.Enabled = false;
                        mskData.Enabled = false;
                        cbxTipoDespesa.Enabled = false;
                        cbxIdMembro.Enabled = false;
                        bnvSalvar.Enabled = false;
                        bnvAlterar.Enabled = true;
                        bnvNovo.Enabled = true;
                        bnvExcluir.Enabled = true;
                        bnvCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Despesa!");
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

            txtValor.Enabled = true;
            txtObs.Enabled = true;
            mskData.Enabled = true;
            cbxTipoDespesa.Enabled = true;
            cbxIdMembro.Enabled = true;
            cbxIdMembro.Focus();
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
                Despesa RegCid = new Despesa();

                RegCid.Iddespesa = Convert.ToInt16(txtIdDespesa.Text);
                RegCid.Idmembro = Convert.ToInt16(cbxIdMembro.SelectedValue);
                RegCid.Idtipodespesa = Convert.ToInt16(cbxTipoDespesa.SelectedValue);
                RegCid.Datadepesa = Convert.ToDateTime(mskData.Text);
                RegCid.Valordespesa = float.Parse(txtValor.Text);
                RegCid.Obsdespesa = txtObs.Text;

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Despesa excluída com sucesso!");
                    Despesa R = new Despesa();
                    dsDespesa.Tables.Clear();
                    dsDespesa.Tables.Add(R.Listar());
                    bnDespesa.DataSource = dsDespesa.Tables["Despesa"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir despesa!");
                }
            }
        }

        private void bnvCancelar_Click(object sender, EventArgs e)
        {
            bnDespesa.CancelEdit();

            bnvSalvar.Enabled = false;
            txtValor.Enabled = false;
            txtObs.Enabled = false;
            mskData.Enabled = false;
            cbxTipoDespesa.Enabled = false;
            cbxIdMembro.Enabled = false;
            bnvAlterar.Enabled = true;
            bnvNovo.Enabled = true;
            bnvExcluir.Enabled = true;
            bnvCancelar.Enabled = false;
        }

        private void bnvSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnvDespesa_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
