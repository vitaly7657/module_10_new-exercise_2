using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace module_10_new_exercise_2
{
    class Manager: Clients
    {
        public Manager(int ID, string Surname, string Name, string Patronymic, string PhoneNumber, string Passport) : base(ID, Surname, Name, Patronymic, PhoneNumber, Passport)
        {
           
        }
        
        public Manager() : this(2, "manager", "manager", "manager", "3", "3")//автозаполнение пустого нового класса
        {

        }
    }
}
