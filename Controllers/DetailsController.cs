using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
  [Route("api/values/{valueId}/details")]
  public class DetailsController : Controller
  {
    [HttpGet]
    public string Get(int valueId) {
      return "get normal";
    }

    [HttpGet("{id}")]
    public string Get(int valueId, int id) {
      return "get by id " + id;
    }
  }
}