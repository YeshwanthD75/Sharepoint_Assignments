using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

// Define the class that maps to table structure
public class Externalcandidate
{
    public string cCandidatecode { get; set; }
    public string vFirstname { get; set; }
    public string vLastname { get; set; }
}

class Program
{
    static void sqlconnectwithclasslist()
    {
        SqlConnection con = null;

        try
        {
            string str = "Data Source=BB16E64EDBFA523;Integrated Security=SSPI;Initial Catalog=Recruitment";
            con = new SqlConnection(str);

            // SQL Command to select candidates where sitescore is not null
            SqlCommand cmd = new SqlCommand("SELECT * FROM Externalcandidate", con);
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            List<Externalcandidate> candidates = new List<Externalcandidate>();

            // Reading each row and adding to the list
            while (sdr.Read())
            {
                candidates.Add(new Externalcandidate
                {
                    cCandidatecode = sdr["cCandidatecode"].ToString(),
                    vFirstname = sdr["vFirstname"].ToString(),
                    vLastname = sdr["vLastname"].ToString()
                });
            }

            // Display the results
            foreach (Externalcandidate c in candidates)
            {
                Console.WriteLine("Candidatecode: {0}, Firstname: {1}, Lastname: {2}",
                    c.cCandidatecode, c.vFirstname, c.vLastname);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }

    static void sqlinsert(string code, string fname, string lname)
    {
        SqlConnection con = null;
        try
        {
            string str = "Data Source=BB16E64EDBFA523;Integrated Security=SSPI;Initial Catalog=Recruitment";
            con = new SqlConnection(str);
            con.Open();

            string sql = "Insert Into Externalcandidate" +
                          "(cCandidatecode, vFirstName, vLastName) Values" +
                          "(@code, @fname, @lname)";
            //SqlCommand cmd= new SqlCommand(sql, con);
            //This command will have internal parameters.
            using (SqlCommand command = new SqlCommand(sql, con)) 
            {

                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@code",
                    Value = code,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@fname",
                    Value = fname,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@lname",
                    Value = lname,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20
                };
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

            }
        }

        catch (Exception ex)

        {
            Console.WriteLine(ex.Message);
        }

     }

    static void GetCandidateByCode(string code)
    {
        const string connString = "Data Source=BB16E64EDBFA523;Integrated Security=SSPI;Initial Catalog=Recruitment";

        using (SqlConnection con = new SqlConnection(connString))
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Externalcandidate WHERE cCandidatecode = @code";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@code",
                        SqlDbType = SqlDbType.Char,
                        Size = 10,
                        Value = code
                    });

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Externalcandidate candidate = new Externalcandidate
                        {
                            cCandidatecode = reader["cCandidatecode"].ToString(),
                            vFirstname = reader["vFirstname"].ToString(),
                            vLastname = reader["vLastname"].ToString()
                        };

                        Console.WriteLine("Candidate Found:");
                        Console.WriteLine("Code: {0}, First Name: {1}, Last Name: {2}",
                            candidate.cCandidatecode, candidate.vFirstname, candidate.vLastname);
                    }
                    else
                    {
                        Console.WriteLine("No candidate found with code: " + code);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void GetAllCandidatesDisconnected()
    {
        string str = "Data Source=BB16E64EDBFA523;Integrated Security=SSPI;Initial Catalog=Recruitment";

        using (SqlConnection con = new SqlConnection(str))
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Externalcandidate", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                // Fill dataset using adapter — disconnected architecture
                adapter.Fill(dataSet);

                DataTable table = dataSet.Tables[0];
                IEnumerable<DataRow> query = from row in table.AsEnumerable() select row;

                Console.WriteLine("Candidate Names (Disconnected Mode):");
                foreach (DataRow row in query)
                {
                    Console.WriteLine(row.Field<string>("vFirstName") + " " + row.Field<string>("vLastName"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in disconnected fetch: " + ex.Message);
            }
        }
    }



    static void Main(string[] args)
    {
        sqlconnectwithclasslist();

        //Console.WriteLine("Insert in process....");
        //sqlinsert("000052", "Meena", "Vehra");
        //Console.WriteLine("Insert Completed....");

        //sqlconnectwithclasslist();

        Console.WriteLine("Fetching candidate with code '000052'");
        GetCandidateByCode("000052");

        Console.WriteLine("Now displaying all candidates using disconnected mode...");
        GetAllCandidatesDisconnected();
    }
}