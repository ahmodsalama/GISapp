using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace COMON.BLL
{
    public class benf : Repository<T_COMN_BENF_TP>
    {
        public T_COMN_BENF_TP Save(T_COMN_BENF_TP bnf)
        {
            try
            {
                base.Add(bnf);
                return bnf;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
