namespace Section03Factories
{
    public class PersonFactory
    {
        private int id = 0;
        public Person CreatePerson(string name)
        {
            Person res = new Person();
            res.Id = id;
            res.Name = name;

            id++;

            return res;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return ($"Id: {Id}, Name: {Name}");
        }
    }
}
