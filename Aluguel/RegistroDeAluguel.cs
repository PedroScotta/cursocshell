using System;
using System.Globalization;

namespace Aluguel
{
    class RegistroDeAluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public RegistroDeAluguel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;                    
        }
    }
}
