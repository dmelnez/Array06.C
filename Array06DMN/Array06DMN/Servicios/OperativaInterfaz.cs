using Array06DMN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de preguntar al usuario los campos necesarios para comepletar los atributos
        /// Que compondran a un nuevo cliente
        /// DMN - 19/12/2023
        /// </summary>
        public void clienteAlta(List<ClienteDtos> listaAntigua);

        public void ordenarClientes(List<ClienteDtos> listaAntigua);


    }
}
