using Common.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Class
{
    public class ClientPERS:Persistencia
    {
        public static bool Add(ClientCOMMON pClient)
        {
            bool retorno = true;

            try
            {
                var Conectar = new SqlConnection(CadenaDeConexion);
                Conectar.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Insert_Client", Conectar);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Name", pClient.Name));
                cmd.Parameters.Add(new SqlParameter("@LastName", pClient.LastName));
                cmd.Parameters.Add(new SqlParameter("@Born", pClient.Born));
                cmd.Parameters.Add(new SqlParameter("@Email", pClient.Email));
                cmd.Parameters.Add(new SqlParameter("@Phone", pClient.Phone));
                cmd.Parameters.Add(new SqlParameter("@Ci", pClient.Ci));
                cmd.Parameters.Add(new SqlParameter("@Address", pClient.address));
                cmd.Parameters.Add(new SqlParameter("@City_Id_FK", pClient.City.Id));
                cmd.Parameters.Add(new SqlParameter("@CategoryPeople", pClient.CategoryPeople));
                cmd.Parameters.Add(new SqlParameter("@Password", pClient.Password));
                cmd.Parameters.Add(new SqlParameter("@DateJoin", pClient.DateJoin));
                cmd.Parameters.Add(new SqlParameter("@LastLogin", pClient.LastLogin));
                cmd.Parameters.Add(new SqlParameter("@Type", pClient.ClientTypeStatus));


                // ejecutamos el store desde c#
                int rtn = cmd.ExecuteNonQuery();

                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public static List<ClientCOMMON> SearchAll()
        {
            List <ClientCOMMON> retorno = new List<ClientCOMMON>();
            ClientCOMMON Client;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Select_All_Client", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        Client = new ClientCOMMON();
                        Client.City = new CityCOMMON();
                        Client.Id = short.Parse(oReader["People_Id"].ToString());
                        Client.Name = oReader["People_Name"].ToString();
                        Client.LastName = oReader["People_LastName"].ToString();
                        Client.Born = Convert.ToDateTime(oReader["People_Born"].ToString());
                        Client.Email = oReader["People_Email"].ToString();
                        Client.Phone = oReader["People_Phone"].ToString();
                        Client.Ci = oReader["People_Ci"].ToString();
                        Client.address = oReader["People_Address"].ToString();
                        Client.City.Id = int.Parse(oReader["City_Id_FK"].ToString());
                        Client.CategoryPeople = oReader["People_CategoryDescription"].ToString();
                        Client.Password = oReader["Client_Password"].ToString();
                        Client.DateJoin = Convert.ToDateTime(oReader["Client_DateJoin"].ToString());
                        Client.LastLogin = Convert.ToDateTime(oReader["Client_LastLogin"].ToString());
                        Client.ClientTypeStatus = oReader["Client_Type"].ToString();
                        retorno.Add(Client);
                       
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }


        public static bool Delete(ClientCOMMON pClient)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Delete_Client", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Client_Id", pClient.Id));

                // ejecutamos el store desde c#
                int rtn = cmd.ExecuteNonQuery();

                if (rtn <= 0)
                {
                    retorno = false;
                }
                // si la conexion esta abierta, la cerramos.
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }


        public static ClientCOMMON SearchClient(ClientCOMMON pClient)
        {
            ClientCOMMON Client = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Select_Client", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Client_Id", pClient.Id));

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        Client = new ClientCOMMON();
                        Client.City = new CityCOMMON();
                        Client.Id = short.Parse(oReader["People_Id"].ToString());
                        Client.Name = oReader["People_Name"].ToString();
                        Client.LastName = oReader["People_LastName"].ToString();
                        Client.Born = Convert.ToDateTime(oReader["People_Born"].ToString());
                        Client.Email = oReader["People_Email"].ToString();
                        Client.Phone = oReader["People_Phone"].ToString();
                        Client.Ci = oReader["People_Ci"].ToString();
                        Client.address = oReader["People_Address"].ToString();
                        Client.City.Id = int.Parse(oReader["City_Id_FK"].ToString());
                        Client.CategoryPeople = oReader["People_CategoryDescription"].ToString();
                        Client.Password = oReader["Client_Password"].ToString();
                        Client.DateJoin = Convert.ToDateTime(oReader["Client_DateJoin"].ToString());
                        Client.LastLogin = Convert.ToDateTime(oReader["Client_LastLogin"].ToString());
                        Client.ClientTypeStatus = oReader["Client_Type"].ToString();


                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Client;
        }


        public static bool Modificar(ClientCOMMON pClient)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Update_Client", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Name", pClient.Name));
                cmd.Parameters.Add(new SqlParameter("@LastName", pClient.LastName));
                cmd.Parameters.Add(new SqlParameter("@Born", pClient.Born));
                cmd.Parameters.Add(new SqlParameter("@Email", pClient.Email));
                cmd.Parameters.Add(new SqlParameter("@Phone", pClient.Phone));
                cmd.Parameters.Add(new SqlParameter("@Ci", pClient.Ci));
                cmd.Parameters.Add(new SqlParameter("@Address", pClient.address));
                cmd.Parameters.Add(new SqlParameter("@City_Id", pClient.City.Id));
                cmd.Parameters.Add(new SqlParameter("@CategoryPeople", pClient.CategoryPeople));
                cmd.Parameters.Add(new SqlParameter("@Password", pClient.Password));
                cmd.Parameters.Add(new SqlParameter("@DateJoin", pClient.DateJoin));
                cmd.Parameters.Add(new SqlParameter("@LastLogin", pClient.LastLogin));
                cmd.Parameters.Add(new SqlParameter("@Type", pClient.ClientTypeStatus));
                // ejecutamos el store desde c#
                int rtn = cmd.ExecuteNonQuery();

                if (rtn <= 0)
                {
                    retorno = false;
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
    }
}
