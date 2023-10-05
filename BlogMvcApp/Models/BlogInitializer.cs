using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                new Category(){KategoriAdi="Asp.net MVC"},
                new Category(){KategoriAdi="Asp.net WebForm"},
                new Category(){KategoriAdi="Windows Form"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik="C# Delegates Hakkında# Delegates Hakkında# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay = true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=1 },
                new Blog(){Baslik="C# Dels Hakkında# Delegates Hakkında# Delegates Hakkında", Aciklama="C# Delegates Hakkındegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-1), Anasayfa=true, Onay = true, Icerik="C# Delegates HakkındaC# Delegates HakkındaCgates Hakkında", Resim="1.jpg", CategoryId=2 },
                new Blog(){Baslik="C# Delegates Hakkı# Delegates Hakkında# Delegates Hakkındanda", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay = true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=1 },
                new Blog(){Baslik="C# Delegata", Aciklama="C# Delegates Hakkıntes Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-2), Anasayfa=false, Onay = true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="2.jpg", CategoryId=3 },
                new Blog(){Baslik="C# Delegates H# Delegates Hakkında# Delegates Hakkındaakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-7), Anasayfa=true, Onay = true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=4 },
                new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Htes Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay = false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="3.jpg", CategoryId=1 },
                new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-5), Anasayfa=true, Onay = true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=4 },
                new Blog(){Baslik="C# Delegate# Delegates Hakkında# Delegates Hakkındas Hakkında", Aciklama="C# Delegates# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-4), Anasayfa=true, Onay = true, Icerik="C# Delegates HakkındaC# Delegates Hakkınelegates Hakkında", Resim="5.jpg", CategoryId=1 },
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}