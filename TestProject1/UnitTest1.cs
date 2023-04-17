namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SeTendriaQueCrearUnObjeto_ProductoClase1()
        {
            var productodeclase1 = new ProductoClase1();
            productodeclase1.Precio = 10000;

            Assert.Equal(10000, productodeclase1.Precio);
        }


        [Fact]
        public void ProductoClase1_debeAceptarIVA()
        {
            var productodeclase1 = new ProductoClase1();
            productodeclase1.Precio = 10000;
            var iva = new IVA();
            productodeclase1.Aceptar(iva);

            Assert.Equal(12100, productodeclase1.Aceptar(iva));
        }

        [Fact]
        public void SeTendriaQueCrearUnObjeto_ProductoClase2()
        {
            var productodeclase2 = new ProductoClase2();
            productodeclase2.Precio = 15000;

            Assert.Equal(15000, productodeclase2.Precio);
        }

        [Fact]
        public void ProductoClase2_debeAceptarIVA()
        {
            var productodeclase2 = new ProductoClase2();
            productodeclase2.Precio = 15000;
            var iva = new IVA();
            productodeclase2.Aceptar(iva);

            Assert.Equal(16575, productodeclase2.Aceptar(iva));
        }
    }
}