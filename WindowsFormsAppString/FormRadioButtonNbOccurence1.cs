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

                                int i = 0;
                                int index = 0;
                                while (textBoxSaisieString.Text.IndexOf(textBoxString1.Text, index) > -1)
                                {
                                    index = textBoxSaisieString.Text.IndexOf(textBoxString1.Text, index) + 1;
                                    i++;
                                }
                                textBoxResultat.Text = $"Le nombre d'occurence est de {i}";
                                break;
                            case "radioButtonRemplacerAll1Par2":  // remplace toutes les occurences de taxtbox1 par textbox2
                                textBoxResultat.Text = textBoxSaisieString.Text.Replace(textBoxString1.Text, textBoxRemplacement2.Text);
                                break;
                            case "radioButtonRemplacer1ErPar2": // remplace la 1er occurence de 1 par 2
                                index = textBoxSaisieString.Text.IndexOf(textBoxString1.Text);
                                textBoxResultat.Text = index > -1 ? 
                                    (textBoxSaisieString.Text.Remove(index, textBoxString1.Text.Length)).Insert(index,textBoxRemplacement2.Text)
                                    :"";
                                break;
                            case "radioButtonRemplacerLast1Par2":
                                index = textBoxSaisieString.Text.LastIndexOf(textBoxString1.Text);
                                textBoxResultat.Text = index > -1 ?
                                    (textBoxSaisieString.Text.Remove(index, textBoxString1.Text.Length)).Insert(index, textBoxRemplacement2.Text)
                                    : "";
                                break;
                        }
                    }
                }
            }
        }
    }
}
