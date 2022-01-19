using MyTrackingOnTime.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MyTrackingOnTime.Service
{
    public class DevicesService
    {
        //** GET/api/get_devices **//

        //  Simpler API, CancellationToken
        //public async Task<List<DevicesModel.Root>> GetDeviceAsync(string lang, string user_api_hash,
        //    CancellationToken cancelToken = default)
        //{
        //    var uri = Util.GetServiceUri(string.Format("get_devices?lang={0}&user_api_hash={1}", lang, user_api_hash));
        //    HttpClient httpClient = new(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } }); // Ignorar certificado SSL no válido o expirado.
        //    var response = await httpClient.GetAsync(uri, cancelToken);
        //    List<DevicesModel.Root> devices = await response.Content.ReadAsAsync<List<DevicesModel.Root>>(cancellationToken: cancelToken);
        //    devices.Single(x => x.PublicPath == null).PublicPath = Util.GetPublicPath();
        //    return devices;
        //    //return await response.Content.ReadAsAsync<List<DeviceModel.Root>>(cancellationToken: cancelToken);
        //}

        //  Simpler API, no CancellationToken
        public async Task<List<DevicesModel.Root>> GetDeviceAsync(string Lang, string UserApiHash)
        {
            var uri = Util.GetServiceUri(string.Format("get_devices?lang={0}&user_api_hash={1}", Lang, UserApiHash));
            HttpClient httpClient = new(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } }); // Ignorar certificado SSL no válido o expirado.
            var Response = await httpClient.GetAsync(uri);
            string Result = Response.Content.ReadAsStringAsync().Result;
            List<DevicesModel.Root> devices = JsonConvert.DeserializeObject<List<DevicesModel.Root>>(Result);
            //List<DevicesModel.Root> devices = await Response.Content.ReadAsAsync<List<DevicesModel.Root>>();
            //devices.Single(x => x.PublicPath == null).PublicPath = Util.GetPublicPath();
            return devices;
            //return await response.Content.ReadAsAsync<List<DeviceModel.Root>>();
        }

        // Simpler API
        //public List<DevicesModel.Root> GetDevice(string Lang, string UserApiHash)
        //{
        //    var uri = Util.GetServiceUri(string.Format("get_devices?lang={0}&user_api_hash={1}", Lang, UserApiHash));
        //    ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true; // Ignorar certificado SSL no válido o expirado.
        //    WebClient webClient = new();
        //    List<DevicesModel.Root> devices = JsonConvert.DeserializeObject<List<DevicesModel.Root>>(webClient.DownloadString(uri));
        //    devices.Single(x => x.PublicPath == null).PublicPath = Util.GetPublicPath();
        //    return devices;
        //    //return JsonConvert.DeserializeObject<List<DeviceModel.Root>>(webClient.DownloadString(uri));
        //}

        //** GET /api/get_devices_latest **//

        public async Task<List<DevicesModel.Root>> GetDevicesLatestAsync(string Lang, string UserApiHash, int Time)
        {
            var uri = Util.GetServiceUri(string.Format("get_devices_latest?lang={0}&user_api_hash={1}&time={2}", Lang, UserApiHash, Time));
            HttpClient httpClient = new(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; } }); // Ignorar certificado SSL no válido o expirado.
            var Response = await httpClient.GetAsync(uri);
            string Result = Response.Content.ReadAsStringAsync().Result;

            JObject obj = JObject.Parse(Result);
            JArray arr = (JArray)obj["items"];
            List<DevicesModel.Root> devices = arr.ToObject<List<DevicesModel.Root>>();

            //List<GetDevicesLatestModel.Root> devices = JsonConvert.DeserializeObject<List<GetDevicesLatestModel.Root>>(result);
            //devices.Single(x => x.PublicPath == null).PublicPath = Util.GetPublicPath();
            return devices;
        }
    }
}
