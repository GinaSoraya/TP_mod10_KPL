using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul10_1302223070.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Gina Soraya", "1302223070"),
            new Mahasiswa("Hafid Alakhyar", "1302223044"),
            new Mahasiswa("Ragadhitya Janatantra Koeshutama", "1302223025"),
            new Mahasiswa("Muhammad Iqbal Nurhaq", "1302223050"),
            new Mahasiswa("Kal El Muhammad Pratama", "1302220096")
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
