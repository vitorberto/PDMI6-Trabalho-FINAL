using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDMTPFINAL.Model
{
    public class Mercadorias
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string NomeMercadoria { get; set; }

        public string PesoMercadoria { get; set; }

        public string NomeProdutor { get; set; }

        public string EmailProdutor { get; set; }

        public string NCM { get; set; }
    }
}
