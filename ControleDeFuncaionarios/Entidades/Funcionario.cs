using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncaionarios.Entidades
{
    /// <summary>
    /// Class representing an employee in the system.
    /// </summary>
    public class Funcionario
    {
        #region Properties

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public DateOnly DataAdmissao { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public Guid EmpresaId { get; set; } = Guid.Empty;

        #endregion

        #region Relacionamentos

        public Empresa Empresa { get; set; } = new();

        #endregion

    }
}
