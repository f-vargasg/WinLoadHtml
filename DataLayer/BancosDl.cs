using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BancosDl : DataWorker
    {

       public List<BancosBe> Listar (int? pCodBancoN)
        {
            string cond = (pCodBancoN == null ? string.Empty : "WHERE COD_BANCO_N = " + Convert.ToString(pCodBancoN));
            List<BancosBe> res = new List<BancosBe>();

            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateCommand("SELECT * FROM GE_AMBBANCO "
                                                                   + cond, connection))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BancosBe be = new BancosBe();
                            be.CodBancoN = Convert.ToInt32(reader["COD_BANCO_N"]);
                            be.CodPaisN  = Convert.ToInt32(reader["COD_PAIS_N"]);
                            be.DesBanco = Convert.ToString(reader["DES_CORTA"]);
                            be.DesCorta = Convert.ToString(reader["DES_CORTA"]);
                            be.CodRegistroN = Convert.ToDecimal(reader ["COD_REGISTRO_N"]);
                            be.CodEstadoN = Convert.ToInt32(reader["COD_ESTADO_N"]);
                            be.CodZonaPigN = Convert.ToInt32(reader["COD_ZONAPIG_N"]);
                            if (reader["COD_SINPE_N"] != DBNull.Value)
                            {
                                be.CodSinpeN = Convert.ToInt32(reader["COD_SINPE_N"]);
                            }
                            
                            res.Add(be);
                        }
                    }
                }
            }
            return res;
        }

    }
}
