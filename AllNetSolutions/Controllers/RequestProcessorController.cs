using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace AllNetSolutions.Controllers
{
    [RoutePrefix("api/process")]
    public class RequestProcessorController : ApiController
    {

        [HttpGet]
        [Route("first")]
        public async Task<IHttpActionResult> GetfirstData()
        {
            List<Result> dicts = new List<Result>();
            try
            {
                var tasks = new List<Task<(string, TimeSpan)>>();

                tasks.Add(CheckNumber());

                var response = await Task.WhenAll(tasks);
                for (int i = 0; i < response.Length; i++)
                {
                    var dict = new Result();
                    dict.status = response[i].Item1;
                    dict.timeTaken = response[i].Item2;
                    dicts.Add(dict);
                }
                return Content(HttpStatusCode.OK, dicts);
            }
            catch (Exception ex)
            {
                var errorResult = new Dictionary<string, string>()
                {
                    { "error", ex.Message }
                };
                return Content(HttpStatusCode.InternalServerError, errorResult);
            }
        }

        [HttpGet]
        [Route("second")]
        public async Task<IHttpActionResult> GetsecondData()
        {
            List<Result> dicts = new List<Result>();
            try
            {
                var tasks = new List<Task<(string, TimeSpan)>>();

                tasks.Add(CheckNumber());

                var response = await Task.WhenAll(tasks);
                for (int i = 0; i < response.Length; i++)
                {
                    var dict = new Result();
                    dict.status = response[i].Item1;
                    dict.timeTaken = response[i].Item2;
                    dicts.Add(dict);
                }
                return Content(HttpStatusCode.OK, dicts);
            }
            catch (Exception ex)
            {
                var errorResult = new Dictionary<string, string>()
                {
                    { "error", ex.Message }
                };
                return Content(HttpStatusCode.InternalServerError, errorResult);
            }
        }

        [HttpGet]
        [Route("third")]
        public async Task<IHttpActionResult> GetthirdData()
        {
            List<Result> dicts = new List<Result>();
            try
            {
                var tasks = new List<Task<(string, TimeSpan)>>();

                tasks.Add(CheckNumber());

                var response = await Task.WhenAll(tasks);
                for (int i = 0; i < response.Length; i++)
                {
                    var dict = new Result();
                    dict.status = response[i].Item1;
                    dict.timeTaken = response[i].Item2;
                    dicts.Add(dict);
                }
                return Content(HttpStatusCode.OK, dicts);
            }
            catch (Exception ex)
            {
                var errorResult = new Dictionary<string, string>()
                {
                    { "error", ex.Message }
                };
                return Content(HttpStatusCode.InternalServerError, errorResult);
            }
        }

        private async Task<(string, TimeSpan)> CheckNumber()
        {
            var random = new Random();
            var number = random.Next(10);
            var isEven = number % 2 == 0;
            var status = isEven ? "success" : "failed";
            
            await Task.Delay(TimeSpan.FromSeconds(number));
            return (status, TimeSpan.FromSeconds(number));
        }
    }
    public class Result
    {
        public string status { get; set; }
        public TimeSpan timeTaken { get; set; }
    }
}