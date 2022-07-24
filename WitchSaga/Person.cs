using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitchSaga
{
    public class Person
    {
        public int BornYear { get; set; }
        public float NumOfPeopleKilled { get; set; }
        public int DeathAge { get; set; }
        public int DeathYear { get; set; }

        public Person(int ageOfDeath, int yearOfDeath)
        {
            DeathAge = ageOfDeath;
            DeathYear = yearOfDeath;
            BornYear = yearOfDeath - ageOfDeath;
            NumOfPeopleKilled = NumberOfPeopleKilledOnYear(BornYear);
        }

        public static float AverageNumberOfPeopleKilled(List<Person> Persons)
        {
            float vRet = 0;
            int div = Persons.Count();
            float totalPeopleKilled = 0;
            foreach (Person p in Persons)
            {
                totalPeopleKilled += p.NumOfPeopleKilled;
            }
            vRet = totalPeopleKilled / div;
            return vRet;
        }

        int NumberOfPeopleKilledOnYear(int year)
        {
            if (year < 0)
            {
                return -1;
            }

            int[] arr = new int[year];

            arr[0] = 1; arr[1] = 1;
            for (int x = 0; x < year; x++)
            {
                if (x == 0)
                {
                    arr[0] = 1;
                }
                else
                {
                    if (x == 1)
                    {
                        arr[1] = 1;
                    }
                    else
                    {
                        arr[x] = arr[x - 1] + arr[x - 2];
                    }
                }
            }
            int sum = arr.Sum();
            return sum;
        }
    }
}