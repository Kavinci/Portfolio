﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Portfolio.Helpers
{
    public class ThirdPartyService
    {
        public static string SendToService(string uri, string method, object json)
        {
            HttpWebRequest webRequest = WebRequest.CreateHttp(uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = method;

            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                streamWriter.Write(JsonSerializer.Serialize(json));
            }

            var response = webRequest.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
