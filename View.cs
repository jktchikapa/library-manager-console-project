using library_manager_console_project.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace library_manager_console_project
{
    internal class View
    {
        public static void DisplayMenu(string menuName, string[] options)
        {
            Console.Clear();
            Console.WriteLine($"{menuName.ToUpper()}");
            Console.WriteLine("\nVeuillez sélectionner une action à effectuer :\n");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {options[i]}");
            }
            Console.Write("\nVotre choix : _");
        }

        public static void DisplayPrincipalMenu()
        {
            string[] options = { "Système de gestion de livres", "Gestion des membres", "Gestion des emprunts", "Gestion des amendes", "Statistiques et rapports", "Sauvegarder les données", "Quitter" };
            DisplayMenu("Menu principal", options);
        }

        public static void DisplayManageBookMenu()
        {
            string[] options = { "Ajouter un nouveau livre", "Afficher tous les livres", "Afficher les livres disponibles", "Rechercher un livre", "Modifier un livre", "Supprimer un livre", "Retour au menu principal" };
            DisplayMenu("Gestion des livres", options);
        }

        public static void DisplayManageMember()
        {
            string[] options = { "Inscrire un nouveau membre", "Afficher tous les membres", "Rechercher un membre", " Modifier un membre", "Suspendre/Réactiver un compte", "Afficher l'historique d'un membre", "Retour au menu principal\r\n" };
            DisplayMenu("Gestion des membres", options);
        }
        public static void DisplayManageLoans()
        {
            string[] options = { "Emprunter un livre", "Retourner un livre", "Afficher tous les emprunts en cours", "Afficher les emprunts en retard", "Afficher l'historique complet des emprunts", "Renouveler un emprunt", "Retour au menu principal" };
            DisplayMenu("Gestion des emprunts", options);
        }
        public static void DisplayManageFine()
        {
            string[] options = { "Afficher les amendes d'un membre", "Payer une amende", "Afficher tous les membres avec amendes", " Afficher l'historique des paiements", "Retour au menu principal\r\n" };
            DisplayMenu("Gestion des amandes", options);
        }

        public static void DisplaySearchABookMenu()
        {
            string[] options = { "Titre", "Auteur", "ISBN", "Catégorie", "Retour" };
            DisplayMenu("Rechercher un livre", options);
        }

        public static void DisplaySearchMemberMenu()
        {
            string[] options = { "Numéro de membre", "Nom", "Courriel", "Retour" };
            DisplayMenu("Rechercher un membre", options);
        }

        public static void DisplayStatistiquesMenu()
        {
            string[] options = { "Livres les plus empruntés", " Membres les plus actifs", "Livres jamais empruntés", "Statistiques générales", "Revenus générés par les amendes", "Taux d'occupation de la bibliothèque", "Exporter un rapport", "Retour au menu principal\r\n" };
            DisplayMenu("Statistiques et rapports", options);
        }

        public static void DisplayErrorMessage(string message = "Choix invalide, veuillez rééssayer.")
        {
            Console.WriteLine(message);
            WaitForKeyPress();
        }

        public static void WaitForKeyPress(string message = "\nAppuyez sur une touche pour continuer ...")
        {
            Console.WriteLine(message);
            Console.ReadKey(true);
        }

        public static void DisplayLeaveMessage(string message = "Merci d'avoir utilisé la bibliothèque, nous espérons vous revoir bientôt!")
        {
            Console.Clear();
            Console.WriteLine(message);
            WaitForKeyPress("\nAppuyez sur une touche pour fermer la bibliothèque ...");
        }

        public static void AskInformationsOfABook(out string title, out string author, out string isbn, out int publicationYear, out string categorie)
        {
            title = Utils.ReadANonEmptyInput("Titre : ");
            author = Utils.ReadANonEmptyInput("Auteur :");
            isbn = Utils.ReadUniqueISBN(); 
            publicationYear = Utils.ReadANonEmptyInputAndConvertToInt32("Année de publication: ");
            categorie = Utils.ReadANonEmptyInput("Catégorie :");
        }

        public static void AskInformationOfAMember(out string name, out string surname, out string email, out int phoneNumber)
        {
            name = Utils.ReadANonEmptyInput("Votre nom : ");
            surname = Utils.ReadANonEmptyInput("Votre prénom : ");
            email = Utils.IsValidEmail("Votre email");
            phoneNumber = Utils.ReadANonEmptyInputAndConvertToInt32("Numéro de téléphone");
        }

        public static void DisplayAllBooks(List<Livre> books)
        {
            Console.Clear();
            Console.WriteLine("==== Liste des livre =====");
            if (!Utils.IsNotEmptyList<Livre>("livre", books))
            {
                Console.WriteLine("Aucun livre à afficher pour l'instant");
                WaitForKeyPress("Appuyer sur une touche pour quitter ...");
            }
            else
            {
                foreach (Livre items in books)
                {
                    Console.WriteLine($"-Titre : {items.Title} - Auteur : {items.Author} -  ISBN : {items.ISBN} - Année de publication : {items.PublicationYear} - Catégorie : {items.Categorie} - Nombres d'exemplaires restants : {items.NumberOfAvailableCopies}");
                }
                WaitForKeyPress("Appuyer sur une touche pour quitter ...");
            }
        }
        public static void LoansABook(Membre member, Livre book)
        {
            if(Utils.IsActiveMember(member) && Utils.IsAvailableBook(book))
            {

            }
        }
    }
}
