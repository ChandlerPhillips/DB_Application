﻿namespace Database_Application
{
    partial class FormDisplaySpecificProj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplaySpecificProj));
            this.pictureBoxGo = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.richTextBoxError = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDisplaySpecificEmp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplaySpecificEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGo
            // 
            this.pictureBoxGo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGo.Image")));
            this.pictureBoxGo.Location = new System.Drawing.Point(470, 144);
            this.pictureBoxGo.Name = "pictureBoxGo";
            this.pictureBoxGo.Size = new System.Drawing.Size(71, 49);
            this.pictureBoxGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGo.TabIndex = 32;
            this.pictureBoxGo.TabStop = false;
            this.pictureBoxGo.Click += new System.EventHandler(this.pictureBoxGo_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.Location = new System.Drawing.Point(234, 167);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(190, 26);
            this.textBoxSearch.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(157, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Search:";
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelp.Image")));
            this.pictureBoxHelp.Location = new System.Drawing.Point(503, 92);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(38, 32);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHelp.TabIndex = 29;
            this.pictureBoxHelp.TabStop = false;
            this.pictureBoxHelp.Click += new System.EventHandler(this.pictureBoxHelp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(118, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "(Double-Click inside the Header of GridView to sort that Field)";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(337, 526);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(130, 46);
            this.buttonReturn.TabIndex = 26;
            this.buttonReturn.Text = "<< Main Menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(183, 526);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(93, 46);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // richTextBoxError
            // 
            this.richTextBoxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxError.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxError.Location = new System.Drawing.Point(121, 422);
            this.richTextBoxError.Name = "richTextBoxError";
            this.richTextBoxError.ReadOnly = true;
            this.richTextBoxError.Size = new System.Drawing.Size(402, 76);
            this.richTextBoxError.TabIndex = 25;
            this.richTextBoxError.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(60, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "ERROR:";
            // 
            // dataGridViewDisplaySpecificEmp
            // 
            this.dataGridViewDisplaySpecificEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplaySpecificEmp.Location = new System.Drawing.Point(12, 209);
            this.dataGridViewDisplaySpecificEmp.Name = "dataGridViewDisplaySpecificEmp";
            this.dataGridViewDisplaySpecificEmp.Size = new System.Drawing.Size(635, 165);
            this.dataGridViewDisplaySpecificEmp.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(168, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Display A Specific Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(214, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "COMPANY DATABASE";
            // 
            // FormDisplaySpecificProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(667, 630);
            this.Controls.Add(this.pictureBoxGo);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.richTextBoxError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewDisplaySpecificEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDisplaySpecificProj";
            this.Text = "DISPLAY A SPECIFIC PROJECT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplaySpecificEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGo;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RichTextBox richTextBoxError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDisplaySpecificEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}