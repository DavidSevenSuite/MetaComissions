using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Data
{
    public class Access
    {
        #region Clientes

        public static DataTable GetClientes(ClientesFil elemento)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(Configuracion.CONEXION_MAIN(ConnectionString.DataSource));
                SqlCommand comando = new SqlCommand("EXEC [MCMS__Clientes_GetInfo] @FilNombreClie, @FilTelefono, @FilCorreo, @FilIdentifiacion, @FilArti_vendi, @FilReferencia, @FilComision", conn);
                SqlParameter param;
                param = comando.Parameters.Add("@FilNombreClie", SqlDbType.NVarChar, 1000);
                param.Value = elemento.Filnombre_clie;
                param = comando.Parameters.Add("@FilTelefono", SqlDbType.Int);
                param.Value = elemento.Filtelefono;
                param = comando.Parameters.Add("@FilCorreo", SqlDbType.NVarChar, 100);
                param.Value = elemento.Filcorreo;
                param = comando.Parameters.Add("@FilIdentifiacion", SqlDbType.Int);
                param.Value = elemento.Filidentificacion;
                param = comando.Parameters.Add("@FilArti_vendi", SqlDbType.NVarChar, 1000);
                param.Value = elemento.Filarticulo_vendi;
                param = comando.Parameters.Add("@FilReferencia", SqlDbType.NVarChar, 1000);
                param.Value = elemento.Filreferencia;
                param = comando.Parameters.Add("@FilComision", SqlDbType.Bit);
                param.Value = elemento.Filcomision;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(dt);

                return dt;
            }
            catch
            {
                throw;
            }
        }

        public static int PutClientes(int id_clie, Clientes elemento, bool vEliminado)
        {
            try
            {
                int Id = -247890;
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(Configuracion.CONEXION_MAIN(ConnectionString.DataSource));
                SqlCommand comando = new SqlCommand("EXEC [MCMS_Clientes_PutInfo] @Id_clie, @NombreClie, @Telefono, @Correo, @Identificacion, @Arti_vendi, @Referencia, @Comision, @vEliminado",conn);
                SqlParameter param;
                param = comando.Parameters.Add("@Id_clie", SqlDbType.Int);
                param.Value = id_clie;
                param = comando.Parameters.Add("@NombreClie", SqlDbType.NVarChar, 1000);
                param.Value = elemento.nombre_clie;
                param = comando.Parameters.Add("@Telefono", SqlDbType.Int);
                param.Value = elemento.telefono;
                param = comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 100);
                param.Value = elemento.correo;
                param = comando.Parameters.Add("@Identificacion", SqlDbType.Int);
                param.Value = elemento.identificacion;
                param = comando.Parameters.Add("@Arti_vendi", SqlDbType.NVarChar, 1000);
                param.Value = elemento.articulo_vendi;
                param = comando.Parameters.Add("@Referencia", SqlDbType.NVarChar, 1000);
                param.Value = elemento.referencia;
                param = comando.Parameters.Add("@Comision", SqlDbType.Bit);
                param.Value = elemento.comision;
                param = comando.Parameters.Add("@vEliminado", SqlDbType.Bit);
                param.Value = vEliminado;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                Id = int.Parse(dt.Rows[0]["Id"].ToString());

                return Id;
            }
            catch
            {
                throw;
            }
        }

        #endregion 
    }
}
