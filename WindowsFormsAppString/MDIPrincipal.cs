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
        private int childFormNumber = 0;
        
        public MDIPrincipal()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

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

        private void EventMotDePasse(object sender, EventArgs e)
        {
            // event qui se passe lors du chargement du formulaire pour demander
            // le compte et le mot de passe
            FormUserControl fUC = new FormUserControl();
            // affection des propriétés au bouton buttonConnect de AcceptButton -> Entrer
            // et au buttonLeave la propriété CancelButton -> Echap
            //fUC.AcceptButton = fUC.Controls.Find("buttonConnect", false)[0] as Button;
            //fUC.CancelButton = fUC.Controls.Find("buttonLeave",false)[0] as Button;

            DialogResult result = fUC.ShowDialog();

            switch ( result )
            {
                case DialogResult.OK:
                    Debug.WriteLine("C'est ok");
                    break;
                case DialogResult.Cancel:
                    Debug.WriteLine("coucou je sort");
                    break;
            }

        }
    }
}
