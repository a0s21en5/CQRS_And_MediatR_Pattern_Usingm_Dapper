using Course_App.Model;
using Course_App.Repository;

CourseRepository courserepository = new CourseRepository();
UserRepository userrepository = new UserRepository();
List<User> allUser = userrepository.GetAllUser();
List<Course> allCourses = courserepository.GetAllCourses();

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
            string menuAdmin = @"Press 1 for 'Show All User' 
Press 2 for 'Add User'";
            Console.WriteLine(menuAdmin);
            Console.WriteLine("\n\nEnter Your Choice:");
            int choiceAdmin = int.Parse(Console.ReadLine());
            switch (choiceAdmin)
            {
                case 1:
                    foreach (User userItem in allUser)
                    {
                        Console.WriteLine(userItem);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Your User Name");
                    string User_Admin_name = Console.ReadLine();
                    User user = new User() { userName = User_Admin_name };
                    Console.WriteLine(userrepository.AddUser(user));
                    foreach (User items in allUser)
                    {
                        Console.WriteLine(items);
                    }
                    break;

            }
            break;
        case 2:
            Console.WriteLine("\t\t\t\t\t\tUser Pannel\n\n");
            string menuUser = @"Press 1 for 'Login' 
Press 2 for 'Register; 
Press 3 for 'LogOut'";
            Console.WriteLine(menuUser);
            Console.WriteLine("\n\nEnter Your Choice:");
            int choiceUser = int.Parse(Console.ReadLine());

            switch (choiceUser)
            {
                case 1:
                    Console.WriteLine("\nLogin Successfully\n");
                    string menuLogin = @"Press 1 for 'All Courses' 
Press 2 for 'Add Course; 
Press 3 for 'Delete Course'";
                    Console.WriteLine(menuLogin);
                    Console.WriteLine("\n\nEnter Your Choice:");
                    int choiceLogin = int.Parse(Console.ReadLine());
                    switch (choiceLogin)
                    {
                        case 1:
                            foreach (Course items in allCourses)
                            {
                                Console.WriteLine(items);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter Your Id");
                            int id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Your Name");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter Your Rating");
                            double rating = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Your Price");
                            int price = int.Parse(Console.ReadLine());

                            Course course = new Course() { Id = id, Name = name, Rating = rating, Price = price };
                            Console.WriteLine(courserepository.AddCourse(course));
                            foreach (Course items in allCourses)
                            {
                                Console.WriteLine(items);
                            }
                            break;
                        case 3:
                            Console.WriteLine("\nDelete\n");
                            string menuDelete = @"Press 1 for 'Course Delete By Name'  
Press 2 for 'Course Delete By Id'";
                            Console.WriteLine(menuDelete);
                            Console.WriteLine("\n\nEnter Your Choice:");
                            int choiceDelete = int.Parse(Console.ReadLine());
                            switch(choiceDelete)
                            {
                                case 1:
                                    Console.WriteLine("Enter the Course Name What you Want to be delete");
                                    string deletecourse = Console.ReadLine();
                                    courserepository.DeleteCourseByName(deletecourse);
                                    break;

                                case 2:
                                    Console.WriteLine("Enter the Course Id What you Want to be delete");
                                    int deleteCourseId = int.Parse (Console.ReadLine());
                                    courserepository.DeleteCourseById(deleteCourseId);
                                    break;
                            }
                            break;

                        case 4:
                            Console.WriteLine("Enter the Course Id What you Want to be delete");
                            int updateId = int.Parse(Console.ReadLine());
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Register");
                    Console.WriteLine("Enter Your User Name");
                    string User_Admin_name = Console.ReadLine();
                    User user = new User() { userName = User_Admin_name };
                    Console.WriteLine(userrepository.AddUser(user));
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