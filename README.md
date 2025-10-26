# Türkçe Alfabe ile Kriptoloji Uygulaması  
### Cryptology Application with Turkish Alphabet

---

## Proje Açıklaması | Project Description

**TR:**  
Bu proje, **Türkçe alfabeye uygun olarak** geliştirilmiş çeşitli **klasik şifreleme algoritmalarını** içeren bir C# konsol uygulamasıdır.  
Amaç, kriptografi prensiplerini Türkçe karakterlerle uygulamalı olarak göstermek ve her algoritmanın çalışma mantığını anlamaktır.  

**EN:**  
This project is a C# console application that implements various **classical encryption algorithms** adapted to the **Turkish alphabet**.  
The purpose is to demonstrate cryptographic principles in practice and understand the logic behind each algorithm.

---

## Kullanılan Alfabe | Alphabet Used


**TR:** Türkçe alfabedeki tüm harfleri kapsar.  
**EN:** Includes all characters from the Turkish alphabet.

---

## Özellikler | Features

**TR:**
- Türkçe alfabeyle tamamen uyumlu çalışır.  
- Konsol tabanlı menü üzerinden kullanıcı etkileşimi sağlar.  
- Her algoritma bağımsız bir metot olarak yazılmıştır.  
- Parametreler (anahtar, kaydırma miktarı, matris boyutu vb.) kullanıcıdan dinamik olarak alınır.  
- Harf dışındaki karakterler otomatik olarak temizlenir.

**EN:**
- Fully compatible with the Turkish alphabet.  
- Console-based user interface for easy interaction.  
- Each encryption method is implemented as a separate function.  
- Parameters (key, shift amount, matrix size, etc.) are entered dynamically by the user.  
- Non-alphabetic characters are automatically removed.

---

## Şifreleme Yöntemleri | Encryption Methods

| No | Yöntem Adı |  Method Name | Açıklama / Description |
|----|----------------|----------------|-------------------------|
| 1 | Kaydırmalı Şifreleme | Caesar Cipher | Her harf belirli bir miktar kaydırılır. / Each letter is shifted by a fixed number. |
| 2 | Doğrusal Şifreleme | Affine Cipher | E(x) = (a*x + b) mod m formülüne göre kodlanır. / Encoded using the affine formula. |
| 3 | Yer Değiştirme Şifreleme | Substitution Cipher | Harfler yeni bir alfabe dizilimiyle değiştirilir. / Letters are replaced according to a new alphabet. |
| 4 | Permütasyon Şifreleme | Permutation Cipher | Harfler belirli bir anahtara göre bloklar hâlinde yeniden sıralanır. / Letters are permuted in blocks according to a key. |
| 5 | Dört Kare Şifreleme | Four-Square Cipher | Dört alfabe matrisiyle çift harfler şifrelenir. / Pairs of letters are encrypted using four matrices. |
| 6 | Sayı Anahtarlı Yer Değiştirme | Columnar Transposition | Metin tabloya yazılır, sütunlar sırayla okunur. / Text is written into a table and read column by column. |
| 7 | Rota Şifreleme | Spiral Cipher | Metin matrise yerleştirilir ve spiral olarak okunur. / Text is placed in a grid and read in a spiral path. |
| 8 | Zigzag Şifreleme | Rail Fence Cipher | Harfler zikzak düzende yazılıp satır satır okunur. / Letters are arranged in a zigzag and read row by row. |
| 9 | Vigenère Şifreleme | Vigenère Cipher | Anahtar kelimeye göre çoklu kaydırma yapılır. / Multiple shifts based on a keyword. |
| 10 | Hill Şifreleme | Hill Cipher | Lineer cebir tabanlı matris çarpımı yöntemi. / Matrix multiplication based on linear algebra. |

---

## Kullanım | Usage

**TR:**  
1. Programı çalıştırın.  
2. Konsolda çıkan menüden şifreleme yöntemini seçin.  
3. İstenilen parametreleri (metin, anahtar, kaydırma miktarı vb.) girin.  
4. Sonuç konsolda “Şifreli Metin” olarak görüntülenecektir.  

**EN:**  
1. Run the program.  
2. Select an encryption method from the console menu.  
3. Enter the required parameters (text, key, shift amount, etc.).  
4. The result will be displayed as “Encrypted Text” in the console.

---

## Teknik Bilgiler | Technical Details

- **Dil / Language:** C#  
- **Platform:** .NET Framework  
- **Namespace:** `Kriptoloji`  
- **Giriş Noktası / Entry Point:** `Main()`  
- **Kod Yapısı / Code Structure:**  
  - Her algoritma bağımsız metot olarak tanımlanmıştır.    
  - Konsol tabanlı kullanıcı arayüzü içerir.  

---

## Geliştirici | Developer

**Ad / Name:** Zişan Yüce  
**Bölüm / Department:** Bilgisayar Mühendisliği (Computer Engineering)  
**Amaç / Goal:**  
Türkçe alfabe destekli klasik şifreleme yöntemlerini uygulayarak kriptolojiye temel düzeyde giriş yapmak.  
To practice classical cryptography methods using the Turkish alphabet and understand their logic.

---

