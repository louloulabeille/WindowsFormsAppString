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
            }
        }

        private void EventAjoutLisBoxComboBox(object sender, EventArgs e)
        {
            if ( ListBoxCible.SelectedIndex > -1 )
            {
                ComboBoxSource.Items.Add(ListBoxCible.SelectedItem);
                ListBoxCible.Items.RemoveAt(ListBoxCible.SelectedIndex);
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
            }
        }

        private void EventHaut(object sender, EventArgs e)
        {
            if (ListBoxCible.SelectedIndex > -1 && ListBoxCible.Items.Count > 0)
            {
                int index = ListBoxCible.SelectedIndex;
                object o = ListBoxCible.SelectedItem;
                ListBoxCible.Items.RemoveAt(index);
                ListBoxCible.Items.Insert(index - 1,o);
                ListBoxCible.SetSelected(index - 1, true);
            }
        }

        private void EventBas(object sender, EventArgs e)
        {
            if (ListBoxCible.SelectedIndex > -1 && ListBoxCible.Items.Count > 0)
            {
                int index = ListBoxCible.SelectedIndex;
                object o = ListBoxCible.SelectedItem;
                ListBoxCible.Items.RemoveAt(index);
                ListBoxCible.Items.Insert(index + 1, o);
                ListBoxCible.SetSelected(index + 1, true);
            }
        }
    }


    
}
