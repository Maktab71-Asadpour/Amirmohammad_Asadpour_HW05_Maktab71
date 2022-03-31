public static class DataStore
{
    private static List<Person>? Persons;
    private static string SourceFilePath { get; set; }

    static DataStore()
    {
        SourceFilePath = Directory.GetCurrentDirectory() + "\\Persons.txt";

        if (!File.Exists(SourceFilePath))
        {
            File.Create(SourceFilePath);
        }

        Persons = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("Persons.txt"));

        if (Persons == null)
        {
            Persons = new List<Person>();
        }
    }

    public static List<Person>? GetPersons()
    {
        return Persons;
    }

    public static void SetPersons(List<Person> personList)
    {
        Persons = personList;
        File.WriteAllText(SourceFilePath, Newtonsoft.Json.JsonConvert.SerializeObject(Persons));
    }
}