using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblio_Project
{
    public class Street
    {
        public int Id { get; set; }
        public string StreetName { get; set; }

        public virtual ICollection<Reader> Readers { get; set; }
        public Street()
        {
            Readers = new List<Reader>();
        }
    }
}
