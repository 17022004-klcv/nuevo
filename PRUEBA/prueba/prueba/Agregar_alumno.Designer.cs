namespace prueba
{
    partial class Agregar_alumno
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
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_name_Estudiante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxM);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_name_Estudiante);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 369);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxM
            // 
            this.comboBoxM.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Items.AddRange(new object[] {
            "Tecnicas de redacción",
            "Ingles",
            "Logica de programación",
            "Matematica I",
            "Sistemas informaticos"});
            this.comboBoxM.Location = new System.Drawing.Point(130, 233);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(530, 26);
            this.comboBoxM.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 302);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_name_Estudiante
            // 
            this.txt_name_Estudiante.BackColor = System.Drawing.Color.DarkGray;
            this.txt_name_Estudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_name_Estudiante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_Estudiante.Location = new System.Drawing.Point(130, 106);
            this.txt_name_Estudiante.Multiline = true;
            this.txt_name_Estudiante.Name = "txt_name_Estudiante";
            this.txt_name_Estudiante.Size = new System.Drawing.Size(535, 38);
            this.txt_name_Estudiante.TabIndex = 2;
            this.txt_name_Estudiante.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del estudiante";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agregar_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Agregar_alumno";
            this.Text = "Agregar_alumno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_name_Estudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.Button button2;
    }
}