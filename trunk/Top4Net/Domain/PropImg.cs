using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// PropImg Data Structure.
    /// </summary>
    [Serializable]
    public class PropImg : BaseObject
    {
        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlElement("id")]
        public long Id { get; set; }

        [XmlElement("position")]
        public int Position { get; set; }

        [XmlElement("properties")]
        public string Properties { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }
    }
}
