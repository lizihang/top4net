using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.bought.get
    /// </summary>
    public class TradesBoughtGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的交易数据结构字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询交易创建时间开始。
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        /// <summary>
        /// 查询交易创建时间结束。
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        public Nullable<int> PageNo { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        public Nullable<int> PageSize { get; set; }

        /// <summary>
        /// 商品名称。
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 交易状态。
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 卖家昵称。
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 交易类型。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.bought.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();

            parameters.Add("fields", this.Fields);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("title", this.Title);
            parameters.Add("status", this.Status);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}