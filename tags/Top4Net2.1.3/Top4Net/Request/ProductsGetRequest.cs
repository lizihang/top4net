using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.products.get
    /// </summary>
    public class ProductsGetRequest : ITopRequest
    {
        public Nullable<long> Cid { get; set; }
        public string Fields { get; set; }
        public string Nick { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }
        public string Props { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.products.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("props", this.Props);
            return parameters;
        }

        #endregion
    }
}