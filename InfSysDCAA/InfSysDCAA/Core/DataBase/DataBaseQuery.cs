using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfSysDCAA.Core.DataBase
{
    public class DataBaseQuery
    {
        public DataBaseQuery()
        {

        }

        /// <summary>
        /// Запрос на получение логина и пароля пользователя
        /// </summary>
        /// <returns></returns>
        private List<string> QueryDatabe(List<string> queryParam)
        {
            List<string> Data = new List<string>();
            string query = "SELECT" + queryParam[0] + "FROM" + queryParam[1];

            return Data;
        }
    }
}
