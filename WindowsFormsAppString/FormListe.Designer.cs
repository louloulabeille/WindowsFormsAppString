﻿using System.Windows.Forms;

namespace WindowsFormsAppString
{
    partial class FormListe
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
            this.components = new System.ComponentModel.Container();
            this.ListBoxCible = new System.Windows.Forms.ListBox();
            this.ComboBoxSource = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonComboList = new System.Windows.Forms.Button();
            this.buttonComboListAll = new System.Windows.Forms.Button();
            this.buttonListCombo = new System.Windows.Forms.Button();
            this.buttonListComboAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonListHaut = new System.Windows.Forms.Button();
            this.buttonListBas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxCible
            // 
            this.ListBoxCible.FormattingEnabled = true;
            this.ListBoxCible.ItemHeight = 15;
            this.ListBoxCible.Location = new System.Drawing.Point(456, 69);
            this.ListBoxCible.Name = "ListBoxCible";
            this.ListBoxCible.Size = new System.Drawing.Size(225, 94);
            this.ListBoxCible.TabIndex = 0;
            // 
            // ComboBoxSource
            // 
            this.ComboBoxSource.FormattingEnabled = true;
            this.ComboBoxSource.Location = new System.Drawing.Point(12, 69);
            this.ComboBoxSource.Name = "ComboBoxSource";
            this.ComboBoxSource.Size = new System.Drawing.Size(186, 23);
            this.ComboBoxSource.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonComboList
            // 
            this.buttonComboList.Location = new System.Drawing.Point(306, 68);
            this.buttonComboList.Name = "buttonComboList";
            this.buttonComboList.Size = new System.Drawing.Size(75, 23);
            this.buttonComboList.TabIndex = 2;
            this.buttonComboList.Text = ">";
            this.buttonComboList.UseVisualStyleBackColor = true;
            this.buttonComboList.Click += new System.EventHandler(this.EventAjoutComboBoxListBox);
            // 
            // buttonComboListAll
            // 
            this.buttonComboListAll.Location = new System.Drawing.Point(306, 104);
            this.buttonComboListAll.Name = "buttonComboListAll";
            this.buttonComboListAll.Size = new System.Drawing.Size(75, 23);
            this.buttonComboListAll.TabIndex = 3;
            this.buttonComboListAll.Text = ">>";
            this.buttonComboListAll.UseVisualStyleBackColor = true;
            this.buttonComboListAll.Click += new System.EventHandler(this.EventAjoutComboBoxListBoxAll);
            // 
            // buttonListCombo
            // 
            this.buttonListCombo.Location = new System.Drawing.Point(306, 140);
            this.buttonListCombo.Name = "buttonListCombo";
            this.buttonListCombo.Size = new System.Drawing.Size(75, 23);
            this.buttonListCombo.TabIndex = 4;
            this.buttonListCombo.Text = "<";
            this.buttonListCombo.UseVisualStyleBackColor = true;
            this.buttonListCombo.Click += new System.EventHandler(this.EventAjoutLisBoxComboBox);
            // 
            // buttonListComboAll
            // 
            this.buttonListComboAll.Location = new System.Drawing.Point(306, 177);
            this.buttonListComboAll.Name = "buttonListComboAll";
            this.buttonListComboAll.Size = new System.Drawing.Size(75, 23);
            this.buttonListComboAll.TabIndex = 5;
            this.buttonListComboAll.Text = "<<";
            this.buttonListComboAll.UseVisualStyleBackColor = true;
            this.buttonListComboAll.Click += new System.EventHandler(this.EventAjoutListBoxComboBoxAll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(539, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cible";
            // 
            // buttonListHaut
            // 
            this.buttonListHaut.Location = new System.Drawing.Point(456, 237);
            this.buttonListHaut.Name = "buttonListHaut";
            this.buttonListHaut.Size = new System.Drawing.Size(75, 42);
            this.buttonListHaut.TabIndex = 8;
            this.buttonListHaut.UseVisualStyleBackColor = true;
            this.buttonListHaut.Click += new System.EventHandler(this.EventHaut);
            // 
            // buttonListBas
            // 
            this.buttonListBas.Location = new System.Drawing.Point(606, 237);
            this.buttonListBas.Name = "buttonListBas";
            this.buttonListBas.Size = new System.Drawing.Size(75, 42);
            this.buttonListBas.TabIndex = 8;
            this.buttonListBas.UseVisualStyleBackColor = true;
            this.buttonListBas.Click += new System.EventHandler(this.EventBas);
            // 
            // FormListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 348);
            this.Controls.Add(this.buttonListBas);
            this.Controls.Add(this.buttonListHaut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonListComboAll);
            this.Controls.Add(this.buttonListCombo);
            this.Controls.Add(this.buttonComboListAll);
            this.Controls.Add(this.buttonComboList);
            this.Controls.Add(this.ComboBoxSource);
            this.Controls.Add(this.ListBoxCible);
            this.Name = "FormListe";
            this.Text = "Formulaire de Découverte des Listes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxCible;
        private System.Windows.Forms.ComboBox ComboBoxSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonListBas;
        private System.Windows.Forms.Button buttonListHaut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListComboAll;
        private System.Windows.Forms.Button buttonListCombo;
        private System.Windows.Forms.Button buttonComboListAll;
        private System.Windows.Forms.Button buttonComboList;
    }
}