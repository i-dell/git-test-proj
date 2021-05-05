using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpfundamentals.Program
{
    class InputOutput
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float salary;
            double contact;
            char gender;
            bool iSaudi;

            Console.WriteLine("Enter User Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter User Age; ")
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Salary: );
            salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter User Contact Number : ");
            contact= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter User Gender : ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Are you Saudi?(True/False: ");
            iSaudi = Convert.ToBoolean(Console.ReadLine());



            Console.WriteLine("--------------------------");
            Console.WriteLine("User Name: " + name);
            Console.WriteLine("User Ae: " + age);
            Console.WriteLine("User Salary :" + salary);
            Console.WriteLine("User Contact Number : " + contact);
            Console.WriteLine("User gender : " + gender);
            Console.WriteLine("User Contact Number : " + contact);

            Console.WriteLine("--------------------------");
            Console.ReadKey();
                       


        }
}
