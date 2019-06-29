using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DataAccess
{
    public class OcphDbContext
    {
      //  public SQLiteConnection Connection { get; set; }
       
        public OcphDbContext() 
        {
           
        }

        public List<Kategori> Categories => GetCategories();

        private List<Kategori> GetCategories()
        {
            var list = new List<Kategori>() {
                new Kategori{ Id=1, Name="Suku"},
                new Kategori{ Id=2, Name="Bunga"},
                new Kategori{ Id=3, Name="Makanan"},
            };
            return list;
        }



        public List<Kata> Words => GetWords();

        private List<Kata> GetWords()
        {
            return new List<Kata> {
                new Kata{ Id=1, KategoriId=1, Nilai="Dani"},
                new Kata{ Id=2, KategoriId=1, Nilai="Asmat"},
                 new Kata{ Id=3, KategoriId=2, Nilai="Mawar"},
                new Kata{ Id=4, KategoriId=2, Nilai="Melati"}
            };
        }
    }
}
