namespace Database_Application
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDisplaySpecificEmp = new System.Windows.Forms.Button();
            this.buttonDisplayAllEmp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisplaySpecificProj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPANY DATABASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(387, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Controls.Add(this.DisplaySpecificProj);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonDisplaySpecificEmp);
            this.groupBox1.Controls.Add(this.buttonDisplayAllEmp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(249, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUERY";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(59, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display All Projects";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDisplaySpecificEmp
            // 
            this.buttonDisplaySpecificEmp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDisplaySpecificEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplaySpecificEmp.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplaySpecificEmp.Location = new System.Drawing.Point(59, 60);
            this.buttonDisplaySpecificEmp.Name = "buttonDisplaySpecificEmp";
            this.buttonDisplaySpecificEmp.Size = new System.Drawing.Size(301, 40);
            this.buttonDisplaySpecificEmp.TabIndex = 0;
            this.buttonDisplaySpecificEmp.Text = "Display a Specific Employee";
            this.buttonDisplaySpecificEmp.UseVisualStyleBackColor = true;
            this.buttonDisplaySpecificEmp.Click += new System.EventHandler(this.buttonDisplaySpecificEmp_Click);
            // 
            // buttonDisplayAllEmp
            // 
            this.buttonDisplayAllEmp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDisplayAllEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayAllEmp.ForeColor = System.Drawing.Color.Black;
            this.buttonDisplayAllEmp.Location = new System.Drawing.Point(59, 17);
            this.buttonDisplayAllEmp.Name = "buttonDisplayAllEmp";
            this.buttonDisplayAllEmp.Size = new System.Drawing.Size(301, 40);
            this.buttonDisplayAllEmp.TabIndex = 0;
            this.buttonDisplayAllEmp.Text = "Display All Employees";
            this.buttonDisplayAllEmp.UseVisualStyleBackColor = true;
            this.buttonDisplayAllEmp.Click += new System.EventHandler(this.buttonDisplayAllEmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DisplaySpecificProj
            // 
            this.DisplaySpecificProj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DisplaySpecificProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplaySpecificProj.ForeColor = System.Drawing.Color.Black;
            this.DisplaySpecificProj.Location = new System.Drawing.Point(59, 151);
            this.DisplaySpecificProj.Name = "DisplaySpecificProj";
            this.DisplaySpecificProj.Size = new System.Drawing.Size(301, 40);
            this.DisplaySpecificProj.TabIndex = 2;
            this.DisplaySpecificProj.Text = "Display a Specific Project";
            this.DisplaySpecificProj.UseVisualStyleBackColor = true;
            this.DisplaySpecificProj.Click += new System.EventHandler(this.DisplaySpecificProj_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(692, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN MENU";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDisplayAllEmp;
        private System.Windows.Forms.Button buttonDisplaySpecificEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DisplaySpecificProj;
    }
}

