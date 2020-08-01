using System;
using Microsoft.AspNetCore.Mvc;

// [ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    public ActionResult Get()
    {

        return Ok("Hi from Get");
    }


}