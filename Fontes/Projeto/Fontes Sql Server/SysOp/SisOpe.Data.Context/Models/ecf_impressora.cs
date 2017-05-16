using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Impressora
    {
        public Ecf_Impressora()
        {
            this.ecf_movimento = new List<Ecf_Movimento>();
        }

        public long ID { get; set; }
        public string CODIGO { get; set; }
        public string SERIE { get; set; }
        public string IDENTIFICACAO { get; set; }
        public string MC { get; set; }
        public string MD { get; set; }
        public string VR { get; set; }
        public string TIPO { get; set; }
        public string MARCA { get; set; }
        public string MODELO_ACBR { get; set; }
        public string MODELO { get; set; }
        public string VERSAO { get; set; }
        public string LE { get; set; }
        public string LEF { get; set; }
        public string MFD { get; set; }
        public string CRENAMFD { get; set; }
        public string DOCTO { get; set; }
        public virtual ICollection<Ecf_Movimento> ecf_movimento { get; set; }
    }
}
