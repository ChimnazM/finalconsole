

namespace ConsoleProgram.Infrastructure.Models
{
    public class Category
    {
        static int count = 1;
        public Category()
        {
            this.Id = count++;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
