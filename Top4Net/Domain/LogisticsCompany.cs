﻿using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 物流公司结构
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("logistic_company")]
    public class LogisticsCompany : BaseObject
    {
        /// <summary>
        /// 物流公司标识
        /// </summary>
        [JsonProperty("company_id")]
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 物流公司代码
        /// </summary>
        [JsonProperty("company_code")]
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 物流公司简称
        /// </summary>
        [JsonProperty("company_name")]
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 派送范围
        /// </summary>
        [JsonProperty("send_area")]
        [XmlElement("send_area")]
        public string SendArea { get; set; }

        /// <summary>
        /// 不派送范围
        /// </summary>
        [JsonProperty("not_send_area")]
        [XmlElement("not_send_area")]
        public string UnsendArea { get; set; }
    }
}