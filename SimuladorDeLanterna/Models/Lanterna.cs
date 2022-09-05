using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladorDeLanterna.Models
{
    public class Lanterna
    {
        private int Status;
        private Bateria Bateria;

        public Lanterna(int status, Bateria bateria)
        {
            Status = status;
            Bateria = bateria;
        }

        public int GetStatus()
        {
            return Status;
        }

        public void SetStatus(int status)
        {
            this.Status = status;
        }

        public int GetCarga()
        {
            return Bateria.Carga;
        }

        public void TrocarBateria(Bateria bateria)
        {
            this.Bateria = bateria;
        }
    }

}
