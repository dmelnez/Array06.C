using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Dtos
{
    internal class ClienteDtos
    {

        long idCliente;
        string nombreCliente = "aaaaaa";
        string apellidosCliente = "aaaaaa";
        string nombreCompletoCliente = "aaaaaa";
        int edad = 111111;



        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }



        public ClienteDtos(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.edad = edad;
        }



        public ClienteDtos() { }


        override

        public string ToString()
        {
            /*
            string valorConcat =

                "Nombre Completo: " + this.nombreCompletoCliente +
                "Edad: " + this.edad;

            return valorConcat;
            */


            /*
            string todo =
                this.idCliente +
                this.nombreCliente +
                this.apellidosCliente +
                this.nombreCompletoCliente +
                this.edad;
            */

            string todo =
                this.idCliente +
                this.nombreCliente +
                this.apellidosCliente +
                "Nombre Completo" + this.nombreCliente + this.apellidosCliente +
                this.edad;

            return todo;



        }



    }
}
