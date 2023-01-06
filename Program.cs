using Course_APP.Model;
using Course_APP.Pepository;

CourseAppRepository FirtsCourse = new CourseAppRepository();

List<Courses> allCourses= FirtsCourse.GetAllCourses();
Courses courses = new Courses() { courseId = 5, courseName = "C#  ", coursePrice = 5000, courseRating = 5.5 };


foreach (Courses items in allCourses)
{
    Console.WriteLine(items);
}

Console.WriteLine(FirtsCourse.AddCourse(courses));
foreach (Courses items in allCourses)
{
    Console.WriteLine(items);
}