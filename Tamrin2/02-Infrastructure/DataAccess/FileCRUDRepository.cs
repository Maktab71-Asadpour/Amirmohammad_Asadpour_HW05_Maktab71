public class FileCRUDRepository : ICRUDRepository<Person>
{
    public void Delete(string nationalCode, string email)
    {
        Person? deletingPerson = DataStore.GetPersons().Where(p => p.NationalCode==nationalCode && p.Email==email).FirstOrDefault();
        List<Person> newPersonList = DataStore.GetPersons();

        if (deletingPerson != null && newPersonList.Remove(deletingPerson))
        {
            DataStore.SetPersons(newPersonList);
        }
        else
        {
            Console.WriteLine("Delete faild!");
        }
    }

    public void Insert(Person newPerson)
    {
        List<Person> newPersonList = DataStore.GetPersons();
        newPersonList.Add(newPerson);
        DataStore.SetPersons(newPersonList);
    }

    public Person? Query(string nationalCode, string email)
    {
        return DataStore.GetPersons().Where(p => p.NationalCode == nationalCode && p.Email == email).FirstOrDefault();
    }

    public void Update(Person newPerson, Person oldPerson)
    {
        List<Person> newPersonList = DataStore.GetPersons();
        int updatingIndex = newPersonList.IndexOf(oldPerson);
        if (updatingIndex != -1)
        {
            newPersonList[updatingIndex] = newPerson;
            DataStore.SetPersons(newPersonList);
        }
    }
}