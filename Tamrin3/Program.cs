
try
{
    string SourceFilePath = Directory.GetCurrentDirectory() + "\\Persons.json";
    List<Person> personList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(SourceFilePath));
    int len = personList.Count();



    //------------------------- Tamrin 3.a -------------------------
    personList.Where(p => p.Age>20).OrderBy(p => p.FirstName + p.LastName);

    //------------------------- Tamrin 3.b -------------------------
    personList.Where(p => p.Birthday.Year < 1999);

    //------------------------- Tamrin 3.b -------------------------
    personList.ToDictionary(p => p.Birthday).

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


