using static ActividadN2.Program;

namespace ActividadN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autobus au = new Autobus
            {
                Modelo = "Mercedes Sprinter", 
                Marca = "Mercedes-Benz",     
                Año = 2022,                  
                NumeroDeSerie = "1234567890",
                CapacidadDePasajeros = 50,  
                NumeroDePuertas = 2,         
                NumeroDeAsientos = 45        
            };

            au.Arrancar();
            au.CargarPasajeros(30);
            au.Acelerar();
            au.Frenar();
            au.DescargarPasajeros(15);
            au.Detener();
        }
        // aca empieza del ejercicio 1 al 2 
        public class Vehiculo
        {
            public string Modelo;
            public string Marca;
            public int Año;
            public string NumeroDeSerie;


            public void Arrancar()
            {
                Console.WriteLine("el vehiculo de modelo"+ this.Modelo+ " a arrancado");
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









    }
}
