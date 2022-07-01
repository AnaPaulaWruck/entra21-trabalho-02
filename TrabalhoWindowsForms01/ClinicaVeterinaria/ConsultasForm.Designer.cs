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
            this.checkedListBoxSintomas.Location = new System.Drawing.Point(272, 32);
            this.checkedListBoxSintomas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxSintomas.Name = "checkedListBoxSintomas";
            this.checkedListBoxSintomas.Size = new System.Drawing.Size(224, 166);
            this.checkedListBoxSintomas.TabIndex = 0;
            // 
            // radioButtonUrgente
            // 
            this.radioButtonUrgente.AutoSize = true;
            this.radioButtonUrgente.Location = new System.Drawing.Point(11, 165);
            this.radioButtonUrgente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUrgente.Name = "radioButtonUrgente";
            this.radioButtonUrgente.Size = new System.Drawing.Size(67, 19);
            this.radioButtonUrgente.TabIndex = 1;
            this.radioButtonUrgente.TabStop = true;
            this.radioButtonUrgente.Text = "Urgente";
            this.radioButtonUrgente.UseVisualStyleBackColor = true;
            // 
            // radioButtonRotina
            // 
            this.radioButtonRotina.AutoSize = true;
            this.radioButtonRotina.Location = new System.Drawing.Point(10, 188);
            this.radioButtonRotina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonRotina.Name = "radioButtonRotina";
            this.radioButtonRotina.Size = new System.Drawing.Size(59, 19);
            this.radioButtonRotina.TabIndex = 2;
            this.radioButtonRotina.TabStop = true;
            this.radioButtonRotina.Text = "Rotina";
            this.radioButtonRotina.UseVisualStyleBackColor = true;
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(11, 114);
            this.comboBoxVeterinario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(224, 23);
            this.comboBoxVeterinario.TabIndex = 3;
            // 
            // labelVeterinario
            // 
            this.labelVeterinario.AutoSize = true;
            this.labelVeterinario.Location = new System.Drawing.Point(11, 97);
            this.labelVeterinario.Name = "labelVeterinario";
            this.labelVeterinario.Size = new System.Drawing.Size(80, 15);
            this.labelVeterinario.TabIndex = 4;
            this.labelVeterinario.Text = "Veterinário (a)";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(11, 56);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(44, 15);
            this.labelCliente.TabIndex = 5;
            this.labelCliente.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Items.AddRange(new object[] {
            "Cliente 1",
            "Cliente 2"});
            this.comboBoxCliente.Location = new System.Drawing.Point(11, 74);
            this.comboBoxCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(224, 23);
            this.comboBoxCliente.TabIndex = 6;
            // 
            // comboBoxPet
            // 
            this.comboBoxPet.FormattingEnabled = true;
            this.comboBoxPet.Location = new System.Drawing.Point(11, 33);
            this.comboBoxPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPet.Name = "comboBoxPet";
            this.comboBoxPet.Size = new System.Drawing.Size(224, 23);
            this.comboBoxPet.TabIndex = 7;
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Location = new System.Drawing.Point(11, 14);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(118, 15);
            this.labelPet.TabIndex = 8;
            this.labelPet.Text = "Animal de Estimação";
            // 
            // labelCheckList
            // 
            this.labelCheckList.AutoSize = true;
            this.labelCheckList.Location = new System.Drawing.Point(272, 14);
            this.labelCheckList.Name = "labelCheckList";
            this.labelCheckList.Size = new System.Drawing.Size(56, 15);
            this.labelCheckList.TabIndex = 9;
            this.labelCheckList.Text = "Sintomas";
            // 
            // labelTipoDeConsulta
            // 
            this.labelTipoDeConsulta.AutoSize = true;
            this.labelTipoDeConsulta.Location = new System.Drawing.Point(11, 148);
            this.labelTipoDeConsulta.Name = "labelTipoDeConsulta";
            this.labelTipoDeConsulta.Size = new System.Drawing.Size(96, 15);
            this.labelTipoDeConsulta.TabIndex = 10;
            this.labelTipoDeConsulta.Text = "Tipo de Consulta";
            // 
            // dateTimePickerDia
            // 
            this.dateTimePickerDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDia.Location = new System.Drawing.Point(62, 230);
            this.dateTimePickerDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDia.Name = "dateTimePickerDia";
            this.dateTimePickerDia.Size = new System.Drawing.Size(132, 23);
            this.dateTimePickerDia.TabIndex = 11;
            // 
            // dateTimePickerHorario
            // 
            this.dateTimePickerHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHorario.Location = new System.Drawing.Point(62, 276);
            this.dateTimePickerHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerHorario.Name = "dateTimePickerHorario";
            this.dateTimePickerHorario.Size = new System.Drawing.Size(132, 23);
            this.dateTimePickerHorario.TabIndex = 12;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(77, 212);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(97, 15);
            this.labelData.TabIndex = 13;
            this.labelData.Text = "Data da Consulta";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(69, 259);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(113, 15);
            this.labelHora.TabIndex = 14;
            this.labelHora.Text = "Horário da Consulta";
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.AllowUserToAddRows = false;
            this.dataGridViewConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnPet,
            this.ColumnCliente,
            this.ColumnVeterinario,
            this.ColumnTipoDeConsulta,
            this.ColumnData,
            this.ColumnHora});
            this.dataGridViewConsultas.Location = new System.Drawing.Point(513, 32);
            this.dataGridViewConsultas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.ReadOnly = true;
            this.dataGridViewConsultas.RowHeadersWidth = 51;
            this.dataGridViewConsultas.RowTemplate.Height = 29;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(654, 300);
            this.dataGridViewConsultas.TabIndex = 15;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 70;
            // 
            // ColumnPet
            // 
            this.ColumnPet.HeaderText = "Animal de Estimação";
            this.ColumnPet.MinimumWidth = 6;
            this.ColumnPet.Name = "ColumnPet";
            this.ColumnPet.ReadOnly = true;
            this.ColumnPet.Width = 125;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.MinimumWidth = 6;
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Width = 125;
            // 
            // ColumnVeterinario
            // 
            this.ColumnVeterinario.HeaderText = "Veterinario (a)";
            this.ColumnVeterinario.MinimumWidth = 6;
            this.ColumnVeterinario.Name = "ColumnVeterinario";
            this.ColumnVeterinario.ReadOnly = true;
            this.ColumnVeterinario.Width = 125;
            // 
            // ColumnTipoDeConsulta
            // 
            this.ColumnTipoDeConsulta.HeaderText = "Tipo de Consulta";
            this.ColumnTipoDeConsulta.MinimumWidth = 6;
            this.ColumnTipoDeConsulta.Name = "ColumnTipoDeConsulta";
            this.ColumnTipoDeConsulta.ReadOnly = true;
            this.ColumnTipoDeConsulta.Width = 90;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data ";
            this.ColumnData.MinimumWidth = 6;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Width = 90;
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.MinimumWidth = 6;
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            this.ColumnHora.Width = 90;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(513, 5);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(82, 22);
            this.buttonEditar.TabIndex = 16;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(676, 5);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(82, 22);
            this.buttonApagar.TabIndex = 17;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(271, 212);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 22);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(382, 212);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(113, 22);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 353);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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