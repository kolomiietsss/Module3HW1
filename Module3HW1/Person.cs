namespace Module3HW1
{
    internal class Person
    {
        public Person()
        {
            Name = "Artem";
            Age = 20;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
