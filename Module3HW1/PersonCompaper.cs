using System.Collections.Generic;

namespace Module3HW1
{
    internal class PersonCompaper : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            if (x.Age < y.Age)
            {
                return -1;
            }
            else if (x.Age > y.Age)
            {
                return 1;
            }

            return 0;
        }
    }
}
