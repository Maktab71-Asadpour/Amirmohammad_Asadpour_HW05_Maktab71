public class Person
{
    public long Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public string? NationalCode { get; private set; }
    public string? Email { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }



    public Person(long id, string? firstName, string? lastName, string? fatherName, string? nationalCode, string? email
        , int height, int weight)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        FatherName = fatherName;
        Email = email;
        Height = height;
        Weight = weight;
        NationalCode = nationalCode;
    }



    public static bool operator ==(Person person1, Person person2)
    {
        if (person1.Id == person2.Id && person1.FirstName == person2.FirstName
            && person1.LastName == person2.LastName && person1.FatherName == person2.FatherName
            && person1.Email == person2.Email && person1.Height == person2.Height
            && person1.Weight == person2.Weight && person1.NationalCode == person2.NationalCode)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Person person1, Person person2) { return !(person1 == person2); }
}