using static ActividadN2.Program;
using static ActividadN2.Program.Biblioteca;

namespace ActividadN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // valores a los atributos del ejerccio 1 al 2 
            Vehiculo ve = new Vehiculo();
            ve.Modelo = "General";
            ve.Marca = "MarcaGenérica";
            ve.NumeroDeSerie = "0000";


            ve.Arrancar();
            ve.Acelerar();
            ve.Frenar();
            ve.Detener();


            Autobus au = new Autobus();
            au.Modelo = "Mercedes chu";
                au.Marca = "Mercedes-Benz";
               au.Año = 2090;
               au.NumeroDeSerie = "1234567890";
               au.CapacidadDePasajeros = 78;
              au.NumeroDePuertas = 2;
                au.NumeroDeAsientos = 68;
            
            au.CargarPasajeros(19);
            au.DescargarPasajeros(70);
            // fin 1y2



            //valores de los atributos de los ejercicios 3 al 5 
            Animal an = new Animal();
            an.Especie = "hiena";
            an.edad = 4;
            an.genero = "Hembra";

            an.Alimentar();
            an.Reproducir();
            an.HacerRuidosCaracteristicos();

            Perro p = new Perro();
            p.Raza = "golden";
            p.Peso = 27;
            p.NivelDeInteligencia = 10;

            p.Correr();
            p.Ladrar();

            Mono m = new Mono();
            m.CantPatas = 2;
            m.CantDedos = 5;
            m.TipoDeMono = "chimpance";

            m.Trepar();
            m.Saltar();
            Libro libro1 = new Libro();
            libro1.Titulo = "Cien Años ";
            libro1.Autor = "Gabriel García";
            libro1.AnioPublicacion = 1967;
            libro1.Genero = "terrr";

            Libro libro2 = new Libro();
            libro2.Titulo = "El Principito";
            libro2.Autor = "susana cordon";
            libro2.AnioPublicacion = 1943;
            libro2.Genero = "Ficción";

            Biblioteca bi = new Biblioteca();
            bi.Nombre = "Biblioteca uyui";
            bi.Ubicacion = "Buenos Aires";
            bi.HorarioApertura = "09:00 am - 10:00 pm";

           
            bi.AgregarLibro(libro1);
            bi.AgregarLibro(libro2);
            bi.BuscarLibro("Principito");
            bi.PrestarLibro("El Principito");
            bi.BuscarLibro("El Principito");
            bi.DevolverLibro(libro2);
            bi.BuscarLibro("El Principito");




            CajeroAutomatico ca = new CajeroAutomatico();
            ca.Ubicacion = "Centro Comercial";
            ca.NumeroDeSerie = "1234P";
            ca.SaldoDisponible = 5000;

            ca.ConsultarSaldo();
            ca.DepositarDinero(1000); 
            ca.ConsultarSaldo();
            ca.RetirarDinero(6000);     
            ca.RetirarDinero(2000);      
            ca.ConsultarSaldo();


            //  sistema de gestión de empleados NO ENTENDI SE QUE TIENE QUE HACER 
            //NO SE PLANTEARLO EN CODIGO 

        }
        // aca empieza las clases del ejercicio 1 al 2 
        public class Vehiculo
        {
            public string Modelo;
            public string Marca;
            public int Año;
            public string NumeroDeSerie;


            public void Arrancar()
            {
                Console.WriteLine("el vehiculo de modelo"+ this.Modelo+ " ha arrancado");
            }
            public void Acelerar()
            {
                Console.WriteLine("el vehiculo con numero de serie"+this.NumeroDeSerie+ "esta acelerando");
            }
            public void Frenar()
            {
                Console.WriteLine("el vehiculo a frenado de marca"+ this.Marca);
            }
            public void Detener()
            {
                Console.WriteLine("el vehiculo se a detenido");
            }

        }
        public class Autobus : Vehiculo
        {
            public int CapacidadDePasajeros;
            public int NumeroDePuertas;
            public int NumeroDeAsientos;


            public void CargarPasajeros(int cant)
            {
                Console.WriteLine("el autobus esta cargando en total una cantidad de pasajeros" + cant);
            }
            public void DescargarPasajeros(int canb)
            {
                Console.WriteLine(canb + "han bajado del autobus");

            }


        }
        public class Auto : Vehiculo
        {
            public int CantidadDePuertas;

        }
        public class Moto : Vehiculo
        {
            public int CantidadDeRuedas;

        }
        public class Camion  : Vehiculo
        {
            public double CapacidadDeCarga;

        }
        // aca termino del ejercicio 1 al 2 
         



        //Aca empieza del ejercicio 3 al 5 

        public  class Animal
        {
            public string Especie;
            public int edad;
            public string genero;


            public void Alimentar()
            {
                Console.WriteLine("alimentar a"+  this.Especie +"que tiene" +this.edad+ "años");
            }
            public void Reproducir()
            {
                Console.WriteLine("reproducir entre las especies" +Especie+"" );
            }
            public void HacerRuidosCaracteristicos()
            {
                Console.WriteLine("los animales de la especie" + Especie+ "y de genero" + genero + "hacen ruidos como risas");
            }

        }
        public class Perro : Animal
        {
            public string Raza;
            public int Peso;
            public int NivelDeInteligencia;


            public void Correr()
            {
                Console.WriteLine("El perro de raza" +this.Raza+  "está corriendo alegremente por el parque.");
            }
            public void Ladrar()
            {
                Console.WriteLine("El perro ladra:cuando se siente en peligro");
            }
        }
        public class Mono: Animal
        {
            public int CantPatas;
            public int CantDedos;
            public string TipoDeMono;

            public void Trepar()
            {
                Console.WriteLine("El mono trepa rápidamente por los árboles por la cantidad de dedos." + this.CantDedos);
            }
            public void Saltar()
            {
                Console.WriteLine("El mono salta ágilmente de rama en rama por la cantidad de patas." + this.CantPatas);
            }
        }
        public class Libro
        {
            public string Titulo;
            public string Autor;
            public int AnioPublicacion;
            public string Genero;

            public void Abrir()
            {
                Console.WriteLine("abriendo el libro: " + this.Titulo + "del autor" +this.Autor);
            }

            public void Cerrar()
            {
                Console.WriteLine("Cerrando el libro: " + this.Titulo);
            }

            public void Leer()
            {
                Console.WriteLine("Leyendo el libro: " + this.Titulo + " de " + this.Autor);
            }
        }
        public class Biblioteca
        {
            public string Nombre;
            public string Ubicacion;
            public string HorarioApertura;

            // no vimos arrays en clases asi que es lo que me salio 
            public Libro Libro1;
            public Libro Libro2;
            public Libro Libro3;

          
            public void AgregarLibro(Libro libro)
            {
                if (Libro1 == null)
                {
                    Libro1 = libro;
                    Console.WriteLine("El libro '" + libro.Titulo + "' se ha agregado en la posición 1.");
                }
                else if (Libro2 == null)
                {
                    Libro2 = libro;
                    Console.WriteLine("El libro '" + libro.Titulo + "' se ha agregado en la posición 2.");
                }
                else if (Libro3 == null)
                {
                    Libro3 = libro;
                    Console.WriteLine("El libro '" + libro.Titulo + "' se ha agregado en la posición 3.");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar el libro, el inventario está lleno.");
                }
            }

           
            public void PrestarLibro(string titulo)
            {
                if (Libro1 != null ) 
                {
                    Console.WriteLine("El libro '" + Libro1.Titulo + "' ha sido prestado.");
                    Libro1 = null;
                    return;
                }
                if (Libro2 != null ) 
                {
                    Console.WriteLine("El libro '" + Libro2.Titulo + "' ha sido prestado.");
                    Libro2 = null;
                    return;
                }
                if (Libro3 != null ) 
                {
                    Console.WriteLine("El libro '" + Libro3.Titulo + "' ha sido prestado.");
                    Libro3 = null;
                    return;
                }
                Console.WriteLine("El libro '" + titulo + "' no se encuentra en el inventario.");
            }

         
            public void DevolverLibro(Libro libro)
            {
                if (Libro1 == null)
                {
                    Libro1 = libro;
                    Console.WriteLine("El libro '" + libro.Titulo + "' ha sido devuelto en la posición 1.");
                }
                else if (Libro2 == null)
                {
                    Libro2 = libro;
                    Console.WriteLine("El libro '" + libro.Titulo + "' ha sido devuelto en la posición 2.");
                }
                else if (Libro3 == null)
                {
                    Libro3 = libro;
                    Console.WriteLine("El libro '" + libro.Titulo + "' ha sido devuelto en la posición 3.");
                }
                else
                {
                    Console.WriteLine("No se pudo devolver el libro, el inventario está lleno.");
                }
            }

         
            public void BuscarLibro(string busqueda)
            {
                bool encontrado = false;
                if (Libro1 != null )
                {
                    Console.WriteLine("Libro encontrado: " + Libro1.Titulo + " por " + Libro1.Autor);
                    encontrado = true;
                }
                if (Libro2 != null) 
                {
                    Console.WriteLine("Libro encontrado: " + Libro2.Titulo + " por " + Libro2.Autor);
                    encontrado = true;
                }
                if (Libro3 != null)
                {
                    Console.WriteLine("Libro encontrado: " + Libro3.Titulo + " por " + Libro3.Autor);
                    encontrado = true;
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encontró ningún libro relacionado con: " + busqueda);
                }
            }
            public class CajeroAutomatico
            {
                public string Ubicacion;
                public string NumeroDeSerie;
                public double SaldoDisponible;

                public void RetirarDinero(double monto)
                {
                    if (monto > SaldoDisponible)
                    {
                        Console.WriteLine("No hay fondos suficientes para retirar $" + monto + ".");
                    }
                    else
                    {
                        SaldoDisponible -= monto;
                        Console.WriteLine("Se han retirado $" + monto + ". Saldo actual: $" + SaldoDisponible);
                    }
                }

                public void DepositarDinero(double monto)
                {
                    SaldoDisponible += monto;
                    Console.WriteLine("Se han depositado $" + monto + ". Saldo actual: $" + SaldoDisponible);
                }

                public void ConsultarSaldo()
                {
                    Console.WriteLine("Saldo Disponible: $" + SaldoDisponible);
                }
            }

            
            public class Empleado
            {
                public int Id;
                public string Nombre;
                public string Apellido;
                public double SalarioBase;
              

                public double CalcularSalario()
                {
                   
                    return SalarioBase;
                }
            }

            public class Rol
            {
                public string Nombre;
                public string Descripcion;
            }

            public class Departamento
            {
                public string Nombre;
                public string Ubicacion;
                

               
            }

            public class GestionEmpleados
            {
                

                public void AgregarEmpleado(Empleado empleado)
                {
                    Console.WriteLine("Empleado " + empleado.Nombre + " agregado.");
                }

               

                public double CalcularSalarioTotal()
                {
                    double total = 0;
                   
                    
                    return total;
                }
            }
        }
    }
    }














  

