using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace AdapterPattern.Adapter
{
     public class Person
    {
        public virtual string Name { get; set; }
        public virtual string Gender { get; set; }
        [Newtonsoft.Json.JsonProperty("hair_color")]
        public virtual string HairColor { get; set; }
    }
 }
