using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.bought.get
    /// </summary>
    public class TradesBoughtGetRequest : ITopRequest
    {
        public Nullable<DateTime> EndCreated { get; set; }
        public string Fields { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public string RateStatus { get; set; }
        public string SellerNick { get; set; }
        public Nullable<DateTime> StartCreated { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.bought.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("rate_status", this.RateStatus);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            return parameters;
        }

        #endregion
    }
}
