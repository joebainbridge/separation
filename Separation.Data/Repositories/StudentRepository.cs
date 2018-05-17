using System;
using Separation.Data.Records;

namespace Separation.Data.Repositories
{
    public class StudentRepository
    {
        public StudentRecord GetStudent()
        {
            return new StudentRecord
            {
                anumber = "A9039090234",
                firstName = "Garby",
                lastName = "Bean"
            };
        }

        public void Create(StudentRecord record)
        {
            Console.WriteLine("Student Created...");
            Console.WriteLine("Anumber: " + record.anumber);
            Console.WriteLine("First Name: " + record.firstName);
            Console.WriteLine("Last Name: " + record.lastName);
        }
    }
}
