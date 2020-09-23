using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppString
{
    public partial class FormCatCaract : Form
    {
        public FormCatCaract()
        {
            InitializeComponent();
            InitNumericUpDown();
        }

        private void InitNumericUpDown()
        {
            // méthode d'intialisation du NumericUpDown
            this.numericUpDownNumCaract.Maximum = 0;
            this.numericUpDownNumCaract.Minimum = 0;
        }

        private void EventMiseAJourNumericUpDown(object sender, EventArgs e)
        {
            // quand le textBoxSaisie est modifié, je modifie le numericUpDown
            this.numericUpDownNumCaract.Maximum = this.textBoxSaisieString.Text.Length;
            this.numericUpDownNumCaract.Minimum = 1;
        }

        private void EventCatCaractere(object sender, EventArgs e)
        {
            if (this.textBoxSaisieString.Text.Length > 0)
            {
                // Event du bouton clic pour retrouner la catégorie du caractère
                Array tabCart = this.textBoxSaisieString.Text.ToArray();
                int i = (int)this.numericUpDownNumCaract.Value - 1;

                if (Char.IsDigit((char)tabCart.GetValue(i)))
                {
                    this.textBoxResultCaract.Text = "chiffre";
                    return;
                }
                else
                {
                    this.textBoxResultCaract.Text = "Sais Pas";
                }

                if (Char.IsLetter((char)tabCart.GetValue(i)))
                {
                    this.textBoxResultCaract.Text = "lettre";
                    return;
                }
                else
                {
                    this.textBoxResultCaract.Text = "Sais Pas";
                }

                if (Char.IsPunctuation((char)tabCart.GetValue(i)))
                {
                    this.textBoxResultCaract.Text = "ponctuation";
                    return;
                }
                else
                {
                    this.textBoxResultCaract.Text = "Sais Pas";
                }

                if (char.IsSymbol((char)tabCart.GetValue(i)))
                {
                    this.textBoxResultCaract.Text = "symbole";
                    return;
                }
                else
                {
                    this.textBoxResultCaract.Text = "Sais Pas";
                }
            }
            
        }
    }
}
