using ClassLibraryFormulaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppString
{
    public partial class MDIPrincipal : Form
    {
        //private int childFormNumber = 0;
        
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        #region Event ouverture des formulaires dans le Mdi
        private void EventOpenFormChar(object sender, EventArgs e)
        {
            FormCatCaract fCC = new FormCatCaract();
            fCC.MdiParent = this;
            fCC.Show();
        }

        private void EventOpenFormString(object sender, EventArgs e)
        {
            FormRadioButtonNbOccurence1 frbnO = new FormRadioButtonNbOccurence1();
            frbnO.MdiParent = this;
            frbnO.Show();
        }

        private void EventOpenListe(object sender, EventArgs e)
        {
            FormListe fL = new FormListe();
            fL.MdiParent = this;
            fL.Show();
        }

        private void EventMotDePasse(object sender, EventArgs e)
        {
            // le compte et le mot de passe
            FormUserControl fUC = new FormUserControl();
            DialogResult result = fUC.ShowDialog();
            
            switch ( result )
            {
                case DialogResult.OK:
                    Debug.WriteLine("C'est ok");
                    break;
                case DialogResult.Cancel:
                    Debug.WriteLine("Coucou je sort");
                    break;
            }

        }
        #endregion

    }
}
