using atelier_injection_dependance.Models;
using atelier_injection_dependance.Services;
using Microsoft.AspNetCore.Mvc;

namespace atelier_injection_dependance.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentDao _studentDao;

        // Injection de dépendance via le constructeur
        public StudentController(IStudentDao studentDao)
        {
            _studentDao = studentDao;
        }

        [HttpGet("students_tls")]
        public IActionResult GetTlsStudents()
        {
            var students = _studentDao.FindAllTls();
            return Ok(students); // Utilisez Ok pour retourner une réponse HTTP 200 OK
        }

        [HttpGet("students_bdx")]
        public IActionResult GetBdxStudents()
        {
            var students = _studentDao.FindAllBdx();
            return Ok(students); // Utilisez Ok pour retourner une réponse HTTP 200 OK
        }
    }
}