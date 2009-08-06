using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.img.upload
    /// </summary>
    public class ProductImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 产品图片ID。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 子图片，要先上传图片后再提交测试，否则图片不会被提交。
        /// </summary>
        public FileInfo Image { get; set; }

        /// <summary>
        /// 图片序号。
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 是否将该图片设为主图(默认为false)。
        /// </summary>
        public string IsPrimary { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("pic_id", this.ImgId);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("position", this.Position);
            parameters.Add("is_major", this.IsPrimary);

            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
