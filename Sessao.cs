using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdWheels
{
    internal class Sessao
    {
        public static int? IdUsuario { get; set; }
        public static string? Tipo { get; set; }
        public static int? IdReferencia { get; set; }
        public static string? Cargo { get; set; }

        public static bool IsCliente => Tipo == "cliente";
        public static bool IsFuncionario => Cargo == "funcionario"; 
        public static bool IsGerente => Cargo == "gerente";



    public static void Limpar()
        {
            IdUsuario = null;
            Tipo = null;
            IdReferencia = null;
            Cargo = null;
        }
    }
}
