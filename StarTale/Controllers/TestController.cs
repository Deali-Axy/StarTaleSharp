using System;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace StarTale.Controllers {
    public class TestController : Controller {
        // GET
        public ObjectResult Index([FromServices] IBackgroundJobClient backgroundJobClient) {
            backgroundJobClient.Enqueue(() => Console.WriteLine("hello hangfire!"));
            return new ObjectResult(new {
                Msg = "ok"
            });
        }
    }
}