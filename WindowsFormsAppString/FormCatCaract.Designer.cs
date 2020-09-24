namespace WindowsFormsAppString
{
    partial class FormCatCaract
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSaisieString = new System.Windows.Forms.TextBox();
            this.numericUpDownNumCaract = new System.Windows.Forms.NumericUpDown();
            this.textBoxResultCaract = new System.Windows.Forms.TextBox();
            this.buttonCaractCategorie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumCaract)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Position du caractère :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Résultat :";
            // 
            // textBoxSaisieString
            // 
            this.textBoxSaisieString.Location = new System.Drawing.Point(278, 77);
            this.textBoxSaisieString.Name = "textBoxSaisieString";
            this.textBoxSaisieString.Size = new System.Drawing.Size(476, 34);
            this.textBoxSaisieString.TabIndex = 1;
            this.textBoxSaisieString.TextChanged += new System.EventHandler(this.EventMiseAJourNumericUpDown);
            // 
            // numericUpDownNumCaract
            // 
            this.numericUpDownNumCaract.Location = new System.Drawing.Point(278, 132);
            this.numericUpDownNumCaract.Name = "numericUpDownNumCaract";
            this.numericUpDownNumCaract.Size = new System.Drawing.Size(120, 34);
            this.numericUpDownNumCaract.TabIndex = 2;
            // 
            // textBoxResultCaract
            // 
            this.textBoxResultCaract.Location = new System.Drawing.Point(278, 233);
            this.textBoxResultCaract.Name = "textBoxResultCaract";
            this.textBoxResultCaract.ReadOnly = true;
            this.textBoxResultCaract.Size = new System.Drawing.Size(476, 34);
            this.textBoxResultCaract.TabIndex = 3;
            // 
            // buttonCaractCategorie
            // 
            this.buttonCaractCategorie.Location = new System.Drawing.Point(55, 356);
            this.buttonCaractCategorie.Name = "buttonCaractCategorie";
            this.buttonCaractCategorie.Size = new System.Drawing.Size(325, 46);
            this.buttonCaractCategorie.TabIndex = 4;
            this.buttonCaractCategorie.Text = "Catégorie du caractère";
            this.buttonCaractCategorie.UseVisualStyleBackColor = true;
            this.buttonCaractCategorie.Click += new System.EventHandler(this.EventCatCaractere);
            // 
            // FormCatCaract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.buttonCaractCategorie);
            this.Controls.Add(this.textBoxResultCaract);
            this.Controls.Add(this.numericUpDownNumCaract);
            this.Controls.Add(this.textBoxSaisieString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCatCaract";
            this.Text = "Catégorie du caractère";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumCaract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSaisieString;
        private System.Windows.Forms.NumericUpDown numericUpDownNumCaract;
        private System.Windows.Forms.TextBox textBoxResultCaract;
        private System.Windows.Forms.Button buttonCaractCategorie;
    }
}

