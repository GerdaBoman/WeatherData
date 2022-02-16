﻿using LumenWorks.Framework.IO.Csv;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ImportData
    {
        private void ImportFine(string connection)
        {
            var linenumber = 0;

            var csvTable = new DataTable();


            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(connection)), true))
            {
                csvTable.Load(csvReader);
            }


            using (SqlConnection importtest = new SqlConnection(@"data source=(localdb)\mssqllocaldb;initial catalog=robogender;integrated security=true"))
            {
                importtest.Open();

                //Fix the path so that its a connection.Text

                using (StreamReader reader = new StreamReader(connection))
                {
                    while (csvTable.Rows.Count >= linenumber + 1)
                    {
                        var line = reader.ReadLine();

                        if (linenumber != 0)
                        {
                            var values = line.Split(',');

                            values[0] = csvTable.Rows[linenumber][0].ToString();
                            values[1] = csvTable.Rows[linenumber][1].ToString();
                            values[2] = csvTable.Rows[linenumber][2].ToString();
                            values[3] = csvTable.Rows[linenumber][3].ToString();

                           // string temp = GetNumbers(values[2]);

                            var sql = "insert into robogender.dbo.weather values(" +
                                "cast('" + values[0] + "' as smalldatetime)" + ",'" + values[1] + "'," + values[2] + "," + values[3] + ")";

                            var cmd = new SqlCommand();
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = importtest;
                            cmd.ExecuteNonQuery();

                        }
                        linenumber++;


                    }
                }
                importtest.Close();


            }
        }

    }
}
