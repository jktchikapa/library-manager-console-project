using library_manager_console_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_manager_console_project
{
    internal class Model
    { private static List<Livre> books = new List<Livre>();
        private static List<Emprunt> loans = new List<Emprunt>();
        private static List<Amende> fines = new List<Amende>();
        private static List<Membre> member = new List<Membre>();

        private static int nextMemberNumber = 1;
        private static int nextLoanNumber = 1;
        private static int nextFineNumber = 1;

        private static string GenerateNextMemberNumber()
        {
            string memberNumber = $"M-{nextMemberNumber:D4}";
            nextMemberNumber++;
            return memberNumber;
        }
        private static string GenerateNextLoanNumber()
        {
            string loanNumber = $"E-{nextLoanNumber:D4}";
            nextLoanNumber++;
            return loanNumber;
        }
        private static string GenerateNextFineNumber()
        {
            string fineNumber = $"A-{nextFineNumber:D4}";
            nextFineNumber++;
            return fineNumber;
        } 
    }
}
