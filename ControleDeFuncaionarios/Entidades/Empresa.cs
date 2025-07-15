using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncaionarios.Entidades
{
    /// <summary>
    /// Class representing a company in the system.
    /// </summary>
    public class Empresa
    {
        #region Properties

        public Guid Id { get; set; } = Guid.NewGuid();
        public string RazaoSocial { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;

        #endregion

        #region Relacionamentos

        public List<Funcionario> Funcionarios { get; set; } = new();

        #endregion

    }
}
