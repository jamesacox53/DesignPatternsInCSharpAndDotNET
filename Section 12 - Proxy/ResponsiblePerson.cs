namespace Section12Proxy
{
    public class Person
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson
    {
        private Person person;
        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public int Age
        {
            set
            {
                person.Age = value;
            }
            get
            {
                return person.Age;
            }
        }

        public string Drink()
        {
            if (this.Age < 18)
            {
                return "too young";
            }
            else
            {
                return this.person.Drink();
            }
        }

        public string Drive()
        {
            if (this.Age < 16)
            {
                return "too young";
            }
            else
            {
                return this.person.Drive();
            }
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
