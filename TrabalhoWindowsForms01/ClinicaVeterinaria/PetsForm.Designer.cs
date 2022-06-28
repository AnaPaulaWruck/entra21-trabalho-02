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
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVacinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labelSexo = new System.Windows.Forms.Label();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.labelRaca = new System.Windows.Forms.Label();
            this.comboBoxRaca = new System.Windows.Forms.ComboBox();
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
            this.checkBoxVacinaQuintupla = new System.Windows.Forms.CheckBox();
            this.checkBoxVacinaGiardiase = new System.Windows.Forms.CheckBox();
            this.checkBoxVacinaQuadrupla = new System.Windows.Forms.CheckBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.labelKg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).BeginInit();
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
            this.ColumnRaca,
            this.ColumnSexo,
            this.ColumnIdade,
            this.ColumnPeso,
            this.ColumnVacinas,
            this.ColumnAlergias});
            this.dataGridViewPets.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewPets.Name = "dataGridViewPets";
            this.dataGridViewPets.ReadOnly = true;
            this.dataGridViewPets.RowTemplate.Height = 25;
            this.dataGridViewPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPets.Size = new System.Drawing.Size(660, 484);
            this.dataGridViewPets.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "COD";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
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
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "RAÇA";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            this.ColumnRaca.Width = 150;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "SEXO";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            this.ColumnSexo.Width = 90;
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.HeaderText = "IDADE";
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            this.ColumnIdade.Width = 75;
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
            this.buttonEditar.Location = new System.Drawing.Point(486, 547);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(90, 36);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(582, 547);
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
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(689, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(282, 27);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelNomeTutor
            // 
            this.labelNomeTutor.AutoSize = true;
            this.labelNomeTutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomeTutor.Location = new System.Drawing.Point(689, 84);
            this.labelNomeTutor.Name = "labelNomeTutor";
            this.labelNomeTutor.Size = new System.Drawing.Size(116, 21);
            this.labelNomeTutor.TabIndex = 6;
            this.labelNomeTutor.Text = "Nome do Tutor";
            // 
            // comboBoxTutor
            // 
            this.comboBoxTutor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTutor.FormattingEnabled = true;
            this.comboBoxTutor.Location = new System.Drawing.Point(689, 111);
            this.comboBoxTutor.Name = "comboBoxTutor";
            this.comboBoxTutor.Size = new System.Drawing.Size(282, 28);
            this.comboBoxTutor.TabIndex = 7;
            // 
            // radioButtonCao
            // 
            this.radioButtonCao.AutoSize = true;
            this.radioButtonCao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCao.Location = new System.Drawing.Point(772, 147);
            this.radioButtonCao.Name = "radioButtonCao";
            this.radioButtonCao.Size = new System.Drawing.Size(53, 24);
            this.radioButtonCao.TabIndex = 8;
            this.radioButtonCao.TabStop = true;
            this.radioButtonCao.Text = "Cão";
            this.radioButtonCao.UseVisualStyleBackColor = true;
            // 
            // radioButtonGato
            // 
            this.radioButtonGato.AutoSize = true;
            this.radioButtonGato.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGato.Location = new System.Drawing.Point(861, 147);
            this.radioButtonGato.Name = "radioButtonGato";
            this.radioButtonGato.Size = new System.Drawing.Size(59, 24);
            this.radioButtonGato.TabIndex = 9;
            this.radioButtonGato.TabStop = true;
            this.radioButtonGato.Text = "Gato";
            this.radioButtonGato.UseVisualStyleBackColor = true;
            // 
            // labelEspecie
            // 
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEspecie.Location = new System.Drawing.Point(689, 149);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(64, 21);
            this.labelEspecie.TabIndex = 10;
            this.labelEspecie.Text = "Espécie:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSexo.Location = new System.Drawing.Point(689, 248);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(46, 21);
            this.labelSexo.TabIndex = 11;
            this.labelSexo.Text = "Sexo:";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFeminino.Location = new System.Drawing.Point(753, 246);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(88, 24);
            this.radioButtonFeminino.TabIndex = 12;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMasculino.Location = new System.Drawing.Point(861, 246);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(94, 24);
            this.radioButtonMasculino.TabIndex = 13;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRaca.Location = new System.Drawing.Point(689, 179);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(43, 21);
            this.labelRaca.TabIndex = 14;
            this.labelRaca.Text = "Raça";
            // 
            // comboBoxRaca
            // 
            this.comboBoxRaca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRaca.FormattingEnabled = true;
            this.comboBoxRaca.Location = new System.Drawing.Point(689, 206);
            this.comboBoxRaca.Name = "comboBoxRaca";
            this.comboBoxRaca.Size = new System.Drawing.Size(282, 28);
            this.comboBoxRaca.TabIndex = 15;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(845, 280);
            this.dateTimePickerDataNascimento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(126, 27);
            this.dateTimePickerDataNascimento.TabIndex = 16;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(689, 283);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(153, 21);
            this.labelDataNascimento.TabIndex = 17;
            this.labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeso.Location = new System.Drawing.Point(689, 324);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(45, 21);
            this.labelPeso.TabIndex = 18;
            this.labelPeso.Text = "Peso:";
            // 
            // labelVacinas
            // 
            this.labelVacinas.AutoSize = true;
            this.labelVacinas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVacinas.Location = new System.Drawing.Point(689, 358);
            this.labelVacinas.Name = "labelVacinas";
            this.labelVacinas.Size = new System.Drawing.Size(65, 21);
            this.labelVacinas.TabIndex = 20;
            this.labelVacinas.Text = "Vacinas:";
            // 
            // checkBoxVacinaAntirrabica
            // 
            this.checkBoxVacinaAntirrabica.AutoSize = true;
            this.checkBoxVacinaAntirrabica.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaAntirrabica.Location = new System.Drawing.Point(704, 385);
            this.checkBoxVacinaAntirrabica.Name = "checkBoxVacinaAntirrabica";
            this.checkBoxVacinaAntirrabica.Size = new System.Drawing.Size(101, 24);
            this.checkBoxVacinaAntirrabica.TabIndex = 21;
            this.checkBoxVacinaAntirrabica.Text = "Antirrábica";
            this.checkBoxVacinaAntirrabica.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaV8
            // 
            this.checkBoxVacinaV8.AutoSize = true;
            this.checkBoxVacinaV8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaV8.Location = new System.Drawing.Point(704, 412);
            this.checkBoxVacinaV8.Name = "checkBoxVacinaV8";
            this.checkBoxVacinaV8.Size = new System.Drawing.Size(45, 24);
            this.checkBoxVacinaV8.TabIndex = 22;
            this.checkBoxVacinaV8.Text = "V8";
            this.checkBoxVacinaV8.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaV10
            // 
            this.checkBoxVacinaV10.AutoSize = true;
            this.checkBoxVacinaV10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaV10.Location = new System.Drawing.Point(704, 439);
            this.checkBoxVacinaV10.Name = "checkBoxVacinaV10";
            this.checkBoxVacinaV10.Size = new System.Drawing.Size(53, 24);
            this.checkBoxVacinaV10.TabIndex = 23;
            this.checkBoxVacinaV10.Text = "V10";
            this.checkBoxVacinaV10.UseVisualStyleBackColor = true;
            // 
            // labelAlergia
            // 
            this.labelAlergia.AutoSize = true;
            this.labelAlergia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAlergia.Location = new System.Drawing.Point(689, 474);
            this.labelAlergia.Name = "labelAlergia";
            this.labelAlergia.Size = new System.Drawing.Size(59, 21);
            this.labelAlergia.TabIndex = 24;
            this.labelAlergia.Text = "Alergia";
            // 
            // comboBoxAlergia
            // 
            this.comboBoxAlergia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAlergia.FormattingEnabled = true;
            this.comboBoxAlergia.Location = new System.Drawing.Point(689, 501);
            this.comboBoxAlergia.Name = "comboBoxAlergia";
            this.comboBoxAlergia.Size = new System.Drawing.Size(282, 28);
            this.comboBoxAlergia.TabIndex = 25;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(786, 547);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 36);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(882, 547);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(90, 36);
            this.buttonSalvar.TabIndex = 27;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaQuintupla
            // 
            this.checkBoxVacinaQuintupla.AutoSize = true;
            this.checkBoxVacinaQuintupla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaQuintupla.Location = new System.Drawing.Point(831, 445);
            this.checkBoxVacinaQuintupla.Name = "checkBoxVacinaQuintupla";
            this.checkBoxVacinaQuintupla.Size = new System.Drawing.Size(134, 24);
            this.checkBoxVacinaQuintupla.TabIndex = 28;
            this.checkBoxVacinaQuintupla.Text = "Quintupla felina";
            this.checkBoxVacinaQuintupla.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaGiardiase
            // 
            this.checkBoxVacinaGiardiase.AutoSize = true;
            this.checkBoxVacinaGiardiase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaGiardiase.Location = new System.Drawing.Point(831, 385);
            this.checkBoxVacinaGiardiase.Name = "checkBoxVacinaGiardiase";
            this.checkBoxVacinaGiardiase.Size = new System.Drawing.Size(90, 24);
            this.checkBoxVacinaGiardiase.TabIndex = 29;
            this.checkBoxVacinaGiardiase.Text = "Giardíase";
            this.checkBoxVacinaGiardiase.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacinaQuadrupla
            // 
            this.checkBoxVacinaQuadrupla.AutoSize = true;
            this.checkBoxVacinaQuadrupla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacinaQuadrupla.Location = new System.Drawing.Point(831, 415);
            this.checkBoxVacinaQuadrupla.Name = "checkBoxVacinaQuadrupla";
            this.checkBoxVacinaQuadrupla.Size = new System.Drawing.Size(139, 24);
            this.checkBoxVacinaQuadrupla.TabIndex = 30;
            this.checkBoxVacinaQuadrupla.Text = "Quádrupla felina";
            this.checkBoxVacinaQuadrupla.UseVisualStyleBackColor = true;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPeso.Location = new System.Drawing.Point(740, 321);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(199, 27);
            this.textBoxPeso.TabIndex = 32;
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKg.Location = new System.Drawing.Point(943, 324);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(28, 21);
            this.labelKg.TabIndex = 33;
            this.labelKg.Text = "Kg";
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 597);
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
            this.Controls.Add(this.comboBoxRaca);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.labelSexo);
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
        private Label labelSexo;
        private RadioButton radioButtonFeminino;
        private RadioButton radioButtonMasculino;
        private Label labelRaca;
        private ComboBox comboBoxRaca;
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
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnTutor;
        private DataGridViewTextBoxColumn ColumnEspecie;
        private DataGridViewTextBoxColumn ColumnRaca;
        private DataGridViewTextBoxColumn ColumnSexo;
        private DataGridViewTextBoxColumn ColumnIdade;
        private DataGridViewTextBoxColumn ColumnPeso;
        private DataGridViewTextBoxColumn ColumnVacinas;
        private DataGridViewTextBoxColumn ColumnAlergias;
        private CheckBox checkBoxVacinaQuintupla;
        private CheckBox checkBoxVacinaGiardiase;
        private CheckBox checkBoxVacinaQuadrupla;
        private TextBox textBoxPeso;
        private Label labelKg;
    }
}