﻿using LagoVista.Core.Diagnostics.ConsoleProxy;
using LagoVista.Core.Rpc.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagoVista.Core.Rpc.Tests.Diagnostics
{
    [TestClass]
    public class DiagnosticsTest
    {
        [TestMethod]
        public void ConsoleProxyFactory_Create_ReturnsNonNull()
        {
            var proxyFactory = new ConsoleProxyFactory(new ConsoleWriter());
            var subject = new ProxySubject();
            var consoleProxy = proxyFactory.Create<IProxySubject>(subject);
            Assert.IsNotNull(consoleProxy);
        }

        [TestMethod]
        public void ConsoleProxyFactory_Create_ReturnsCorrectType()
        {
            var proxyFactory = new ConsoleProxyFactory(new ConsoleWriter());
            var subject = new ProxySubject();
            var consoleProxy = proxyFactory.Create<IProxySubject>(subject);
            Assert.IsInstanceOfType(consoleProxy, typeof(IProxySubject));
        }

        [TestMethod]
        public void ConsoleProxyFactory_ProxyExecutesWithParam()
        {
            var proxyFactory = new ConsoleProxyFactory(new ConsoleWriter());
            var subject = new ProxySubject();
            var consoleProxy = proxyFactory.Create<IProxySubject>(subject);
            var value = consoleProxy.Echo(ProxySubject.EchoValueConst);
            Assert.AreEqual(ProxySubject.EchoValueConst, value);
        }

        [TestMethod]
        public void ConsoleProxyFactory_ProxyExecutesWithoutParam()
        {
            var proxyFactory = new ConsoleProxyFactory(new ConsoleWriter());
            var subject = new ProxySubject();
            var consoleProxy = proxyFactory.Create<IProxySubject>(subject);
            var value = consoleProxy.SkipMe();
            Assert.AreEqual(ProxySubject.EchoValueConst, value);
        }
    }
}
