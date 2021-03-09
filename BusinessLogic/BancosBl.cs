using BusinessEntity;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BancosBl
    {
        BancosDl bancosDl;

        public BancosBl()
        {
            this.bancosDl = new BancosDl();
        }
        public List<BancosBe> Listar (int? pCodBancoN)
        {
            List<BancosBe> res = null;

            res = this.bancosDl.Listar(pCodBancoN);

            return res;
        }
    }
}
