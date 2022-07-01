namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    partial class EnderecoForm
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
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.textBoxCep = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.dataGridViewEnderecoCliente = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnderecoCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(529, 50);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(259, 23);
            this.textBoxEnderecoCompleto.TabIndex = 0;
            // 
            // textBoxCep
            // 
            this.textBoxCep.Location = new System.Drawing.Point(529, 175);
            this.textBoxCep.Name = "textBoxCep";
            this.textBoxCep.Size = new System.Drawing.Size(120, 23);
            this.textBoxCep.TabIndex = 1;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(529, 113);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumero.TabIndex = 2;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(529, 32);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(112, 15);
            this.labelEnderecoCompleto.TabIndex = 3;
            this.labelEnderecoCompleto.Text = "Endereço Completo";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(529, 157);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 15);
            this.labelCep.TabIndex = 4;
            this.labelCep.Text = "CEP";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(529, 95);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(51, 15);
            this.labelNumero.TabIndex = 5;
            this.labelNumero.Text = "Numero";
            // 
            // dataGridViewEnderecoCliente
            // 
            this.dataGridViewEnderecoCliente.AllowUserToAddRows = false;
            this.dataGridViewEnderecoCliente.AllowUserToDeleteRows = false;
            this.dataGridViewEnderecoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnderecoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnEnderecoCompleto,
            this.ColumnNumero,
            this.ColumnCep});
            this.dataGridViewEnderecoCliente.Location = new System.Drawing.Point(2, 32);
            this.dataGridViewEnderecoCliente.Name = "dataGridViewEnderecoCliente";
            this.dataGridViewEnderecoCliente.ReadOnly = true;
            this.dataGridViewEnderecoCliente.RowTemplate.Height = 25;
            this.dataGridViewEnderecoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEnderecoCliente.Size = new System.Drawing.Size(491, 219);
            this.dataGridViewEnderecoCliente.TabIndex = 6;
            this.dataGridViewEnderecoCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnderecoCliente_CellContentClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnEnderecoCompleto
            // 
            this.ColumnEnderecoCompleto.HeaderText = "Endereço Completo";
            this.ColumnEnderecoCompleto.Name = "ColumnEnderecoCompleto";
            this.ColumnEnderecoCompleto.ReadOnly = true;
            this.ColumnEnderecoCompleto.Width = 200;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Numero";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            this.ColumnNumero.Width = 200;
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            this.ColumnCep.Width = 170;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(604, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(125, 415);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "APAGAR";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(2, 415);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(713, 415);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonMenuPrincipal
            // 
            this.buttonMenuPrincipal.Location = new System.Drawing.Point(357, 415);
            this.buttonMenuPrincipal.Name = "buttonMenuPrincipal";
            this.buttonMenuPrincipal.Size = new System.Drawing.Size(75, 23);
            this.buttonMenuPrincipal.TabIndex = 11;
            this.buttonMenuPrincipal.Text = "MENU PRINCIPAL";
            this.buttonMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonMenuPrincipal.Click += new System.EventHandler(this.buttonMenuPrincipal_Click);
            // 
            // EnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMenuPrincipal);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewEnderecoCliente);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxCep);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Name = "EnderecoForm";
            this.Text = "EnderecosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnderecoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxEnderecoCompleto;
        private TextBox textBoxCep;
        private TextBox textBoxNumero;
        private Label labelEnderecoCompleto;
        private Label labelCep;
        private Label labelNumero;
        private DataGridView dataGridViewEnderecoCliente;
        private Button buttonCancelar;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonSalvar;
        private Button buttonMenuPrincipal;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnEnderecoCompleto;
        private DataGridViewTextBoxColumn ColumnNumero;
        private DataGridViewTextBoxColumn ColumnCep;
    }
}