using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DWO_01
{
    internal class Human
    {
        public string Name, Title;
        public DateTime BirthDay;

        public void SetHuman(string _name, string _title, DateTime _birthDay)
        {
            this.Name = _name;
            this.Title = _title;
            this.BirthDay = _birthDay;
        }

        public string GetHumanNT()
        {
            return Name + Title;
        }

        public DateTime GetHumanD()
        {
            return BirthDay;
        }

    }
}
