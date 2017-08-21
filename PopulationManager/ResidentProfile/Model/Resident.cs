using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class Resident
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ResidentId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public bool IsInNationalServiceAgeRange { get; set; }

        /// <summary>
        /// Get or set houses whose owner is this person.
        /// </summary>
        public ICollection<House> Houses { get; set; }
    }
}
