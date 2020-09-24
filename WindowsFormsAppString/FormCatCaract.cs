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
                char[] tabCart = this.textBoxSaisieString.Text.ToArray();
                int i = (int)this.numericUpDownNumCaract.Value - 1;
                textBoxResultCaract.Text = IsVerifChar(tabCart[i]);
            }
        }

        private string IsVerifChar( char caract )
        {
            if (Char.IsDigit(caract))
            {
                return "chiffre";
            }
            
            if (Char.IsLetter(caract))
            {
                return "lettre";
            }

            if (Char.IsPunctuation(caract))
            {
                return "ponctuation";
            }

            if (char.IsSymbol(caract))
            {
                return "symbole";
            }
            
            return "Sais Pas";
            
        }
    }
}
