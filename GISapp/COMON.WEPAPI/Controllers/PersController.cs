using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;

namespace COMON.WEPAPI.Controllers
{
    public class PersController : ApiController
    {
        // GET api/<controller>
        public IList<T_COMN_PERS_DATA> Get()
        {
            COMON.BLL.pers persbll = new BLL.pers();
            var persons = persbll.GetAllPersons();
            return persons;
        }
        // POST api/<controller>
        public T_COMN_BENF_TP Post([FromBody]T_COMN_PERS_DATA value)
        {
            COMON.BLL.benf bnfbll = new BLL.benf();
            T_COMN_BENF_TP bnf = new T_COMN_BENF_TP();
            bnf.T_COMN_PERS_DATA.Add(value);
            bnfbll.Add(bnf);
            return bnf;
        }
    }
}
