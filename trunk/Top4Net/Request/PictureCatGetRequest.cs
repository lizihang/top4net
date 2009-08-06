using System;
using System.Collections.Generic;

using Taobao.Top.Api;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.category.get
    /// </summary>
    public class PictureCatGetRequest : ITopRequest
    {
        /// <summary>
        /// 需要返回的字段,根据PictureCategory中的以下字段：picture_category_id,picture_category_name,position,type,total,created,modified ,多个字段用“,”分隔。如：type,total,created,modified。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 图片分类ID。
        /// </summary>
        public string PicCategoryId { get; set; }

        /// <summary>
        /// 图片分类名，不支持模糊查询。
        /// </summary>
        public string PicCategoryName { get; set; }

        /// <summary>
        /// 分类类型,fixed代表店铺装修分类类别，auction代表宝贝分类类别，user-define代表用户自定义分类类别。
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.category.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("fields", this.Fields);
            parameters.Add("picture_category_id", this.PicCategoryId);
            parameters.Add("picture_category_name", this.PicCategoryName);
            parameters.Add("type", this.Type);

            return parameters;
        }

        #endregion
    }
}
