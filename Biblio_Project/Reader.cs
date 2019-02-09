using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Biblio_Project
{
    public class Reader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get { return $"{LastName} {FirstName} {MiddleName}"; } }
        public string PhoneNumber { get; set; }
        public int Id_Street { get; set; }
        public int HouseNumber { get; set; }
        public string LibraryCardNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ReregistrationDate { get; set; }

        public int StreetsId { get; set; }
        public virtual Street Street { get; set; }
    }
}
