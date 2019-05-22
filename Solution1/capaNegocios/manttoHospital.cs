using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class manttoHospital
    {
        bdConex test = new bdConex();

        int idHospital, numCama;
        String nombreHospital, direccion, telefono;
        public DataTable dt = new DataTable();

        //GET y SET
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String NombreHospital
        {
            get { return nombreHospital; }
            set { nombreHospital = value; }
        }

        public int NumCama
        {
            get { return numCama; }
            set { numCama = value; }
        }

        public int IdHospital
        {
            get { return idHospital; }
            set { idHospital = value; }
        }

        //METODOS
        public void insertarHospital()
        {
            try
            {
                String insert = "insert into hospital.Hospital(Hospital_Cod, Nombre, Direccion, Telefono, Num_Cama) values(" + idHospital + ", '" + nombreHospital + "', '"+ direccion + "', '"+ telefono +"'," +numCama+");";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void deleteHospital()
        {
            try
            {
                String delete = "delete from hospital.Hospital where Hospital_Cod = " + idHospital + "";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void updateHospital()
        {
            try
            {
                String update = "update hospital.Hospital set Nombre='" + nombreHospital + "', Direccion='" + direccion + "', Telefono='" + telefono + "', Num_Cama=" + numCama + " where Hospital_Cod=" + idHospital + "";

                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }
        }

        ////////////////

        //public void consultar()
        //{
        //    try
        //    {
        //        String select = "select '" + codigoVendor + "' '" + nombreVendor + "' from VENDEDOR where VENDEDOR = '" + codigoVendor + "'";
        //        test.Conectar();
        //        test.consultaSQL(select);
        //        test.Desconectar();
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}

        //////////////////


        //public void mostrarVendor()
        //{
        //    try
        //    {
        //        String consulta = "select * from VENDEDOR";
        //        test.Conectar();
        //        test.mostrarSQL(consulta);
        //        test.da.Fill(dt);
        //        test.Desconectar();
        //    }
        //    catch
        //    {
        //    }
        //}
    }
}
