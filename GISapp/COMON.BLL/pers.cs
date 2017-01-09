using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace COMON.BLL
{
    class pers : Repository<T_COMN_PERS_DATA>
    {
        public decimal Save(T_COMN_PERS_DATA person)
        {
            try
            {
                if (person.ID == 0)
                {
                    base.Add(person);
                    return person.ID;
                }
                else
                {
                    base.Update(person);
                    return person.ID;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public T_COMN_PERS_DATA GetPersonByID(decimal id)
        {
            var person = base.Get(id);
            return person;
        }
        public T_COMN_PERS_DATA GetPersonByNationalID(string NID)
        {
            var person = base.SearchFor(x => x.ID.ToString() == NID).FirstOrDefault();
            return person;
        }
        public List<T_COMN_PERS_DATA> GetAllPersons()
        {
            return base.GetAll().ToList();
        }
        public List<T_COMN_PERS_DATA> GetPersonsByName(string PersName)
        {
            var persons = base.SearchFor(x => x.PERSNAME.Contains(PersName)).ToList();
            return persons;
        }
    }
}
