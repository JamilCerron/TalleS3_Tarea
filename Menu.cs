using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerS3_Tarea
{
    internal class Menu
    {
        Inventario nuevoInventario= new Inventario();
        int valor;
        bool repetirMenuPrincipal = true, repetirMenuCrearArma = true, repetirMenuInventario = true;
        public void EjecutarMenuPrincipal()
        {
            Console.WriteLine("Bienvenido al Menu de Creacion de Armas");

            while (repetirMenuPrincipal)
            {
                repetirMenuPrincipal = true; repetirMenuCrearArma = true; repetirMenuInventario = true;
                Console.WriteLine("Porfavor,escoja una de las siguientes opciones disponibles");

                Console.WriteLine("1.Crear arma");
                Console.WriteLine("2.Inventario de armas");
                Console.WriteLine("3.Salir del programa");
                string entradaMenuP= Console.ReadLine();

                if(int.TryParse(entradaMenuP,out valor) && valor<=3)
                {
                    switch(valor)
                    {
                        case 1: EjecutarMenuCrearArma();break;
                        case 2:EjecutarMenuInventario();break;
                        case 3:
                                 repetirMenuPrincipal=false;
                                 Console.WriteLine("Presione cualquier tecla para salir...");
                                 Console.ReadKey();
                                 break;
                    }
                }
                else MensajeDeOpcionInvalida2();
            }

        }

        void EjecutarMenuCrearArma()
        {
            while (repetirMenuCrearArma)
            {
                Console.WriteLine("Seleccione el tipo de arma");
                Console.WriteLine("1.Espada");
                Console.WriteLine("2.Pistola");
                Console.WriteLine("3.Arco");

               string OpcionDelArma= Console.ReadLine();

                if (int.TryParse(OpcionDelArma, out valor) && valor <= 3)
                {
                    Console.WriteLine("¿Que nombre deseas ponerle?");
                    string parametro1 = Console.ReadLine();

                    Console.WriteLine("¿Cuanto daño hara?");
                    string daño = Console.ReadLine();

                    if (float.TryParse(daño, out float parametro2))
                    {
                        Console.WriteLine("¿Cual sera su velocidad de ataque por segundo?");
                        string velocidadDeAtaque = Console.ReadLine();

                        if (float.TryParse(velocidadDeAtaque, out float parametro3))
                        {
                            Console.WriteLine("¿Que precio le pondras?");
                            string precio = Console.ReadLine();
                            
                            if (float.TryParse(precio, out float parametro4))
                            {
                                if(valor == 1)
                                {
                                    Arma nuevaEspada = new Espada(parametro1, parametro2, parametro3, parametro4);
                                }
                                else if(valor == 2)
                                {
                                    Arma nuevaPistola = new Pistola(parametro1, parametro2, parametro3, parametro4);
                                }

                                else if(valor == 3)
                                {
                                    Arma nuevoArco = new Arco(parametro1, parametro2, parametro3, parametro4);
                                    
                                    Console.WriteLine("Nota importante: usted ha creado un arma tipo arco");
                                    Console.WriteLine("Añada a continuación el daño que hara el proyectil, cuyo valor se sumara al daño total del arma");
                                    string lecturaDañoProyectil = Console.ReadLine();

                                    if (float.TryParse(lecturaDañoProyectil, out float dañoProyectil))
                                    {
                                        Proyectil nuevoProyectil= new Proyectil(dañoProyectil);
                                    }
                                    else MensajeDeOpcionInvalida1();
                                }

                                Console.WriteLine("Arma creada satisfactoriamente");
                                repetirMenuCrearArma = false;

                            }
                            else MensajeDeOpcionInvalida1();

                        }
                        else MensajeDeOpcionInvalida1();

                    }
                    else MensajeDeOpcionInvalida1();

                }
                else MensajeDeOpcionInvalida1();
     
            }            

        }

        void EjecutarMenuInventario()
        {
            Console.WriteLine("Bienvenido al menu inventario");
            Console.WriteLine("Porfavor,escoja una de las siguientes opciones disponibles");

            Console.WriteLine("1.Revisar la lista del inventario");
            Console.WriteLine("2.Eliminar armas de la lista del inventario");

            string entradaMenuInventario = Console.ReadLine();

            if(int.TryParse(entradaMenuInventario, out valor))
            {
                if (valor == 1)
                {
                    Console.WriteLine("Armas");
                    Console.WriteLine(nuevoInventario.listaDeArmas);
                    Console.WriteLine("Proyectiles");
                    Console.WriteLine(nuevoInventario.listaDeProyectiles);
                }
            }



        }

        void MensajeDeOpcionInvalida1()
        {
            Console.WriteLine("Lectura invalida.Porfavor ,vuelva a digitar los valores correspondientes");
        }

        void MensajeDeOpcionInvalida2()
        {
            Console.WriteLine("Opción invalida. Porfavor vuelva a marcar una de las opciones");
        }

    }
}
