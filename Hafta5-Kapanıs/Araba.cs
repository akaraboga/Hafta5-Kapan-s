using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Kapanıs
{
    internal class Araba
    {
       

        DateTime UretimTarihi { get; set; }

        public int SeriNo { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public int KapıSayısı { get; set; }




        /*public Araba(DateTime _uretimTarih,int _seriNo,string _marka,string _model,int _kapıSayı)
        {
            UretimTarihi = _uretimTarih;
            SeriNo = _seriNo;
            Marka = _marka;
            Model = _model;
            KapıSayısı=_kapıSayı;

        }*/

 
        public Araba(DateTime dateime, int serino, string marka, string model, int kapiS)
        {
            UretimTarihi=dateime;
            SeriNo = serino;
            Marka = marka;
            Model = model;
            KapıSayısı = kapiS;

           
        }
        public void bilgi()
        {

            Console.WriteLine("Arabanın markası : {0}", Marka);
            Console.WriteLine("Modeli : {0}", Model);
            Console.WriteLine("Uretim yılı {0}", UretimTarihi);
            Console.WriteLine("Seri No : {0}", SeriNo);
            Console.WriteLine("Kapı Sayısı : {0}", KapıSayısı);
        }

       

    }
}
