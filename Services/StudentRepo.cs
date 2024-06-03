using atelier_injection_dependance.Models;

namespace atelier_injection_dependance.Services
{
    public class StudentRepo : IStudentDao
    {
        List<Student> TlsStudents;
        List<Student> BdxStudents;

        public StudentRepo()
        {
            // Initialiser les listes avec des données d'étudiants
            TlsStudents = new List<Student>() {
            new Student("Etudiant1", "Toulouse"),
            new Student("Etudiant2", "Toulouse"),
            // Ajoutez plus d'étudiants Toulousains ici
        };

            BdxStudents = new List<Student>() {
            new Student("Etudiant3", "Bordeaux"),
            new Student("Etudiant4", "Bordeaux"),
            // Ajoutez plus d'étudiants Bordelais ici
        };
        }

        public List<Student> FindAllTls()
        {
            // Retourne la liste des étudiants Toulousains
            return TlsStudents;
        }

        public List<Student> FindAllBdx()
        {
            // Retourne la liste des étudiants Bordelais
            return BdxStudents;
        }
    }
}
