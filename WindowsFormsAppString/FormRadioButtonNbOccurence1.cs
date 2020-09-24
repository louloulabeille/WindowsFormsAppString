using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
//using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsAppString
{
    public partial class FormRadioButtonNbOccurence1 : Form
    {
        public FormRadioButtonNbOccurence1()
        {
            InitializeComponent();
            
        }

        private void EventButtonGame(object sender, EventArgs e)
        {
            if ( textBoxString1.Text.Length!=0 && textBoxSaisieString.Text.Length !=0 && textBoxRemplacement2.Text.Length !=0 )
            {
                foreach (Control item in this.groupBox1.Controls)
                {
                    RadioButton dB = item as RadioButton;
                    if ( dB.Checked )
                    {
                        switch (dB.Name)
                        {
                            case "radioButtonNbOccurence1": // on recherche le nombre d'occurence de la portion de chaine 1 dans la chaine saisie
                                textBoxResultat.Text = $"Le nombre d'occurence est de {NbOccurence(textBoxSaisieString.Text,textBoxString1.Text)}";
                                break;
                            case "radioButtonRemplacerAll1Par2":  // remplace toutes les occurences de taxtbox1 par textbox2
                                textBoxResultat.Text = textBoxSaisieString.Text.Replace(textBoxString1.Text, textBoxRemplacement2.Text);
                                break;
                            case "radioButtonRemplacer1ErPar2": // remplace la 1er occurence de 1 par 2
                                textBoxResultat.Text = FirstReplace(textBoxSaisieString.Text, textBoxString1.Text, textBoxRemplacement2.Text);
                                break;
                            case "radioButtonRemplacerLast1Par2":
                                textBoxResultat.Text = LastReplace(textBoxSaisieString.Text, textBoxString1.Text, textBoxRemplacement2.Text);
                                break;
                        }
                    }
                }
            }
        }

        #region méthode interne 
        /// <summary>
        /// Retourne le nombre occurence d'une chaine
        /// </summary>
        /// <param name="chaine">chaine de recherche</param>
        /// <param name="recherche">élément à rechercher</param>
        /// <returns></returns>
        private int NbOccurence(string chaine, string recherche)
        {
            int i = 0;
            int index = 0;
            while ((index = textBoxSaisieString.Text.IndexOf(textBoxString1.Text, index)) > -1)
            {
                index++;
                i++;
            }
            return i;
        }

        /// <summary>
        /// Recherche la première occurence et la remplace dans la chaine
        /// </summary>
        /// <param name="chaine">chaine de recherche</param>
        /// <param name="rechercher">chaine à rechercher</param>
        /// <param name="remplace">chaine de remplacement</param>
        /// <returns></returns>
        private string FirstReplace (string chaine, string rechercher, string remplace)
        {
            int index = chaine.IndexOf(rechercher);
            return index > -1 ?
                (chaine.Remove(index, rechercher.Length)).Insert(index, remplace)
                : "";
        }

        /// <summary>
        /// Recherche et remplace la dernière occurence
        /// </summary>
        /// <param name="chaine">chaine de recherche</param>
        /// <param name="rechercher">chaine à rechercher</param>
        /// <param name="remplace">chaine de remplacement</param>
        /// <returns></returns>
        private string LastReplace(string chaine, string rechercher, string remplace)
        {
            int index = chaine.LastIndexOf(rechercher);
            return  index > -1 ?
                (chaine.Remove(index, rechercher.Length)).Insert(index, remplace)
                : "";
        }
        #endregion
    }
}
