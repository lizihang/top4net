﻿using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 用户信用信息。
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("credit")]
    public class UserCredit
    {
        /// <summary>
        /// 信用等级。
        /// </summary>
        [JsonProperty("level")]
        [XmlElement("level")]
        public int Level { get; set; }

        /// <summary>
        /// 信用总分。
        /// </summary>
        [JsonProperty("score")]
        [XmlElement("score")]
        public int Score { get; set; }

        /// <summary>
        /// 收到的评价总条数。
        /// </summary>
        [JsonProperty("total_num")]
        [XmlElement("total_num")]
        public int TotalNum { get; set; }

        /// <summary>
        /// 收到的好评总条数。
        /// </summary>
        [JsonProperty("good_num")]
        [XmlElement("good_num")]
        public int GoodNum { get; set; }
    }
}