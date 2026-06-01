using Microsoft.VisualBasic;

namespace Program
{
    public class Person
    {
        private DateTime _bithdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _bithdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _bithdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1998, 7, 9));
            System.Console.WriteLine(person.GetBirthdate());
            
        }
    }    
        
}


