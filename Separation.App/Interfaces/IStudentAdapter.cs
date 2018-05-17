using Separation.App.Models;

namespace Separation.App.Interfaces
{
    public interface IStudentAdapter
    {
        Student GetStudent();

        void CreateStudent(Student student);
    }
}
