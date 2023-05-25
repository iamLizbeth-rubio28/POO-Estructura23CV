using Actividad_Majo23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Majo23CV.Services
{
    public class ClienteServices
    {
        //agregar los datos del cliente
        public Cliente Agregar() 
        {
			try
			{
                Cliente cliente = new Cliente();
                Console.WriteLine("Ingresar Nombre:");
                cliente.Nombre = Console.ReadLine();
                Console.WriteLine("Ingresar Telefono:");
                cliente.Telefono = Console.ReadLine();
                Console.WriteLine("Ingresar Correo: ");
                cliente.Correo = Console.ReadLine();
                return cliente;
			}
			catch (Exception ex)
			{
                throw new Exception(ex.Message); 
			}

        }  
        public void Imprimir(Cliente request)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Datos Personales:");
                Console.WriteLine("El Nombre es:" + request.Nombre);
                Console.WriteLine("El Telefono es:" + request.Telefono);
                Console.WriteLine("El Correo es: " + request.Correo);
            }
            catch (Exception ex)
            {

                throw new Exception ( "Sucedio Un Error" + ex.Message);
            }
        }





        public int SumaProducto()
        {
            try
            {
                int Total = 0;
                Console.WriteLine("Inserte 5 numeros de las compras: ");
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Articulo:", i);
                    int numero  = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
          
                
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
