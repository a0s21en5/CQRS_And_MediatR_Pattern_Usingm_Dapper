using Model;
using System.Data.SqlClient;

namespace Repository
{
    public class CourseRepository
    {
        //SQL Connection and Command Classes
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public CourseRepository()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-AVEU8VJ;Database=CourseDatabase;Trusted_Connection=True");
            cmd = new SqlCommand();
        }

        //---------------------------- Admin Functionalities --------------------------------
        //Get All Product
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            //To Give The Query
            cmd.CommandText = "select * from Course_TB";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course course = new Course();
                course.Id = (int)reader["ID"];
                course.Name = (string)reader["Name"];
                course.Price = (int)reader["Price"];
                course.Rating = (float)(double)reader["Rating"];
                courses.Add(course);
            }
            sqlConnection.Close();
            return courses;
        }

        //Add Course
        public void AddCourse(Course course)
        {
            cmd.CommandText = "insert into Course_TB values(@Id,@Name,@Price,@Rating)";
            cmd.Parameters.AddWithValue("@Id", course.Id);
            cmd.Parameters.AddWithValue("@Name", course.Name);
            cmd.Parameters.AddWithValue("@Price", course.Price);
            cmd.Parameters.AddWithValue("@Rating", course.Rating);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //Delete Product By Id
        public void DeleteCourseById(Course course)
        {
            cmd.CommandText = "DELETE FROM Course_TB WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", course.Id);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //Update Course By ID
        public void UpdateCourseById(Course course)
        {
            sqlConnection.Open();
            cmd.CommandText = "UPDATE Course_TB SET Name = @Name, Price = @Price, Rating = @Rating WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", course.Id);
            cmd.Parameters.AddWithValue("@Name", course.Name);
            cmd.Parameters.AddWithValue("@Price", course.Price);
            cmd.Parameters.AddWithValue("@Rating", course.Rating);
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //---------------------------- User Functionalities -------------------------------- 
        //Get All User
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            //To Give The Query
            cmd.CommandText = "select* from User_TB";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.userName = (string)reader["Name"];
                user.Password = (string)reader["Password"];
                users.Add(user);
            }
            sqlConnection.Close();
            return users;
        }

        public void AddUser(User user)
        {
            cmd.CommandText = "insert into User_TB values(@Name,@Password)";
            cmd.Parameters.AddWithValue("@Name", user.userName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        //Delete Product By User Name
        public void DeleteCourseByName(User user)
        {
            cmd.CommandText = "DELETE FROM User_TB WHERE Name = @Name";
            cmd.Parameters.AddWithValue("@Name", user.userName);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}