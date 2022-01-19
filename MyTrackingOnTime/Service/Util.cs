using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace MyTrackingOnTime.Service
{
    public static class Util
    {
        public static string GetRootUri()
        {
            // For IIS Express, use localhost:7734 
            var uri = "https://173.212.222.117/";
            // Get the root URI from Web.config
            //uri = Configuration.WidgetServiceURI;
            return uri;
        }

        public static string GetPublicPath()
        {
            var publicPath = "https://admin.mytrackingontime.com/";
            return publicPath;
        }

        public static string GetServiceUri(string srv)
        {
            return GetRootUri() + "api/" + srv;
        }
    }


    //public static class Configuration
    //{
    //    private static string _uri = null;

    //    public static string WidgetServiceURI
    //    {
    //        get
    //        {
    //            if (!string.IsNullOrEmpty(_uri))
    //                return _uri;

    //            _uri = getKeyVal("WidgetServiceURI");
    //            if (string.IsNullOrEmpty(_uri))
    //                return "http://localhost:7734/";
    //            else
    //                return _uri;
    //        }
    //    }
    //    public static string getKeyVal(string key)
    //    {
    //        return ConfigurationManager.AppSettings[key];
    //    }
    //}
}
