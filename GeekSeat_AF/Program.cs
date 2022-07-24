using System;
using System.Collections.Generic;

namespace GeekSeat_AF
{
    class Program
    {
        static void Main(string[] args)
        {

            List<WitchSaga.Person> ps = new List<WitchSaga.Person>();
            WitchSaga.Person p = new WitchSaga.Person(10, 12);
            ps.Add(p);
            Console.WriteLine("Person 1 Born On Year = " + p.DeathYear + " - " + p.DeathAge + " = " + p.BornYear.ToString() + ", Number of People Killed on year " + p.BornYear + " is " + p.NumOfPeopleKilled.ToString());
            p = new WitchSaga.Person(13, 17);
            ps.Add(p);
            Console.WriteLine("Person 2 Born On Year = " + p.DeathYear + " - " + p.DeathAge + " = " + p.BornYear.ToString() + ", Number of People Killed on year " + p.BornYear + " is " + p.NumOfPeopleKilled.ToString());
            float avg = WitchSaga.Person.AverageNumberOfPeopleKilled(ps);
            Console.WriteLine("So the average is " + avg.ToString());
            //Console.WriteLine(r.ToString());
            Console.ReadLine();
        }
    }
}
