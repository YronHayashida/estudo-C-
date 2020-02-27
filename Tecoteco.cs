using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo
{
    class Tecoteco : VeiculoAereo
    {
        public override void AceleracaoMax(int kilometroHora)
        {
            int max = 400;
            if (kilometroHora == max)
            { AceleracaoMaxima = true; }
            else { AceleracaoMaxima = false; }
        }
    }
}
