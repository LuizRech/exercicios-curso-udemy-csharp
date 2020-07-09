using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel_ExercicioVetores
{
    class Cliente
    {
        public string Nome;
        public string Email;

        public override string ToString()
        {
            return Nome
                + ", "
                + Email;
                
        }
    }
}
