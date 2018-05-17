using Separation.App.Interfaces;
using Separation.App.Models;

namespace Separation.App.Interactor
{
    public class StudentCreateInteractor
    {
        private readonly IStudentAdapter _studentAdapter;

        public StudentCreateInteractor(IStudentAdapter studentAdapter)
        {
            _studentAdapter = studentAdapter;
        }

        public void CreateStudent(Student student)
        {
            _studentAdapter.CreateStudent(student);
        }
    }
}
