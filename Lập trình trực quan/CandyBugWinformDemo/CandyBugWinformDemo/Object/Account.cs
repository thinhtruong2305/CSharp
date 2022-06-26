using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
   public class Account
    {
        public Account(string userName, string displayName, Boolean type, string password = null)
        {
            this.Username = userName;
            this.Displayname = displayName;
            this.Type = type;
            this.Password = password;
        }
        // lay du lieu tu database
        public Account(DataRow row)
        {
            this.Username = row["userName"].ToString();
            this.Displayname = row["displayName"].ToString();
            this.Type = (Boolean)row["type"];
            this.Password = row["password"].ToString();
        }

        private Boolean type;
        private int idAcc;
        private string username;
        private string password;
        private string displayname;

        public bool Type { get => type; set => type = value; }
        public int IdAcc { get => idAcc; set => idAcc = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
    }
}
