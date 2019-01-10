using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhbarDosyasıProgramı
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aslında databaseden isimler liste halinde alınıp tutulmalı
            //Klasördeki dosyaların isimleri liste halinde alınıp karşılaştırma yapılmalı
            //Karşılaştırma yapılacak klasörün adresi seçilir
            Console.WriteLine("Değiştirmek istediğiniz klasörün adresini giriniz: ");
            string pathA = Console.ReadLine();

            string[] klasorAd = Directory.GetDirectories(pathA);

            foreach (string dir in klasorAd)
            {
                //listeye yazdırdığı kısım
                klasorAd.Add(Path);
            }


       
            //Databaseden klasör isimlerinin bulunduğu klasör seçilir
            Console.WriteLine("Karşılaştırmak istediğiniz eski klasörün adresini giriniz: ");
            string pathB = Console.ReadLine();

            List<string> db = new List<string>();

            using (SqlConnection sqlConn = new SqlConnection(string.Format(dosyaAdi)))
            {
                using (SqlCommand sqlComm = new SqlCommand(string.Format("SELECT k_ihbarlar FROM ihb_dosyaNo ", unitID), sqlConn))
                {
                    try
                    {
                        sqlConn.Open();
                        using (SqlDataReader sqlReader = sqlComm.ExecuteReader())
                        {
                            if (sqlReader.HasRows)
                            {
                                while (sqlReader.Read())
                                {
                                    //Employee employee = new Employee()
                                    {
                                        //ID= sqlReader["ID"].ToString(),
                                        //Name = StaticField.id_ID.TextInfo.ToTitleCase(sqlReader["Name"].ToString())
                                    };
                                //employees.Add(employee);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Liste alınamadı");
                    }

            //return employees;
        }
    }
}

            //string pathA = @"C:\Users\fdery\Desktop\Ihbarlar\AnadoluSigorta";  
            //string pathB = @"C:\Users\fdery\Desktop\Eski Ihbarlar\AnadoluSigorta";  

 
            //Bu iki klasörler karşılaştırılır

            System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(pathA);  
            System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(pathB);
 
            IEnumerable<System.IO.FileInfo> list1 = dir1.GetFiles("*.*", System.IO.SearchOption.AllDirectories);  
            IEnumerable<System.IO.FileInfo> list2 = dir2.GetFiles("*.*", System.IO.SearchOption.AllDirectories); 

            //IhbarDosyasıProgramı myFileCompare = new klasorKarsilastir();  


            //var queryCommonFiles = list1.Intersect(list2, myFileCompare);  
  
            //if (queryCommonFiles.Count() > 0)  
            //{  
            //    Console.WriteLine("The following files are in both folders:");  
            //    foreach (var v in queryCommonFiles)  
            //    {  
            //        Console.WriteLine(v.FullName); //shows which items end up in result list  
            //    }  
            //}


            //Eşleşen isimdeki klasörler yeni bir klasöre taşınır.
            //Yeni klasörlerin isimleri eşleşmedeki klasörlerin ismi olacak

            //İşlemin bittiğine haber ver
            Console.WriteLine("İslem başarıyla gerçekleşti!");



        }

        //public static klasorSayisi(string x)
        //{
        //    x = x+@?\?;
        //    //Hesaplama
        //    String[] all_files=Directory.GetFileSystemEntries(x);
        //    //Döngü
        //    foreach(string klasorler in all_files)
        //    {
        //        if(Directory.Exists(klasorler ))
        //        {
        //        GetDirectoryFileCount(klasorler );
        //        }
        //        else
        //        {
        //        klasorler_count++;
        //        }
        //    }
        //    return klasorler_count;

        //}

        public static string klasorOlustur()
        {
            //Directory.CreateDirectory("D:\\YeniKlasor");
            //String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\YeniKlasör";
            //DirectoryInfo _info = Directory.CreateDirectory(path);
            //Console.WriteLine(_info.FullName);

            string path = "AnadoluSigorta";
            Directory.CreateDirectory("C:\\YeniKlasör"+path);

            return path;
        }

        public static string klasorKarsilastir()
        {
            return null;
        }

        public static string klasorTasi()
        {
            try
            {
                string source = @pathA;
                string destination = @path;
                //eski klasörün ismini kendi alması gerekiyor ve taşınan yeri de kendi alması gerekiyor
                //Directory.Move(@"C:\Users\fdery\Desktop\Ihbarlar\AnadoluSigorta", @"C:\YeniKlasör");    
                Directory.Move(source,destination);
            }
            catch (Exception)
            {
                
                throw;
            }

            //return düzeltilmeli
            return null;
        }

        public static string klasorAdiniDegistir()
        {

            return null;
        }

    }
}
