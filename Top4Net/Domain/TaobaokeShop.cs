﻿using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Taobao.Top.Api.Domain
{
    /// <summary>
    /// 淘宝客店铺
    /// </summary>
    [Serializable]
    [JsonObject]
    [XmlRoot("taobaokeShop")]
    public class TaobaokeShop
    {
        /// <summary>
        /// 店铺用户id
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("shop_title")]
        [XmlElement("shop_title")]
        public string ShopTitle { get; set; }
        /// <summary>
        /// 店铺推广URL
        /// </summary>
        [JsonProperty("click_url")]
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }
        /// <summary>
        /// 淘宝客店铺佣金比率
        /// </summary>
        [JsonProperty("shop_commissionRate")]
        [XmlElement("shop_commissionRate")]
        public string ShopCommissionRate { get; set; }
    }
}