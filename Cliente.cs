using System;
using System.Collections.Generic;
using System.Text;

namespace DPRN3_U2_EA_JHRM
{
    class Cliente
    {
        //Atributos de cada cliente
        private string curp;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string sexo;
        private string persona;
        private string calle;
        private string num_ext;
        private string num_int;
        private int cp;
        private string ciudad;
        private string estado;

        //Constructores se inicializan vacios o en 0
        public Cliente()
        {
            this.curp = "";
            this.nombre = "";
            this.apellido_paterno = "";
            this.apellido_materno = "";
            this.sexo = "";
            this.persona = "";
            this.calle = "";
            this.num_ext = "";
            this.num_int = "";
            this.cp = 0;
            this.ciudad = "";
            this.estado = "";
        }





        //Métodos Get Set para acceder y modificar datos
        public string Curp { get => curp; set => curp = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Persona { get => persona; set => persona = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Num_ext { get => num_ext; set => num_ext = value; }
        public string Num_int { get => num_int; set => num_int = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }


    }
}
