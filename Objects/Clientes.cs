using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Clientes
    {
        private string _nombre_clie;
        private int _telefono;
        private string _correo;
        private int _identificacion;
        private string _articulo_vendi;
        private string _referencia;
        private bool _comision;

        public Clientes() { }

        public Clientes(string nombre_clie, int telefono, string correo, int identificacion, string articulo_vendi,
        string referencia, bool comision)
        {
            this.nombre_clie = nombre_clie;
            this.telefono = telefono;
            this.correo = correo;
            this.identificacion = identificacion;
            this.articulo_vendi = articulo_vendi;
            this.referencia = referencia;
            this.comision = comision;
        }

        public string nombre_clie
        {
            get
            {
                return _nombre_clie;
            }
            set
            {
                _nombre_clie = value;
            }
        }

        public int telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        public string correo
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
            }
        }

        public int identificacion
        {
            get
            {
                return _identificacion;
            }
            set
            {
                _identificacion = value;
            }
        }

        public string articulo_vendi
        {
            get
            {
                return _articulo_vendi;
            }
            set
            {
                _articulo_vendi = value;
            }
        }

        public string referencia
        {
            get
            {
                return _referencia;
            }
            set
            {
                _referencia = value;
            }
        }

        public bool comision
        {
            get
            {
                return _comision;
            }
            set
            {
                _comision = value;
            }
        }
    }
}
