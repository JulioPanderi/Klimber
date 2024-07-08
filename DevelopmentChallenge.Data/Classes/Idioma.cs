using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Enums = DevelopmentChallenge.Data.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Logging;

namespace DevelopmentChallenge.Data.Classes
{
    public class DiccionarioIdioma
    {
        private readonly Dictionary<string, string> _mensajes;
        private readonly Enums.Idioma _idioma;

        public DiccionarioIdioma(Enums.Idioma Idioma, Dictionary<string, string> Mensajes)
        {
            _idioma = Idioma;
            _mensajes = Mensajes;
        }

        public DiccionarioIdioma(Enums.Idioma Idioma)
        {
            _idioma = Idioma;
            string path = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).Replace($"file:\\", string.Empty);
            string configFile = $"{path}\\{Enum.GetName(typeof(Enums.Idioma), Idioma)}.json";
            using (StreamReader reader = new StreamReader(configFile))
            {
                string jsonData = reader.ReadToEnd();
                _mensajes = new Dictionary<string, string>();
                try
                {
                    JArray jArray = (JArray)JsonConvert.DeserializeObject(jsonData);
                    foreach (JObject item in jArray.Children<JObject>())
                    {
                        _mensajes.Add(item["Id"].ToString(), item["Texto"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    //TODO: Log the exception
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Enums.Idioma Idioma => _idioma;
        public Dictionary<string, string> Mensajes => _mensajes;
    }
}
