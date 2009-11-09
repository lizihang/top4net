﻿using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;
using Taobao.Top.Api.Domain;

namespace Taobao.Top.Api.Test
{
    [TestClass]
    public class TaobaokeApiTest
    {
        [TestMethod]
        public void GetTaobaokeItemsByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url";
            request.Nick = "tbtest561";
            //request.Keyword = "鞋";
            request.Cid = "0";
            request.PageSize = 6;
            request.PageNo = 1;
            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListJsonParser()).Content;
            Assert.IsTrue(items.Count > 0);
        }

        [TestMethod]
        public void GetTaobaokeItemsByXml()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            TaobaokeItemsGetRequest request = new TaobaokeItemsGetRequest();
            request.Fields = "iid,title,nick,pic_url,price,click_url";
            request.Nick = "tbtest561";
            //request.Keyword = "鞋";
            request.PageSize = 5;
            request.Cid = "0";

            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListXmlParser()).Content;
            Assert.IsTrue(items.Count > 0);
        }

        [TestMethod]
        public void ConvertTaobaokeItemsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            TaobaokeItemsConvertRequest request = new TaobaokeItemsConvertRequest();
            request.Fields = "iid,click_url,iid,commission,commission_rate,commission_num,commission_volume";
            request.Iids = "18052f24da6a89ef989cdc401036300f,18052f24da6a89ef989cdc401036300f";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListJsonParser()).Content;
            Assert.AreEqual(2, items.Count);
        }

        [TestMethod]
        public void ConvertTaobaokeItemsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            TaobaokeItemsConvertRequest request = new TaobaokeItemsConvertRequest();
            request.Fields = "iid,click_url,iid,commission,commission_rate,commission_num,commission_volume";
            request.Iids = "18052f24da6a89ef989cdc401036300f,18052f24da6a89ef989cdc401036300f";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeItem> items = client.Execute(request, new TaobaokeItemListXmlParser()).Content;
            Assert.AreEqual(2, items.Count);
        }

        [TestMethod]
        public void ConvertTaobaokeShopsByJson()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("json");
            TaobaokeShopsConvertRequest request = new TaobaokeShopsConvertRequest();
            request.Fields = "user_id,shop_title,click_url,shop_commission.rate";
            request.Sids = "79852143,456,789";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeShop> shops = client.Execute(request, new TaobaokeShopListJsonParser()).Content;
            Assert.AreEqual(3, shops.Count);
        }

        [TestMethod]
        public void ConvertTaobaokeShopsByXml()
        {
            ITopClient client = TestUtils.GetSandboxTopClient("xml");
            TaobaokeShopsConvertRequest request = new TaobaokeShopsConvertRequest();
            request.Fields = "user_id,shop_title,click_url,shop_commission.rate";
            request.Sids = "79852143,456,789";
            request.Nick = "tbtest520";
            request.OuterCode = "54321";
            List<TaobaokeShop> shops = client.Execute(request, new TaobaokeShopListXmlParser()).Content;
            Assert.AreEqual(3, shops.Count);
        }

        [TestMethod]
        public void GetTaobaokeListUrlByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            TaobaokeListUrlGetRequest request = new TaobaokeListUrlGetRequest();
            request.Query = "三星";
            request.Nick = "tbtest520";
            request.OuterCode = "123456";
            string rsp = client.Execute(request, new TaobaokeListUrlJsonParser());
            Assert.IsNotNull(rsp);
        }

        [TestMethod]
        public void GetTaobaokeListUrlByXml()
        {
            ITopClient client = TestUtils.GetProductTopClient("xml");
            TaobaokeListUrlGetRequest request = new TaobaokeListUrlGetRequest();
            request.Query = "三星";
            request.Nick = "tbtest520";
            request.OuterCode = "123456";
            string rsp = client.Execute(request, new TaobaokeListUrlXmlParser());
            Assert.IsNotNull(rsp);
        }

        [TestMethod]
        public void GetTaobaokeReportByJson()
        {
            ITopClient client = TestUtils.GetProductTopClient("json");
            TaobaokeListUrlGetRequest request = new TaobaokeListUrlGetRequest();
            request.Query = "三星";
            request.Nick = "tbtest520";
            request.OuterCode = "123456";
            string rsp = client.Execute(request, new TaobaokeListUrlJsonParser());
            Assert.IsNotNull(rsp);
        }
    }
}