using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSystem
{
    internal class Client
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }

        public Client(string lastname, string firstname, string phoneno, string email, string address)
        {
            LastName = lastname;
            FirstName = firstname;
            PhoneNo = phoneno;
            Email = email;
            Address = address;
        }

        public Client(string roomtype, string roomnumber, DateTime datein, DateTime dateout)
        {
            RoomType = roomtype;
            RoomNumber = roomnumber;
            DateIn = datein;
            DateOut = dateout;
        }

        public Client(string fullname, string roomtype, string roomnumber, DateTime datein, DateTime dateout)
        {
            string[] names = fullname.Split(' ');
            FirstName = names[0];
            LastName = names.Length > 1 ? names[1] : "";
            RoomType = roomtype;
            RoomNumber = roomnumber;
            DateIn = datein;
            DateOut = dateout;
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}
