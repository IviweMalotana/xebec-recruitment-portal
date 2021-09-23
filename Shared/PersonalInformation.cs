using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public class PersonalInformation
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string IdNumber { get; set; }

        public string Address { get; set; }

        public bool Disability { get; set; }

        public string Gender { get; set; }

        public string Ethnicity { get; set; }

        //foreign key
        public int UserId { get; set; }

        public User User { get; set; }

    }
}