using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.video.upload
    /// </summary>
    public class ItemVideoUploadRequest : ITopRequest
    {
        public Nullable<long> Id { get; set; }
        public string Iid { get; set; }
        public string Lang { get; set; }
        public Nullable<long> NumIid { get; set; }
        public Nullable<long> VideoId { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.video.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("iid", this.Iid);
            parameters.Add("lang", this.Lang);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("video_id", this.VideoId);
            return parameters;
        }

        #endregion
    }
}