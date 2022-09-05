using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioEngenho.Services
{
    public class MultiplierService
    {
        private readonly int tres = 3;
        private readonly int cinco = 5;
        private int resultado;

        public int VerificarMultiplosDeTresECinco(int range)
        {
            for (int i = 0; i < range + 1; i++)
            {
                if (i % this.tres == 0 || i % this.cinco == 0)
                {
                    this.resultado += i;
                };
            };

            return resultado;
        }
    }
}
