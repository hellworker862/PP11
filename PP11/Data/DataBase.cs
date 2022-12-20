﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PP11
{
    public class DataBase
    {
        private const string _stringConnection = @"Data Source=MyPC;Initial Catalog=PracDB;Integrated Security=True;TrustServerCertificate=true;MultipleActiveResultSets=True";
        private SqlDataAdapter _adapter;

        public DataBase()
        {
            _adapter = new SqlDataAdapter();
        }

        private SqlConnection openConnection()
        {
            var connect = new SqlConnection(_stringConnection);
            connect.Open();

            return connect;
        }

        public async Task<DataTable> SelectQuery(string query, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = null;
            DataSet ds = new DataSet();
            SqlConnection connection = openConnection();

            try
            {
                cmd.Connection = connection;
                cmd.CommandText = query;
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                await cmd.ExecuteNonQueryAsync();
                _adapter.SelectCommand = cmd;
                _adapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            connection.Close();
            return dt;
        }

        public async Task<bool> InsertQuery(string query, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connection = openConnection();

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                _adapter.InsertCommand = cmd;
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            connection.Close();
            return true;
        }

        public async Task<bool> UpdateQuery(string query, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connection = openConnection();

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                _adapter.UpdateCommand = cmd;
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            connection.Close();
            return true;
        }

        public async Task<bool> DeleteQuery(string query, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connection = openConnection();

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                _adapter.DeleteCommand = cmd;
                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
            connection.Close();
            return true;
        }
    }
}
