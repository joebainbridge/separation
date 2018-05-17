using Separation.App.Interfaces;
using Separation.App.Models;

namespace Separation.App.Interactor
{
    public class StudentGetInteractor
    {
        private readonly IStudentAdapter _studentAdapter;

        public StudentGetInteractor(IStudentAdapter studentAdapter)
        {
            _studentAdapter = studentAdapter;
        }

        public Student GetStudent()
        {
            return _studentAdapter.GetStudent();
        }
    }
}
