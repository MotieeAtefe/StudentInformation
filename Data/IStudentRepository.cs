using StudentInformation.Model;

namespace StudentInformation.Data
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);  //insert student
         IEnumerator<Student> GetAll();  //get value from sql
      //  Student GetById(int id);  //get value by Id


    }
}
