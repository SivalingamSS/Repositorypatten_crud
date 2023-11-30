using BussinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repoistorypattern_DTO.student_details_viewmodel;

namespace Repositorypattern_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IbussinessInterface _ibussinessInterface;
        public StudentController(IbussinessInterface ibussinessInterface)
        {
            _ibussinessInterface = ibussinessInterface;
        }
        [HttpGet("get")]
        public IActionResult get()
        {
            var data = _ibussinessInterface.get();
            return Ok(data);
        }
        [HttpPost("post")]
        public object Postvalue(Employee see)
        {
            var str = _ibussinessInterface.Postvalue(see);
            return str;

        }
        [HttpPut("put")]
        public object putvalue(int id, viewmodel can)
        {
            var str = _ibussinessInterface.putvalue(id, can);
            return str;
        }
        [HttpDelete("delete")]
        public object deletevalue(int Id)
        {
            var str = _ibussinessInterface.deletevalue(Id);
            return str;
        }


    }
}
