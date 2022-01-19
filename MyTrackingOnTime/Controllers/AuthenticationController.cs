using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MyTrackingOnTime.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Security;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MyTrackingOnTime.Service;

namespace MyTrackingOnTime.Controllers
{
    public class AuthenticationController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                HttpClientHandler clientHandler = new();
                clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };
                HttpClient httpClient = new(clientHandler);

                AuthenticationModel.Login Login = new();
                Login.email = email;
                Login.password = password;


                var request = new HttpRequestMessage(new HttpMethod("POST"), Util.GetServiceUri("login"));
                request.Headers.TryAddWithoutValidation("accept", "application/json");

                var multipartContent = new MultipartFormDataContent
                {
                    { new StringContent(Login.email), "email" },
                    { new StringContent(Login.password), "password" }
                };
                request.Content = multipartContent;

                HttpResponseMessage Response = await httpClient.SendAsync(request);

                if (Response.StatusCode == HttpStatusCode.OK)
                {
                    string response = Response.Content.ReadAsStringAsync().Result;
                    AuthenticationModel.Root permissions = JsonConvert.DeserializeObject<AuthenticationModel.Root>(response);
                    HttpContext.Session.SetString("token", permissions.user_api_hash);
                    return View("../Profile/Permissions", permissions);
                }
                else
                {
                    ViewBag.error = "Status: " + (int)Response.StatusCode + "." + " Error: " + Response.ReasonPhrase;
                    return View("Index");
                }
            }
            else
            {
                ViewBag.error = "El campo Email y Contraseña es requerido";
                return View("Index");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("token");
            TempData["Message"] = "¡El usuario cerró la sesión correctamente!";
            //ViewBag.Message = "¡El usuario cerró la sesión correctamente!";
            return RedirectToAction("Index", "Home");
        }

    }
}
