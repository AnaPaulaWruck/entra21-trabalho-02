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
            this.CheckBoxFemea = new System.Windows.Forms.CheckBox();
            this.checkBoxMacho = new System.Windows.Forms.CheckBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelPet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBoxCachorro = new System.Windows.Forms.CheckBox();
            this.checkBoxGato = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDataAdesao = new System.Windows.Forms.DateTimePicker();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(516, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDataAdesao
            // 
            this.labelDataAdesao.AutoSize = true;
            this.labelDataAdesao.Location = new System.Drawing.Point(516, 341);
            this.labelDataAdesao.Name = "labelDataAdesao";
            this.labelDataAdesao.Size = new System.Drawing.Size(92, 15);
            this.labelDataAdesao.TabIndex = 1;
            this.labelDataAdesao.Text = "Data de Adesão:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(516, 109);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(59, 15);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(516, 55);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(117, 15);
            this.labelDataNascimento.TabIndex = 3;
            this.labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(699, 261);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Genêro";
            // 
            // CheckBoxFemea
            // 
            this.CheckBoxFemea.AutoSize = true;
            this.CheckBoxFemea.Location = new System.Drawing.Point(697, 304);
            this.CheckBoxFemea.Name = "CheckBoxFemea";
            this.CheckBoxFemea.Size = new System.Drawing.Size(61, 19);
            this.CheckBoxFemea.TabIndex = 5;
            this.CheckBoxFemea.Text = "Femêa";
            this.CheckBoxFemea.UseVisualStyleBackColor = true;
            // 
            // checkBoxMacho
            // 
            this.checkBoxMacho.AutoSize = true;
            this.checkBoxMacho.Location = new System.Drawing.Point(697, 279);
            this.checkBoxMacho.Name = "checkBoxMacho";
            this.checkBoxMacho.Size = new System.Drawing.Size(63, 19);
            this.checkBoxMacho.TabIndex = 6;
            this.checkBoxMacho.Text = "Macho";
            this.checkBoxMacho.UseVisualStyleBackColor = true;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(516, 155);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 7;
            this.labelCPF.Text = "CPF:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(516, 208);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 8;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Location = new System.Drawing.Point(516, 261);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(24, 15);
            this.labelPet.TabIndex = 9;
            this.labelPet.Text = "Pet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 23);
            this.textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(516, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(329, 23);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(516, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(329, 23);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(516, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(329, 23);
            this.textBox5.TabIndex = 14;
            // 
            // checkBoxCachorro
            // 
            this.checkBoxCachorro.AutoSize = true;
            this.checkBoxCachorro.Location = new System.Drawing.Point(516, 279);
            this.checkBoxCachorro.Name = "checkBoxCachorro";
            this.checkBoxCachorro.Size = new System.Drawing.Size(75, 19);
            this.checkBoxCachorro.TabIndex = 16;
            this.checkBoxCachorro.Text = "Cachorro";
            this.checkBoxCachorro.UseVisualStyleBackColor = true;
            // 
            // checkBoxGato
            // 
            this.checkBoxGato.AutoSize = true;
            this.checkBoxGato.Location = new System.Drawing.Point(516, 304);
            this.checkBoxGato.Name = "checkBoxGato";
            this.checkBoxGato.Size = new System.Drawing.Size(51, 19);
            this.checkBoxGato.TabIndex = 17;
            this.checkBoxGato.Text = "Gato";
            this.checkBoxGato.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(516, 73);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(143, 23);
            this.dateTimePickerDataNascimento.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(474, 450);
            this.dataGridView1.TabIndex = 19;
            // 
            // dateTimePickerDataAdesao
            // 
            this.dateTimePickerDataAdesao.Location = new System.Drawing.Point(516, 359);
            this.dateTimePickerDataAdesao.Name = "dateTimePickerDataAdesao";
            this.dateTimePickerDataAdesao.Size = new System.Drawing.Size(164, 23);
            this.dateTimePickerDataAdesao.TabIndex = 20;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(3, 504);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 21;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(164, 504);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 22;
            this.buttonApagar.Text = "APAGAR";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(619, 504);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(770, 504);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 24;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 539);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dateTimePickerDataAdesao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.checkBoxGato);
            this.Controls.Add(this.checkBoxCachorro);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPet);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.checkBoxMacho);
            this.Controls.Add(this.CheckBoxFemea);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelDataAdesao);
            this.Controls.Add(this.labelNome);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
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
        private CheckBox CheckBoxFemea;
        private CheckBox checkBoxMacho;
        private Label labelCPF;
        private Label labelTelefone;
        private Label labelPet;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBoxCachorro;
        private CheckBox checkBoxGato;
        private DateTimePicker dateTimePickerDataNascimento;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerDataAdesao;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}