using Array06DMN.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array06DMN.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

      public void clienteAlta(List<ClienteDtos> listaAntigua)
        {
            ClienteDtos clienteNuevo = new ClienteDtos();

            Console.WriteLine("ID Cliente: ");
            clienteNuevo.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Nombre: ");
            clienteNuevo.NombreCliente = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            clienteNuevo.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Edad: ");
            clienteNuevo.Edad = Convert.ToInt32(Console.ReadLine());

            listaAntigua.Add(clienteNuevo);
            



        }



        public void ordenarClientes(List<ClienteDtos> listaAntigua)
        {

            foreach (ClienteDtos cliente in listaAntigua)
            {

             Console.WriteLine(cliente);
                

            }


        }

    }
}
