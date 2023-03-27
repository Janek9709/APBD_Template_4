using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Zadanie4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get([FromQuery]string param)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=db-mssql16;Initial Catalog=sXXXXX;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT * FROM... {param}", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["..."];

                }

                reader.Close();
                connection.Close();

                return Ok();
            }
        }

        [HttpPost]
        public ActionResult Post()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=db-mssql16;Initial Catalog=sXXXXX;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO ... VALUES (@Name...", connection);

                command.Parameters.AddWithValue("@param", "...");

                var numberOfRows = (int?)command.ExecuteNonQuery();
                connection.Close();

                return Ok();
            }
        }
    }
}
