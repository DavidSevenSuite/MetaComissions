using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class ClientesFil
    {
        private string _Filnombre_clie;
        private int _Filtelefono;
        private string _Filcorreo;
        private int _Filidentificacion;
        private string _Filarticulo_vendi;
        private string _Filreferencia;
        private bool _Filcomision;

        public ClientesFil () { }

        public ClientesFil(string Filnombre_clie, int Filtelefono, string Filcorreo, int Filidentificacion, string Filarticulo_vendi,
        string Filreferencia, bool Filcomision)
        {
            this.Filnombre_clie = Filnombre_clie;
            this.Filtelefono = Filtelefono;
            this.Filcorreo = Filcorreo;
            this.Filidentificacion = Filidentificacion;
            this.Filarticulo_vendi = Filarticulo_vendi;
            this.Filreferencia = Filreferencia;
            this.Filcomision = Filcomision;
        }

        public string Filnombre_clie { get; set; }

        public int Filtelefono { get; set; }

        public string Filcorreo { get; set; }

        public int Filidentificacion { get; set; }

        public string Filarticulo_vendi { get; set; }

        public string Filreferencia { get; set; }

        public bool Filcomision { get; set; }

    }
}
