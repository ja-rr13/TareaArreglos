using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace clase4
{
    internal class Articulos
    {
        public static int[] id = new int[3];
        public static string[] nombre = new string[3];
        public static int[] cantidad = new int[3];
        public static int[] bodega = new int[3];
        public static void InicializarArreglos()
        {
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                nombre[i] = "";
                
            }
            Console.WriteLine("Los Arreglos han sido inicializados");
        }
        public static void IngresarProductos()
        {
            int indice = 0;
            while (indice < id.Length)
            {
                Console.WriteLine("Digite un codigo");
                id[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite un articulo");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite el numero de bodega donde se almacena");
                bodega[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de articulos en la bodega");
                cantidad[indice] = int.Parse(Console.ReadLine());
                
                indice++;
             
               
                


            }
            Console.WriteLine("Los articulos han sido agregados");
        }
        public static void ModificarProdructos()
        {
            
            Console.WriteLine("Digite el codigo del articulo que desea modificar: ");
            int nuevocodigo=int.Parse(Console.ReadLine());
            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
                    Console.WriteLine("Digite un nuevo codigo");
                    id[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite un nuevo articulo");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite el nuevo numero de bodega donde se almacena");
                    bodega[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la cantidad de articulos en la bodega");
                    cantidad[i] = int.Parse(Console.ReadLine());
                } 
               

            }
          

        }
        public static void ConsultarProdructos()
        {
            Console.Clear();
            Console.WriteLine("****Reporte Articulos****");
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]} N.Bodega: {bodega[i]} Cantidad: {cantidad[i]}");
               
            }
            Console.WriteLine("****Fin Del Reporte****"); 
        }
        public static void ExcluirProductos()
        {
            int br = 0;

            Console.WriteLine("Digite el codigo del articulo que desea borrar");
            br = int.Parse(Console.ReadLine());
            for (int i = 0; i < id.Length; i++)
            {
                if (br == id[i])
                {
                    id[i] = 0;
                    nombre[i] = "";
                    bodega[i] = 0;
                    cantidad[i] = 0;
                    Console.WriteLine("Se borro el articulo");
                    break;
                   

                }
            }
        }
        public static void BuscarArticulo()
        {
            int bs = 0;
            Console.WriteLine("Digite el codigo del articulo que desea buscar");
            bs = int.Parse(Console.ReadLine());
            for (int i = 0; i < id.Length; i++)
            {
              
                if (bs.Equals(id[i]))
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]} Cantidad: {cantidad[i]}");
                    break;


                }
            }

        }


    }
}
