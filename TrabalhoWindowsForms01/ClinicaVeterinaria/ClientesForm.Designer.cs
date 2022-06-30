namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    partial class ClientesForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataAdesao = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelPet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDataAdesao = new System.Windows.Forms.DateTimePicker();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPet = new System.Windows.Forms.ComboBox();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.comboBoxEndereco = new System.Windows.Forms.ComboBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxSms = new System.Windows.Forms.CheckBox();
            this.checkBoxWhatsApp = new System.Windows.Forms.CheckBox();
            this.labelComoDeseja = new System.Windows.Forms.Label();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataAdesao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(3, 234);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDataAdesao
            // 
            this.labelDataAdesao.AutoSize = true;
            this.labelDataAdesao.Location = new System.Drawing.Point(407, 252);
            this.labelDataAdesao.Name = "labelDataAdesao";
            this.labelDataAdesao.Size = new System.Drawing.Size(92, 15);
            this.labelDataAdesao.TabIndex = 1;
            this.labelDataAdesao.Text = "Data de Adesão:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(3, 341);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(59, 15);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(3, 287);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(117, 15);
            this.labelDataNascimento.TabIndex = 3;
            this.labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(407, 305);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Genêro";
            this.labelGenero.Click += new System.EventHandler(this.labelGenero_Click);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(3, 395);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 7;
            this.labelCPF.Text = "CPF:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(3, 446);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 8;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Location = new System.Drawing.Point(407, 381);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(24, 15);
            this.labelPet.TabIndex = 9;
            this.labelPet.Text = "Pet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 23);
            this.textBox1.TabIndex = 10;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(3, 305);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(143, 23);
            this.dateTimePickerDataNascimento.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnDataNascimento,
            this.ColumnGenero,
            this.ColumnCpf,
            this.ColumnEndereco,
            this.ColumnTelefone,
            this.ColumnDataAdesao,
            this.ColumnPet});
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(850, 216);
            this.dataGridView1.TabIndex = 19;
            // 
            // dateTimePickerDataAdesao
            // 
            this.dateTimePickerDataAdesao.Location = new System.Drawing.Point(407, 270);
            this.dateTimePickerDataAdesao.Name = "dateTimePickerDataAdesao";
            this.dateTimePickerDataAdesao.Size = new System.Drawing.Size(164, 23);
            this.dateTimePickerDataAdesao.TabIndex = 20;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(98, 504);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 21;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(3, 504);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 22;
            this.buttonApagar.Text = "APAGAR";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(688, 504);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(778, 504);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 24;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(3, 410);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(329, 23);
            this.maskedTextBoxCpf.TabIndex = 25;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(3, 464);
            this.maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTelefone.TabIndex = 26;
            // 
            // comboBoxPet
            // 
            this.comboBoxPet.FormattingEnabled = true;
            this.comboBoxPet.Location = new System.Drawing.Point(407, 399);
            this.comboBoxPet.Name = "comboBoxPet";
            this.comboBoxPet.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPet.TabIndex = 27;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(407, 323);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioButtonMasculino.TabIndex = 28;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(407, 341);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(75, 19);
            this.radioButtonFeminino.TabIndex = 29;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // comboBoxEndereco
            // 
            this.comboBoxEndereco.FormattingEnabled = true;
            this.comboBoxEndereco.Location = new System.Drawing.Point(3, 360);
            this.comboBoxEndereco.Name = "comboBoxEndereco";
            this.comboBoxEndereco.Size = new System.Drawing.Size(329, 23);
            this.comboBoxEndereco.TabIndex = 30;
            this.comboBoxEndereco.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(635, 288);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(79, 19);
            this.checkBoxEmail.TabIndex = 31;
            this.checkBoxEmail.Text = "Via E-Mail";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxSms
            // 
            this.checkBoxSms.AutoSize = true;
            this.checkBoxSms.Location = new System.Drawing.Point(635, 309);
            this.checkBoxSms.Name = "checkBoxSms";
            this.checkBoxSms.Size = new System.Drawing.Size(68, 19);
            this.checkBoxSms.TabIndex = 32;
            this.checkBoxSms.Text = "Via SMS";
            this.checkBoxSms.UseVisualStyleBackColor = true;
            // 
            // checkBoxWhatsApp
            // 
            this.checkBoxWhatsApp.AutoSize = true;
            this.checkBoxWhatsApp.Location = new System.Drawing.Point(635, 334);
            this.checkBoxWhatsApp.Name = "checkBoxWhatsApp";
            this.checkBoxWhatsApp.Size = new System.Drawing.Size(100, 19);
            this.checkBoxWhatsApp.TabIndex = 33;
            this.checkBoxWhatsApp.Text = "Via WhatsApp";
            this.checkBoxWhatsApp.UseVisualStyleBackColor = true;
            // 
            // labelComoDeseja
            // 
            this.labelComoDeseja.AutoSize = true;
            this.labelComoDeseja.Location = new System.Drawing.Point(635, 270);
            this.labelComoDeseja.Name = "labelComoDeseja";
            this.labelComoDeseja.Size = new System.Drawing.Size(215, 15);
            this.labelComoDeseja.TabIndex = 34;
            this.labelComoDeseja.Text = "Como Deseja Receber está Informacao?";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.HeaderText = "Data Nascimento";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            this.ColumnDataNascimento.ReadOnly = true;
            // 
            // ColumnGenero
            // 
            this.ColumnGenero.HeaderText = "Genêro";
            this.ColumnGenero.Name = "ColumnGenero";
            this.ColumnGenero.ReadOnly = true;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.HeaderText = "Endereço";
            this.ColumnEndereco.Name = "ColumnEndereco";
            this.ColumnEndereco.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // ColumnDataAdesao
            // 
            this.ColumnDataAdesao.HeaderText = "Data Adesão";
            this.ColumnDataAdesao.Name = "ColumnDataAdesao";
            this.ColumnDataAdesao.ReadOnly = true;
            // 
            // ColumnPet
            // 
            this.ColumnPet.HeaderText = "PET";
            this.ColumnPet.Name = "ColumnPet";
            this.ColumnPet.ReadOnly = true;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 539);
            this.Controls.Add(this.labelComoDeseja);
            this.Controls.Add(this.checkBoxWhatsApp);
            this.Controls.Add(this.checkBoxSms);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.comboBoxEndereco);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.comboBoxPet);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dateTimePickerDataAdesao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPet);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelDataAdesao);
            this.Controls.Add(this.labelNome);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private Label labelDataAdesao;
        private Label labelEndereco;
        private Label labelDataNascimento;
        private Label labelGenero;
        private Label labelCPF;
        private Label labelTelefone;
        private Label labelPet;
        private TextBox textBox1;
        private DateTimePicker dateTimePickerDataNascimento;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerDataAdesao;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxTelefone;
        private ComboBox comboBoxPet;
        private RadioButton radioButtonMasculino;
        private RadioButton radioButtonFeminino;
        private ComboBox comboBoxEndereco;
        private CheckBox checkBoxEmail;
        private CheckBox checkBoxSms;
        private CheckBox checkBoxWhatsApp;
        private Label labelComoDeseja;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnDataNascimento;
        private DataGridViewTextBoxColumn ColumnGenero;
        private DataGridViewTextBoxColumn ColumnCpf;
        private DataGridViewTextBoxColumn ColumnEndereco;
        private DataGridViewTextBoxColumn ColumnTelefone;
        private DataGridViewTextBoxColumn ColumnDataAdesao;
        private DataGridViewTextBoxColumn ColumnPet;
    }
}