using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.img.delete
    /// </summary>
    public class ItemImgDeleteRequest : ITopRequest
    {
        public Nullable<long> Id { get; set; }
        public string Iid { get; set; }
        public Nullable<long> ItemimgId { get; set; }
        public Nullable<long> NumIid { get; set; }
        public string V { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.img.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("iid", this.Iid);
            parameters.Add("itemimg_id", this.ItemimgId);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("v", this.V);
            return parameters;
        }

        #endregion
    }
}
