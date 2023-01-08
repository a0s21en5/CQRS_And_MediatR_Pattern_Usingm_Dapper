
using Course_App.Model;

namespace Course_App.Repository
{
    internal class CourseRepository
    {
        //Declare List
        List<Course> courses;
        public CourseRepository()
        {
            courses= new List<Course>()
            {
                new Course() {Id = 1, Name = "HTML", Rating = 4.5, Price = 500},
                new Course() {Id = 2, Name = "CSS", Rating = 4.6, Price = 800},
                new Course() {Id = 3, Name = "C", Rating = 5, Price = 1000},
                new Course() {Id = 4, Name = "C++", Rating = 4.8, Price = 1500},
                new Course() {Id = 5, Name = "Python", Rating = 3.9, Price = 2000},
            };
        }
        //Get All Courses
        public List<Course> GetAllCourses()
        {
            return courses;
        }

        public string AddCourse(Course course)
        {
            courses.Add(course);
            return $"Course Add Successfully";
        }

        //Course Delete By Name
        public void DeleteCourseByName(string deleteCourseName)
        {
            foreach (Course item in courses)
            {
                if(item.Name != deleteCourseName)
                {
                    Console.WriteLine($"Id = {item.Id}\t\t Course= {item.Name} \t\t Rating = {item.Rating}\t\t Price = {item.Price}");
                }
            }
        }

        //Course Delete By Id
        public void DeleteCourseById(int deleteCourseId)
        {
            foreach (Course item in courses)
            {
                if (item.Id != deleteCourseId)
                {
                    Console.WriteLine($"Id = {item.Id}\t\t Course= {item.Name} \t\t Rating = {item.Rating}\t\t Price = {item.Price}");
                }
            }
        }

        //Update Product By Id
        public void UpdateProduct(int updateId)
        {
            foreach (Course item in courses)
            {
                if(item.Id!= updateId) 
                {
                    Console.WriteLine($"Id = {item.Id}\t\t Course= {item.Name} \t\t Rating = {item.Rating}\t\t Price = {item.Price}");
                }
            }
        }
    }
}
