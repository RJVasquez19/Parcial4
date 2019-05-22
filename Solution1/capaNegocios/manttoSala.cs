using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class manttoSala
    {
        bdConex test = new bdConex();

        int salaCod, codHospital, numCama;

        public int NumCama
        {
            get { return numCama; }
            set { numCama = value; }
        }

        public int CodHospital
        {
            get { return codHospital; }
            set { codHospital = value; }
        }

        public int SalaCod
        {
            get { return salaCod; }
            set { salaCod = value; }
        }
        String nombreSala;

        

        public String NombreSala
        {
            get { return nombreSala; }
            set { nombreSala = value; }
        }
        public DataTable dt = new DataTable();

        //GET y SET
        

        //METODOS
        public void insertarSala()
        {
            try
            {
                String insert = "insert into Sala(Sala_Cod, Hospital_Cod, Nombre, Num_Cama) values(" + salaCod + ", " + codHospital + ", '" + nombreSala + "', " + numCama + ");";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void deleteSala()
        {
            try
            {
                String delete = "delete from Sala where Sala_Cod = " + salaCod + "";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void updateSala()
        {
            try
            {
                String update = "";

                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }
        }
    }
}
