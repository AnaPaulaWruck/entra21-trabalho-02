namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    partial class PetsForm
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
            this.dataGridViewPets = new System.Windows.Forms.DataGridView();
            this.labelListaPets = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeTutor = new System.Windows.Forms.Label();
            this.comboBoxTutor = new System.Windows.Forms.ComboBox();
            this.radioButtonCao = new System.Windows.Forms.RadioButton();
            this.radioButtonGato = new System.Windows.Forms.RadioButton();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.radioButtonFemea = new System.Windows.Forms.RadioButton();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.labelRaca = new System.Windows.Forms.Label();
            this.comboBoxRaca = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelVacinas = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.labelAlergia = new System.Windows.Forms.Label();
            this.comboBoxAlergia = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPets
            // 
            this.dataGridViewPets.AllowUserToAddRows = false;
            this.dataGridViewPets.AllowUserToDeleteRows = false;
            this.dataGridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPets.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewPets.Name = "dataGridViewPets";
            this.dataGridViewPets.ReadOnly = true;
            this.dataGridViewPets.RowTemplate.Height = 25;
            this.dataGridViewPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPets.Size = new System.Drawing.Size(550, 355);
            this.dataGridViewPets.TabIndex = 0;
            // 
            // labelListaPets
            // 
            this.labelListaPets.AutoSize = true;
            this.labelListaPets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListaPets.Location = new System.Drawing.Point(12, 18);
            this.labelListaPets.Name = "labelListaPets";
            this.labelListaPets.Size = new System.Drawing.Size(95, 21);
            this.labelListaPets.TabIndex = 1;
            this.labelListaPets.Text = "Lista de Pets";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(376, 406);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(90, 36);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(472, 406);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(90, 36);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(593, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(594, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelNomeTutor
            // 
            this.labelNomeTutor.AutoSize = true;
            this.labelNomeTutor.Location = new System.Drawing.Point(594, 82);
            this.labelNomeTutor.Name = "labelNomeTutor";
            this.labelNomeTutor.Size = new System.Drawing.Size(35, 15);
            this.labelNomeTutor.TabIndex = 6;
            this.labelNomeTutor.Text = "Tutor";
            // 
            // comboBoxTutor
            // 
            this.comboBoxTutor.FormattingEnabled = true;
            this.comboBoxTutor.Location = new System.Drawing.Point(594, 109);
            this.comboBoxTutor.Name = "comboBoxTutor";
            this.comboBoxTutor.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTutor.TabIndex = 7;
            // 
            // radioButtonCao
            // 
            this.radioButtonCao.AutoSize = true;
            this.radioButtonCao.Location = new System.Drawing.Point(594, 159);
            this.radioButtonCao.Name = "radioButtonCao";
            this.radioButtonCao.Size = new System.Drawing.Size(46, 19);
            this.radioButtonCao.TabIndex = 8;
            this.radioButtonCao.TabStop = true;
            this.radioButtonCao.Text = "Cão";
            this.radioButtonCao.UseVisualStyleBackColor = true;
            // 
            // radioButtonGato
            // 
            this.radioButtonGato.AutoSize = true;
            this.radioButtonGato.Location = new System.Drawing.Point(676, 159);
            this.radioButtonGato.Name = "radioButtonGato";
            this.radioButtonGato.Size = new System.Drawing.Size(50, 19);
            this.radioButtonGato.TabIndex = 9;
            this.radioButtonGato.TabStop = true;
            this.radioButtonGato.Text = "Gato";
            this.radioButtonGato.UseVisualStyleBackColor = true;
            // 
            // labelEspecie
            // 
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.Location = new System.Drawing.Point(594, 143);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(46, 15);
            this.labelEspecie.TabIndex = 10;
            this.labelEspecie.Text = "Espécie";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(594, 197);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 11;
            this.labelGenero.Text = "Gênero";
            // 
            // radioButtonFemea
            // 
            this.radioButtonFemea.AutoSize = true;
            this.radioButtonFemea.Location = new System.Drawing.Point(595, 224);
            this.radioButtonFemea.Name = "radioButtonFemea";
            this.radioButtonFemea.Size = new System.Drawing.Size(60, 19);
            this.radioButtonFemea.TabIndex = 12;
            this.radioButtonFemea.TabStop = true;
            this.radioButtonFemea.Text = "Fêmea";
            this.radioButtonFemea.UseVisualStyleBackColor = true;
            // 
            // radioButtonMacho
            // 
            this.radioButtonMacho.AutoSize = true;
            this.radioButtonMacho.Location = new System.Drawing.Point(676, 224);
            this.radioButtonMacho.Name = "radioButtonMacho";
            this.radioButtonMacho.Size = new System.Drawing.Size(62, 19);
            this.radioButtonMacho.TabIndex = 13;
            this.radioButtonMacho.TabStop = true;
            this.radioButtonMacho.Text = "Macho";
            this.radioButtonMacho.UseVisualStyleBackColor = true;
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Location = new System.Drawing.Point(591, 256);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(32, 15);
            this.labelRaca.TabIndex = 14;
            this.labelRaca.Text = "Raça";
            // 
            // comboBoxRaca
            // 
            this.comboBoxRaca.FormattingEnabled = true;
            this.comboBoxRaca.Location = new System.Drawing.Point(593, 281);
            this.comboBoxRaca.Name = "comboBoxRaca";
            this.comboBoxRaca.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRaca.TabIndex = 15;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(588, 337);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDataNascimento.TabIndex = 16;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(589, 319);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.labelDataNascimento.TabIndex = 17;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(590, 370);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(32, 15);
            this.labelPeso.TabIndex = 18;
            this.labelPeso.Text = "Peso";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(594, 392);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 23);
            this.textBoxPeso.TabIndex = 19;
            // 
            // labelVacinas
            // 
            this.labelVacinas.AutoSize = true;
            this.labelVacinas.Location = new System.Drawing.Point(591, 428);
            this.labelVacinas.Name = "labelVacinas";
            this.labelVacinas.Size = new System.Drawing.Size(46, 15);
            this.labelVacinas.TabIndex = 20;
            this.labelVacinas.Text = "Vacinas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(593, 452);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(593, 477);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(592, 500);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 19);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // labelAlergia
            // 
            this.labelAlergia.AutoSize = true;
            this.labelAlergia.Location = new System.Drawing.Point(591, 529);
            this.labelAlergia.Name = "labelAlergia";
            this.labelAlergia.Size = new System.Drawing.Size(44, 15);
            this.labelAlergia.TabIndex = 24;
            this.labelAlergia.Text = "Alergia";
            // 
            // comboBoxAlergia
            // 
            this.comboBoxAlergia.FormattingEnabled = true;
            this.comboBoxAlergia.Location = new System.Drawing.Point(595, 556);
            this.comboBoxAlergia.Name = "comboBoxAlergia";
            this.comboBoxAlergia.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAlergia.TabIndex = 25;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(534, 608);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(658, 611);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 27;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxAlergia);
            this.Controls.Add(this.labelAlergia);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelVacinas);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.comboBoxRaca);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.radioButtonMacho);
            this.Controls.Add(this.radioButtonFemea);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelEspecie);
            this.Controls.Add(this.radioButtonGato);
            this.Controls.Add(this.radioButtonCao);
            this.Controls.Add(this.comboBoxTutor);
            this.Controls.Add(this.labelNomeTutor);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelListaPets);
            this.Controls.Add(this.dataGridViewPets);
            this.Name = "PetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewPets;
        private Label labelListaPets;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelNomeTutor;
        private ComboBox comboBoxTutor;
        private RadioButton radioButtonCao;
        private RadioButton radioButtonGato;
        private Label labelEspecie;
        private Label labelGenero;
        private RadioButton radioButtonFemea;
        private RadioButton radioButtonMacho;
        private Label labelRaca;
        private ComboBox comboBoxRaca;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelDataNascimento;
        private Label labelPeso;
        private TextBox textBoxPeso;
        private Label labelVacinas;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label labelAlergia;
        private ComboBox comboBoxAlergia;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}