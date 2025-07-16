using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncaionarios.Configuracoes
{
    /// <summary>
    /// Class representing the database configuration settings.
    /// </summary>
    public class ConfiguracaoDB
    {
        public string ConnectionString 
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBFuncionarios;Integrated Security=True";
            }
        }
    }
}
