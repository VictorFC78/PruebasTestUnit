using BancAvilesLogic;

namespace BancAvilesTest
{
    public class Tests
    {
        Cuenta cuenta;
        [SetUp]
        public void Setup()
        {
            Cliente cliente = new Cliente("Juan", "Fernandez");
            cuenta = new Cuenta(cliente);
        }

        [Test]
        public void TestInicializarSladoCero()
        {
            double saldo = 0;
            Assert.That(cuenta.Saldo, Is.EqualTo(saldo));
            Assert.Pass();
        }
        [Test]
        public void TestIncrementaSaldo()
        {
            double saldo = 10;
            cuenta.Ingresar(saldo);
            Assert.That(cuenta.Saldo, Is.EqualTo(saldo));
        }
        [Test]
        public void TestDecrementaSaldo()
        {
            double saldo = 10;
            cuenta.Extraer(saldo);
            Assert.That(cuenta.Saldo, Is.EqualTo(-10));
        }
        //[Test]
        // public void TestLenStringHelloIs4()
        //{ // Arrange
        //string hello = "Hola";
        // Act
        // int helloLength = hello.Length;
        // Assert
        // Assert.That(helloLength, Is.EqualTo(4)); }
        //}
    }
}