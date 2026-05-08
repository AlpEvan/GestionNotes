using System;
using System.Collections.Generic;
using System.Text;

namespace GestionNotes
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }

        public Utilisateur(int id, string nom, string email, string motDePasse)
        {
            Id = id;
            Nom = nom;
            Email = email;
            MotDePasse = motDePasse;
        }

        public override string ToString()
        {
            return $"{Id} - {Nom} - {Email}";
        }
    }
}
