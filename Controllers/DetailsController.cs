using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

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

  public HttpResponseMessage Post() {
    return new HttpResponseMessage(HttpStatusCode.OK, "test");
  }
}