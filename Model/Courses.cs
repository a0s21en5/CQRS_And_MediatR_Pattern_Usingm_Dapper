using System;

namespace Course_APP.Model
{
    internal class Courses
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public int coursePrice { get; set; }

        public double courseRating { get; set; }

        public override string ToString()
        {
            return $"ID = {courseId}\t\t Course Name = {courseName}\t\t\t  Course Price = {coursePrice}\t\t Course Rating = {courseRating}";
        }
    }
}
