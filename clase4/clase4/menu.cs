using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4
{
    internal class menu
    {
        public static void principal()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1.Inicializar arreglos");
                Console.WriteLine("2.Ingresar articulos");
                Console.WriteLine("3.Modificar Articulos");
                Console.WriteLine("4.Borrar articulos");
                Console.WriteLine("5.Consultar articulos");
                Console.WriteLine("6.Buscar articulo por codigo");
                Console.WriteLine("7.Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine()); 
                switch (opcion)
                {
                    case 1:Articulos.InicializarArreglos(); break;
                    case 2:Articulos.IngresarProductos(); break;
                    case 3:Articulos.ModificarProdructos(); break;
                    case 4:Articulos.ExcluirProductos(); break;
                    case 5:Articulos.ConsultarProdructos(); break;
                    case 6:Articulos.BuscarArticulo(); break;
                    case 7: break;  

                    default: Console.WriteLine("***Opcion incorrecta***"); break;
                }

            } while (opcion!=7);
        }
    }
}
