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
    public partial class FormUserControl : Form
    {
        public FormUserControl()
        {
            InitializeComponent();
            
        }

        private void textBoxIdUtilisateur_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !User.IsVerifId(textBoxIdUtilisateur.Text);
        }

        private void textBoxIdUtilisateur_Validated(object sender, EventArgs e)
        {
            textBoxMp.Focus();
        }

        private void textBoxMp_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !User.IsVerifMp(textBoxMp.Text);
        }

        private void textBoxMp_Validated(object sender, EventArgs e)
        {
            buttonConnect.Focus();
        }

        private void EventSeConnecter(object sender, EventArgs e)
        {
            User utilisateur = new User(textBoxIdUtilisateur.Text, textBoxMp.Text);
            User moi = new User("Afpa2020", "loulou", "azerty2020");
            if (moi.IsVerifIdMp(utilisateur))
            {
                textBoxIdUtilisateur.CausesValidation = false;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                textBoxIdUtilisateur.CausesValidation = true;
                this.DialogResult = DialogResult.None;
            }

        }
        private void EventTest(object sender, EventArgs e)
        {
            //Debug.WriteLine($"test de la méthode isverifid \"14fghf\" false : {User.IsVerifId("14fghf")}");
            //Debug.WriteLine($"test de la méthode isverifid \"loulou\" true : {User.IsVerifId("loulou")}");
            //Debug.WriteLine($"test de la méthode isverifid \"ao4lo\" false : {User.IsVerifId("aoulo")}");
            //Debug.WriteLine($"test de la méthode isverifid \"loulou14\" true : {User.IsVerifId("loulou14")}");
            //Debug.WriteLine($"test de la méthode isverifid \"ljk\" false : {User.IsVerifId("ljk")}");
            //Debug.WriteLine($"test de la méthode isverifid \"rlghg\" false : {User.IsVerifId("rlghg")}");
            //Debug.WriteLine($"test de la méthode isverifId \"lou45lou\" true : {User.IsVerifId("lou45lou")}");
            //Debug.WriteLine($"test de la méthode isverifId \"Papoune\" true : {User.IsVerifId("Papoune")}");
            //Debug.WriteLine($"test de la méthode isverifId \"Pap45oune\" true : {User.IsVerifId("Pap45oune")}");
            Debug.WriteLine($"test du mot de passe 1 false = {User.IsVerifMp("1")}");
            Debug.WriteLine($"test du mot de passe 12 false = {User.IsVerifMp("12")}");
            Debug.WriteLine($"test du mot de passe 135 false = {User.IsVerifMp("135")}");
            Debug.WriteLine($"test du mot de passe 1464 false = {User.IsVerifMp("1464")}");
            Debug.WriteLine($"test du mot de passe 14581 true = {User.IsVerifMp("14581")}");
            Debug.WriteLine($"test du mot de passe jdfhj1 true = {User.IsVerifMp("jdfhj1")}");
            Debug.WriteLine($"test du mot de passe kdjcfd true = {User.IsVerifMp("kdjcfd")}");
            Debug.WriteLine($"test du mot de passe Adjcfd true = {User.IsVerifMp("Adjcfd")}");
            Debug.WriteLine($"test du mot de passe 1djcfd true = {User.IsVerifMp("1djcfd")}");
            //User us = new User("loulou", "loula");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula false = {us.IsVerifIdMp(new User("lojdud", "loula"))}");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula true = {us.IsVerifIdMp(new User("loulou", "loula"))}");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula false = {us.IsVerifIdMp(new User("loulou", "loula12"))}");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula false = {us.IsVerifIdMp(new User("loulou45", "loula45"))}");


        }

        
    }
}
