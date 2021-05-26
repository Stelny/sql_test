using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace sql_test
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var i = 0;
            bool up = true;
            int length = 10;

            List<ConsoleColor> colors = new List<ConsoleColor>();

            //ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkBlue, ConsoleColor.White
            ConsoleColor[] color = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkBlue, ConsoleColor.White };

            while (true)
            {
                
                for (var a = 0; a < i; a++)
                {
                    Console.Write("*");
                    Console.ForegroundColor = color[0];
                }
                Console.WriteLine("\n");


                if (up)
                {
                    if (i < length)
                    {
                        i++;
                    } else
                    {
                        up = false;
                    }
                } else
                {
                    if (i < 2)
                    {
                        up = true;
                    }
                    
                    i--;
                }


                System.Threading.Thread.Sleep(50);
            }*/


            var _cs = @"Server=mssql.sps-prosek.local;Database=stellja18;User ID=stellja18;Password=stellja18";
            using var _con = new SqlConnection(_cs);
            _con.Open();

            var _sql = "SELECT * FROM [dbo].[user]";

            using var _cmd = new SqlCommand(_sql, _con);

            string _ret = _cmd.ExecuteScalar().ToString();
            Console.WriteLine(_ret);
        }
    }
}
