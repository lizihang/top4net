using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trades.sold.increment.get
    /// </summary>
    public class TradesSoldIncrementGetRequest : ITopRequest
    {
        public Nullable<DateTime> EndModified { get; set; }
        public string Fields { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public Nullable<DateTime> StartModified { get; set; }
        public string Status { get; set; }
        public string Tag { get; set; }
        public string Type { get; set; }
        public Nullable<bool> UseHasNext { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trades.sold.increment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("status", this.Status);
            parameters.Add("tag", this.Tag);
            parameters.Add("type", this.Type);
            parameters.Add("use_has_next", this.UseHasNext);
            return parameters;
        }

        #endregion
    }
}