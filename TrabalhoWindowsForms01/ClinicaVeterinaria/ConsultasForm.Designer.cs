namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    partial class ConsultasForm
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
            this.checkedListBoxSintomas = new System.Windows.Forms.CheckedListBox();
            this.radioButtonUrgente = new System.Windows.Forms.RadioButton();
            this.radioButtonRotina = new System.Windows.Forms.RadioButton();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.labelVeterinario = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxPet = new System.Windows.Forms.ComboBox();
            this.labelPet = new System.Windows.Forms.Label();
            this.labelCheckList = new System.Windows.Forms.Label();
            this.labelTipoDeConsulta = new System.Windows.Forms.Label();
            this.dateTimePickerDia = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHorario = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoDeConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxSintomas
            // 
            this.checkedListBoxSintomas.FormattingEnabled = true;
            this.checkedListBoxSintomas.Items.AddRange(new object[] {
            "Convulsão",
            "Hemorragia",
            "Dispneia (falta de ar)",
            "Obstrução urinária ",
            "Vômito",
            "Diarreia  ",
            "Halitose",
            "Coceira intensa",
            "Desnutrição",
            "Outros"});
            this.checkedListBoxSintomas.Location = new System.Drawing.Point(311, 43);
            this.checkedListBoxSintomas.Name = "checkedListBoxSintomas";
            this.checkedListBoxSintomas.Size = new System.Drawing.Size(255, 224);
            this.checkedListBoxSintomas.TabIndex = 0;
            // 
            // radioButtonUrgente
            // 
            this.radioButtonUrgente.AutoSize = true;
            this.radioButtonUrgente.Location = new System.Drawing.Point(13, 220);
            this.radioButtonUrgente.Name = "radioButtonUrgente";
            this.radioButtonUrgente.Size = new System.Drawing.Size(83, 24);
            this.radioButtonUrgente.TabIndex = 1;
            this.radioButtonUrgente.TabStop = true;
            this.radioButtonUrgente.Text = "Urgente";
            this.radioButtonUrgente.UseVisualStyleBackColor = true;
            // 
            // radioButtonRotina
            // 
            this.radioButtonRotina.AutoSize = true;
            this.radioButtonRotina.Location = new System.Drawing.Point(11, 251);
            this.radioButtonRotina.Name = "radioButtonRotina";
            this.radioButtonRotina.Size = new System.Drawing.Size(73, 24);
            this.radioButtonRotina.TabIndex = 2;
            this.radioButtonRotina.TabStop = true;
            this.radioButtonRotina.Text = "Rotina";
            this.radioButtonRotina.UseVisualStyleBackColor = true;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(13, 152);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(255, 28);
            this.comboBoxVeterinario.TabIndex = 3;
            // 
            // labelVeterinario
            // 
            this.labelVeterinario.AutoSize = true;
            this.labelVeterinario.Location = new System.Drawing.Point(13, 129);
            this.labelVeterinario.Name = "labelVeterinario";
            this.labelVeterinario.Size = new System.Drawing.Size(103, 20);
            this.labelVeterinario.TabIndex = 4;
            this.labelVeterinario.Text = "Veterinário (a)";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(13, 75);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 20);
            this.labelCliente.TabIndex = 5;
            this.labelCliente.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(13, 99);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(255, 28);
            this.comboBoxCliente.TabIndex = 6;
            // 
            // comboBoxPet
            // 
            this.comboBoxPet.FormattingEnabled = true;
            this.comboBoxPet.Location = new System.Drawing.Point(13, 44);
            this.comboBoxPet.Name = "comboBoxPet";
            this.comboBoxPet.Size = new System.Drawing.Size(255, 28);
            this.comboBoxPet.TabIndex = 7;
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Location = new System.Drawing.Point(13, 19);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(149, 20);
            this.labelPet.TabIndex = 8;
            this.labelPet.Text = "Animal de Estimação";
            // 
            // labelCheckList
            // 
            this.labelCheckList.AutoSize = true;
            this.labelCheckList.Location = new System.Drawing.Point(311, 19);
            this.labelCheckList.Name = "labelCheckList";
            this.labelCheckList.Size = new System.Drawing.Size(70, 20);
            this.labelCheckList.TabIndex = 9;
            this.labelCheckList.Text = "Sintomas";
            // 
            // labelTipoDeConsulta
            // 
            this.labelTipoDeConsulta.AutoSize = true;
            this.labelTipoDeConsulta.Location = new System.Drawing.Point(13, 197);
            this.labelTipoDeConsulta.Name = "labelTipoDeConsulta";
            this.labelTipoDeConsulta.Size = new System.Drawing.Size(121, 20);
            this.labelTipoDeConsulta.TabIndex = 10;
            this.labelTipoDeConsulta.Text = "Tipo de Consulta";
            // 
            // dateTimePickerDia
            // 
            this.dateTimePickerDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDia.Location = new System.Drawing.Point(71, 306);
            this.dateTimePickerDia.Name = "dateTimePickerDia";
            this.dateTimePickerDia.Size = new System.Drawing.Size(150, 27);
            this.dateTimePickerDia.TabIndex = 11;
            // 
            // dateTimePickerHorario
            // 
            this.dateTimePickerHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHorario.Location = new System.Drawing.Point(71, 368);
            this.dateTimePickerHorario.Name = "dateTimePickerHorario";
            this.dateTimePickerHorario.Size = new System.Drawing.Size(150, 27);
            this.dateTimePickerHorario.TabIndex = 12;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(88, 283);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(123, 20);
            this.labelData.TabIndex = 13;
            this.labelData.Text = "Data da Consulta";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(79, 345);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(142, 20);
            this.labelHora.TabIndex = 14;
            this.labelHora.Text = "Horário da Consulta";
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnPet,
            this.ColumnCliente,
            this.ColumnVeterinario,
            this.ColumnTipoDeConsulta,
            this.ColumnData,
            this.ColumnHora});
            this.dataGridViewConsultas.Location = new System.Drawing.Point(586, 43);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.RowHeadersWidth = 51;
            this.dataGridViewConsultas.RowTemplate.Height = 29;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(747, 400);
            this.dataGridViewConsultas.TabIndex = 15;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 70;
            // 
            // ColumnPet
            // 
            this.ColumnPet.HeaderText = "Animal de Estimação";
            this.ColumnPet.MinimumWidth = 6;
            this.ColumnPet.Name = "ColumnPet";
            this.ColumnPet.Width = 125;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.MinimumWidth = 6;
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.Width = 125;
            // 
            // ColumnVeterinario
            // 
            this.ColumnVeterinario.HeaderText = "Veterinario (a)";
            this.ColumnVeterinario.MinimumWidth = 6;
            this.ColumnVeterinario.Name = "ColumnVeterinario";
            this.ColumnVeterinario.Width = 125;
            // 
            // ColumnTipoDeConsulta
            // 
            this.ColumnTipoDeConsulta.HeaderText = "Tipo de Consulta";
            this.ColumnTipoDeConsulta.MinimumWidth = 6;
            this.ColumnTipoDeConsulta.Name = "ColumnTipoDeConsulta";
            this.ColumnTipoDeConsulta.Width = 90;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data ";
            this.ColumnData.MinimumWidth = 6;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.Width = 90;
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.MinimumWidth = 6;
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.Width = 90;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(586, 7);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 29);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(773, 7);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(94, 29);
            this.buttonApagar.TabIndex = 17;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(310, 283);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(121, 29);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(437, 283);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(129, 29);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 471);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewConsultas);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePickerHorario);
            this.Controls.Add(this.dateTimePickerDia);
            this.Controls.Add(this.labelTipoDeConsulta);
            this.Controls.Add(this.labelCheckList);
            this.Controls.Add(this.labelPet);
            this.Controls.Add(this.comboBoxPet);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelVeterinario);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.radioButtonRotina);
            this.Controls.Add(this.radioButtonUrgente);
            this.Controls.Add(this.checkedListBoxSintomas);
            this.Name = "ConsultasForm";
            this.Text = "Cadastro de Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBoxSintomas;
        private RadioButton radioButtonUrgente;
        private RadioButton radioButtonRotina;
        private ComboBox comboBoxVeterinario;
        private Label labelVeterinario;
        private Label labelCliente;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxPet;
        private Label labelPet;
        private Label labelCheckList;
        private Label labelTipoDeConsulta;
        private DateTimePicker dateTimePickerDia;
        private DateTimePicker dateTimePickerHorario;
        private Label labelData;
        private Label labelHora;
        private DataGridView dataGridViewConsultas;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnPet;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnVeterinario;
        private DataGridViewTextBoxColumn ColumnTipoDeConsulta;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn ColumnHora;
        private Button buttonEditar;
        private Button buttonApagar;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}