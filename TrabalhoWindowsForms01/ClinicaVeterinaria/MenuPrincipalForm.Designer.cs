﻿namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    partial class MenuPrincipalForm
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
            this.buttonConsultas = new System.Windows.Forms.Button();
            this.buttonPets = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonVeterinarios = new System.Windows.Forms.Button();
            this.buttonAlergias = new System.Windows.Forms.Button();
            this.buttonEnderecos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConsultas
            // 
            this.buttonConsultas.Location = new System.Drawing.Point(22, 24);
            this.buttonConsultas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConsultas.Name = "buttonConsultas";
            this.buttonConsultas.Size = new System.Drawing.Size(143, 167);
            this.buttonConsultas.TabIndex = 0;
            this.buttonConsultas.Text = "CONSULTAS";
            this.buttonConsultas.UseVisualStyleBackColor = true;
            this.buttonConsultas.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // buttonPets
            // 
            this.buttonPets.Location = new System.Drawing.Point(183, 24);
            this.buttonPets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPets.Name = "buttonPets";
            this.buttonPets.Size = new System.Drawing.Size(143, 167);
            this.buttonPets.TabIndex = 1;
            this.buttonPets.Text = "PETS";
            this.buttonPets.UseVisualStyleBackColor = true;
            this.buttonPets.Click += new System.EventHandler(this.buttonPets_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(344, 24);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(143, 167);
            this.buttonClientes.TabIndex = 2;
            this.buttonClientes.Text = "CLIENTES";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonVeterinarios
            // 
            this.buttonVeterinarios.Location = new System.Drawing.Point(22, 217);
            this.buttonVeterinarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVeterinarios.Name = "buttonVeterinarios";
            this.buttonVeterinarios.Size = new System.Drawing.Size(143, 167);
            this.buttonVeterinarios.TabIndex = 3;
            this.buttonVeterinarios.Text = "VETERINÁRIOS";
            this.buttonVeterinarios.UseVisualStyleBackColor = true;
            this.buttonVeterinarios.Click += new System.EventHandler(this.buttonVeterinarios_Click);
            // 
            // buttonAlergias
            // 
            this.buttonAlergias.Location = new System.Drawing.Point(183, 217);
            this.buttonAlergias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAlergias.Name = "buttonAlergias";
            this.buttonAlergias.Size = new System.Drawing.Size(143, 167);
            this.buttonAlergias.TabIndex = 4;
            this.buttonAlergias.Text = "ALERGIAS";
            this.buttonAlergias.UseVisualStyleBackColor = true;
            this.buttonAlergias.Click += new System.EventHandler(this.buttonAlergias_Click);
            // 
            // buttonEnderecos
            // 
            this.buttonEnderecos.Location = new System.Drawing.Point(344, 217);
            this.buttonEnderecos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEnderecos.Name = "buttonEnderecos";
            this.buttonEnderecos.Size = new System.Drawing.Size(143, 167);
            this.buttonEnderecos.TabIndex = 5;
            this.buttonEnderecos.Text = "ENDEREÇOS";
            this.buttonEnderecos.UseVisualStyleBackColor = true;
            this.buttonEnderecos.Click += new System.EventHandler(this.buttonEnderecos_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 412);
            this.Controls.Add(this.buttonEnderecos);
            this.Controls.Add(this.buttonAlergias);
            this.Controls.Add(this.buttonVeterinarios);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonPets);
            this.Controls.Add(this.buttonConsultas);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonConsultas;
        private Button buttonPets;
        private Button buttonClientes;
        private Button buttonVeterinarios;
        private Button buttonAlergias;
        private Button buttonEnderecos;
    }
}