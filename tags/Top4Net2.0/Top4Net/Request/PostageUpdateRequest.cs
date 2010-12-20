using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.postage.update
    /// </summary>
    public class PostageUpdateRequest : ITopRequest
    {
        public string EmsIncrease { get; set; }
        public string EmsPrice { get; set; }
        public string ExpressIncrease { get; set; }
        public string ExpressPrice { get; set; }
        public string Memo { get; set; }
        public string Name { get; set; }
        public string PostIncrease { get; set; }
        public string PostPrice { get; set; }
        public Nullable<long> PostageId { get; set; }
        public string PostageModeDests { get; set; }
        public string PostageModeIds { get; set; }
        public string PostageModeIncreases { get; set; }
        public string PostageModeOptTypes { get; set; }
        public string PostageModePrices { get; set; }
        public string PostageModeTypes { get; set; }
        public Nullable<bool> RemoveEms { get; set; }
        public Nullable<bool> RemoveExpress { get; set; }
        public Nullable<bool> RemovePost { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.postage.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ems_increase", this.EmsIncrease);
            parameters.Add("ems_price", this.EmsPrice);
            parameters.Add("express_increase", this.ExpressIncrease);
            parameters.Add("express_price", this.ExpressPrice);
            parameters.Add("memo", this.Memo);
            parameters.Add("name", this.Name);
            parameters.Add("post_increase", this.PostIncrease);
            parameters.Add("post_price", this.PostPrice);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("postage_mode_dests", this.PostageModeDests);
            parameters.Add("postage_mode_ids", this.PostageModeIds);
            parameters.Add("postage_mode_increases", this.PostageModeIncreases);
            parameters.Add("postage_mode_optTypes", this.PostageModeOptTypes);
            parameters.Add("postage_mode_prices", this.PostageModePrices);
            parameters.Add("postage_mode_types", this.PostageModeTypes);
            parameters.Add("remove_ems", this.RemoveEms);
            parameters.Add("remove_express", this.RemoveExpress);
            parameters.Add("remove_post", this.RemovePost);
            return parameters;
        }

        #endregion
    }
}