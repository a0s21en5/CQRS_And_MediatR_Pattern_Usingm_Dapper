using Course_APP.Model;
using System;
namespace Course_APP.Pepository
{
    internal class UserAppRepository
    {
        //Declare a List for User
        List<User> userName;

        //User Add
        public void AddUser()
        {
            userName = new List<User>()
            {
                new User() {userName="ash"},
                new User() {userName="bikash"},
                new User() {userName="raj"}
            };
        }
        //Get All User 
        public List<User> GetAllUser()
        {
            return userName;
        }
    }
}
