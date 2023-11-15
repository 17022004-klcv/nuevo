namespace prueba
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_admin = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_estudiante = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_docente = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.bt_admin);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(527, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 370);
            this.panel3.TabIndex = 4;
            // 
            // bt_admin
            // 
            this.bt_admin.BackColor = System.Drawing.Color.Silver;
            this.bt_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_admin.Location = new System.Drawing.Point(26, 288);
            this.bt_admin.Margin = new System.Windows.Forms.Padding(2);
            this.bt_admin.Name = "bt_admin";
            this.bt_admin.Size = new System.Drawing.Size(172, 56);
            this.bt_admin.TabIndex = 2;
            this.bt_admin.Text = "Administrador";
            this.bt_admin.UseVisualStyleBackColor = false;
            this.bt_admin.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(12, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 244);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.bt_estudiante);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(287, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 370);
            this.panel2.TabIndex = 3;
            // 
            // bt_estudiante
            // 
            this.bt_estudiante.BackColor = System.Drawing.Color.Silver;
            this.bt_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_estudiante.Location = new System.Drawing.Point(29, 288);
            this.bt_estudiante.Margin = new System.Windows.Forms.Padding(2);
            this.bt_estudiante.Name = "bt_estudiante";
            this.bt_estudiante.Size = new System.Drawing.Size(172, 56);
            this.bt_estudiante.TabIndex = 2;
            this.bt_estudiante.Text = "Estudiantes";
            this.bt_estudiante.UseVisualStyleBackColor = false;
            this.bt_estudiante.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(14, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 244);
            this.panel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.bt_docente);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(45, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 370);
            this.panel1.TabIndex = 2;
            // 
            // bt_docente
            // 
            this.bt_docente.BackColor = System.Drawing.Color.Silver;
            this.bt_docente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_docente.Location = new System.Drawing.Point(26, 290);
            this.bt_docente.Margin = new System.Windows.Forms.Padding(2);
            this.bt_docente.Name = "bt_docente";
            this.bt_docente.Size = new System.Drawing.Size(172, 56);
            this.bt_docente.TabIndex = 1;
            this.bt_docente.Text = "Docentes";
            this.bt_docente.UseVisualStyleBackColor = false;
            this.bt_docente.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(14, 16);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 244);
            this.panel4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_admin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_estudiante;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_docente;
        private System.Windows.Forms.Panel panel4;
    }
}