using Separation.App.Interfaces;
using Separation.App.Models;

namespace Separation.App.Interactor
{
    public class StudentGetInteractor
    {
        private readonly IStudentGet _studentAdapter;

        public StudentGetInteractor(IStudentGet studentAdapter)
        {
            _studentAdapter = studentAdapter;
        }

        public Student GetStudent()
        {
            return _studentAdapter.GetStudent();
        }
    }
}
