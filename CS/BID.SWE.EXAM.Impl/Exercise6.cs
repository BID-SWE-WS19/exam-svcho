﻿using System;
using System.Data.SqlClient;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO @Table VALUES (@Id, @Tag, @Monat, @Jahr, @Stunde, @Minute, @Name)");

            cmd.Parameters.AddWithValue("@Table", "TestAbgabe");
            cmd.Parameters.AddWithValue("@Id", "99");
            cmd.Parameters.AddWithValue("@Tag", "12");
            cmd.Parameters.AddWithValue("@Monat", "12");
            cmd.Parameters.AddWithValue("@Jahr", "2019");
            cmd.Parameters.AddWithValue("@Stunde", "17");
            cmd.Parameters.AddWithValue("@Minute", "00");
            cmd.Parameters.AddWithValue("@Name", "Jacob");

            return cmd;
        }
    }
}