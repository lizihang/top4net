using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// NotifyRefund Data Structure.
    /// </summary>
    [Serializable]
    public class NotifyRefund : BaseObject
    {
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        [XmlElement("modified")]
        public DateTime Modified { get; set; }

        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        [XmlElement("rid")]
        public long Rid { get; set; }

        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("tid")]
        public long Tid { get; set; }
    }
}
