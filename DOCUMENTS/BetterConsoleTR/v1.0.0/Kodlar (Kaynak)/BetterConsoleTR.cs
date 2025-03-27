using System;
using System.Collections.Generic;
using System.Linq;

namespace BetterConsolePlugin
{
    /// <summary>
    /// Gelişmiş konsol çıktıları ve etkileşimleri sağlayan ana sınıf.
    /// Renkli metinler, olay bazlı çıktılar, ayraçlı metinler ve çizgi çizme gibi işlevler sunar.
    /// </summary>
    public class GelismisKonsol
    {
        /// <summary>
        /// Varsayılan metin rengi.  <see cref="Yaz"/> metodunda renk belirtilmezse bu renk kullanılır.
        /// </summary>
        public ConsoleColor VarsayilanMetinRengi { get; set; } = Console.ForegroundColor;

        /// <summary>
        /// Olay türü belirtildiğinde, olayın etrafındaki ayraçların varsayılan rengi.
        /// <see cref="Yaz"/> metodunda olay türü belirtilmişse, ayraçlar bu renkte gösterilir.
        /// </summary>
        public ConsoleColor VarsayilanAyracRengi { get; set; } = Console.ForegroundColor;

        /// <summary>
        /// <see cref="Yaz"/> metodu çağrıldığında, olay parametresi belirtilmezse kullanılacak varsayılan olay türü.
        /// Null ise, varsayılan olarak bir olay türü kullanılmaz (olay ayracı gösterilmez).
        /// </summary>
        private Olay? VarsayilanOlay { get; set; } = null;

        /// <summary>
        /// <see cref="Yaz"/> metodu çağrıldığında, satirAtla parametresi belirtilmezse,
        /// varsayılan olarak metnin sonuna yeni satır karakteri eklenip eklenmeyeceğini belirler.
        /// </summary>
        public bool VarsayilanSatirAtla { get; set; } = false;

        private AyracTuru _varsayilanAyracTuru = AyracTuru.Kare;
        private string _solAyrac = "[";
        private string _sagAyrac = "]";

        /// <summary>
        /// <see cref="Yaz"/> metodu çağrıldığında, olay türü belirtilirse, olayın etrafında
        /// kullanılacak varsayılan ayraç türü.
        /// </summary>
        public AyracTuru VarsayilanAyracTuru
        {
            get { return _varsayilanAyracTuru; }
            set
            {
                // Ayraç türü değiştiğinde, ayraç karakterlerini güncelle.
                if (_varsayilanAyracTuru != value)
                {
                    _varsayilanAyracTuru = value;
                    AyracKarakterleriniGuncelle();
                }
            }
        }

        /// <summary>
        /// Seçilen <see cref="VarsayilanAyracTuru"/> değerine göre ayraç karakterlerini (_solAyrac ve _sagAyrac) günceller.
        /// Bu metot, <see cref="VarsayilanAyracTuru"/> özelliği değiştirildiğinde otomatik olarak çağrılır.
        /// </summary>
        private void AyracKarakterleriniGuncelle()
        {
            switch (_varsayilanAyracTuru)
            {
                case AyracTuru.Kare:
                    _solAyrac = "[";
                    _sagAyrac = "]";
                    break;
                case AyracTuru.Kivrimli:
                    _solAyrac = "{";
                    _sagAyrac = "}";
                    break;
                case AyracTuru.Koseli:
                    _solAyrac = "(";
                    _sagAyrac = ")";
                    break;
                case AyracTuru.Cizgi:
                    _solAyrac = "|";
                    _sagAyrac = "|";
                    break;
                case AyracTuru.Bos:
                    _solAyrac = "";
                    _sagAyrac = "";
                    break;
                case AyracTuru.CiftTirnak:
                    _solAyrac = "\"";
                    _sagAyrac = "\"";
                    break;
                case AyracTuru.Tirnak:
                    _solAyrac = "'";
                    _sagAyrac = "'";
                    break;
                case AyracTuru.BuyukKucuk:
                    _solAyrac = "<";
                    _sagAyrac = ">";
                    break;
                default:
                    _solAyrac = "[";
                    _sagAyrac = "]";
                    break;
            }
        }

        /// <summary>
        /// Konsola metin yazar. Metin rengi, olay türüne göre ayraçlar ve yeni satır karakteri eklenebilir.
        /// </summary>
        /// <param name="metin">Yazılacak metin. Metin null veya boş olamaz.</param>
        /// <param name="olay">Olay türü (isteğe bağlı). Olay türü belirtilirse, metnin solunda olay türünü belirten bir ayraç gösterilir.</param>
        /// <param name="metinRengi">Metin rengi (isteğe bağlı). Belirtilmezse <see cref="VarsayilanMetinRengi"/> kullanılır.</param>
        /// <param name="satirAtla">Yeni satıra geçilip geçilmeyeceği (isteğe bağlı). Belirtilmezse <see cref="VarsayilanSatirAtla"/> kullanılır.</param>
        /// <exception cref="ArgumentNullException">Eğer <paramref name="metin"/> null ise fırlatılır.</exception>
        public void Yaz(string metin, Olay? olay = null, ConsoleColor? metinRengi = null, bool? satirAtla = null)
        {
            // Metnin null olup olmadığını kontrol et
            if (metin == null)
            {
                throw new ArgumentNullException(nameof(metin), "Metin null olamaz.");
            }

            // Kullanılacak değerleri, parametreler belirtilmemişse varsayılan değerlerden al.
            ConsoleColor kullanilacakMetinRengi = metinRengi ?? this.VarsayilanMetinRengi;
            ConsoleColor ayracRengi = this.VarsayilanAyracRengi;
            Olay? kullanilacakOlay = olay ?? this.VarsayilanOlay;
            bool kullanilacakSatirAtla = satirAtla ?? this.VarsayilanSatirAtla;
            AyracTuru? kullanilacakAyracTuru = this._varsayilanAyracTuru; // Kullanılacak ayraç türünü al.

            string olayMetni = "";
            ConsoleColor olayRengi = ConsoleColor.White;

            // Eğer bir olay türü belirtilmişse, olay metnini ve rengini belirle.
            if (kullanilacakOlay != null)
            {
                switch (kullanilacakOlay)
                {
                    case Olay.Bilgi:
                        olayMetni = "INFO";
                        olayRengi = ConsoleColor.Blue;
                        break;
                    case Olay.Hata:
                        olayMetni = "HATA";
                        olayRengi = ConsoleColor.Red;
                        break;
                    case Olay.Uyari:
                        olayMetni = "UYARI";
                        olayRengi = ConsoleColor.Yellow;
                        break;
                    case Olay.Basarili:
                        olayMetni = "BASARILI";
                        olayRengi = ConsoleColor.Green;
                        break;
                    case Olay.Soru:
                        olayMetni = "SORU";
                        olayRengi = ConsoleColor.Magenta;
                        break;
                    case Olay.Debug:
                        olayMetni = "DEBUG";
                        olayRengi = ConsoleColor.Gray;
                        break;
                    case Olay.Kritik:
                        olayMetni = "KRITIK";
                        olayRengi = ConsoleColor.DarkRed;
                        break;
                    case Olay.Test:
                        olayMetni = "TEST";
                        olayRengi = ConsoleColor.Cyan;
                        break;
                    default:
                        olayMetni = "BILINMEYEN";
                        olayRengi = ConsoleColor.DarkGray;
                        break;
                }

                // Olay ayracını yazdır.
                Console.ForegroundColor = ayracRengi;
                Console.Write(_solAyrac);

                // Olay metnini yazdır (eğer varsa).
                if (!string.IsNullOrEmpty(olayMetni))
                {
                    Console.ForegroundColor = olayRengi;
                    Console.Write(olayMetni);
                }

                Console.ForegroundColor = ayracRengi;
                Console.Write(_sagAyrac + " "); // Sağ ayracı ve boşluğu ekle.
            }

            // Metni yazdır.
            Console.ForegroundColor = kullanilacakMetinRengi;
            if (kullanilacakSatirAtla)
            {
                Console.WriteLine(metin);
            }
            else
            {
                Console.Write(metin);
            }

            // Renkleri sıfırla (önemli!).
            Console.ResetColor();
        }

        /// <summary>
        /// Konsolda belirtilen renkte ve karakterde bir çizgi çizer.
        /// </summary>
        /// <param name="renk">Çizgi rengi.</param>
        /// <param name="karakter">Çizgi karakteri (varsayılan '-').</param>
        public void CizgiCiz(ConsoleColor renk, char karakter = '-')
        {
            Console.ForegroundColor = renk;
            Console.WriteLine(new string(karakter, Console.WindowWidth));
            Console.ResetColor(); // Renkleri sıfırlamayı unutma!
        }
    }

    /// <summary>
    /// Olay türlerini tanımlar. Bu enum, <see cref="GelismisKonsol.Yaz"/> metodunda kullanılır.
    /// </summary>
    public enum Olay { Bilgi, Hata, Uyari, Basarili, Soru, Debug, Kritik, Test }

    /// <summary>
    /// Ayraç türlerini tanımlar. Bu enum, <see cref="GelismisKonsol"/> sınıfında kullanılır.
    /// </summary>
    public enum AyracTuru { Bos, Kare, Kivrimli, Koseli, Cizgi, Tirnak, CiftTirnak, BuyukKucuk }


    /// <summary>
    /// Tablo verilerini ve biçimlendirmesini yönetir. Tabloyu konsola yazdırmak için kullanılır.
    /// </summary>
    public class Tablo
    {
        /// <summary>
        /// Tablo başlıkları. Her bir eleman bir sütun başlığını temsil eder.
        /// </summary>
        public string[] Basliklar { get; set; }

        /// <summary>
        /// Tablo verileri. Her bir iç dizi bir satırı, her bir object ise bir hücreyi temsil eder.
        /// Farklı türlerdeki verileri (string, int, double, vb.) tutmak için object dizisi kullanılır.
        /// </summary>
        public List<object[]> Veriler { get; set; } = new List<object[]>();

        /// <summary>
        /// Başlık rengi (isteğe bağlı). Belirtilmezse varsayılan konsol rengi kullanılır.
        /// </summary>
        public ConsoleColor? BaslikRengi { get; set; }

        /// <summary>
        /// Veri rengi (isteğe bağlı). Belirtilmezse varsayılan konsol rengi kullanılır.
        /// </summary>
        public ConsoleColor? VeriRengi { get; set; }

        /// <summary>
        /// Tabloya yeni bir satır ekler.
        /// </summary>
        /// <param name="satirVerileri">Satır verileri (her biri bir sütunu temsil eder).
        ///                            Bu parametre, 'params' anahtar kelimesi sayesinde,
        ///                            metodu çağırırken sanki bir dizi veriyormuşsunuz gibi,
        ///                            verileri virgülle ayırarak girmenizi sağlar.</param>
        /// <exception cref="ArgumentException">Eklenen satırın sütun sayısı, başlıkların sütun sayısıyla uyuşmuyorsa fırlatılır.</exception>
        public void SatirEkle(params object[] satirVerileri)
        {
            if (Basliklar != null && Basliklar.Length > 0 && satirVerileri.Length != Basliklar.Length)
            {
                throw new ArgumentException("Eklenen satırın sütun sayısı başlıkla uyumsuz!", nameof(satirVerileri));
            }
            Veriler.Add(satirVerileri);
        }

        /// <summary>
        /// Tablo başlıklarını ekler veya değiştirir.
        /// </summary>
        /// <param name="basliklar">Başlıklar.  Bu parametre, 'params' anahtar kelimesi sayesinde,
        ///                           metodu çağırırken sanki bir dizi veriyormuşsunuz gibi,
        ///                           başlıkları virgülle ayırarak girmenizi sağlar.</param>
        ///  <exception cref="ArgumentException">Başlık sütun sayısı, mevcut veri sütun sayısı ile uyumsuz ise fırlatılır.</exception>
        public void BaslikEkle(params string[] basliklar)
        {
            if (Veriler.Count > 0 && Veriler[0].Length != basliklar.Length)
            {
                throw new ArgumentException("Başlık sütun sayısı mevcut veri sütun sayısı ile uyumsuz!", nameof(basliklar));
            }

            Basliklar = basliklar;
        }

        /// <summary>
        /// Tabloyu konsola yazdırır.
        /// </summary>
        public void Yazdir()
        {
            ConsoleColor baslikRengi = BaslikRengi ?? ConsoleColor.Cyan;
            ConsoleColor veriRengi = VeriRengi ?? ConsoleColor.White;

            if ((Basliklar == null || Basliklar.Length == 0) && (Veriler == null || Veriler.Count == 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uyarı: Başlık veya veri yok!");
                Console.ResetColor();
                return;
            }

            int sutunSayisi = 0;
            if (Basliklar != null)
                sutunSayisi = Basliklar.Length;
            else if (Veriler.Count > 0)
                sutunSayisi = Veriler[0].Length;

            int[] sutunGenislikleri = new int[sutunSayisi];

            if (Basliklar != null)
            {
                for (int i = 0; i < sutunSayisi; i++)
                {
                    sutunGenislikleri[i] = Basliklar[i].Length;
                }
            }

            foreach (var satir in Veriler)
            {
                if (satir.Length != sutunSayisi)
                {
                    throw new ArgumentException("Satır sütun sayısı olması gerekenden farklı!");
                }

                for (int i = 0; i < sutunSayisi; i++)
                {
                    sutunGenislikleri[i] = Math.Max(sutunGenislikleri[i], satir[i]?.ToString().Length ?? 0);
                }
            }

            if (Basliklar != null)
            {
                Console.ForegroundColor = baslikRengi;
                for (int i = 0; i < sutunSayisi; i++)
                {
                    Console.Write(Basliklar[i].PadRight(sutunGenislikleri[i] + 2));
                }
                Console.WriteLine();
            }

            if (Basliklar != null || Veriler.Count > 0)
            {
                Console.ForegroundColor = (Basliklar != null) ? baslikRengi : veriRengi;
                Console.WriteLine(new string('-', sutunGenislikleri.Sum() + (sutunSayisi * 2)));
            }

            Console.ForegroundColor = veriRengi;
            foreach (var satir in Veriler)
            {
                for (int i = 0; i < sutunSayisi; i++)
                {
                    Console.Write(satir[i]?.ToString().PadRight(sutunGenislikleri[i] + 2));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }


    /// <summary>
    /// Bir menü öğesini temsil eder.
    /// </summary>
    public class MenuOgesi
    {
        /// <summary>
        /// Menü öğesinin metni (örneğin, "Yeni Oyun").
        /// </summary>
        public string Metin { get; set; }

        /// <summary>
        /// Menü öğesinin açıklaması (isteğe bağlı) (örneğin, "Yeni bir oyun başlatır.").
        /// </summary>
        public string Aciklama { get; set; }

        /// <summary>
        /// Menü öğesi seçildiğinde çalıştırılacak eylem (Action).
        /// </summary>
        public Action Eylem { get; set; }


        /// <summary>
        /// Yeni bir menü öğesi oluşturur.
        /// </summary>
        /// <param name="metin">Menü öğesinin metni.</param>
        /// <param name="eylem">Menü öğesi seçildiğinde çalıştırılacak eylem.</param>
        /// <param name="aciklama">Menü öğesinin açıklaması (isteğe bağlı).</param>
        public MenuOgesi(string metin, Action eylem, string aciklama = null)
        {
            Metin = metin;
            Eylem = eylem;
            Aciklama = aciklama;
        }
    }

    /// <summary>
    /// Konsol menüsünü oluşturur ve yönetir. Kullanıcıya seçenekler sunar ve seçilen seçeneğe göre işlem yapar.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Menü öğeleri listesi.
        /// </summary>
        public List<MenuOgesi> Ogeler { get; set; }

        /// <summary>
        /// Seçili menü öğesinin rengi (isteğe bağlı). Belirtilmezse varsayılan konsol rengi kullanılır.
        /// </summary>
        public ConsoleColor? SecimRengi { get; set; }

        /// <summary>
        /// Seçili olmayan menü öğelerinin rengi (isteğe bağlı). Belirtilmezse varsayılan konsol rengi kullanılır.
        /// </summary>
        public ConsoleColor? NormalOgeRengi { get; set; }

        /// <summary>
        /// Yeni bir menü oluşturur.
        /// </summary>
        /// <param name="ogeler">Menü öğeleri listesi.</param>
        /// <param name="secimRengi">Seçili menü öğesinin rengi (isteğe bağlı).</param>
        /// <param name="normalOgeRengi">Seçili olmayan menü öğelerinin rengi (isteğe bağlı).</param>
        public Menu(List<MenuOgesi> ogeler, ConsoleColor? secimRengi = null, ConsoleColor? normalOgeRengi = null)
        {
            Ogeler = ogeler;
            SecimRengi = secimRengi;
            NormalOgeRengi = normalOgeRengi;
        }

        /// <summary>
        /// Menüyü oluşturur, kullanıcıya seçenekleri sunar ve seçilen seçeneğe göre eylemi gerçekleştirir.
        /// </summary>
        public void Olustur()
        {
            int seciliOge = 0;
            ConsoleKeyInfo basilanTus;

            do
            {
                Console.CursorVisible = false;
                if (Console.CursorTop >= Ogeler.Count)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - Ogeler.Count);
                }

                int i = 0;
                foreach (var oge in Ogeler)
                {
                    string prefix = (i == seciliOge) ? ">" : " ";
                    Console.ForegroundColor = (i == seciliOge) ? (SecimRengi ?? ConsoleColor.Yellow) : (NormalOgeRengi ?? ConsoleColor.White);

                    if (string.IsNullOrEmpty(oge.Aciklama))
                    {
                        Console.WriteLine($"{prefix}{oge.Metin}");
                    }
                    else
                    {
                        Console.WriteLine($"{prefix}{oge.Metin,-20} : {oge.Aciklama}");
                    }

                    i++;
                }

                basilanTus = Console.ReadKey(true);

                switch (basilanTus.Key)
                {
                    case ConsoleKey.UpArrow:
                        seciliOge = (seciliOge - 1 + Ogeler.Count) % Ogeler.Count;
                        break;
                    case ConsoleKey.DownArrow:
                        seciliOge = (seciliOge + 1) % Ogeler.Count;
                        break;
                }

            } while (basilanTus.Key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            Console.ResetColor();

            Ogeler[seciliOge].Eylem();
        }
    }
}