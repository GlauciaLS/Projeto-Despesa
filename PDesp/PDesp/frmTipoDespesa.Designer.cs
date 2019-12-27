namespace PDesp
{
    partial class frmTipoDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDespesa));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTipoDespesa = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bnvTipoDespesa = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnvNovo = new System.Windows.Forms.ToolStripButton();
            this.bnvSalvar = new System.Windows.Forms.ToolStripButton();
            this.bnvAlterar = new System.Windows.Forms.ToolStripButton();
            this.bnvExcluir = new System.Windows.Forms.ToolStripButton();
            this.bnvCancelar = new System.Windows.Forms.ToolStripButton();
            this.bnvSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDespesa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvTipoDespesa)).BeginInit();
            this.bnvTipoDespesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 280);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTipoDespesa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTipoDespesa
            // 
            this.dgvTipoDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDespesa.Location = new System.Drawing.Point(0, 3);
            this.dgvTipoDespesa.Name = "dgvTipoDespesa";
            this.dgvTipoDespesa.ReadOnly = true;
            this.dgvTipoDespesa.Size = new System.Drawing.Size(429, 248);
            this.dgvTipoDespesa.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 103);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(171, 64);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // bnvTipoDespesa
            // 
            this.bnvTipoDespesa.AddNewItem = null;
            this.bnvTipoDespesa.CountItem = this.bindingNavigatorCountItem;
            this.bnvTipoDespesa.DeleteItem = null;
            this.bnvTipoDespesa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bnvNovo,
            this.bnvSalvar,
            this.bnvAlterar,
            this.bnvExcluir,
            this.bnvCancelar,
            this.bnvSair});
            this.bnvTipoDespesa.Location = new System.Drawing.Point(0, 0);
            this.bnvTipoDespesa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvTipoDespesa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvTipoDespesa.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvTipoDespesa.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvTipoDespesa.Name = "bnvTipoDespesa";
            this.bnvTipoDespesa.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvTipoDespesa.Size = new System.Drawing.Size(506, 25);
            this.bnvTipoDespesa.TabIndex = 2;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bnvNovo
            // 
            this.bnvNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvNovo.Image = ((System.Drawing.Image)(resources.GetObject("bnvNovo.Image")));
            this.bnvNovo.Name = "bnvNovo";
            this.bnvNovo.RightToLeftAutoMirrorImage = true;
            this.bnvNovo.Size = new System.Drawing.Size(23, 22);
            this.bnvNovo.Text = "Add new";
            this.bnvNovo.Click += new System.EventHandler(this.bnvNovo_Click);
            // 
            // bnvSalvar
            // 
            this.bnvSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvSalvar.Image = ((System.Drawing.Image)(resources.GetObject("bnvSalvar.Image")));
            this.bnvSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnvSalvar.Name = "bnvSalvar";
            this.bnvSalvar.Size = new System.Drawing.Size(23, 22);
            this.bnvSalvar.Text = "Salvar";
            this.bnvSalvar.Click += new System.EventHandler(this.bnvSalvar_Click);
            // 
            // bnvAlterar
            // 
            this.bnvAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvAlterar.Image = ((System.Drawing.Image)(resources.GetObject("bnvAlterar.Image")));
            this.bnvAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnvAlterar.Name = "bnvAlterar";
            this.bnvAlterar.Size = new System.Drawing.Size(23, 22);
            this.bnvAlterar.Text = "Alterar";
            this.bnvAlterar.Click += new System.EventHandler(this.bnvAlterar_Click);
            // 
            // bnvExcluir
            // 
            this.bnvExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvExcluir.Image = ((System.Drawing.Image)(resources.GetObject("bnvExcluir.Image")));
            this.bnvExcluir.Name = "bnvExcluir";
            this.bnvExcluir.RightToLeftAutoMirrorImage = true;
            this.bnvExcluir.Size = new System.Drawing.Size(23, 22);
            this.bnvExcluir.Text = "Excluir";
            this.bnvExcluir.Click += new System.EventHandler(this.bnvExcluir_Click);
            // 
            // bnvCancelar
            // 
            this.bnvCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bnvCancelar.Image")));
            this.bnvCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnvCancelar.Name = "bnvCancelar";
            this.bnvCancelar.Size = new System.Drawing.Size(23, 22);
            this.bnvCancelar.Text = "Cancelar";
            this.bnvCancelar.Click += new System.EventHandler(this.bnvCancelar_Click);
            // 
            // bnvSair
            // 
            this.bnvSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnvSair.Image = ((System.Drawing.Image)(resources.GetObject("bnvSair.Image")));
            this.bnvSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnvSair.Name = "bnvSair";
            this.bnvSair.Size = new System.Drawing.Size(23, 22);
            this.bnvSair.Text = "Sair";
            this.bnvSair.Click += new System.EventHandler(this.bnvSair_Click);
            // 
            // frmTipoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 352);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnvTipoDespesa);
            this.Name = "frmTipoDespesa";
            this.Text = "frmTipoDespesa";
            this.Load += new System.EventHandler(this.frmTipoDespesa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDespesa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvTipoDespesa)).EndInit();
            this.bnvTipoDespesa.ResumeLayout(false);
            this.bnvTipoDespesa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTipoDespesa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.BindingNavigator bnvTipoDespesa;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnvNovo;
        private System.Windows.Forms.ToolStripButton bnvSalvar;
        private System.Windows.Forms.ToolStripButton bnvAlterar;
        private System.Windows.Forms.ToolStripButton bnvExcluir;
        private System.Windows.Forms.ToolStripButton bnvCancelar;
        private System.Windows.Forms.ToolStripButton bnvSair;

    }
}