﻿using DataAccess.Abstract;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.Concrete.NpgSql
{
    public class NSRepositoryBase : IEntityRepository
    {
        NpgsqlConnection npgsql= new NpgsqlConnection(@"Server=chunee.db.elephantsql.com;Port=5432;User Id=lnimvljt;Password=YXkBhzMdvSpezCyfWKKcZyqOhKWy7-Iz;Database=lnimvljt");
        public void Add(string query)
        {
           
            NpgsqlCommand cmd = new NpgsqlCommand(query, npgsql);
            npgsql.Open();

           int x= cmd.ExecuteNonQuery();

            npgsql.Close();
        }

        public void Delete(string query)
        {

            npgsql.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, npgsql);
            npgsqlCommand.ExecuteNonQuery();
            npgsql.Close();
        }

        public DataSet List(string query)
        {
            npgsql.Open();

            DataSet dataSet = new DataSet();

            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(query, npgsql);
            npgsqlDataAdapter.Fill(dataSet);

            npgsql.Close();
            return dataSet;
        }

        public void Update(string query)
        {
            npgsql.Open();
            NpgsqlCommand npgsqlCommandUpdt = new NpgsqlCommand(query, npgsql);
            npgsqlCommandUpdt.ExecuteNonQuery();
            npgsql.Close();
        }
    }
}
