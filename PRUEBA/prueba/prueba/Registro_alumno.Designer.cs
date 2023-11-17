namespace prueba
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
            this.txt_name_Materia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Registrar_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txt_name_Materia);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_Registrar_usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(61, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 371);
            this.panel1.TabIndex = 0;
            // 
            // txt_name_Materia
            // 
            this.txt_name_Materia.BackColor = System.Drawing.Color.DarkGray;
            this.txt_name_Materia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_name_Materia.Location = new System.Drawing.Point(88, 211);
            this.txt_name_Materia.Multiline = true;
            this.txt_name_Materia.Name = "txt_name_Materia";
            this.txt_name_Materia.Size = new System.Drawing.Size(522, 41);
            this.txt_name_Materia.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(283, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Registrar_usuario
            // 
            this.txt_Registrar_usuario.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Registrar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Registrar_usuario.Location = new System.Drawing.Point(88, 80);
            this.txt_Registrar_usuario.Multiline = true;
            this.txt_Registrar_usuario.Name = "txt_Registrar_usuario";
            this.txt_Registrar_usuario.Size = new System.Drawing.Size(522, 41);
            this.txt_Registrar_usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario que desea registrar";
            // 
            // Registro_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
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
    }
}