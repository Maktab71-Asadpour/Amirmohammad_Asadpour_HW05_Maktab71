public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string NationalCode { get; private set; }
    public DateTime Birthday { get; set; }



    public Person(int id, string firstName, string lastName, string email, int age, string address, string nationalCode, DateTime birthday)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
        Address = address;
        NationalCode = nationalCode;
        Birthday = birthday;
    }

}