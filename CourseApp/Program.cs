using Model;
using Repository;

CourseRepository courseRepository= new CourseRepository();

List<User> AllUsers = courseRepository.GetAllUsers();


int loopContinue = 1;
while (loopContinue == 1)
{
    Console.WriteLine("\t\t\t\t\tHello, Choose From the Below Menu\n\n");
    string menu = @"                    Press 1 for 'Admin'          Press 2 for 'User         Press any num to Stop";
    Console.WriteLine(menu);
    Console.WriteLine("\n\nEnter Your Choice:");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("\t\t\t\t\t\tAdmin Pannel\n\n");
            string menuAdmin = @"Press 11 for 'Show All User' 
Press 22 for 'Add User'
Press 33 for 'Delete User'";
            Console.WriteLine(menuAdmin);
            Console.WriteLine("\n\nEnter Your Choice:");
            int choiceAdmin = int.Parse(Console.ReadLine());
            switch (choiceAdmin)
            {
                case 11:
                    //Get All Users
                    foreach (User userItem in AllUsers)
                    {
                        Console.WriteLine(userItem);
                    }
                    break;

                case 22:
                    //Add New Course 
                    Console.WriteLine("Enter User Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Password Name");
                    string password = Console.ReadLine();

                    User userAdd = new User() { userName = name, Password = password };
                    courseRepository.AddUser(userAdd);
                    break;

                case 33:
                    //Delete User by Name
                    Console.WriteLine("Enter User Name what you want to be deleted");
                    string nameDelete = Console.ReadLine();

                    User userDelete = new User() { userName = nameDelete };
                    courseRepository.DeleteCourseByName(userDelete);
                    break;
            }
            break;

        case 2:
            Console.WriteLine("\t\t\t\t\t\tUser Pannel\n\n");
            string menuUser = @"Press 1 for 'Login' 
Press 2 for 'Register; 
Press 3 for 'LogOut'";
            Console.WriteLine(menuUser);
            int choiceUser = int.Parse(Console.ReadLine());
            string User_Login_Name = Console.ReadLine();

            switch (choiceUser)
            {
                case 1:
                    Console.WriteLine("Login");
                    Console.WriteLine("\nEnter Your Login Name")

                    break;

                case 2:
                    Console.WriteLine("\nRegister\n");
                    Console.WriteLine("Enter User Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("\nEnter Password Name");
                    string password = Console.ReadLine();

                    User userAdd = new User() { userName = name, Password = password };
                    courseRepository.AddUser(userAdd);
                    break;

                case 3:
                    Console.WriteLine("LogOut Successfully");
                    loopContinue = 0;
                    break;
            }
            break;
        default:
            loopContinue = 0;
            break;
    }
}