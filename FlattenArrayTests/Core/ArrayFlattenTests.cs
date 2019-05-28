using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlattenArray.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FlattenArray.Core.Tests
{
    [TestClass()]
    public class ArrayFlattenTests
    {
        [TestMethod()]
        public void FlatArrayTest()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(new ArrayList() { 1, 2, 3, new ArrayList() { 8, 9, 19 } });
            list.Add(21);
            list.Add(16);
            list.Add(15);

            int[] compare = { 1, 1, 2, 3, 8, 9, 15, 16, 19, 20 };


            Assert.IsFalse(compare.SequenceEqual(ArrayFlatten.FlatArray(list)));

        }

        [TestMethod()]
        public void FlatArrayTest2()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(new ArrayList() { 1, 2, 3, new ArrayList() { 8, 9, 19 } });
            list.Add(20);
            list.Add(16);
            list.Add(15);

            int[] compare = { 1, 1, 2, 3, 8, 9, 15, 16, 19, 20 };


            Assert.IsTrue(compare.SequenceEqual(ArrayFlatten.FlatArray(list)));

        }

        [TestMethod()]
        public void FlatArrayTest3()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(new ArrayList() { 1, 2, 3, new ArrayList() { 8, "a", 19 } });
            list.Add(20);
            list.Add(16);
            list.Add(15);

            int[] compare = { 1, 1, 2, 3, 8, 9, 15, 16, 19, 20 };

            try
            {
                ArrayFlatten.FlatArray(list);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Tipo de dato no soportado")); ;

            }

        }
    }
}