using System;
using System.Text.RegularExpressions;

namespace ClassLibraryFormulaire
{
    // classe de gestion des utilisateurs pour cette application

    public class User
    {
        private string _idUser;
        private string _userName;
        private string _mP;

        public static string _patternID = @"^[A-Za-z]{1}\w{5,}";
        public static string _patternMp = @"\w{5,}";

        #region constructeur

        public User( string id,string motDePasse )
        {
            IdUser = id;
            MP = motDePasse;
        }
        public User( string id, string name, string motDePasse)
        {
            IdUser = id;
            UserName = name;
            MP = motDePasse;

        }
        #endregion

        #region accesseur
        public string IdUser { 
            get => _idUser;
            set
            {
                _idUser = User.IsVerifId(value) ? value : throw new ApplicationException("L'idenfiant est invalide.");
            }
        }

        public string UserName { get => _userName; set => _userName = value; }
        public string MP
        {
            get => _mP;
            set
            {
                _mP = User.IsVerifMp(value)? value: throw new ApplicationException("Le mot de passe est trop court");
            }
        }
        #endregion

        #region override
        public override bool Equals(object obj)
        {
            User utilisateur = obj as User;
            return this._idUser == utilisateur._idUser&& this._mP == utilisateur._mP;
        }

        public override int GetHashCode()
        {
            return _idUser.GetHashCode()^_mP.GetHashCode();
        }
        #endregion


        #region méthode de vérification de la classe
        public bool IsVerifIdMp( object obj )
        {
            return this.Equals( obj );
        }

        /// <summary>
        /// méthode de vérification de Identifant 
        /// il doit être @"^[a-bA-Z]{1}[a-zA-Z0-9]{n,}"
        /// </summary>
        /// <param name="value">identifant de l'utilisateur</param>
        /// <returns></returns>
        public static bool IsVerifId (string value)
        {
            Regex rgx = new Regex(_patternID);
            return rgx.IsMatch(value);
        }

        public static bool IsVerifMp (string value)
        {
            Regex rgx = new Regex(_patternMp);
            return rgx.IsMatch(value);
        }
        
        #endregion
    }
}
