using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace library_manager_console_project.Models
{
    internal class Membre
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MemberNumber { get; set; }
        public string MemberMail { get; set; }
        public string MemberNumberPhone { get; set; }
        public DateTime InscriptionDate { get; set; }
        public bool AccountStatus { get; set; }

        public Membre(string name, string firstName, string memberNumber, string memberMail, string memberNumberPhone, bool accountStatus)
        {
            Name = name;
            MemberNumber = memberNumber;
            MemberMail = memberMail;
            MemberNumberPhone = memberNumberPhone;
            AccountStatus = accountStatus;
            InscriptionDate = DateTime.Now;
        }
    }
}
