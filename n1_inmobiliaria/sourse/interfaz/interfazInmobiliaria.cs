using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using n1_inmobiliaria.sourse.mundo;



namespace n1_inmobiliaria.sourse.interfaz
{
    public partial class interfazInmobiliaria : Form
    {
        Inmobiliaria unaInmobiliaria;  
        public interfazInmobiliaria()
        {
            InitializeComponent();
            inicializador();
        }

        //metodo para inicializar la instancia y los metodos creados para esta clase 

        public void inicializador()
        {
            unaInmobiliaria = new Inmobiliaria();
            unaInmobiliaria.inicializar();
            asignarnarCostosm1();
            asignarnarCostosm2();
            asignarnarCostosm3();
            asignarCostoAdministracion();
            asignarCostoPromedioServicios();


        }
        //metodo para asignar los costos a la mancion 1
        public void asignarnarCostosm1()
        {
            Mansion msn1 = unaInmobiliaria.darMancion1();
            txtcostolimpiezam1.Text = msn1.calcularCostoLimpieza().ToString();
            txtcostoserviciosm1.Text = msn1.calcularCostoServicios().ToString();
            txtcostoseguridadm1.Text = msn1.calcularCostoSeguridad().ToString();
         
        }

        //metodo para asignar los costos a la mancion 2
        public void asignarnarCostosm2()
        {
            Mansion msn2 = unaInmobiliaria.darMancion2();
            txtcostolimpiezam2.Text = msn2.calcularCostoLimpieza().ToString();
            txtcostoserviciosm2.Text = msn2.calcularCostoServicios().ToString();
            txtcostoseguridadm2.Text = msn2.calcularCostoSeguridad().ToString();

        }

        //metodo para asignar los costos a la mancion 3
        public void asignarnarCostosm3()
        {
            Mansion msn3 = unaInmobiliaria.darMancion3();
            txtcostolimpiezam3.Text = msn3.calcularCostoLimpieza().ToString();
            txtcostoserviciosm3.Text = msn3.calcularCostoServicios().ToString();
            txtcostoseguridadm3.Text = msn3.calcularCostoSeguridad().ToString();

        }
        //metodo para asignar el costo administracion 
        public void asignarCostoAdministracion()
        {
            
          txtcostoAdm.Text= unaInmobiliaria.calcularCostoAdministrativo().ToString();
        
        }
        //metodo para asignar el costo promedio servicios 
        public void asignarCostoPromedioServicios()
        {
            txtcostoPromServi.Text = unaInmobiliaria.calcularCostoPromedioServicios().ToString();
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btnActualiM1_Click(object sender, EventArgs e)
        {
            Form1 agregaedatosiniciales = new Form1();
            agregaedatosiniciales.ShowDialog();
            unaInmobiliaria.actualizarDatosMancion1(int.Parse(agregaedatosiniciales.txthabitantes.Text), int.Parse(agregaedatosiniciales.txtparqueaderos.Text),
                int.Parse(agregaedatosiniciales.txtempleados.Text), int.Parse(agregaedatosiniciales.txtprecio.Text), int.Parse(agregaedatosiniciales.txttamanio.Text));
            asignarnarCostosm1();
            asignarCostoAdministracion();
            asignarCostoPromedioServicios();

        }

        private void btnActualiM2_Click(object sender, EventArgs e)
        {
            Form1 agregaedatosiniciales = new Form1();
            agregaedatosiniciales.ShowDialog();

            unaInmobiliaria.actualizarDatosMancion2(int.Parse(agregaedatosiniciales.txthabitantes.Text), int.Parse(agregaedatosiniciales.txtparqueaderos.Text),
               int.Parse(agregaedatosiniciales.txtempleados.Text), int.Parse(agregaedatosiniciales.txtprecio.Text), int.Parse(agregaedatosiniciales.txttamanio.Text));
            asignarnarCostosm2();
            asignarCostoAdministracion();
            asignarCostoPromedioServicios();

        }

        

        private void btnActualiM3_Click(object sender, EventArgs e)
        {
            Form1 agregaedatosiniciales = new Form1();
            agregaedatosiniciales.ShowDialog();

            unaInmobiliaria.actualizarDatosMancion3(int.Parse(agregaedatosiniciales.txthabitantes.Text), int.Parse(agregaedatosiniciales.txtparqueaderos.Text),
               int.Parse(agregaedatosiniciales.txtempleados.Text), int.Parse(agregaedatosiniciales.txtprecio.Text), int.Parse(agregaedatosiniciales.txttamanio.Text));
            asignarnarCostosm3();
            asignarCostoAdministracion();
            asignarCostoPromedioServicios();
        }
    }
}
