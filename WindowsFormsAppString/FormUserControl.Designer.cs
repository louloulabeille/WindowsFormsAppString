namespace WindowsFormsAppString
{
    partial class FormUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxIdUtilisateur = new System.Windows.Forms.TextBox();
            this.textBoxMp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIdUtilisateur);
            this.groupBox1.Controls.Add(this.textBoxMp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(73, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(481, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres d\'authentification";
            // 
            // textBoxIdUtilisateur
            // 
            this.textBoxIdUtilisateur.Location = new System.Drawing.Point(150, 52);
            this.textBoxIdUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIdUtilisateur.Name = "textBoxIdUtilisateur";
            this.textBoxIdUtilisateur.Size = new System.Drawing.Size(299, 32);
            this.textBoxIdUtilisateur.TabIndex = 0;
            this.textBoxIdUtilisateur.Text = "";
            this.textBoxIdUtilisateur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIdUtilisateur_Validating);
            this.textBoxIdUtilisateur.Validated += new System.EventHandler(this.textBoxIdUtilisateur_Validated);
            // 
            // textBoxMp
            // 
            this.textBoxMp.Location = new System.Drawing.Point(150, 104);
            this.textBoxMp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMp.Name = "textBoxMp";
            this.textBoxMp.PasswordChar = '*';
            this.textBoxMp.Size = new System.Drawing.Size(299, 32);
            this.textBoxMp.TabIndex = 1;
            this.textBoxMp.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMp_Validating);
            this.textBoxMp.Validated += new System.EventHandler(this.textBoxMp_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID utilisateur :";
            // 
            // buttonConnect
            // 
            this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConnect.Location = new System.Drawing.Point(104, 268);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(163, 44);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Se connecter";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.EventSeConnecter);
            // 
            // buttonLeave
            // 
            this.buttonLeave.CausesValidation = false;
            this.buttonLeave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLeave.Location = new System.Drawing.Point(346, 268);
            this.buttonLeave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(163, 44);
            this.buttonLeave.TabIndex = 3;
            this.buttonLeave.Text = "Quitter";
            this.buttonLeave.UseVisualStyleBackColor = true;
            // 
            // buttonTest
            // 
            this.buttonTest.CausesValidation = false;
            this.buttonTest.Location = new System.Drawing.Point(549, 275);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(86, 31);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.EventTest);
            // 
            // FormUserControl
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonLeave;
            this.ClientSize = new System.Drawing.Size(648, 357);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identifier-vous";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.TextBox textBoxMp;
        private System.Windows.Forms.TextBox textBoxIdUtilisateur;
        private System.Windows.Forms.Button buttonTest;
    }
}