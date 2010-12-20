using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// Subscription Data Structure.
    /// </summary>
    [Serializable]
    public class Subscription : BaseObject
    {
        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
