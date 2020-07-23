using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice1
{
    public class PersonList
    {
        public string m_Name { get; set; }
        public DateTime m_Date { get; set; }
        public int m_Age { get; set; }
        public  string m_Profession { get; set; }

        public PersonList(string i_Name, DateTime i_Date, int i_Age, string i_Profession)
        {
            m_Name = i_Name;
            m_Date = i_Date;
            m_Age = i_Age;
            m_Profession = i_Profession;
        }
    }
}
