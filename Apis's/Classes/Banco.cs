using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Apis_s.Classes
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strConn = @"server=127.0.0.1;database=mydb;user id=root;password=usbw;port=3306";
            MySqlConnection cn = new MySqlConnection(strConn);
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                    cmd.Connection = cn;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return cmd;
        }
    }
}