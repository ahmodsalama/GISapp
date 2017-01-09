using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace COMON.BLL
{
    class blackList:Repository<T_COMN_BLACK_LIST>
    {
        public decimal Save(T_COMN_BLACK_LIST blck)
        {
            try
            {
                if (blck.ID == 0)
                {
                    base.Add(blck);
                    return blck.ID;
                }
                else
                {
                    base.Update(blck);
                    return blck.ID;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
