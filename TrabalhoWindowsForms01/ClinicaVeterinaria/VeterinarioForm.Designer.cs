namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    partial class VeterinarioForm
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.textBoxEspecializacao = new System.Windows.Forms.TextBox();
            this.textBoxCrmv = new System.Windows.Forms.TextBox();
            this.labelEspecializacao = new System.Windows.Forms.Label();
            this.labelCrmv = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecializacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCrmv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 236);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(132, 29);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(284, 236);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(130, 29);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Location = new System.Drawing.Point(12, 44);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(120, 20);
            this.labelNomeCompleto.TabIndex = 2;
            this.labelNomeCompleto.Text = "Nome Completo";
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(12, 67);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(402, 27);
            this.textBoxNomeCompleto.TabIndex = 3;
            // 
            // textBoxEspecializacao
            // 
            this.textBoxEspecializacao.Location = new System.Drawing.Point(12, 126);
            this.textBoxEspecializacao.Name = "textBoxEspecializacao";
            this.textBoxEspecializacao.Size = new System.Drawing.Size(402, 27);
            this.textBoxEspecializacao.TabIndex = 4;
            // 
            // textBoxCrmv
            // 
            this.textBoxCrmv.Location = new System.Drawing.Point(12, 184);
            this.textBoxCrmv.Name = "textBoxCrmv";
            this.textBoxCrmv.Size = new System.Drawing.Size(402, 27);
            this.textBoxCrmv.TabIndex = 5;
            // 
            // labelEspecializacao
            // 
            this.labelEspecializacao.AutoSize = true;
            this.labelEspecializacao.Location = new System.Drawing.Point(12, 103);
            this.labelEspecializacao.Name = "labelEspecializacao";
            this.labelEspecializacao.Size = new System.Drawing.Size(106, 20);
            this.labelEspecializacao.TabIndex = 6;
            this.labelEspecializacao.Text = "Especialização";
            // 
            // labelCrmv
            // 
            this.labelCrmv.AutoSize = true;
            this.labelCrmv.Location = new System.Drawing.Point(12, 161);
            this.labelCrmv.Name = "labelCrmv";
            this.labelCrmv.Size = new System.Drawing.Size(49, 20);
            this.labelCrmv.TabIndex = 7;
            this.labelCrmv.Text = "CRMV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNomeCompleto,
            this.ColumnEspecializacao,
            this.ColumnCrmv});
            this.dataGridView1.Location = new System.Drawing.Point(442, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(921, 450);
            this.dataGridView1.TabIndex = 8;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 150;
            // 
            // ColumnNomeCompleto
            // 
            this.ColumnNomeCompleto.HeaderText = "Veterinario (a)";
            this.ColumnNomeCompleto.MinimumWidth = 6;
            this.ColumnNomeCompleto.Name = "ColumnNomeCompleto";
            this.ColumnNomeCompleto.ReadOnly = true;
            this.ColumnNomeCompleto.Width = 300;
            // 
            // ColumnEspecializacao
            // 
            this.ColumnEspecializacao.HeaderText = "Especialização";
            this.ColumnEspecializacao.MinimumWidth = 6;
            this.ColumnEspecializacao.Name = "ColumnEspecializacao";
            this.ColumnEspecializacao.ReadOnly = true;
            this.ColumnEspecializacao.Width = 300;
            // 
            // ColumnCrmv
            // 
            this.ColumnCrmv.HeaderText = "CRMV";
            this.ColumnCrmv.MinimumWidth = 6;
            this.ColumnCrmv.Name = "ColumnCrmv";
            this.ColumnCrmv.ReadOnly = true;
            this.ColumnCrmv.Width = 150;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(736, 32);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(853, 32);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 10;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // VeterinarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 540);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCrmv);
            this.Controls.Add(this.labelEspecializacao);
            this.Controls.Add(this.textBoxCrmv);
            this.Controls.Add(this.textBoxEspecializacao);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(this.labelNomeCompleto);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "VeterinarioForm";
            this.Text = "Cadastro de Veterinários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label labelNomeCompleto;
        private TextBox textBoxNomeCompleto;
        private TextBox textBoxEspecializacao;
        private TextBox textBoxCrmv;
        private Label labelEspecializacao;
        private Label labelCrmv;
        private DataGridView dataGridView1;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNomeCompleto;
        private DataGridViewTextBoxColumn ColumnEspecializacao;
        private DataGridViewTextBoxColumn ColumnCrmv;
    }
}