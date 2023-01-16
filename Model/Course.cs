namespace Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public float Rating { get; set; }

        public override string ToString()
        {
            return $"\nId = {Id}\t\t\t Name = {Name}\t\t\t Price = {Price}\t\t\t Rating = {Rating}\t\t\t\n\n";
        }
    }
}