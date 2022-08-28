using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;

namespace YazılımEviInsanKaynaklarıSistemi
{
    class Personnel
    {
        int tc;
        public int TC
        {
            get { return tc; }
            set { tc = value; }
        }
        string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string role;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

    }

}
