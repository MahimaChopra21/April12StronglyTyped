using System.Collections.Generic;

namespace Practice12April.Models
{
    public class SportsData
    {
        public List<SportsPersonData> getData()
        {
            SportsPersonData obj = new SportsPersonData
            {
                SportsPersonId=1,
                SportPersonName="Sachin Tendulkar",
                SportsName="Cricket",
                DoesHeOrShePlayNow= false
            };
            SportsPersonData obj1 = new SportsPersonData
            {
                SportsPersonId = 2,
                SportPersonName = "M.S Dhoni",
                SportsName = "Cricket",
                DoesHeOrShePlayNow = true
            };
            SportsPersonData obj2 = new SportsPersonData
            {
                SportsPersonId = 3,
                SportPersonName = "Virat Kohli",
                SportsName = "Cricket",
                DoesHeOrShePlayNow = true
            };

            List<SportsPersonData> data = new List<SportsPersonData>();
            data.Add(obj);
            data.Add(obj1);
            data.Add(obj2);

            return data; 

        }
    }
}
