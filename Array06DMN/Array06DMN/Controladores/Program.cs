
using Array06DMN.Dtos;
using Array06DMN.Servicios;

namespace Array06DMN.Controladores;


class Program
{


    static void Main(string[] args)
    {

        List<ClienteDtos> listaClientes = new List<ClienteDtos>();

        MenuInterfaz me = new MenuImplementacion();
        

        OperativaInterfaz op = new OperativaImplementacion();

       
        bool cerrarMenu = false;

        while (!cerrarMenu)
        {
            int valorIntro = me.menuPrincipal();

            switch (valorIntro)
            {

                case 0:
                    Console.WriteLine("[INFO] - Cerrar Aplicacion");
                    cerrarMenu |= true;
                    break;

                case 1:
                    Console.WriteLine("[INFO] - Dar Alta Cliente");
                    op.clienteAlta(listaClientes);
                    break;

                case 2:
                    Console.WriteLine("[INFO] - Ordenar Lista Clientes");
                    op.ordenarClientes(listaClientes);

                    /*
                    foreach (ClienteDtos cliente in listaClientes)
                    {

                        Console.WriteLine(cliente);


                    }

                    */
                    break;

                default:
                    Console.WriteLine("[ATENCION] - Seleccion no Valida");
                    break;



            }



        }






    }

    private static void MenuInterfaz()
    {
        throw new NotImplementedException();
    }
}