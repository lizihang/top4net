﻿using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Taobao.Top.Api.Request;
using Taobao.Top.Api.Parser;

namespace Taobao.Top.Api.Test.Request
{
    [TestClass]
    public class TradeApiTest
    {
        [TestMethod]
        public void GetSuitesByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            SuitesGetRequest req = new SuitesGetRequest();
            req.ServiceCode = "TADGET_SHOP_TACTIC";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest5");
            string rsp = client.Execute(proxy, new StringParser());
            Console.WriteLine(rsp);
        }

        public void GetTradeDetailByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("json");
            TradeDetailGetRequest req = new TradeDetailGetRequest();
        }

        [TestMethod]
        public void GetRefundByJson()
        {
            ITopClient client = TestUtils.GetDevelopTopClient("xml");
            RefundGetRequest req = new RefundGetRequest();
            req.Fields = "refund_id,address";
            req.Rid = "126628";
            ITopRequest proxy = new TopRequestProxy(req, "tbtest1202");
            string rsp = client.Execute(proxy, new StringParser());
            Console.WriteLine(rsp);
        }
    }
}