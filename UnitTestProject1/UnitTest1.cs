using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    // === Задача 1 ===
    [TestClass]
    public class TestTask1_TribonacciGeneration
    {
        [TestMethod]
        public void Test1_1_TribonacciFirst3Elements()
        {
            int n = 3;
            List<string> result = Sequences.GenerateTribonacciStrings(n);

            Assert.AreEqual(5, result.Count);
            Assert.AreEqual("0: 0 (---)", result[2]);
            Assert.AreEqual("1: 1 (---)", result[3]);
            Assert.AreEqual("2: 1 (1,0000)", result[4]);
        }

        [TestMethod]
        public void Test1_2_TribonacciFirst7Elements()
        {
            int n = 7;
            List<string> result = Sequences.GenerateTribonacciStrings(n);

            Assert.AreEqual(9, result.Count);
            Assert.AreEqual("0: 0 (---)", result[2]);
            Assert.AreEqual("1: 1 (---)", result[3]);
            Assert.AreEqual("2: 1 (1,0000)", result[4]);
            Assert.AreEqual("3: 2 (2,0000)", result[5]);
            Assert.AreEqual("4: 4 (2,0000)", result[6]);
            Assert.AreEqual("5: 7 (1,7500)", result[7]);
            Assert.AreEqual("6: 13 (1,8571)", result[8]);
        }

        [TestMethod]
        public void Test1_3_TribonacciZeroInput()
        {
            int n = 0;
            List<string> result = Sequences.GenerateTribonacciStrings(n);

            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result[0].Contains("Ошибка"));
            Assert.IsTrue(result[0].Contains(">="));
        }

        [TestMethod]
        public void Test1_4_TribonacciNegativeInput()
        {
            int n = -5;
            List<string> result = Sequences.GenerateTribonacciStrings(n);

            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result[0].Contains("Ошибка"));
        }

        [TestMethod]
        public void Test1_5_TribonacciBoundaryCaseN1()
        {
            int n = 1;
            List<string> result = Sequences.GenerateTribonacciStrings(n);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("0: 0 (---)", result[2]);
        }
    }


    // === Задача 2 ===
    [TestClass]
    public class TestTask2_Comparison
    {
                [TestMethod]
                public void Test2_1_FibonacciFirst5Elements()
                {
                    int n = 5;
                    List<string> result = Sequences.GenerateFibonacciStrings(n);

                    Assert.AreEqual(7, result.Count);
                    Assert.AreEqual("0: 0 (---)", result[2]);
                    Assert.AreEqual("1: 1 (---)", result[3]);
                    Assert.AreEqual("2: 1 (1,0000)", result[4]);
                    Assert.AreEqual("3: 2 (2,0000)", result[5]);
                    Assert.AreEqual("4: 3 (1,5000)", result[6]);
                }

                [TestMethod]
                public void Test2_2_TribonacciFirst5Elements()
                {
                    int n = 5;
                    List<string> result = Sequences.GenerateTribonacciStrings(n);

                    Assert.AreEqual(7, result.Count);
                    Assert.AreEqual("0: 0 (---)", result[2]);
                    Assert.AreEqual("1: 1 (---)", result[3]);
                    Assert.AreEqual("2: 1 (1,0000)", result[4]);
                    Assert.AreEqual("3: 2 (2,0000)", result[5]);
                    Assert.AreEqual("4: 4 (2,0000)", result[6]);
                }

                [TestMethod]
                public void Test2_3_FibonacciAndTribonacciAreDifferent()
                {
                    int n = 5;
                    List<string> fib = Sequences.GenerateFibonacciStrings(n);
                    List<string> trib = Sequences.GenerateTribonacciStrings(n);

                    Assert.AreNotEqual(fib[6], trib[6]);
                    Assert.AreEqual("4: 3 (1,5000)", fib[6]);
                    Assert.AreEqual("4: 4 (2,0000)", trib[6]);
                }

                [TestMethod]
                public void Test2_4_TribonacciGrowsFasterThanFibonacci()
                {
                    int n = 10;
                    List<long> fib = Sequences.GenerateFibonacciNumbers(n);
                    List<long> trib = Sequences.GenerateTribonacciNumbers(n);

                    Assert.IsNotNull(fib);
                    Assert.IsNotNull(trib);
                    Assert.IsTrue(trib[9] > fib[9]);
                    Assert.AreEqual(34, fib[9]);
                    Assert.AreEqual(81, trib[9]);
                }

                [TestMethod]
                public void Test2_5_DivisionByZeroHandling()
                {
                    int n = 2;
                    List<string> fib = Sequences.GenerateFibonacciStrings(n);
                    List<string> trib = Sequences.GenerateTribonacciStrings(n);

                    Assert.AreEqual("1: 1 (---)", fib[3]);
                    Assert.AreEqual("1: 1 (---)", trib[3]);
                }
    }

    [TestClass]
    public class TestTask3_GraphVisualization
    { 
            // === Задача 3 ===
            [TestMethod]
            public void Test3_1_FibonacciNumbersFirst5()
            {
                int n = 5;
                List<long> result = Sequences.GenerateFibonacciNumbers(n);

                Assert.IsNotNull(result);
                Assert.AreEqual(5, result.Count);
                Assert.AreEqual(0, result[0]);
                Assert.AreEqual(1, result[1]);
                Assert.AreEqual(1, result[2]);
                Assert.AreEqual(2, result[3]);
                Assert.AreEqual(3, result[4]);
            }

            [TestMethod]
            public void Test3_2_TribonacciNumbersFirst5()
            {
                int n = 5;
                List<long> result = Sequences.GenerateTribonacciNumbers(n);

                Assert.IsNotNull(result);
                Assert.AreEqual(5, result.Count);
                Assert.AreEqual(0, result[0]);
                Assert.AreEqual(1, result[1]);
                Assert.AreEqual(1, result[2]);
                Assert.AreEqual(2, result[3]);
                Assert.AreEqual(4, result[4]);
            }

            [TestMethod]
            public void Test3_3_FibonacciOverflow()
            {
                int n = 100;
                List<long> result = Sequences.GenerateFibonacciNumbers(n);

                Assert.IsNull(result);
            }

            [TestMethod]
            public void Test3_4_TribonacciOverflow()
            {
                int n = 100;
                List<long> result = Sequences.GenerateTribonacciNumbers(n);

                Assert.IsNull(result);
            }

            [TestMethod]
            public void Test3_5_NumericSequencesComparison()
            {
                int n = 8;
                List<long> fib = Sequences.GenerateFibonacciNumbers(n);
                List<long> trib = Sequences.GenerateTribonacciNumbers(n);

                Assert.IsNotNull(fib);
                Assert.IsNotNull(trib);
                Assert.AreEqual(n, fib.Count);
                Assert.AreEqual(n, trib.Count);

                // Проверяем, что последовательности различны
                bool areDifferent = false;
                for (int i = 0; i < n; i++)
                {
                    if (fib[i] != trib[i])
                    {
                        areDifferent = true;
                        break;
                    }
                }
                Assert.IsTrue(areDifferent);
            }
    }
}

