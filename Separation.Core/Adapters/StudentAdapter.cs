using Separation.App.Interfaces;
using Separation.App.Models;
using Separation.Data.Records;
using Separation.Data.Repositories;

namespace Separation.Core.Adapters
{
    public class StudentAdapter : IStudentGet, IStudentCreate
    {
        private readonly StudentRepository _studentRepository;

        public StudentAdapter(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetStudent()
        {
            var record = _studentRepository.GetStudent();
            return ToEntity(record);
        }

        public void CreateStudent(Student student)
        {
            _studentRepository.Create(ToRecord(student));
        }

        /**
         * 
         * Since the adapter knows about the App and Data layer,
         * mapping from Entity -> Record and Record -> Entity can happen here.
         * Rather than static methods in the Record class
         * 
         */
        private static Student ToEntity(StudentRecord studentRecord)
        {
            return new Student
            {
                Anumber = studentRecord.anumber,
                FirstName = studentRecord.firstName,
                LastName = studentRecord.lastName
            };
        }

        private static StudentRecord ToRecord(Student student)
        {
            return new StudentRecord
            {
                anumber = student.Anumber,
                firstName = student.FirstName,
                lastName = student.LastName
            };
        }
    }
}
