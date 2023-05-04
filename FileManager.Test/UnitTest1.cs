namespace FileManager.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CrearUnArchivo1()
        {
            var writer = new System.IO.StreamWriter(path: "Demo.txt", append: true );
            writer.Write("Demo NadadeNada");
            writer.Close();

            Assert.True( true );
        }
    

        [Fact]
        public void leerUnArchivo()
        {
            var reader = new System.IO.StreamReader(path: "Demo.txt");
            var contenido = reader.ReadToEnd();
            reader.Close();

            Assert.Equal("Demo NadadeNada", contenido  );
        }


        [Fact]
        public void Escribirunarchivo()
        {
            File.AppendAllText(path: "Archivo2", "otro Archivo");

            Assert.True(true);
        }


        [Fact]
        public void CrearUnDirectorio()
        {
            Directory.CreateDirectory("PruebaArchivo");

            var a = new DirectoryInfo("PruebaArchivo");

            

            Assert.True( true );
        }


        [Fact]
        public void DirectorioEliminar()
        {

            var d = new DirectoryInfo("Starwars");

            d.Delete();

            //d.CreateSubdirectory("Galaxy")


            Assert.True(true);
        }
    }
}