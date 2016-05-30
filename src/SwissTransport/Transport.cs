using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;
using System;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public bool Error { get; set; }

        public Exception ThrowedException { get; set; }

        public Stations GetStations(string query)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message);
                    return stations;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                ThrowedException = ex;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var stationboard =
                        JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                    return stationboard;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                ThrowedException = ex;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStattion)
        {
            try
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var connections =
                        JsonConvert.DeserializeObject<Connections>(readToEnd);
                    return connections;
                }
            }
            catch (Exception ex)
            {
                Error = true;
                ThrowedException = ex;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;

            return request;
        }
    }
}
