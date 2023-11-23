public class Program
{

    public static void Main(string[] args)
    {


        int A;
        int B;

        decimal C;

        A = 10; B = 20;

        C = (decimal)A / (decimal)B;

        Console.WriteLine($"The Modulus of A and B is {A%B}");

        //Desolve the equation X^2 -5x + 10 = 0

        Console.WriteLine("Enter the first coefficient 'a' ");

        
        double a = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter the second coefficient 'b' ");

        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the last coefficient 'c' ");

        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Finding the discriminant \n");

        double discriminant = (b * b) - 4 * a * c;

        if(discriminant >= 0)
        {
           double root1 =  (-b+ Math.Sqrt(discriminant))/ 2 * a ;

         double root2 = (-b- Math.Sqrt(discriminant)) / 2 * a;

            Console.WriteLine($"The first root is {root1}");
            Console.WriteLine($"The second root is {root2}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

            Console.WriteLine($"{realPart} + {imaginaryPart}i ");
        }


        




        {
            // Task 1: Create an Array of 10 Students
            Student[] students = new Student[10];
            students[0] = new Student() { Name = "Ismail Adegbite", Age=18, DateOfBirth = new DateTime(2005, 1, 18), Email="ismail.adegbite@gmail.com" };
            students[1] = new Student() { Name = "Babajide Moses", Age = 27, DateOfBirth = new DateTime(1996, 3, 20), Email = "babajide.moses@gmail.com" };
            students[2] = new Student() { Name = "Bola Afolayan", Age = 33, DateOfBirth = new DateTime(1990, 4, 20), Email = "bola.afolayan@gmail.com" };
            students[3] = new Student() { Name = "Babajide Amara", Age = 29, DateOfBirth = new DateTime(1994, 3, 20), Email = "babajide.moses@gmail.com" };
            students[4] = new Student() { Name = "animashaun habib", Age = 23, DateOfBirth = new DateTime(2000, 3, 10), Email = "animashaun.habib@gmail.com" };
            students[5] = new Student() { Name = "James Ford", Age = 18, DateOfBirth = new DateTime(2005, 5, 12), Email = "james.ford@gmail.com" };
            students[6] = new Student() { Name = "Paul Orimogunje", Age = 27, DateOfBirth = new DateTime(1996, 5, 10), Email = "paul.orimogunje@gmail.com" };
            students[7] = new Student() { Name = "Opeyemi Coker", Age = 25, DateOfBirth = new DateTime(1998, 3, 20), Email = "opeyemi.coker@gmail.com" };
            students[8] = new Student() { Name = "Kelechi Oghu", Age = 24, DateOfBirth = new DateTime(1999, 5, 11), Email = "kelechi.oguh@gmail.com" };
            students[9] = new Student() { Name = "Peter Okoye", Age = 25, DateOfBirth = new DateTime(1997, 4, 6), Email = "peter.okoye@zenithbank.com" };
            // Task 2: Create a List of Student Ages
            List<int> studentAges = students.Select(s => s.Age).ToList();

            // Query if a student whose age is 18 is in the list
            bool isStudent18 = studentAges.Contains(18);

            Console.WriteLine($"Is there a student with age 18? {isStudent18}");


            int targetAge = 18;
            List<Student> studentsWithTargetAge = students
                .Where(student => student.Age == targetAge)
                .ToList();

            Console.WriteLine($"Students with age {targetAge}:");
            foreach (var student in studentsWithTargetAge)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }

            
        }



    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }
    }



}