using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Staff : Person
    {
        private static int AutoId { get; set; } = 1;
        public string Id { get; set; }
        public string Role { get; set; }

        public Staff(string username, string password, string name,
            string gender, DateTime birthdate, string phoneNumber,
            string email, string address, string avatarPath, string role):
            base(username, password, name, gender, 
                birthdate, phoneNumber, email,
                address, avatarPath)
        {
            Id = "NV" + AutoId++;
            Role = role;
        }
    }
}
