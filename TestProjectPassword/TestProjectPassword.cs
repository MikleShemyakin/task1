using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp1;

namespace TestProjectPassword
{
    [TestClass]
    public class TestProjectPassword
    {
        [TestMethod]
        public void Valid_parol()
        {
            Auth auth= new Auth();
           string actual = auth.TestPassword("W4fgh&7");
           string  expected = "Пароль отличный!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_Length_valid()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("W4fgh&7890");
            string expected = "Пароль отличный!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Length_parol()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("W4fgh&78901");
            string expected = "Пароль дликкый!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Short_parol()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("W4fgh&");
            string expected = "Пароль короткий!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void No_digit()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("Wfgh&su");
            string expected = "Пароль должен содержать цифры!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Valid_and_Big_symvol()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("w4fgh&7reD");
            string expected = "Пароль отличный!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void No_Big_symvol()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("w4fgh&7red");
            string expected = "Пароль должен содержать символы в верхнем регистре!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void No_Low_symvol()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("W4FGH&7RED");
            string expected = "Пароль должен содержать симнволы в нижнем регистре!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void No_Spec_symvol()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("W4fgh87");
            string expected = "Пароль должен содержать спецсимволы!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Povtor_2_symvol()
        {
            Auth auth = new Auth();
            string actual = auth.TestPassword("W4ffh&7");
            string expected = "В пароле не должно быть подряд идущих повторяющихся символов!";
            Assert.AreEqual(expected, actual);
        }
    }
}
