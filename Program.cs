namespace task1_OOP_Eraaasoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students =  new List<Student>();

            Student s1 = new Student();
            Student s2 = new Student();


            s1.name = "Ahmed";
            s1.id = 1;
            s1.studentLevel = StudentLevel.Senior; 
            s1.Addr = new Address();

            
            s1.Addr.Street = "Cairo";
            s1.Addr.City = "Nasr City";
            s1.Addr.ZipCode = "12345";
            students.Add(s1);

            s2.name = "Mai";
            s2.id = 2;
            s2.studentLevel = StudentLevel.Junior;
            students.Add(s2);
            s2.Addr = new Address();
            s2.Addr.Street = "Giza";
            s2.Addr.City = "Dokki";
            s2.Addr.ZipCode = "54321";

            s1.DisplayInfo();
            Console.WriteLine("\n");
            s2.DisplayInfo();



        }
    }
}
