using Course_App.Model;
using System;

namespace Course_App.Repository
{
    internal class UserRepository
    {
        //Declare User List
        List<User> users;
        public UserRepository()
        {
            users= new List<User>()
            {
                new User() {userName = "ash"},
                new User() {userName = "vani"},
            };
        }
        //Get All User
        public List<User> GetAllUser()
        {
            return users;
        }

        public string AddUser(User user)
        {
            users.Add(user);
            return $"User Add Successfully";
        }
    }
}
