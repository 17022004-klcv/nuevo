﻿namespace prueba
{
    partial class Registro_alumno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_docente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name_Materia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Registrar_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txt_docente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_name_Materia);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_Registrar_usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(81, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 457);
            this.panel1.TabIndex = 0;
            // 
            // txt_docente
            // 
            this.txt_docente.BackColor = System.Drawing.Color.DarkGray;
            this.txt_docente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_docente.Location = new System.Drawing.Point(117, 322);
            this.txt_docente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_docente.Multiline = true;
            this.txt_docente.Name = "txt_docente";
            this.txt_docente.Size = new System.Drawing.Size(695, 50);
            this.txt_docente.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese su usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_name_Materia
            // 
            this.txt_name_Materia.BackColor = System.Drawing.Color.DarkGray;
            this.txt_name_Materia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_name_Materia.Location = new System.Drawing.Point(117, 203);
            this.txt_name_Materia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name_Materia.Multiline = true;
            this.txt_name_Materia.Name = "txt_name_Materia";
            this.txt_name_Materia.Size = new System.Drawing.Size(695, 50);
            this.txt_name_Materia.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(375, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Registrar_usuario
            // 
            this.txt_Registrar_usuario.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Registrar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Registrar_usuario.Location = new System.Drawing.Point(117, 98);
            this.txt_Registrar_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Registrar_usuario.Multiline = true;
            this.txt_Registrar_usuario.Name = "txt_Registrar_usuario";
            this.txt_Registrar_usuario.Size = new System.Drawing.Size(695, 50);
            this.txt_Registrar_usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario que desea registrar";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registro_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro_alumno";
            this.Text = "Registro_alumno";
            this.Load += new System.EventHandler(this.Registro_alumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Registrar_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name_Materia;
        private System.Windows.Forms.TextBox txt_docente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}