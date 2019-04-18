using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    [TestClass]
    public class TestKlasse
    {
        [TestMethod]
        public void ErstelleAddiereRechner()
        {
            Rechner addiereRechner = new Rechner("Addieren");
            Assert.IsNotNull(addiereRechner);
        }
        [TestMethod]
        public void TesteAddiereRechner()
        {
            Rechner addiereRechner = new Rechner("Addieren");
            int ergebnis = addiereRechner.Rechne(3, 5);
            Assert.AreEqual(ergebnis, 8);
        }
        [TestMethod]
        public void TesteAddiereRechnerMitNegativenWerten()
        {
            Rechner addiereRechner = new Rechner("Addieren");
            int ergebnis = addiereRechner.Rechne(3, -5);
            Assert.AreEqual(ergebnis, -2);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TesteAddiereRechnerMitFalschenWerten() {
            Rechner addiereRechner = new Rechner("Addieren");
            int ergebnis = addiereRechner.Rechne(int.MaxValue, 3);
        }
    }
}
