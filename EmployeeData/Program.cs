using System;
using System.Data.SqlClient;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=U1-4P576Y2-L;Initial Catalog=CApoc;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql;

            //Delete existing table
            sql = "DROP TABLE Employee_data";
            SqlCommand command1 = new SqlCommand(sql, conn);
            command1.ExecuteNonQuery();
            command1.Dispose();

            //Create new table
            sql = "CREATE TABLE Employee_data ( " +
                    "EmpID int, LastName varchar(50), FirstName varchar(50), DOB DateTime, DOJ DateTime, Age varchar(50), PhoneNo varchar(50), email varchar(50) )";
            SqlCommand command2 = new SqlCommand(sql, conn);
            command2.ExecuteNonQuery();
            command2.Dispose();

            //Add new record
            sql = "INSERT INTO Employee_data VALUES('1', 'Elton', 'John', '1993-01-11', '2018-06-12', '26', '(212)345-5463','jelton@gmail.com')";
            SqlCommand command3 = new SqlCommand(sql, conn);
            command3.ExecuteNonQuery();
            command3.Dispose();

            //Add new record
            sql = "INSERT INTO Employee_data VALUES('2', 'Roger', 'Svetlana', '1967-04-21', '2018-06-12', '52', '(212)654-5463','sroger@gmail.com')";
            SqlCommand command4 = new SqlCommand(sql, conn);
            command4.ExecuteNonQuery();
            command4.Dispose();

            //Add new record
            sql = "INSERT INTO Employee_data VALUES('3', 'Benette', 'Katherine', '1997-05-01', '2018-06-12', '23', '(212)345-5463','kbenette@gmail.com')";
            SqlCommand command5 = new SqlCommand(sql, conn);
            command5.ExecuteNonQuery();
            command5.Dispose();

            //Update existing record
            sql = "UPDATE Employee_data SET LastName='William' Where EmpID='1' ";
            SqlCommand command6 = new SqlCommand(sql, conn);
            command6.ExecuteNonQuery();
            command6.Dispose();

            //Delete record 
            sql = "DELETE FROM Employee_data Where EmpID='1' ";
            SqlCommand command7 = new SqlCommand(sql, conn);
            command7.ExecuteNonQuery();
            command7.Dispose();


            conn.Close();



        }
    }
}
