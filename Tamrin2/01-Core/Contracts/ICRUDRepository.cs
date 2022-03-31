
public interface ICRUDRepository<T>
{
    public void Insert(Person person);
    public T? Query(string nationalCode, string email);
    public void Update(Person newPerson, Person oldPerson);
    public void Delete(string nationalCode, string email);
}
