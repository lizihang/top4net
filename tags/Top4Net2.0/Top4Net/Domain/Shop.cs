using System;
using System.Xml.Serialization;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// Shop Data Structure.
    /// </summary>
    [Serializable]
    public class Shop : BaseObject
    {
        [XmlElement("bulletin")]
        public string Bulletin { get; set; }

        [XmlElement("cid")]
        public long Cid { get; set; }

        [XmlElement("created")]
        public string Created { get; set; }

        [XmlElement("desc")]
        public string Desc { get; set; }

        [XmlElement("modified")]
        public string Modified { get; set; }

        [XmlElement("nick")]
        public string Nick { get; set; }

        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        [XmlElement("remain_count")]
        public int RemainCount { get; set; }

        [XmlElement("shop_score")]
        public ShopScore ShopScore { get; set; }

        [XmlElement("sid")]
        public long Sid { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }
    }
}