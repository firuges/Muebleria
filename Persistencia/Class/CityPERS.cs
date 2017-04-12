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
    public class CityPERS : Persistencia
    {
        public static bool Add(int pDepartId, CityCOMMON pCity)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Insert_City", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Departament_Id", pDepartId));
                cmd.Parameters.Add(new SqlParameter("@Name", pCity.Name));

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
        public static List<CityCOMMON> SearchAllofDepartment(int pDepartment_Id)
        {
            List<CityCOMMON> retorno = new List<CityCOMMON>();
            CityCOMMON City;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Select_All_City_Of_Department", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Department_Id", pDepartment_Id));
                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        City = new CityCOMMON();
                        City.Id = short.Parse(oReader["City_Id"].ToString());
                        City.Name = oReader["City_Name"].ToString();
                        retorno.Add(City);

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


        public static bool Delete(CityCOMMON pCity)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Delete_City", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@City_Id", pCity.Id));

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


        public static CityCOMMON SearchCity(CityCOMMON pCity)
        {
            CityCOMMON City = null;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Select_City", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@City_Id", pCity.Id));

                // ejecutamos el store desde c#
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        City = new CityCOMMON();
                        City.Id = short.Parse(oReader["City_Id"].ToString());
                        City.Name = oReader["City_Name"].ToString();
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return City;
        }


        public static bool Update(CityCOMMON pCity)
        {
            bool retorno = true;

            try
            {
                var conn = new SqlConnection(CadenaDeConexion);
                conn.Open();

                // 1. identificamos el store procedure a ejecutar
                SqlCommand cmd = new SqlCommand("Update_City", conn);

                // 2. identificamos el tipo de ejecución, en este caso un SP
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. en caso de que los lleve se ponen los parametros del SP
                cmd.Parameters.Add(new SqlParameter("@Id", pCity.Id));
                cmd.Parameters.Add(new SqlParameter("@Name", pCity.Name));
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
