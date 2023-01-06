using System;

namespace Course_APP.Model
{
    internal class User
    {
        public string userName { get; set; }

        public override string ToString()
        {
            return $"User Name = {userName}";
        }
    }
}
