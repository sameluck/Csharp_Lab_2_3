namespace Csharp_Lab_2
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _birthdate;

        public Person(string firstName, string lastName, string email, string birthdate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _birthdate = birthdate;
        }
    }
}