using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Order Data Structure.
    /// </summary>
    [Serializable]
    public class Order : TopObject
    {
        /// <summary>
        /// 卖家优惠金额.格式为:1.01;单位:元;精确到小数点后两位.
        /// </summary>
        [XmlElement("adjust_fee")]
        public string AdjustFee { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家是否已评价。可选值：true(已评价)，false(未评价)
        /// </summary>
        [XmlElement("buyer_rate")]
        public bool BuyerRate { get; set; }

        /// <summary>
        /// 交易商品对应的类目ID
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 交易创建时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 系统优惠金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 商品的字符串编号(注意：iid近期即将废弃，请用num_iid参数)
        /// </summary>
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 是否超卖
        /// </summary>
        [XmlElement("is_oversold")]
        public bool IsOversold { get; set; }

        /// <summary>
        /// 套餐的值。如：M8原装电池:便携支架:M8专用座充:莫凡保护袋
        /// </summary>
        [XmlElement("item_meal_name")]
        public string ItemMealName { get; set; }

        /// <summary>
        /// 子订单最后修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 购买数量。取值范围:大于零的整数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 商品数字ID
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 子订单编号
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 商家外部编码(可与商家外部系统对接)。外部商家自己定义的商品Item的id，可以通过taobao.items.custom.get获取商品的Item的信息
        /// </summary>
        [XmlElement("outer_iid")]
        public string OuterIid { get; set; }

        /// <summary>
        /// 外部网店自己定义的Sku编号
        /// </summary>
        [XmlElement("outer_sku_id")]
        public string OuterSkuId { get; set; }

        /// <summary>
        /// 买家实付金额（单笔子订单时包含物流费用，多笔子订单时不包含物流费用 ，付款后这个价格不会变化）。精确到2位小数，单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 商品图片的绝对路径
        /// </summary>
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 退款中的退款ID
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 退款状态。退款状态。可选值  NO_REFUND(没有退款),WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意) WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货) WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货) SELLER_REFUSE_BUYER(卖家拒绝退款) CLOSED(退款关闭) SUCCESS(退款成功)
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 卖家是否已评价。可选值：true(已评价)，false(未评价)
        /// </summary>
        [XmlElement("seller_rate")]
        public bool SellerRate { get; set; }

        /// <summary>
        /// 卖家类型，可选值为：B（商城商家），C（普通卖家）
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }

        /// <summary>
        /// 商品的最小库存单位Sku的id.可以通过taobao.item.sku.get获取详细的Sku信息
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// SKU的值。如：机身颜色:黑色;手机套餐:官方标配
        /// </summary>
        [XmlElement("sku_properties_name")]
        public string SkuPropertiesName { get; set; }

        /// <summary>
        /// 订单快照详细信息
        /// </summary>
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 订单快照URL
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 订单状态。TRADE_NO_CREATE_PAY(没有创建支付宝交易) WAIT_BUYER_PAY(等待买家付款) WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款) WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货) TRADE_BUYER_SIGNED(买家已签收,货到付款专用) TRADE_FINISHED(交易成功) TRADE_CLOSED(交易关闭) TRADE_CLOSED_BY_TAOBAO(交易被淘宝关闭) ALL_WAIT_PAY(包含：WAIT_BUYER_PAY、TRADE_NO_CREATE_PAY) ALL_CLOSED(包含：TRADE_CLOSED、TRADE_CLOSED_BY_TAOBAO)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单超时到期时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("timeout_action_time")]
        public string TimeoutActionTime { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 应付金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
