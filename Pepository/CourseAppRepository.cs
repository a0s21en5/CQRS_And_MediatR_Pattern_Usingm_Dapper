using Course_APP.Model;
using System;
using System.Net;

namespace Course_APP.Pepository
{
    internal class CourseAppRepository
    {
        //Declare a List
        List<Course> course;
        
        public CourseAppRepository()
        {
            course = new List<Courses>()
            {
                new Courses() {courseId = 1, courseName = "C  ", coursePrice = 500, courseRating = 4.5},
                new Courses() {courseId = 2, courseName = "C++", coursePrice = 1000, courseRating = 4},
                new Courses() {courseId = 3, courseName = "Java", coursePrice = 1500, courseRating = 4.2},
                new Courses() {courseId = 4, courseName = "Python", coursePrice = 900, courseRating = 4.3},
            };
        }
        //Get All Course
        public List<Courses> GetAllCourses()
        {
            return courses;
        }
        //Add Course
        public string AddCourse(Courses courses)
        {
            courses.Add(courses);
            return $"Course Add Successfully";
        }
    }
}
