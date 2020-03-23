using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.helpers
{
    class LoginHelper
    {
        /// <summary>
        /// Constructor
        /// </summary>
        LoginHelper()
        {

        }

        public static bool isUsernamePasswordValid(string username, string password)
        {
            bool result = false;

            try
            {
                string sdwConnectionString = Properties.Settings.Default.DBConnectString;
                string commandText = "SELECT u_idUser FROM tbl_users WHERE u_username=@username and u_password=Hashbytes('SHA2_256',@password);";
                SqlConnection conn = new SqlConnection(sdwConnectionString);
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);

                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;

                using (conn)
                using(cmd)
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    result = reader.HasRows;

                    if (result)
                    {
                        reader.Read();
                        object u_idUser = reader.GetValue(0);
                        GlobalSettings.Instance.IdUser= (int) u_idUser;
                        GlobalSettings.Instance.Username= username;
                    }

                    conn.Close();
                }

            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return result;
        }
    }
}
