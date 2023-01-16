using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public string userName { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"User Name = {userName}\t\t\t Password = {Password}";
        }
    }
}
