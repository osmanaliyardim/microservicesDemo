﻿using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("-- > Inbound POST # Command Service");

        return Ok("Inbound test from PlatformsController");
    }
}