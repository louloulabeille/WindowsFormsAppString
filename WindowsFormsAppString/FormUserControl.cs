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

        #region Validatin et valided
        /// <summary>
        /// Vérification de la bonne saisie de Id
        /// 1er caractère une lettre
        /// > 5 caractères 
        /// caractères qui doivent être des alphanumériques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxIdUtilisateur_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textBoxIdUtilisateur, String.Empty);
            if (!User.IsVerifId(textBoxIdUtilisateur.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxIdUtilisateur, "La saisie de l'identifiant doit avoir plus de 5 caractères et commencer par une lettre.");
            }else
            {
                e.Cancel = false;
            }
        }

        private void textBoxIdUtilisateur_Validated(object sender, EventArgs e)
        {
            textBoxMp.Focus();
        }

        /// <summary>
        /// vérification de la bonne saisie du mot de passe
        /// 5 caractères minimum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxMp_Validating(object sender, CancelEventArgs e)
        {
            errorProvider3.SetError(textBoxMp, string.Empty);
            if (!User.IsVerifMp(textBoxMp.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(textBoxMp, "La saisie du Mot de passe doit avoir au minimun 5 caractères.");

            }else
            {
                e.Cancel = false;
            }
        }

        private void textBoxMp_Validated(object sender, EventArgs e)
        {
            buttonConnect.Focus();
        }
        #endregion

        #region Event autre
        /// <summary>
        /// Verification de Id et du mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventSeConnecter(object sender, EventArgs e)
        {
            try
            {
                User utilisateur = new User(textBoxIdUtilisateur.Text, textBoxMp.Text);
                User moi = new User("Afpa!2020", "loulou", "azerty2020");

                errorProvider1.SetError(textBoxIdUtilisateur, string.Empty);
                errorProvider3.SetError(textBoxMp, string.Empty);
                labelError.Visible = false;

                if (moi.IsVerifIdMp(utilisateur))
                {
                    //textBoxIdUtilisateur.CausesValidation = false;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    textBoxIdUtilisateur.CausesValidation = true;
                    textBoxMp.CausesValidation = true;
                    errorProvider1.SetError(textBoxIdUtilisateur,"Impossible de vous identifer.");
                    errorProvider3.SetError(textBoxMp, "Erreur sur l'idenfiant ou le mot de passe.");
                    textBoxIdUtilisateur.Focus();
                    this.DialogResult = DialogResult.None;
                }
            } 
            catch(ApplicationException aE)
            {

                labelError.Text = (aE.Message);
                labelError.Visible = true;
            }
            

        }
        #endregion

        #region Event de test
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
            Debug.WriteLine($"test du mot de passe 1.:81 true = {User.IsVerifMp("1.:81")}");
            Debug.WriteLine($"test du mot de passe j7f?j1 true = {User.IsVerifMp("j7f?j1")}");
            Debug.WriteLine($"test du mot de passe kdjcfd true = {User.IsVerifMp("kdjcfd")}");
            Debug.WriteLine($"test du mot de passe Adjcfd true = {User.IsVerifMp("Adjcfd")}");
            Debug.WriteLine($"test du mot de passe 1djcfd true = {User.IsVerifMp("1djcfd")}");
            //User us = new User("loulou", "loula");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula false = {us.IsVerifIdMp(new User("lojdud", "loula"))}");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula true = {us.IsVerifIdMp(new User("loulou", "loula"))}");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula false = {us.IsVerifIdMp(new User("loulou", "loula12"))}");
            //Debug.WriteLine($"test de la méthode IsVerifIdMp id:loulou mp: loula false = {us.IsVerifIdMp(new User("loulou45", "loula45"))}");


        }
        #endregion

    }
}
