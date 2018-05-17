using Separation.App.Interfaces;
using Separation.App.Models;

namespace Separation.App.Interactor
{
    public class StudentCreateInteractor
    {
        private readonly IStudentCreate _studentAdapter;

        public StudentCreateInteractor(IStudentCreate studentAdapter)
        {
            _studentAdapter = studentAdapter;
        }

        public void CreateStudent(Student student)
        {
            _studentAdapter.CreateStudent(student);
        }
    }
}
