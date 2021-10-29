using System;
using System.Collections.Generic;
using System.Text;

namespace n1_inmobiliaria.sourse.mundo
{
    public class Mansion
    {
        //atributos de la clase mansion 
        private int habitantes;
        private int numParqueaderos;
        private int numEmpleados;
        private int precio;
        private int tamanio;

        //metodo inicializdor 
        public void inicializar()
        {
            habitantes = 0;
            numParqueaderos = 0;
            numEmpleados = 0;
            precio = 0;
            tamanio = 0;
        }

        //metodo para dar el numero de habitantes 
        public int darHabitantes()
        {
            return habitantes;
        }
        //metodo para dar el numero de empleados
        public int darEmpleados()
        {
            return numEmpleados;
        }

        //metodo para dar el numero de parqueaderos
        public int darParqueadero()
        {
            return numParqueaderos;
        }

        //metodo para dar el precio de cada mansion
        public int darPrecio()
        {
            return precio;
        }

        //metodo para dar el tamaño de cada mansion 
        public int darTamanio()
        {
            return tamanio;
        }

        //metodo para modificar el numero de los habitantes 
        public void modificarHabitantes(int pHabitantes)
        {
            habitantes = pHabitantes;
        }

        //metodo para modificar el numero de empleados
        public void modificarNumeroEmpleados(int pNumEmpleados)
        {
            numEmpleados = pNumEmpleados;
        }

        //metodo para modificar el numero de parqueaderos
        public void modificarNumeroParqueaderos(int pNumParqueaderos)
        {
            numEmpleados = pNumParqueaderos;
        }

        //metodo para modificar el precio de las mansiones 
        public void modificarPrecio(int pPrecio)
        {
            precio = pPrecio;
        }

        //metodo para modificar el tamaño de las manciones 
        public void modificarTamanio(int pTamanio)
        {
            tamanio = pTamanio;
        }

        //metodo para calcular el costp de la limpieza de las manciones
        public int calcularCostoLimpieza()
        {
            int total;
            total = (habitantes * 250) + (numEmpleados * 3000) + (tamanio * 500);
            return total;
        }

        //metodo para calcular el costo de los servicios de las manciones 
        public double calcularCostoServicios()
        {
            int total = (habitantes * 5000) + (precio * 2 / 100);
            return total;
        }

        //metodo para calcular el costo de la seguridad de las mansiones 
        public int calcularCostoSeguridad()
        {
            int total = (numParqueaderos * 450) + (tamanio * 500);
            return total;
        }
    }
}
