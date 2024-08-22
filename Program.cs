using EF_1.Entities;

namespace EF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // By DbContext 
            iti_Context DB = new iti_Context();
            Course c =new Course(1,"5 Month","C#","Course Description");
            DB.Add(c);
        }
    }
}
