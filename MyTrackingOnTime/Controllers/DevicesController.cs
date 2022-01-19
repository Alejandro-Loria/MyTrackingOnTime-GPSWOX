using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.CodeAnalysis;
using MyTrackingOnTime.Filters;
using MyTrackingOnTime.Models;
using MyTrackingOnTime.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace MyTrackingOnTime.Controllers
{
    [UseStopwatch]
    //[OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
    public class DevicesController : Controller
    {
        //private static readonly string userAgen = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
        private readonly string baseUrl = "https://173.212.222.117";
        private readonly string publicPath = "https://admin.mytrackingontime.com/";

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            ViewBag.SyncOrAsync = "Synchronous (WebClient)";
            ViewBag.Message = "¡Se obtuvieron todos los dispositivos!";
            var deviceService = new DevicesService();
            var token = new DevicesModel.Token { Lang = "es", UserApiHash = HttpContext.Session.GetString("token") };
            if (string.IsNullOrEmpty(token.UserApiHash))
            {
                return RedirectToAction("Index", "Authentication");
            }
            return View("get_devices", deviceService.GetDeviceAsync(token.Lang, token.UserApiHash));
        }

        //[HandleError(ExceptionType = typeof(TimeoutException), View = "TimeoutError")]
        public async Task<ActionResult> GetDevices()
        {
            ViewBag.SyncOrAsync = "Asynchronous (CancellationToken)";
            ViewBag.Message = "¡Se obtuvieron todos los dispositivos!";
            var deviceService = new DevicesService();
            var token = new DevicesModel.Token { Lang = "es", UserApiHash = HttpContext.Session.GetString("token") };
            if (string.IsNullOrEmpty(token.UserApiHash))
            {
                return RedirectToAction("Index", "Authentication");
            }
            return View("get_devices", await deviceService.GetDeviceAsync(token.Lang, token.UserApiHash));
        }

        public async Task<ActionResult> GetDevicesLatest()
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            ViewBag.Message = "¡Se obtuvieron todos los dispositivos (get_devices_latest)!";
            var deviceService = new DevicesService();
            //int unixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            int unixTimestamp = 1637090700;
            var token = new DevicesModel.Token { Lang = "es", UserApiHash = HttpContext.Session.GetString("token"), Time = unixTimestamp };
            if (string.IsNullOrEmpty(token.UserApiHash))
            {
                return RedirectToAction("Index", "Authentication");
            }
            return View("get_devices", await deviceService.GetDevicesLatestAsync(token.Lang, token.UserApiHash, token.Time));
        }

        //public async Task<ActionResult> Index()
        //{
        //    ViewBag.SyncOrAsync = "Asynchronous (HttpClient)";
        //    ViewBag.Message = "¡Se obtuvieron todos los dispositivos!";
        //    var deviceService = new DeviceService();
        //    var token = new DeviceModel.Token { lang = "es", user_api_hash = HttpContext.Session.GetString("token") };
        //    if (string.IsNullOrEmpty(token.user_api_hash))
        //    {
        //        return RedirectToAction("Index", "Authentication");
        //    }
        //    return View("get_devices", await deviceService.GetDeviceAsync(token.lang, token.user_api_hash));
        //}

        public async Task<IActionResult> GetDevices2()
        {
            //HttpClientHandler clientHandler = new();
            //clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };
            //HttpClient httpClient = new(clientHandler);
            //httpClient.BaseAddress = new Uri(baseUrl);

            var token = new DevicesModel.Token
            {
                Lang = "es",
                UserApiHash = HttpContext.Session.GetString("token")
            };

            HttpClient httpClient = new(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } })
            {
                BaseAddress = new Uri(baseUrl)
            };
            //httpClient.DefaultRequestHeaders.Add("user-agent", userAgen);
            httpClient.CancelPendingRequests();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("lang", token.Lang);
            //httpClient.DefaultRequestHeaders.Add("user_api_hash", token.user_api_hash);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //Task<HttpResponseMessage> taskResponse = httpClient.GetAsync("/api/get_devices");
            var endpoint = "/api/get_devices";

            //taskResponse.Wait();
            //HttpResponseMessage response = taskResponse.Result;
            //using var request = new HttpRequestMessage(new HttpMethod("GET"), baseUrl + endpoint);
            //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");
            //var stringContent = new FormUrlEncodedContent(new[]
            //{
            //    new KeyValuePair<string, string>("lang", token.lang),
            //    new KeyValuePair<string, string>("user_api_hash", token.user_api_hash),
            //});

            //request.Content = stringContent;
            //corregir la url de consulta

            using HttpResponseMessage Response = await httpClient.GetAsync(string.Format(endpoint + "?lang={0}&user_api_hash={1}", token.Lang, token.UserApiHash));

            if (Response.StatusCode == HttpStatusCode.OK)
            {
                string response = Response.Content.ReadAsStringAsync().Result;
                List<DevicesModel.Root> devices = JsonConvert.DeserializeObject<List<DevicesModel.Root>>(response);
                //devices.Single(x => x.PublicPath == null).PublicPath = publicPath;
                //DeviceModel.Root devices = JsonConvert.DeserializeObject<DeviceModel.Root>(response);
                ViewBag.Message = "¡Se obtuvieron todos los dispositivos!";
                return View("get_devices", devices);
            }
            else if(Response.StatusCode == HttpStatusCode.BadRequest)
            {
                ViewBag.error = "Status: 400" + "." + " Error: " + Response.ReasonPhrase;
                return View("get_devices");
            }
            else if (Response.StatusCode == HttpStatusCode.Unauthorized)
            {
                ViewBag.error = "Status: 401" + "." + " Error: " + Response.ReasonPhrase;
                return View("get_devices");
            }
            return View("get_devices");
        }
    }
}
