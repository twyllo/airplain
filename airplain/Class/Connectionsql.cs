using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace airplain.Class
{
    internal class Connectionsql
    {
        public static string vStrConneciton = string.Empty;

        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;

        public static string v_server = string.Empty;
        public static string v_port = string.Empty;
        public static string v_username = string.Empty;
        public static string v_password = string.Empty;
        public static string v_dbname = string.Empty;

        public string ReadXml(string Part)
        {

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(Part);

            XmlNode Node;
            Node = xmldoc.DocumentElement;

            foreach (XmlNode n in Node.ChildNodes)
            {
                if (n.Name == "server")
                {
                    v_server = n.InnerText;
                }
                else if (n.Name == "port")
                {
                    v_port = n.InnerText;
                }
                else if (n.Name == "user")
                {
                    v_username = n.InnerText;
                }
                else if (n.Name == "password")
                {
                    v_password = n.InnerText;
                }
                else if (n.Name == "dbname")
                {
                    v_dbname = n.InnerText;
                }


            }

            vStrConneciton = "Server=" + v_server + "; port=" + v_port + " ; user id=" + v_username + "; password=" + v_password + "; database=" + v_dbname + " ;Include Error Detail=true; ";

            return vStrConneciton;

        }

        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConneciton;
            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }
        }

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            connection();
            vCmd = new NpgsqlCommand();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }


        public void ExecuteProc(string proc, List<pgParameter> parameters, out DataTable dt)
        {
            if (parameters == null) parameters = new List<pgParameter>();
            dt = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection())
            {
                try
                {

                    conn.ConnectionString = vStrConneciton;
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    using (NpgsqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted))
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            StringBuilder query = new StringBuilder();
                            query.Append("call ").Append(proc).Append("(");

                            for (int i = 0; i < parameters.Count; i++)
                            {
                                query.Append("@").Append(parameters[i].name).Append(", ");
                                cmd.Parameters.AddWithValue(parameters[i].name, parameters[i].npgqtyp, parameters[i].value == null ? DBNull.Value : parameters[i].value);
                            }

                            query.Append("'out_result');");
                            cmd.CommandText = query.ToString();
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "fetch all in \"out_result\";";
                            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                            {
                                da.Fill(dt);
                            }

                        }
                        tran.Commit();
                    }
                }
                catch { }
            }
        }


    }
}
