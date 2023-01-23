namespace Camere.Hotel
{
    public class UnitTest1
    {
        [Fact]
        public void Creazione_Corretta()
        {
           Camera camera = new Camera("123",24,1,true,true,true,120,1);
            Assert.True(camera.Costo == 120);
            Assert.True(camera.Bagno == true);
            Assert.True(camera.Numero == "123");
            Assert.True(camera.Frigo == true);
            Assert.True(camera.Dimensione == 24);
            Assert.True(camera.Persone == 1);
            Assert.True(camera.Posti_letto == 1);
            Assert.True(camera.TV == true);
        }
        [Fact]
        public void test_ModifichaTV()
        {
            Camera camera = new Camera("123", 24, 1, true, true, true, 120, 1);
            camera.Modifica_tv(false);
            Assert.True(camera.TV==false);
        }
        [Fact]
        public void test_ModifichaBagno()
        {
            Camera camera = new Camera("123", 24, 1, true, true, true, 120, 1);
            camera.Modifica_bagno(false);
            Assert.True(camera.Bagno == false);
        }
        [Fact]
        public void test_ModifichaFrigo()
        {
            Camera camera = new Camera("123", 24, 1, true, true, true, 120, 1);
            camera.Modifica_frigo(false);
            Assert.True(camera.Frigo == false);
        }
        [Fact]
        public void test_ModifichaDimensioni()
        {
            Camera camera = new Camera("123", 24, 1, true, true, true, 120, 1);
            camera.Modifica_dimensione(130);
            Assert.True(camera.Dimensione == 130);
            camera.Modifica_dimensione(120);
            Assert.False(camera.Dimensione == 130);
            Assert.Throws<Exception>(() => camera.Modifica_dimensione(-20));

        }
        [Fact]
        public void test_Aggiungi_diminuiscipersone ()
        {
            Camera camera = new Camera("123", 24, 1, true, true, true, 120, 1);
            camera.Aggiungi_per();
            Assert.True(camera.Persone == 2);
            camera.Diminuisci_per();
            Assert.False(camera.Persone == 2);
            Assert.Throws<Exception>(() => camera.Diminuisci_per());

        }
        [Fact]
        public void test_Prezzo_persona()
        {
            Camera camera = new Camera("123", 24, 1, true, true, true, 120, 1);
            Assert.True(camera.prezzo_singola()==120);
            camera.Aggiungi_per();
            Assert.True(camera.prezzo_singola() == 60);

        }
        [Fact]
        public void test_ConfrontaPrezzo()
        {
            Camera camera = new Camera("123", 24, 1, true, true, true, 120, 1);
            Camera camera2 = new Camera("124", 24, 1, true, true, true, 140, 1);
            Assert.True(camera.confronta_Prezzo(camera2) == "la camera più conveniente è quella numero 123");
            Assert.True(camera2.confronta_Prezzo(camera) == "la camera più conveniente è quella numero 123");                    
            Camera camera3 = new Camera("123", 24, 1, true, true, true, 140, 1);
            Camera camera4 = new Camera("124", 24, 1, true, true, true, 120, 1);

            Assert.False(camera3.confronta_Prezzo(camera4) == "la camera più conveniente è quella numero 123");
            Assert.False(camera4.confronta_Prezzo(camera3) == "la camera più conveniente è quella numero 123");

        }
    }
}