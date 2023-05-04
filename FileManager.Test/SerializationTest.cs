using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileManager.Test
{
    public class SerializationTest
    {
        [Fact]
        public void SerializarEnJsonUnObjetoAnonimo()
        {
            var directorio = new
            {
                Name = "Starwars",
                Date = new DateTime(2023, 4, 11, 16, 35, 0)
            };

            var dataJson = JsonSerializer.Serialize(directorio);

            Assert.Equal("Starwars", directorio.Name);
            Assert.Equal("{\"Name\":\"Starwars\",\"Date\":\"2023-04-11T16:35:00\"}", dataJson);
        }


        //[Fact]
        //public void SerializarEnJsonUnDirectorio()
        //{
        //    //Directory.CreateDirectory("Starwars");

        //    var d = new DirectoryInfo("Starwars");
        //    d.Create();

        //    var options = new JsonSerializerOptions()
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve
        //    };

        //    var dJson = JsonSerializer.Serialize(d, options: options);

        //    Assert.True(true);
        //}


        [Fact]
        public void CrearCarpetasApartirDeUnafecha()
        {
            Directory.CreateDirectory("DateTime");
            var d = new DirectoryInfo("DateTime");

            var a = new DateTime(2023, 05, 08);

            a.ToString("año yyyy - MMMM - ddd dd");

            //d.CreateSubdirectory( a.ToString("año yyyy - MMMM - ddd dd"));

            d.CreateSubdirectory($"{a.ToString("yyyy") }/{a.ToString("MMMM")}/{a.ToString("ddd")}{a.ToString("dd")} ");

           
            var writer = new System.IO.StreamWriter(path:$"{a.ToString("año yyyy - MMMM - ddd dd")}.txt", append: true);
            writer.Write("Demo NadadeNada");
            writer.Close();


        }



    }


}
