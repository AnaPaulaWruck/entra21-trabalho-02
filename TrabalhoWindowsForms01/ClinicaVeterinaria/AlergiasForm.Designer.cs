namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    partial class AlergiasForm
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
            this.dataGridViewAlergias = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCausa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListaAlergias = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCausa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxCausa = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelCodigoProcedimento = new System.Windows.Forms.Label();
            this.maskedTextBoxCodigoProcedimento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlergias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlergias
            // 
            this.dataGridViewAlergias.AllowUserToAddRows = false;
            this.dataGridViewAlergias.AllowUserToDeleteRows = false;
            this.dataGridViewAlergias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlergias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnCategoria,
            this.ColumnCausa});
            this.dataGridViewAlergias.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewAlergias.Name = "dataGridViewAlergias";
            this.dataGridViewAlergias.ReadOnly = true;
            this.dataGridViewAlergias.RowTemplate.Height = 25;
            this.dataGridViewAlergias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlergias.Size = new System.Drawing.Size(660, 340);
            this.dataGridViewAlergias.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "COD";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 40;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "NOME";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 150;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "CATEGORIA";
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            this.ColumnCategoria.Width = 150;
            // 
            // ColumnCausa
            // 
            this.ColumnCausa.HeaderText = "CAUSA";
            this.ColumnCausa.Name = "ColumnCausa";
            this.ColumnCausa.ReadOnly = true;
            this.ColumnCausa.Width = 276;
            // 
            // labelListaAlergias
            // 
            this.labelListaAlergias.AutoSize = true;
            this.labelListaAlergias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListaAlergias.Location = new System.Drawing.Point(12, 18);
            this.labelListaAlergias.Name = "labelListaAlergias";
            this.labelListaAlergias.Size = new System.Drawing.Size(123, 21);
            this.labelListaAlergias.TabIndex = 1;
            this.labelListaAlergias.Text = "Lista de Alergias";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(486, 403);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(90, 36);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(582, 403);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(90, 36);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(689, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 21);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(689, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // labelCausa
            // 
            this.labelCausa.AutoSize = true;
            this.labelCausa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCausa.Location = new System.Drawing.Point(689, 218);
            this.labelCausa.Name = "labelCausa";
            this.labelCausa.Size = new System.Drawing.Size(126, 21);
            this.labelCausa.TabIndex = 6;
            this.labelCausa.Text = "Causa da Alergia";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(689, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 27);
            this.textBox1.TabIndex = 7;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(689, 111);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(282, 28);
            this.comboBoxCategoria.TabIndex = 8;
            // 
            // textBoxCausa
            // 
            this.textBoxCausa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCausa.Location = new System.Drawing.Point(689, 245);
            this.textBoxCausa.Name = "textBoxCausa";
            this.textBoxCausa.Size = new System.Drawing.Size(282, 27);
            this.textBoxCausa.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(785, 291);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 36);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(881, 291);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(90, 36);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // labelCodigoProcedimento
            // 
            this.labelCodigoProcedimento.AutoSize = true;
            this.labelCodigoProcedimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodigoProcedimento.Location = new System.Drawing.Point(689, 152);
            this.labelCodigoProcedimento.Name = "labelCodigoProcedimento";
            this.labelCodigoProcedimento.Size = new System.Drawing.Size(183, 21);
            this.labelCodigoProcedimento.TabIndex = 12;
            this.labelCodigoProcedimento.Text = "Código do Procedimento";
            // 
            // maskedTextBoxCodigoProcedimento
            // 
            this.maskedTextBoxCodigoProcedimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCodigoProcedimento.Location = new System.Drawing.Point(689, 179);
            this.maskedTextBoxCodigoProcedimento.Mask = "9.99.99.99-9";
            this.maskedTextBoxCodigoProcedimento.Name = "maskedTextBoxCodigoProcedimento";
            this.maskedTextBoxCodigoProcedimento.Size = new System.Drawing.Size(282, 27);
            this.maskedTextBoxCodigoProcedimento.TabIndex = 13;
            // 
            // AlergiasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 451);
            this.Controls.Add(this.maskedTextBoxCodigoProcedimento);
            this.Controls.Add(this.labelCodigoProcedimento);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxCausa);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCausa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelListaAlergias);
            this.Controls.Add(this.dataGridViewAlergias);
            this.Name = "AlergiasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alergias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlergias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewAlergias;
        private Label labelListaAlergias;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private Label label2;
        private Label labelCausa;
        private TextBox textBox1;
        private ComboBox comboBoxCategoria;
        private TextBox textBoxCausa;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnCausa;
        private Label labelCodigoProcedimento;
        private MaskedTextBox maskedTextBoxCodigoProcedimento;
    }
}