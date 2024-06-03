namespace atelier_injection_dependance.Models
{
    public class Student
    {
        public String Name { get; set; }
        public String  Adress { get; set; }
        
        public Student(string name, string adress)
        
        {
            Name = name;
            Adress = adress;
        }
    }
}
