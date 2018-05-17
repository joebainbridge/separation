using System;
using System.Linq;
using Separation.App.Interactor;
using Separation.App.Models;
using Separation.Core.Adapters;
using Separation.Data.Repositories;

namespace Separation.Core.Controllers
{
    /**
     * 
     * This is a console application that implements the Adapter Pattern and the Repository Pattern.  
     * 
     **/

    internal class StudentController
    {
        private const string HelpText =
            "\n" +
            "\t Options:\n" +
            "\t --get ...................... Run a mock GET Student Request\n" +
            "\t --create ................... Run a mock POST Student Request\n" +
            "\t -h --help .................. Show this screen";

        private static void Main(string[] args)
        {
           ParseArgs(args);
        }

        private static void ParseArgs(string[] args)
        {
            if (args.Any(StartsWith("-h")) || args.Any(StartsWith("--help")))
            {
                Console.WriteLine(HelpText);
            }
            if (args.Any(StartsWith("--get")))
            {
                //Mock GET Student request
                GetStudent();
            }
            if (args.Any(StartsWith("--create")))
            {
                //Mock POST Student request
                CreateStudent();
            }
        }

        private static Func<string, bool> StartsWith(string arg)
        {
            return a => a.StartsWith(arg);
        }

        private static void GetStudent()
        {
            var repository = new StudentRepository();
            var adapter = new StudentAdapter(repository);
            var interactor = new StudentGetInteractor(adapter);
            var student = interactor.GetStudent();

            Console.WriteLine("Anumber: " + student.Anumber);
            Console.WriteLine("First Name: " + student.FirstName);
            Console.WriteLine("Last Name: " + student.LastName);
        }

        private static void CreateStudent()
        {
            var repository = new StudentRepository();
            var adapter = new StudentAdapter(repository);
            var interactor = new StudentCreateInteractor(adapter);

            //student would be received from FormBody
            var studentFromFormBody = new Student
            {
                Anumber = "A9033829465",
                FirstName = "Jordanzo",
                LastName = "Hollywood"
            };

            interactor.CreateStudent(studentFromFormBody);
        }
    }
}
