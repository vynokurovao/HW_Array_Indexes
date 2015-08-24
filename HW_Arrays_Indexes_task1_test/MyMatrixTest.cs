using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_Arrays_Indexes_task1;

namespace HW_Arrays_Indexes_task1_test
{
    [TestClass]
    public class MyMatrixTest
    {
        MyMatrix matrix = new MyMatrix(10, 10);

        [TestMethod]
        public void MyMatrix_WithRedusedNumberOfRows()
        {
            matrix.Rows = 6;
            int expected = 6;

            Assert.AreEqual(expected, matrix.Rows);
        }

        [TestMethod]
        public void MyMatrix_WithEnlargedNumberOfRows()
        {
            matrix.Rows = 16;
            int expected = 16;

            Assert.AreEqual(expected, matrix.Rows);
        }

        [TestMethod]
        public void MyMatrix_WithRedusedNumberOfColumns()
        {
            matrix.Columns = 6;
            int expected = 6;

            Assert.AreEqual(expected, matrix.Columns);
        }

        [TestMethod]
        public void MyMatrix_WithEnlargedNumberOfColumns()
        {
            matrix.Columns = 16;
            int expected = 16;

            Assert.AreEqual(expected, matrix.Columns);
        }
    }
}
