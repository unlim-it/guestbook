namespace Guestbook.Silverlight.Network
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    internal class WebInvoker
    {
        public static async Task<TResult> Invoke<TResult>(string url, string method, object data, 
            params KeyValuePair<string, string>[] headers) where TResult : class 
        {
            var request = WebRequest.Create(url);

            request.Method = method;

            if (headers != null)
            {
                foreach (var pair in headers)
                {
                    request.Headers[pair.Key] = pair.Value;
                }
            }

            if (method != "GET")
            {
                request.ContentType = "application/json";
                var postData = JsonConvert.SerializeObject(data);

                var byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentLength = byteArray.Length;

                var requestStream = await request.GetRequestStreamAsync();

                requestStream.Write(byteArray, 0, byteArray.Length);
                requestStream.Close();
            }

            var response = await request.GetResponseAsync();
            var responseStream = response.GetResponseStream();
            string responseBody;
            if (responseStream == null)
            {
                return null;
            }

            using (var reader = new StreamReader(responseStream))
            {
                responseBody = await reader.ReadToEndAsync();
            }

            return JsonConvert.DeserializeObject<TResult>(responseBody);
        }
    }
}