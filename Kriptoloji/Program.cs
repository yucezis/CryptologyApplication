using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Kriptoloji
{
    class Program
    {
        static string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
         
        public static string KaydırmalıSifreleme(string metin, int kaydirma)
        {
            metin = metin.ToUpper();

            string temizMetin = "";

            foreach (char c in metin)        
            {                                 
                if (alfabe.Contains(c))
                {
                    temizMetin += c;
                }
            }

            
            string sonuc = "";
            foreach (char c in temizMetin)               
            {
                int index = alfabe.IndexOf(c);           
                int yeniIndex = (index + kaydirma) % alfabe.Length;      
                sonuc += alfabe[yeniIndex];          
            }

            return sonuc;
        }

        static string DogrusalSifrele(string metin, int a, int b)
        {
            metin = metin.ToUpper();   


            string temizMetin = "";

            foreach (char c in metin) 
            {
                if (alfabe.Contains(c))
                {
                    temizMetin += c;
                }
            }

            string sonuc = "";

            foreach (char c in temizMetin)                     
            {
                    int x = alfabe.IndexOf(c);    
                    int yeniIndex = (a * x + b) % alfabe.Length;    
                    sonuc += alfabe[yeniIndex];  
            }

            return sonuc;
        }

        static string YerDegistirmeAlfabeIle(string metin)
        {
            string yeniAlfabe = "ZÜYVUTŞSRPÖONMLKJİIHĞGFEDÇCBA"; 
            metin = metin.ToUpper(); 

            string temizMetin = "";

            foreach (char c in metin) 
            { 
                if (alfabe.Contains(c))
                {
                    temizMetin += c;
                }
            }


            string sonuc = "";

            foreach (char c in temizMetin)       
            {
                    int index = alfabe.IndexOf(c); 
                    sonuc += yeniAlfabe[index];  
                
            }

            return sonuc;
        }

        static string PermutasyonSifrele(string mesaj4, int[] anahtar4)
        {
            
            mesaj4 = mesaj4.ToUpper(); 

            string temizMesaj = "";

            foreach (char c in mesaj4) 
            {
                if (alfabe.Contains(c))
                {
                    temizMesaj += c;
                }
            }

           
            int m = anahtar4.Length; 

            while (temizMesaj.Length % m != 0) 
            {
                temizMesaj += "Ğ";
            }

            string sifreli = "";

            for (int i = 0; i < temizMesaj.Length; i += m)  
            {
                char[] blok = new char[m];

                for (int j = 0; j < m; j++)
                {
                    int hedefIndex = anahtar4[j] - 1;
                    blok[j] = temizMesaj[i + hedefIndex];

                    sifreli += new string(blok);
                }
            }

            return sifreli;
        }


        static string alfabe2 = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZĞ";

        static char[,] MatrisYap(string metin) 
        {
            char[,] matris = new char[6, 5];
            int index = 0;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 5; j++)
                    matris[i, j] = metin[index++];
            return matris;
        }

        
        static (int, int) KonumBul(char[,] matris, char harf)
        {                                       
            for (int i = 0; i < 6; i++)         
                for (int j = 0; j < 5; j++)
                    if (matris[i, j] == harf)
                        return (i, j);
            return (-1, -1); 
        }

        static string DortKareSifrele(string metin)
        {
            
            char[,] solUst = MatrisYap(alfabe2);                        
            char[,] sagUst = MatrisYap("KSZFEPİŞLCRBGOAÜYÇHTĞUJDÖMVNIĞ"); 
            char[,] solAlt = MatrisYap("UNJPZRBÜŞEAÇKCFMYGİODTIHSLĞÖVĞ"); 
            char[,] sagAlt = MatrisYap(alfabe2);                          

            metin = metin.ToUpper();                    
            string temiz = "";
            foreach (char c in metin)                 
            {                                          
                if (alfabe2.Contains(c))               
                    temiz += c;
            }

            
            if (temiz.Length % 2 != 0)      
                temiz += 'Ğ';                
            string sifreli = "";

            for (int i = 0; i < temiz.Length; i += 2)     
            {                                          
                                                       
                char h1 = temiz[i];            
                char h2 = temiz[i + 1];

                var (r1, c1) = KonumBul(solUst, h1);   
                var (r2, c2) = KonumBul(sagAlt, h2);  

                char yeni1 = sagUst[r1, c2];    
                char yeni2 = solAlt[r2, c1];    

                sifreli += $"{yeni1}{yeni2}"; 
            }

            return sifreli;
        }


        static string SayiAnahtarliYerDegistirme(string metin, int sutunSayisi)
        {

            metin = metin.ToUpper();


            string temizMetin = "";        
                                           
            foreach (char c in metin)    
            {
               if (alfabe.Contains(c))
               {
                        temizMetin += c;
               }
            }


            int toplamHane = (int)Math.Ceiling((double)temizMetin.Length / sutunSayisi) * sutunSayisi;  
            temizMetin = temizMetin.PadRight(toplamHane, 'Ğ');

            int satirSayisi = temizMetin.Length / sutunSayisi; 
            char[,] tablo = new char[satirSayisi, sutunSayisi]; 

            int index = 0;
            for (int i = 0; i < satirSayisi; i++)      
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    tablo[i, j] = temizMetin[index++];
                }
            }

            string sifreliMetin = "";            
            for (int j = 0; j < sutunSayisi; j++)  
            {
               for (int i = 0; i < satirSayisi; i++)
               {
                    sifreliMetin += tablo[i, j];
               }
            }

            return sifreliMetin;
        }
        


        public static string RotaSifreleme(string metin7, int satirlar, int sutunlar)
        {
            
            metin7 = metin7.ToUpper();

            
            string temizMetin = "";
            foreach (char c in metin7)      
            {
                if (alfabe.Contains(c))
                {
                    temizMetin += c;
                }
            }

            int toplamHane = satirlar * sutunlar;        
            if (temizMetin.Length < toplamHane)          
            {
                temizMetin = temizMetin.PadRight(toplamHane, 'Ğ');
            }

            char[,] matrix = new char[satirlar, sutunlar];  
            int index = 0;
            for (int i = 0; i < satirlar; i++)      
            {
                for (int j = 0; j < sutunlar; j++)
                {
                    matrix[i, j] = temizMetin[index++];
                }
            }

            string sifreli = "";
            int top = 0, bottom = satirlar - 1;
            int left = 0, right = sutunlar - 1;

            while (top <= bottom && left <= right)
            {
               
                for (int j = left; j <= right; j++)   
                    sifreli += matrix[top, j];
                top++;

                
                for (int i = top; i <= bottom; i++)   
                    sifreli += matrix[i, right];     
                right--;

               
                if (top <= bottom)                       
                {                                        
                    for (int j = right; j >= left; j--)
                        sifreli += matrix[bottom, j];
                    bottom--;
                }

              
                if (left <= right)                         
                {
                    for (int i = bottom; i >= top; i--)
                        sifreli += matrix[i, left];
                    left++;
                }
            }                                            

            return sifreli;
        }


        public static string ZigzagSifreleme(string metin8, int key8)
        {
            
            metin8 = metin8.ToUpper();

            string temizMetin = "";
            foreach (char c in metin8)      
            {
                if (alfabe.Contains(c))
                {
                    temizMetin += c;
                }
            }

            if (key8 == 1)
            {
                return temizMetin;
            }

            string[] zigzag = new string[key8];  
            for (int i = 0; i < key8; i++)     
            {
                zigzag[i] = ""; 
            }

            int currentRow = 0; 
            bool goingDown = true;

            foreach (char c in temizMetin) 
            {
                zigzag[currentRow] += c;  

                if (goingDown)   
                {
                    currentRow++;  

                    if (currentRow == key8) 
                    {
                        goingDown = false;      
                        currentRow = key8 - 2;  
                    }
                }
                else 
                {
                    currentRow--;  
                    if (currentRow < 0)
                    {
                        goingDown = true;   
                        currentRow = 1;
                    }
                }
            }

            string sifreliMetin8 = "";
            foreach (string rowText in zigzag) 
            {
                sifreliMetin8 += rowText; 
            }

            return sifreliMetin8;
        }


        public static string VigenereSifreleme(string metin9, string key9)
        {
            
            string sifreliMetin9 = "";
            int keyIndex = 0; 
            int alfabeUzunlugu = alfabe.Length;

            metin9 = metin9.ToUpper();
            key9 = key9.ToUpper();

            foreach (char c in metin9)  
            {
                if (alfabe.Contains(c))  
                {
                    int harfIndex = alfabe.IndexOf(c);  
                    char keyChar = key9[keyIndex % key9.Length]; 
                    int keyIndexVal = alfabe.IndexOf(keyChar); 

                    int sifreliHarfIndex = (harfIndex + keyIndexVal) % alfabeUzunlugu;

                    keyIndex++;
                }
            }

            return sifreliMetin9;
        }


        public static string HillSifrele(string metin, int[,] keyMatrix, int n)
        {
           
            metin = metin.ToUpper();
            string temizMetin = "";

            foreach (char c in metin)
            {
                if (alfabe.Contains(c))
                {
                    temizMetin += c;
                }
            }

            
            while (temizMetin.Length % n != 0)
            {
                temizMetin += 'Ğ';
            }

            string sifreliMetin = "";

            for (int i = 0; i < temizMetin.Length; i += n)  
            {
                int[] girisVektor = new int[n]; 
                
                for (int j = 0; j < n; j++)
                {
                    girisVektor[j] = alfabe.IndexOf(temizMetin[i + j]);
                }

                
                for (int satir = 0; satir < n; satir++)
                {
                    int toplam = 0;
                    for (int col = 0; col < n; col++)
                    {
                        toplam += keyMatrix[satir, col] * girisVektor[col];
                    }

                    toplam %= alfabe.Length;  
                    if (toplam < 0)
                    {
                        toplam += alfabe.Length;  
                    }

                    sifreliMetin += alfabe[toplam]; 
                }
            }

            return sifreliMetin;
        }




        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("**************\n" +
                    "1. Kaydırmalı Şifreleme\n" +  
                    "2. Doğrusal Şifreleme\n" +                
                    "3. Yer değiştirme ile şifreleme\n" +
                    "4. Permütasyon ile şifreleme\n" +
                    "5. 4 kare şifrelme\n" +
                    "6. Yer değiştirme (sayı anahtarlı) şifreleme\n" +
                    "7. Rota şifreleme\n" +
                    "8. Zigzak şifreleme\n" +
                    "9. Vigenere şifreleme\n" +
                    "10. Hill şifreleme\n" +
                    "Çıkış için 0 giriniz\n" +
                    "**************\n"
                );
                Console.Write("Şifreleme Yöntemi Seçiniz: ");

                int yontem = int.Parse(Console.ReadLine());

                
                if (yontem == 0)
                {
                    break; 
                }

                switch (yontem)
                {
                    case 1:

                        Console.Write("Metni girin: ");
                        string input = Console.ReadLine();

                        Console.Write("Kaydırma miktarı: ");
                        int shift = int.Parse(Console.ReadLine());

                        string sifrelimetin1 = KaydırmalıSifreleme(input, shift);

                        Console.WriteLine("Şifreli Metin: " + sifrelimetin1);

                        break;
                    case 2:
                        Console.Write("Şifrelenecek metni girin: ");
                        string metin = Console.ReadLine();

                        Console.Write("a değerini girin: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("b değerini girin: ");
                        int b = int.Parse(Console.ReadLine());

                        string sifreliMetin = DogrusalSifrele(metin, a, b);

                        Console.WriteLine("Şifreli Metin: "+ sifreliMetin);
                        break;
                    case 3:
                        Console.Write("Şifrelenecek metni girin: ");
                        string input3 = Console.ReadLine().ToUpper();

                        string sonuc3 = YerDegistirmeAlfabeIle(input3);
                        Console.WriteLine("Şifreli Metin: " + sonuc3);
                        break;
                    case 4:
                        Console.Write("Mesajı girin: ");
                        string mesaj4 = Console.ReadLine();

                        Console.Write("Anahtar uzunluğunu girin: ");
                        int m = int.Parse(Console.ReadLine());

                        int[] anahtar4 = new int[m];
                        Console.Write("Permütasyon anahtarını girin: ");
                        string[] anahtarStr = Console.ReadLine().Split(' ');

                        for (int i = 0; i < m; i++)
                        {
                            anahtar4[i] = int.Parse(anahtarStr[i]);
                        }

                        string sifreliMesaj = PermutasyonSifrele(mesaj4, anahtar4);

                        Console.WriteLine("Şifreli metin: " + sifreliMesaj);
                        break;
                    case 5:
                        Console.Write("Şifrelenecek metni girin:");
                        string metin5 = Console.ReadLine();
                        string sonuc5 = DortKareSifrele(metin5);
                        Console.WriteLine("Şifreli Metin: "+ sonuc5);
                        break;
                    case 6:
                        Console.Write("Şifrelenecek metni girin: ");
                        string metin6 = Console.ReadLine();
                        Console.Write("Sütun sayısını giriniz: ");
                        int sutunSayisi6 = int.Parse(Console.ReadLine());
                        string sonuc6 = SayiAnahtarliYerDegistirme(metin6, sutunSayisi6);
                        Console.WriteLine("Şifreli Metin: " + sonuc6);
                        break;
                    case 7:
                        Console.Write("Şifrelenecek metni girin: ");
                        string plaintext = Console.ReadLine();

                        Console.Write("Sütun sayısını girin: ");
                        int columns = int.Parse(Console.ReadLine());


                        int rows = (plaintext.Length + columns - 1) / columns;


                        while (plaintext.Length < rows * columns)
                        {
                            plaintext += 'a';
                        }

                        string encryptedText = RotaSifreleme(plaintext, rows, columns);
                        Console.Write("Şifrelenmiş Metin: ");
                        Console.WriteLine(encryptedText);
                        break;
                    case 8:
                        Console.Write("Şifrelenecek metni girin: ");
                        string metin8 = Console.ReadLine();

                        Console.Write("Satır sayısını girin: ");
                        int key8 = int.Parse(Console.ReadLine());

                        string sifrelimetin8 = ZigzagSifreleme(metin8, key8);
                        Console.Write("Şifrelenmiş Metin: ");
                        Console.WriteLine(sifrelimetin8);
                        break;
                    case 9:
                        Console.Write("Şifrelenecek metni girin: ");
                        string metin9 = Console.ReadLine().ToUpper();

                        Console.Write("Anahtar kelimeyi girin: ");
                        string key9 = Console.ReadLine().ToUpper();

                        string sifrelimetin9 = VigenereSifreleme(metin9, key9);
                        Console.Write("Şifrelenmiş Metin:");
                        Console.WriteLine(sifrelimetin9);
                        break;
                    case 10:
                        Console.Write("Metni giriniz: ");
                        string metin10 = Console.ReadLine();

                        Console.Write("Matris boyutunu giriniz (örn: 2, 3, 4): ");
                        int n = int.Parse(Console.ReadLine());
                        
                        int[,] keyMatrix = new int[n, n];
                        Console.Write($"{n}x{n} Anahtar Matrisi değerlerini giriniz: ");

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write($"[{i},{j}]: ");
                                keyMatrix[i, j] = int.Parse(Console.ReadLine());
                            }
                        }

                        string sifreli = HillSifrele(metin10, keyMatrix, n);
                        Console.WriteLine("Şifreli Metin: " + sifreli);
                        break;
                    default:
                        Console.WriteLine("1 ile 10 arasında seçim yapınız");
                        break;
                }

             

            }
        }
    
    }

}