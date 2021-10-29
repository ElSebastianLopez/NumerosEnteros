using System;
using System.Collections.Generic;
using System.Text;

namespace n1_inmobiliaria.sourse.mundo
{
    public class Inmobiliaria
    {
        //atributos de relacion

        private Mansion mansion1;
        private Mansion mansion2;
        private Mansion mansion3;

        //metodo inicializador o constructor
        public void inicializar()
        {
            mansion1 = new Mansion();
            mansion1.inicializar();
            mansion2 = new Mansion();
            mansion2.inicializar();
            mansion3 = new Mansion();
            mansion3.inicializar();

        }

        //metodo para dar la informacion a cada mansion1 
        public Mansion darMancion1()
        {
            return mansion1;
        }
        //metodo para dar la informacion a cada mansion 2
        public Mansion darMancion2()
        {
            return mansion2;
        }
        //metodo para dar la informacion a cada mansion 3
        public Mansion darMancion3()
        {
            return mansion3;
        }
        //metodo para actualizar los datos de la mancion 1 
        public void actualizarDatosMancion1(int habitantes,int numParequeadero,int numEmpleados,int precio,int tamanio)
        {
            mansion1.modificarHabitantes(habitantes);
            mansion1.modificarNumeroParqueaderos(numParequeadero);
            mansion1.modificarNumeroEmpleados(numEmpleados);
            mansion1.modificarPrecio(precio);
            mansion1.modificarTamanio(tamanio);
           
        }
        //metodo para actualizar los datos de la mancion 2
        public void actualizarDatosMancion2(int habitantes, int numParequeadero, int numEmpleados, int precio, int tamanio)
        {
            mansion2.modificarHabitantes(habitantes);
            mansion2.modificarNumeroParqueaderos(numParequeadero);
            mansion2.modificarNumeroEmpleados(numEmpleados);
            mansion2.modificarPrecio(precio);
            mansion2.modificarTamanio(tamanio);

        }
        //metodo para actualizar los datos de la mancion 3
        public void actualizarDatosMancion3(int habitantes, int numParequeadero, int numEmpleados, int precio, int tamanio)
        {
            mansion3.modificarHabitantes(habitantes);
            mansion3.modificarNumeroParqueaderos(numParequeadero);
            mansion3.modificarNumeroEmpleados(numEmpleados);
            mansion3.modificarPrecio(precio);
            mansion3.modificarTamanio(tamanio);

        }
        //metodo para calcular el costo administrativo
        public double calcularCostoAdministrativo()
        {
            double totalSumaLimpieza = mansion1.calcularCostoLimpieza() + mansion2.calcularCostoLimpieza()
                + mansion3.calcularCostoLimpieza();
            double totalPorcentajeLimpieza = (totalSumaLimpieza * 25) / 100;
            double totalSumaSeguridad = mansion1.calcularCostoSeguridad() + mansion2.calcularCostoSeguridad()
                + mansion3.calcularCostoSeguridad();
            double totalPorcentajeSeguridad = (totalSumaSeguridad * 10) / 100;
            double costoAdministrativoTotal = totalPorcentajeLimpieza + totalPorcentajeSeguridad;
            return costoAdministrativoTotal;
        }
        //metodo para calcular el costo promedio de los servicios 
        public double calcularCostoPromedioServicios()
        {
            double total = (mansion1.calcularCostoServicios() + mansion2.calcularCostoServicios() + mansion3.calcularCostoServicios())/3;
            return total;
        }

    }
}
