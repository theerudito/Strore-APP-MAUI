using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaven.Model
{
    public class MClient
    {
        public string _id { get; set; }
        public string DNI { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Direction { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
