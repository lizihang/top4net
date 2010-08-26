using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// ShippingAddress Data Structure.
    /// </summary>
    [Serializable]
    public class ShippingAddress : BaseObject
    {
        [XmlElement("address_id")]
        public long AddressId { get; set; }

        [XmlElement("created")]
        public string Created { get; set; }

        [XmlElement("is_default")]
        public bool IsDefault { get; set; }

        [XmlElement("location")]
        public Location Location { get; set; }

        [XmlElement("mobile")]
        public string Mobile { get; set; }

        [XmlElement("phone")]
        public string Phone { get; set; }

        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }
    }
}
