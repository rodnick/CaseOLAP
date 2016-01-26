using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data.SqlClient;

namespace SQL
{
    public enum SqlState { Success = 1, Error = 2, EmptyResult = 3 };
    public static class SqlFunc
    {
        public static string ConnectStringCompService =
        @"Data Source=192.168.56.2; Persist Security Info=True;Password=123456;
          User ID=sa; Initial Catalog=lab3v5;Connection Timeout=5";

        public static string ConnectString = ConnectStringCompService;

        public static string ToSqlDate(DateTime dt)
        {
            string res = string.Empty;
            res = dt.Year.ToString();
            string month = dt.Month.ToString();
            if (month.Length == 1) month = "0" + dt.Month.ToString();
            res += month;
            string day = dt.Day.ToString();
            if (day.Length == 1) day = "0" + dt.Day.ToString();
            res += day;
            return res;
        }


        public static SqlConnection ConnectToServer()
        {
            SqlConnection SQLConn = new SqlConnection(ConnectString);
            try
            {
                SQLConn.Open();
                return SQLConn;
            }
            catch (Exception exp)
            {
                string ErrMsg = "Method: " + exp.TargetSite.Name.ToString() + "\r\nMessage: " + exp.Message + "\r\nSource: " + exp.Source;
                MessageBox.Show(ErrMsg, "ConnectToServer() Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Вывести в ds результат запроса select из command
        /// В случае ошибки вывести код ошибки.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="ds"></param>
        /// <param name="ErrMsg"></param>
        /// <returns></returns>
        public static SqlState SqlViewTable(string Command, ref DataSet ResultDS, ref string ErrMsg)
        {
            SqlDataAdapter sql = new SqlDataAdapter(Command, ConnectString);
            ResultDS = new DataSet();
            try
            {
                int count = sql.Fill(ResultDS);
                sql.Dispose();
                if (count > 0)
                    return SqlState.Success;
                else
                {
                    ErrMsg = "Запрос не вернул ни одну запись.";
                    return SqlState.EmptyResult;
                }
            }
            catch (Exception exp)
            {
                sql.Dispose();
                ErrMsg = "Method: " + exp.TargetSite.Name.ToString() + "\r\nMessage: " + exp.Message + "\r\nSource: " + exp.Source + "\r\nCommand: " + Command;
                MessageBox.Show(ErrMsg, "SqlViewTable() Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return SqlState.Error;
            }
            finally
            {
                sql.Dispose();
            }
        }

        /// <summary>
        /// Для запросов типа Insert, Update, Delete
        /// Возвращает true, если запрос command успешно выполнился и обновил больше 0 записей.
        /// Возвращает false и записывает в ErrMsg сообщение об ошибке иначе.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="ds"></param>
        /// <param name="ErrMsg"></param>
        /// <returns></returns>
        public static SqlState SqlChange(SqlCommand command, ref string ErrMsg)
        {

            SqlCommand sqlCommand = command;
            try
            {
                SqlConnection con = new SqlConnection(ConnectString);
                con.Open();
                sqlCommand.Connection = con;
                //  sqlCommand.Transaction = con.BeginTransaction();
                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    sqlCommand.Dispose();
                    return SqlState.Success;
                }
                else
                {
                    sqlCommand.Dispose();
                    ErrMsg = "Обновлено 0 записей.";
                    return SqlState.EmptyResult;
                }
                //sqlCommand.Transaction.Commit();
            }
            catch (Exception exp)
            {
                //  sqlCommand.Transaction.Rollback();
                sqlCommand.Dispose();
                ErrMsg = "Method: " + exp.TargetSite.Name.ToString() + "\r\nMessage: " + exp.Message + "\r\nSource: " + exp.Source + "\r\nCommand: " + command.CommandText;
                MessageBox.Show(ErrMsg, "SqlChange() Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return SqlState.Error;
            }
            finally
            {
                sqlCommand.Dispose();
            }
        }

        /// <summary>
        /// Используется для получения в переменной Res содержимого поля, которое получается выполнением запроса command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="Res"></param>
        /// <param name="ErrMsg"></param>
        /// <returns></returns>
        /// 
        public static SqlState SqlGetField(string command, ref object Res, ref string ErrMsg)
        {
            SqlDataAdapter sql = new SqlDataAdapter(command, ConnectString);
            try
            {
                DataSet ds = new DataSet();
                sql.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    sql.Dispose();
                    Res = ds.Tables[0].Rows[0][0];
                    return SqlState.Success;
                }
                else
                {
                    sql.Dispose();
                    ErrMsg = "Нужное поле не найдено!";
                    return SqlState.EmptyResult;
                }
            }
            catch (Exception exp)
            {
                sql.Dispose();
                ErrMsg = "Method: " + exp.TargetSite.Name.ToString() + "\r\nMessage " + exp.Message + "\r\nSource " + exp.Source + "\r\nCommand " + command; ;
                MessageBox.Show(ErrMsg, "SqlChange() Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return SqlState.Error;
            }
            finally
            {
                sql.Dispose();
            }
        }
    }
}