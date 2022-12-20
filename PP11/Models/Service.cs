namespace PP11.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
