using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;

namespace TechnicalRadiation.Models.Attributes
{
    public class HyperMediaModel
    {
        public HyperMediaModel() { Links = new ExpandoObject(); }
        [JsonProperty(PropertyName = "_links")]
        public ExpandoObject Links { get; set; }
        public void addReference<T>(string key, T value) => this.Links.TryAdd(key, value);
    }
}