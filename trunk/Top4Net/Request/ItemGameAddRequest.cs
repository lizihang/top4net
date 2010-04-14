using System;
using System.Collections.Generic;

using Taobao.Top.Api.Domain;
using Taobao.Top.Api.Util;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.game.add
    /// </summary>
    public class ItemGameAddRequest : ITopUploadRequest
    {
        public string ApproveStatus { get; set; }
        public Nullable<long> AuctionPoint { get; set; }
        public string AutoRepost { get; set; }
        public Nullable<long> Cid { get; set; }
        public string Desc { get; set; }
        public string EmsFee { get; set; }
        public string ExpressFee { get; set; }
        public string FreightPayer { get; set; }
        public string GameType { get; set; }
        public string HasDiscount { get; set; }
        public string HasInvoice { get; set; }
        public string HasShowcase { get; set; }
        public string HasWarranty { get; set; }
        public string Increment { get; set; }
        public string InputPids { get; set; }
        public string InputStr { get; set; }
        public string Is3D { get; set; }
        public string IsEx { get; set; }
        public string IsTaobao { get; set; }
        public string Lang { get; set; }
        public string ListTime { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public Nullable<long> Num { get; set; }
        public string OuterId { get; set; }
        public string PicPath { get; set; }
        public string PostFee { get; set; }
        public Nullable<long> PostageId { get; set; }
        public string Price { get; set; }
        public Nullable<long> ProductId { get; set; }
        public string PropertyAlias { get; set; }
        public string Props { get; set; }
        public string SellerCids { get; set; }
        public string SkuOuterIds { get; set; }
        public string SkuPrices { get; set; }
        public string SkuProperties { get; set; }
        public string SkuQuantities { get; set; }
        public string StuffStatus { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public Nullable<long> ValidThru { get; set; }
        public string VerticalIds { get; set; }
        public FileItem VerticalImage { get; set; }
        public Nullable<long> VerticalImageId { get; set; }
        public string VerticalValues { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.game.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("auction_point", this.AuctionPoint);
            parameters.Add("auto_repost", this.AutoRepost);
            parameters.Add("cid", this.Cid);
            parameters.Add("desc", this.Desc);
            parameters.Add("ems_fee", this.EmsFee);
            parameters.Add("express_fee", this.ExpressFee);
            parameters.Add("freight_payer", this.FreightPayer);
            parameters.Add("game_type", this.GameType);
            parameters.Add("has_discount", this.HasDiscount);
            parameters.Add("has_invoice", this.HasInvoice);
            parameters.Add("has_showcase", this.HasShowcase);
            parameters.Add("has_warranty", this.HasWarranty);
            parameters.Add("increment", this.Increment);
            parameters.Add("input_pids", this.InputPids);
            parameters.Add("input_str", this.InputStr);
            parameters.Add("is_3D", this.Is3D);
            parameters.Add("is_ex", this.IsEx);
            parameters.Add("is_taobao", this.IsTaobao);
            parameters.Add("lang", this.Lang);
            parameters.Add("list_time", this.ListTime);
            parameters.Add("location.city", this.LocationCity);
            parameters.Add("location.state", this.LocationState);
            parameters.Add("num", this.Num);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("post_fee", this.PostFee);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("price", this.Price);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("property_alias", this.PropertyAlias);
            parameters.Add("props", this.Props);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("sku_outer_ids", this.SkuOuterIds);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.Add("sku_properties", this.SkuProperties);
            parameters.Add("sku_quantities", this.SkuQuantities);
            parameters.Add("stuff_status", this.StuffStatus);
            parameters.Add("title", this.Title);
            parameters.Add("type", this.Type);
            parameters.Add("valid_thru", this.ValidThru);
            parameters.Add("vertical_ids", this.VerticalIds);
            parameters.Add("vertical_image_id", this.VerticalImageId);
            parameters.Add("vertical_values", this.VerticalValues);
            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("vertical_image", this.VerticalImage);
            return parameters;
        }

        #endregion
    }
}
