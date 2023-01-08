using System;

namespace Course_App.Model
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Rating { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}\t\t\t Course Name = {Name}\t\t\t Rating = {Rating}\t\t\t Price = {Price}";
        }
    }
}
