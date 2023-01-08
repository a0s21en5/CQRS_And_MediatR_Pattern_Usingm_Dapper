using System;

namespace Course_App.Model
{
    public class User
    {
        public string userName { get; set; }
        public override string ToString()
        {
            return $"User Name = {userName}";
        }
    }
}
