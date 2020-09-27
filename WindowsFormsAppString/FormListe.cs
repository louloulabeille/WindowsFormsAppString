using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace WindowsFormsAppString
{
    public partial class FormListe : Form
    {
        public FormListe()
        {
            InitializeComponent();
            InitCombo();
        }

        private void InitCombo()
        {
            object[] items = new object[] 
            {
                "France",
                "Japon",
                "Corée du Sud",
                "Allemagne",
                "Pays Bas",
                "Italie"
            };
            ComboBoxSource.Items.AddRange(items);
        }

        private void EventAjoutComboBoxListBox(object sender, EventArgs e)
        {
            if ( ComboBoxSource.SelectedIndex > -1)
            {
                ListBoxCible.Items.Add(ComboBoxSource.SelectedItem);
                ComboBoxSource.Items.RemoveAt(ComboBoxSource.SelectedIndex);
                GestionButton();
            }
        }

        private void EventAjoutComboBoxListBoxAll(object sender, EventArgs e)
        {
            if (ComboBoxSource.Items.Count > 0)
            {
                foreach(object item in ComboBoxSource.Items)
                {
                    ListBoxCible.Items.Add(item);
                }
                ComboBoxSource.Items.Clear();
                GestionButton();
            }
        }

        private void EventAjoutLisBoxComboBox(object sender, EventArgs e)
        {
            if ( ListBoxCible.SelectedIndex > -1 )
            {
                ComboBoxSource.Items.Add(ListBoxCible.SelectedItem);
                ListBoxCible.Items.RemoveAt(ListBoxCible.SelectedIndex);
                GestionButton();
            } 
        }

        private void EventAjoutListBoxComboBoxAll(object sender, EventArgs e)
        {
            if (ListBoxCible.Items.Count > 0)
            {
                foreach (object item in ListBoxCible.Items)
                {
                    ComboBoxSource.Items.Add(item);
                }
                ListBoxCible.Items.Clear();
                GestionButton();
            }
        }

        private void EventHaut(object sender, EventArgs e)
        {
            int index = ListBoxCible.SelectedIndex;
            if ( index > -1 && ListBoxCible.Items.Count > 1 && index !=0 )
            {
                object o = ListBoxCible.SelectedItem;
                ListBoxCible.Items.RemoveAt(index);
                ListBoxCible.Items.Insert(index - 1,o);
                ListBoxCible.SetSelected(index - 1, true);
            }
        }

        private void EventBas(object sender, EventArgs e)
        {
            int index = ListBoxCible.SelectedIndex;
            if (index > -1 && ListBoxCible.Items.Count > 1 && index < ListBoxCible.Items.Count -1)
            {
                object o = ListBoxCible.SelectedItem;
                ListBoxCible.Items.RemoveAt(index);
                ListBoxCible.Items.Insert(index + 1, o);
                ListBoxCible.SetSelected(index + 1, true);
            }
        }

        /// <summary>
        /// méthode de gestion des boutons de cette fenêtre
        /// désactive ou active les boutons de gestions de list
        /// </summary>
        /// <param name="sender"></param>
        private void GestionButton( )
        {            
            switch (ListBoxCible.Items.Count)
            {
                case 0:
                    buttonListComboAll.Enabled = true;
                    buttonListCombo.Enabled = true;
                    buttonComboListAll.Enabled = false;
                    buttonComboList.Enabled = false;
                    buttonListBas.Enabled = false;
                    buttonListHaut.Enabled = false;
                    break;
                case 1:
                    buttonListComboAll.Enabled = true;
                    buttonListCombo.Enabled = true;
                    buttonComboListAll.Enabled = true;
                    buttonComboList.Enabled = true;
                    buttonListBas.Enabled = false;
                    buttonListHaut.Enabled = false;
                    break;
                default :
                    buttonListComboAll.Enabled = true;
                    buttonListCombo.Enabled = true;
                    buttonComboListAll.Enabled  = false;
                    buttonComboList.Enabled  = false;
                    buttonListHaut.Enabled = true;
                    buttonListBas.Enabled = true;
                    break;
            }

            switch (ComboBoxSource.Items.Count)
            {
                case 0:
                    buttonListComboAll.Enabled = true;
                    buttonListCombo.Enabled = true;
                    buttonComboListAll.Enabled = false;
                    buttonComboList.Enabled = false;
                    buttonListHaut.Enabled = true;
                    buttonListBas.Enabled = true;
                    break;
                default:
                    buttonListComboAll.Enabled = true;
                    buttonListCombo.Enabled = true;
                    buttonComboListAll.Enabled = true;
                    buttonComboList.Enabled = true;
                    buttonListHaut.Enabled = true;
                    buttonListBas.Enabled = true;
                    break;
            }
        }
    }


    
}
