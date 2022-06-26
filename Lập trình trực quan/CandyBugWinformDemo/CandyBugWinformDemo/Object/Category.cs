using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyBugWinformDemo.Object
{
    class Category
    {
       
        private string name;

        
        public string Name { get => name; set => name = value; }

        public Category(DataRow row)
        {
            this.name = row["name"].ToString();
        }
    }
}
