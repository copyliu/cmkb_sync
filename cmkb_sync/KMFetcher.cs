using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using cmkb_sync.ESI;
using cmkb_sync.Model;
using Newtonsoft.Json;

namespace cmkb_sync
{
    public class KMFetcher
    {
        
        public static bool GetKM(Model.killboard_waiting_api waitingApi,bool tq=false)
        {
            string url;
            if (tq)
            {
                url = $"https://esi.evetech.net/v1/killmails/{waitingApi.KillId}/{waitingApi.Hash}/";
            }
            else
            {
                throw new NotImplementedException("沒有國服");
            }
            var httpResponse = Helpers.httpClient.GetAsync(url).Result;
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new HttpRequestException(httpResponse.StatusCode.ToString());
            }

            KillMail kmresult;
            using (var s = httpResponse.Content.ReadAsStreamAsync().Result)
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                         kmresult = serializer.Deserialize<ESI.KillMail>(reader);
                       
                    }
                }
            }
            InsertModel(kmresult, tq);


            throw new NotImplementedException();
            
        }

        public static void UpdateNames(List<int> ids, bool tq = false)
        {
            throw new NotImplementedException();
        }
        private static void InsertModel(KillMail kmresult, bool tq = false)
        {
            throw new NotImplementedException();
        }

        private static void CalcAch(KillMail kmresult, bool tq = false)
        {
            throw new NotImplementedException();
        }
        private static void UpdateCharStatic(KillMail kmresult, bool tq = false)
        {
            throw new NotImplementedException();
        }

    }
}
