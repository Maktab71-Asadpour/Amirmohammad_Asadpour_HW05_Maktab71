
try
{
    string SourceFilePath = Directory.GetCurrentDirectory() + "\\Persons.json";
    List<Person> personList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(SourceFilePath));



    //------------------------- Tamrin 3.a -------------------------
    List<Person> personList_A = personList.Where(p => p.Age>20).OrderBy(p => p.FirstName).ThenBy(a => a.LastName).ToList();

    //------------------------- Tamrin 3.b -------------------------
    List<Person> personList_B = personList.Where(p => p.Birthday.Year < 1999).ToList();

    //------------------------- Tamrin 3.c -------------------------
    List<Person> personList_C = personList.Where(p => personList.Count(a => a.Birthday == p.Birthday ) > 1).OrderBy(b => b.Birthday).ToList();

    //------------------------- Tamrin 3.d -------------------------
    List<Person> personList_D = personList.OrderBy(p => p.Id).ToList();
    personList_D.RemoveAt(3);

    //------------------------- Tamrin 3.e -------------------------
    List<Person> personList_E = personList.OrderBy(p => p.Id).ToList();
    personList_E.RemoveRange(49, 30);

    //------------------------- Tamrin 3.f -------------------------
    List<Person> personList_F = personList.Where(p => p.Birthday.Subtract(DateTime.UnixEpoch).TotalSeconds == personList.Max(a => a.Birthday.Subtract(DateTime.UnixEpoch).TotalSeconds)).ToList();

    //------------------------- Tamrin 3.g -------------------------
    List<Person> personList_G = personList.Where(p => personList.Count(a => a.NationalCode == p.NationalCode) > 1).ToList();

    //------------------------- Tamrin 3.h -------------------------
    List<Person> personList_H = personList.Where(p => p.Address.ToLower().Contains("tehran")).ToList();

    //------------------------- Tamrin 3.i -------------------------
    List<Person> personList_I = personList.Where(p => p.Address.ToLower().Contains("tehran") && personList.Count(a => a.Address == p.Address) > 1).ToList();

    //------------------------- Tamrin 3.j -------------------------
    List<Person> personList_J = personList.Where(p => p.NationalCode.Contains("123")).ToList();

    //------------------------- Tamrin 3.k -------------------------
    List<string> infoList_K = personList.Where(P => P.Age>25).Select(a => $"The national code is {a.NationalCode} and the address is {a.Address}").ToList();

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


