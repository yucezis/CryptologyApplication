# Cryptology Application with Turkish Alphabet

---

## Project Description

This project is a C# console application that implements various **classical encryption algorithms** adapted to the **Turkish alphabet**.  
The purpose is to demonstrate cryptographic principles in practice and understand the logic behind each algorithm.

---

## Alphabet Used

Includes all characters from the Turkish alphabet.

---

##  Features

- Fully compatible with the Turkish alphabet.  
- Console-based user interface for easy interaction.  
- Each encryption method is implemented as a separate function.  
- Parameters (key, shift amount, matrix size, etc.) are entered dynamically by the user.  
- Non-alphabetic characters are automatically removed.

---

##  Encryption Methods

| No |  Method Name | Description |
|----|----------------|-------------------------|
| 1 | Caesar Cipher | Each letter is shifted by a fixed number. |
| 2 | Affine Cipher | E(x) = (a*x + b) Encoded using the affine formula. |
| 3 | Substitution Cipher | Letters are replaced according to a new alphabet. |
| 4 | Permutation Cipher | Letters are permuted in blocks according to a key. |
| 5 | Four-Square Cipher | Pairs of letters are encrypted using four matrices. |
| 6 | Columnar Transposition | Text is written into a table and read column by column. |
| 7 | Spiral Cipher | Text is placed in a grid and read in a spiral path. |
| 8 | Rail Fence Cipher | Letters are arranged in a zigzag and read row by row. |
| 9 | Vigenère Cipher | Multiple shifts based on a keyword. |
| 10 | Hill Cipher | Matrix multiplication based on linear algebra. |

---

## Usage

1. Run the program.  
2. Select an encryption method from the console menu.  
3. Enter the required parameters (text, key, shift amount, etc.).  
4. The result will be displayed as “Encrypted Text” in the console.

---

## Technical Details

- **Language:** C#  
- **Platform:** .NET Framework  
- **Namespace:** `Kriptoloji`  
- **Entry Point:** `Main()`  

---

## Developer

**Ad / Name:** Zişan Yüce  
**Bölüm / Department:** Bilgisayar Mühendisliği (Computer Engineering)  
**Goal:** To practice classical cryptography methods using the Turkish alphabet and understand their logic.

---

⭐ If you like this project, don’t forget to give it a star!  
