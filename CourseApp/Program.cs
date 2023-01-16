using Model;
using Repository;

CourseRepository courseRepository = new CourseRepository();
List<Course> AllCourse = courseRepository.GetAllCourses();


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
            int innerloop = 1;
            while(innerloop==1)
            {
                Console.WriteLine("\t\t\t\t\t\tAdmin Pannel\n\n");
                string menuAdmin = @"Press 11 for 'Show All User' 
Press 22 for 'Add User'
Press 33 for 'Delete User'
Press 44 for 'Get All Course
Press 55 for 'Add New Course'
Press 66 for 'Delete Product by Id'
Press 77 for 'Update New Course'
Press 99 for 'Go To Main Menu'";
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
                        courseRepository.DeleteUserByName(userDelete);
                        break;
                    case 44:
                        foreach (Course items in AllCourse)
                        {
                            Console.WriteLine(items);
                        }
                        break;

                    case 55:
                        //Add Course
                        Console.WriteLine("Enter Course Id");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Course Name");
                        string names = Console.ReadLine();

                        Console.WriteLine("Enter Course Price");
                        int price = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Course Rating");
                        float rating = float.Parse(Console.ReadLine());

                        Course course = new Course() { Id = id, Name = names, Price = price, Rating = rating };
                        courseRepository.AddCourse(course);
                        break;

                    case 66:
                        //Delete Course Id
                        Console.WriteLine("Enter Course what you want to be deleted Id");
                        int idDelete = int.Parse(Console.ReadLine());

                        Course Course = new Course() { Id = idDelete };
                        courseRepository.DeleteCourseById(Course);
                        break;

                    case 77:
                        //Update Course
                        Console.WriteLine("Enter Course Id");
                        int idUpdate = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Course Name");
                        string nameUpdate = Console.ReadLine();

                        Console.WriteLine("Enter Course Price");
                        int priceUpdate = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Course Rating");
                        float ratingUpdate = float.Parse(Console.ReadLine());

                        Course courseUpdate = new Course() { Id = idUpdate, Name = nameUpdate, Price = priceUpdate, Rating = ratingUpdate };
                        courseRepository.UpdateCourseById(courseUpdate);
                        break;

                    case 99:
                        innerloop = 0;
                        break;
                }
            }
            break;

        case 2:
            Console.WriteLine("\n\n\n"); 
            Console.WriteLine("\t\t\t\t\t\t\n\nUser Pannel");
            Console.WriteLine("\n\n\n");
            string menuUser = @"Press 1 for 'Login' 
Press 2 for 'Register; 
Press 3 for 'LogOut'";
            Console.WriteLine(menuUser);
            Console.WriteLine("\n");
            int choiceUser = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (choiceUser)
            {
                case 1:
                    Console.WriteLine("Login");
                    Console.WriteLine("\nEnter Your Login Name");
                    string nameLogin = Console.ReadLine();

                    Console.WriteLine("\nEnter Your Login Password");
                    string passwordLogin = Console.ReadLine();

                    User userLogin = new User() { userName = nameLogin, Password = passwordLogin };
                    courseRepository.LogIn(userLogin);

                    int innerLoop = 1;
                    while(innerLoop==1)
                    {
                        Console.WriteLine("\t\t\t\t\t\tUser Pannel\n\n");
                        string loginMenu = @"Press 1 for 'Get All Course'
Press 2 for 'Book Course'
Press 3 for 'Delete Course in Cart'
Press 4 for 'Show All Course in Cart'
Press 5 for 'Go To Main Menu'";
                        Console.WriteLine(loginMenu);

                        int LoginMen = int.Parse(Console.ReadLine());

                        switch (LoginMen)
                        {
                            case 1:
                                foreach (Course items in AllCourse)
                                {
                                    Console.WriteLine(items);
                                }
                                break;

                            case 2:
                                Console.WriteLine("Enter Your Course Id");
                                int inputId = int.Parse(Console.ReadLine());
                                Course courseCart = new Course() { Id = inputId };
                                courseRepository.AddToCartInCourse(courseCart);
                                Console.WriteLine("Course Added To Cart");
                                break;

                            case 3:
                                Console.WriteLine("Enter User Name what you want to be deleted");
                                int id_Delete = int.Parse(Console.ReadLine());

                                Course course = new Course() { Id = id_Delete };
                                courseRepository.DeleteCourseInCart(course);
                                Console.WriteLine("Course Delete To Cart");
                                break;

                            case 4:
                                List<Course> AllCourseCart = courseRepository.GetAllCourseInCart();
                                foreach (Course itemCart in AllCourseCart)
                                {
                                    Console.WriteLine(itemCart);
                                }
                                break; 
                            
                            case 5:
                                innerLoop = 0;
                                break;
                        }
                    }

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