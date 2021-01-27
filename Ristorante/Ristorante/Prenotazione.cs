using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ristorante
{
    public class Prenotazione
    {
        private DateTime _giornoOra;
        private int _numeroPersone;
        private int _nomePrenotazione;

        public Prenotazione()
        {


        }

        public Prenotazione(DateTime giornoOra, int numeroPersone, int nomePrenotazione)
        {
            this.GiornoOra = giornoOra;
        }

        public DateTime GiornoOra
        {
            get => _giornoOra;

            private set
            {
                if (DateTime.Compare(value, DateTime.Now) > 0)
                    _giornoOra = value;
            }
        }


        

        public int NumeroPersone { get => _numeroPersone; set => _numeroPersone = value; }
        public int NomePrenotazione { get => _nomePrenotazione; set => _nomePrenotazione = value; }

       
    }
}