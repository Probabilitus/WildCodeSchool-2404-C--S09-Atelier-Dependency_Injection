using atelier_injection_dependance.Models;

namespace atelier_injection_dependance.Services
{
    public interface IStudentDao
    {
        List<Student> FindAllTls();
        List<Student> FindAllBdx();
   
    }
    
}
