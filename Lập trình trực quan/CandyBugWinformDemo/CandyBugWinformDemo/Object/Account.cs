using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
   public class Account
    {

        private int idAcc;
        private string username;
        private string password;
        private string displayname;

        public int IdAcc { get => idAcc; set => idAcc = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
    }
}
