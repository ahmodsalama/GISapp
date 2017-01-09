using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace PERS.BLL
{
    class pers : Repository<T_COMN_PERS_DATA>
    {
        public decimal Save(T_COMN_PERS_DATA person)
        {
            try
            {
                if (person.ID==0)
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
    }
}
