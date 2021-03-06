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
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVacinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListaPets = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.radioButtonFemea = new System.Windows.Forms.RadioButton();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.labelRaca = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelVacinas = new System.Windows.Forms.Label();
            this.checkBoxVacinaAntirrabica = new System.Windows.Forms.CheckBox();
            this.checkBoxVacinaV8 = new System.Windows.Forms.CheckBox();
            this.checkBoxVacinaV10 = new System.Windows.Forms.CheckBox();
            this.labelAlergia = new System.Windows.Forms.Label();
            this.comboBoxAlergia = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelKg = new System.Windows.Forms.Label();
            this.radioButtonGato = new System.Windows.Forms.RadioButton();
            this.radioButtonCao = new System.Windows.Forms.RadioButton();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.groupBoxEspecie = new System.Windows.Forms.GroupBox();
            this.textBoxRaca = new System.Windows.Forms.TextBox();
            this.checkBoxVacinaQuintupla = new System.Windows.Forms.CheckBox();
            this.checkBoxVacinaGiardiase = new System.Windows.Forms.CheckBox();
            this.checkBoxVacinaQuadrupla = new System.Windows.Forms.CheckBox();
            this.buttonVoltarParaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxEspecie.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPets
            // 
            this.dataGridViewPets.AllowUserToAddRows = false;
            this.dataGridViewPets.AllowUserToDeleteRows = false;
            this.dataGridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnTutor,
            this.ColumnEspecie,
            this.ColumnSexo,
            this.ColumnRaca,
            this.ColumnDataNascimento,
            this.ColumnPeso,
            this.ColumnVacinas,
            this.ColumnAlergias});
            this.dataGridViewPets.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewPets.Name = "dataGridViewPets";
            this.dataGridViewPets.ReadOnly = true;
            this.dataGridViewPets.RowTemplate.Height = 25;
            this.dataGridViewPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPets.Size = new System.Drawing.Size(660, 418);
            this.dataGridViewPets.TabIndex = 0;
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
            // ColumnTutor
            // 
            this.ColumnTutor.HeaderText = "TUTOR";
            this.ColumnTutor.Name = "ColumnTutor";
            this.ColumnTutor.ReadOnly = true;
            this.ColumnTutor.Width = 150;
            // 
            // ColumnEspecie
            // 
            this.ColumnEspecie.HeaderText = "ESPÉCIE";
            this.ColumnEspecie.Name = "ColumnEspecie";
            this.ColumnEspecie.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "SEXO";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            this.ColumnSexo.Width = 90;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "RAÇA";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            this.ColumnRaca.Width = 150;
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.HeaderText = "DATA NASCIMENTO";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            this.ColumnDataNascimento.ReadOnly = true;
            this.ColumnDataNascimento.Width = 150;
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.HeaderText = "PESO";
            this.ColumnPeso.Name = "ColumnPeso";
            this.ColumnPeso.ReadOnly = true;
            this.ColumnPeso.Width = 75;
            // 
            // ColumnVacinas
            // 
            this.ColumnVacinas.HeaderText = "VACINAS";
            this.ColumnVacinas.Name = "ColumnVacinas";
            this.ColumnVacinas.ReadOnly = true;
            this.ColumnVacinas.Width = 150;
            // 
            // ColumnAlergias
            // 
            this.ColumnAlergias.HeaderText = "ALERGIAS";
            this.ColumnAlergias.Name = "ColumnAlergias";
            this.ColumnAlergias.ReadOnly = true;
            this.ColumnAlergias.Width = 150;
            // 
            // labelListaPets
            // 
            this.labelListaPets.AutoSize = true;
            this.labelListaPets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListaPets.Location = new System.Drawing.Point(12, 12);
            this.labelListaPets.Name = "labelListaPets";
            this.labelListaPets.Size = new System.Drawing.Size(72, 15);
            this.labelListaPets.TabIndex = 1;
            this.labelListaPets.Text = "Lista de Pets";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(486, 463);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(90, 26);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(582, 463);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(90, 26);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(689, 13);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(689, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(282, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(689, 65);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(88, 15);
            this.labelCliente.TabIndex = 6;
            this.labelCliente.Text = "Nome do Tutor";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(689, 86);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(282, 23);
            this.comboBoxCliente.TabIndex = 7;
            // 
            // radioButtonFemea
            // 
            this.radioButtonFemea.AutoSize = true;
            this.radioButtonFemea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFemea.Location = new System.Drawing.Point(22, 24);
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
            this.radioButtonMacho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMacho.Location = new System.Drawing.Point(22, 48);
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
            this.labelRaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRaca.Location = new System.Drawing.Point(689, 199);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(32, 15);
            this.labelRaca.TabIndex = 14;
            this.labelRaca.Text = "Raça";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDataNascimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(813, 250);
            this.dateTimePickerDataNascimento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(158, 23);
            this.dateTimePickerDataNascimento.TabIndex = 16;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(689, 254);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(117, 15);
            this.labelDataNascimento.TabIndex = 17;
            this.labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeso.Location = new System.Drawing.Point(689, 284);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(35, 15);
            this.labelPeso.TabIndex = 18;
            this.labelPeso.Text = "Peso:";
            // 
            // labelVacinas
            // 
            this.labelVacinas.AutoSize = true;
            this.labelVacinas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVacinas.Location = new System.Drawing.Point(689, 311);
            this.labelVacinas.Name = "labelVacinas";
            this.labelVacinas.Size = new System.Drawing.Size(49, 15);
            this.labelVacinas.TabIndex = 20;
            this.labelVacinas.Text = "Vacinas:";
            // 
            // checkBoxVacinaAntirrabica
            // 
            this.checkBoxVacinaAntirrabica.AutoSize = true;
            this.checkBoxVacinaAntirrabica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaAntirrabica.Location = new System.Drawing.Point(704, 334);
            this.checkBoxVacinaAntirrabica.Name = "checkBoxVacinaAntirrabica";
            this.checkBoxVacinaAntirrabica.Size = new System.Drawing.Size(84, 19);
            this.checkBoxVacinaAntirrabica.TabIndex = 21;
            this.checkBoxVacinaAntirrabica.Text = "Antirrábica";
            this.checkBoxVacinaAntirrabica.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaV8
            // 
            this.checkBoxVacinaV8.AutoSize = true;
            this.checkBoxVacinaV8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaV8.Location = new System.Drawing.Point(704, 359);
            this.checkBoxVacinaV8.Name = "checkBoxVacinaV8";
            this.checkBoxVacinaV8.Size = new System.Drawing.Size(39, 19);
            this.checkBoxVacinaV8.TabIndex = 22;
            this.checkBoxVacinaV8.Text = "V8";
            this.checkBoxVacinaV8.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaV10
            // 
            this.checkBoxVacinaV10.AutoSize = true;
            this.checkBoxVacinaV10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaV10.Location = new System.Drawing.Point(704, 384);
            this.checkBoxVacinaV10.Name = "checkBoxVacinaV10";
            this.checkBoxVacinaV10.Size = new System.Drawing.Size(45, 19);
            this.checkBoxVacinaV10.TabIndex = 23;
            this.checkBoxVacinaV10.Text = "V10";
            this.checkBoxVacinaV10.UseVisualStyleBackColor = true;
            // 
            // labelAlergia
            // 
            this.labelAlergia.AutoSize = true;
            this.labelAlergia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAlergia.Location = new System.Drawing.Point(689, 408);
            this.labelAlergia.Name = "labelAlergia";
            this.labelAlergia.Size = new System.Drawing.Size(44, 15);
            this.labelAlergia.TabIndex = 24;
            this.labelAlergia.Text = "Alergia";
            // 
            // comboBoxAlergia
            // 
            this.comboBoxAlergia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAlergia.FormattingEnabled = true;
            this.comboBoxAlergia.Location = new System.Drawing.Point(689, 428);
            this.comboBoxAlergia.Name = "comboBoxAlergia";
            this.comboBoxAlergia.Size = new System.Drawing.Size(282, 23);
            this.comboBoxAlergia.TabIndex = 25;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(785, 463);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 26);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(881, 463);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(90, 26);
            this.buttonSalvar.TabIndex = 27;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPeso.Location = new System.Drawing.Point(740, 281);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(204, 23);
            this.textBoxPeso.TabIndex = 32;
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKg.Location = new System.Drawing.Point(950, 284);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(21, 15);
            this.labelKg.TabIndex = 33;
            this.labelKg.Text = "Kg";
            // 
            // radioButtonGato
            // 
            this.radioButtonGato.AutoSize = true;
            this.radioButtonGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGato.Location = new System.Drawing.Point(21, 47);
            this.radioButtonGato.Name = "radioButtonGato";
            this.radioButtonGato.Size = new System.Drawing.Size(51, 19);
            this.radioButtonGato.TabIndex = 9;
            this.radioButtonGato.TabStop = true;
            this.radioButtonGato.Text = "Gato";
            this.radioButtonGato.UseVisualStyleBackColor = true;
            // 
            // radioButtonCao
            // 
            this.radioButtonCao.AutoSize = true;
            this.radioButtonCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCao.Location = new System.Drawing.Point(21, 22);
            this.radioButtonCao.Name = "radioButtonCao";
            this.radioButtonCao.Size = new System.Drawing.Size(46, 19);
            this.radioButtonCao.TabIndex = 8;
            this.radioButtonCao.TabStop = true;
            this.radioButtonCao.Text = "Cão";
            this.radioButtonCao.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.groupBoxSexo.Controls.Add(this.radioButtonMacho);
            this.groupBoxSexo.Controls.Add(this.radioButtonFemea);
            this.groupBoxSexo.Location = new System.Drawing.Point(833, 119);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(138, 75);
            this.groupBoxSexo.TabIndex = 36;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // groupBoxEspecie
            // 
            this.groupBoxEspecie.Controls.Add(this.radioButtonCao);
            this.groupBoxEspecie.Controls.Add(this.radioButtonGato);
            this.groupBoxEspecie.Location = new System.Drawing.Point(689, 119);
            this.groupBoxEspecie.Name = "groupBoxEspecie";
            this.groupBoxEspecie.Size = new System.Drawing.Size(138, 75);
            this.groupBoxEspecie.TabIndex = 37;
            this.groupBoxEspecie.TabStop = false;
            this.groupBoxEspecie.Text = "Espécie:";
            // 
            // textBoxRaca
            // 
            this.textBoxRaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRaca.Location = new System.Drawing.Point(689, 219);
            this.textBoxRaca.Name = "textBoxRaca";
            this.textBoxRaca.Size = new System.Drawing.Size(282, 23);
            this.textBoxRaca.TabIndex = 38;
            // 
            // checkBoxVacinaQuintupla
            // 
            this.checkBoxVacinaQuintupla.AutoSize = true;
            this.checkBoxVacinaQuintupla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaQuintupla.Location = new System.Drawing.Point(831, 390);
            this.checkBoxVacinaQuintupla.Name = "checkBoxVacinaQuintupla";
            this.checkBoxVacinaQuintupla.Size = new System.Drawing.Size(111, 19);
            this.checkBoxVacinaQuintupla.TabIndex = 28;
            this.checkBoxVacinaQuintupla.Text = "Quintupla felina";
            this.checkBoxVacinaQuintupla.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaGiardiase
            // 
            this.checkBoxVacinaGiardiase.AutoSize = true;
            this.checkBoxVacinaGiardiase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaGiardiase.Location = new System.Drawing.Point(831, 334);
            this.checkBoxVacinaGiardiase.Name = "checkBoxVacinaGiardiase";
            this.checkBoxVacinaGiardiase.Size = new System.Drawing.Size(74, 19);
            this.checkBoxVacinaGiardiase.TabIndex = 29;
            this.checkBoxVacinaGiardiase.Text = "Giardíase";
            this.checkBoxVacinaGiardiase.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaQuadrupla
            // 
            this.checkBoxVacinaQuadrupla.AutoSize = true;
            this.checkBoxVacinaQuadrupla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaQuadrupla.Location = new System.Drawing.Point(831, 362);
            this.checkBoxVacinaQuadrupla.Name = "checkBoxVacinaQuadrupla";
            this.checkBoxVacinaQuadrupla.Size = new System.Drawing.Size(114, 19);
            this.checkBoxVacinaQuadrupla.TabIndex = 30;
            this.checkBoxVacinaQuadrupla.Text = "Quádrupla felina";
            this.checkBoxVacinaQuadrupla.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarParaMenu
            // 
            this.buttonVoltarParaMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVoltarParaMenu.Location = new System.Drawing.Point(12, 465);
            this.buttonVoltarParaMenu.Name = "buttonVoltarParaMenu";
            this.buttonVoltarParaMenu.Size = new System.Drawing.Size(115, 23);
            this.buttonVoltarParaMenu.TabIndex = 39;
            this.buttonVoltarParaMenu.Text = "Voltar ao Menu";
            this.buttonVoltarParaMenu.UseVisualStyleBackColor = true;
            this.buttonVoltarParaMenu.Click += new System.EventHandler(this.buttonVoltarParaMenu_Click);
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 500);
            this.Controls.Add(this.buttonVoltarParaMenu);
            this.Controls.Add(this.textBoxRaca);
            this.Controls.Add(this.groupBoxEspecie);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.labelKg);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.checkBoxVacinaQuadrupla);
            this.Controls.Add(this.checkBoxVacinaGiardiase);
            this.Controls.Add(this.checkBoxVacinaQuintupla);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxAlergia);
            this.Controls.Add(this.labelAlergia);
            this.Controls.Add(this.checkBoxVacinaV10);
            this.Controls.Add(this.checkBoxVacinaV8);
            this.Controls.Add(this.checkBoxVacinaAntirrabica);
            this.Controls.Add(this.labelVacinas);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelListaPets);
            this.Controls.Add(this.dataGridViewPets);
            this.Name = "PetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pets";
            this.Load += new System.EventHandler(this.PetsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.groupBoxEspecie.ResumeLayout(false);
            this.groupBoxEspecie.PerformLayout();
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
        private Label labelCliente;
        private ComboBox comboBoxCliente;
        private RadioButton radioButtonFemea;
        private RadioButton radioButtonMacho;
        private Label labelRaca;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelDataNascimento;
        private Label labelPeso;
        private Label labelVacinas;
        private CheckBox checkBoxVacinaAntirrabica;
        private CheckBox checkBoxVacinaV8;
        private CheckBox checkBoxVacinaV10;
        private Label labelAlergia;
        private ComboBox comboBoxAlergia;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private TextBox textBoxPeso;
        private Label labelKg;
        private RadioButton radioButtonGato;
        private RadioButton radioButtonCao;
        private GroupBox groupBoxSexo;
        private GroupBox groupBoxEspecie;
        private TextBox textBoxRaca;
        private CheckBox checkBoxVacinaQuintupla;
        private CheckBox checkBoxVacinaGiardiase;
        private CheckBox checkBoxVacinaQuadrupla;
        private Button buttonVoltarParaMenu;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnTutor;
        private DataGridViewTextBoxColumn ColumnEspecie;
        private DataGridViewTextBoxColumn ColumnSexo;
        private DataGridViewTextBoxColumn ColumnRaca;
        private DataGridViewTextBoxColumn ColumnDataNascimento;
        private DataGridViewTextBoxColumn ColumnPeso;
        private DataGridViewTextBoxColumn ColumnVacinas;
        private DataGridViewTextBoxColumn ColumnAlergias;
    }
}