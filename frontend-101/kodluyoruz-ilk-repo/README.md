# Kodluyoruz İlk Repo - Ödev - 1 (Repo Klonlama Rehberi)
Bu repo [Kodluyoruz](https://www.kodluyoruz.org/) Front-End Eğitiminde oluşturduğumuz ilk repo. İçerisinde bir adet README dosyası, bir adet de index.html barındırıyor.

![Ekran görüntüsü 2025-06-15 204153](https://github.com/user-attachments/assets/4234095f-6535-4006-b210-af72836f6b0c)

## Installation
Öncelikle projeyi clone edin. (Buraya sizin reponuzdan aldığınız link gelecek)

```
git clone https://github.com/ayildizzz/kodluyoruzilkrepo.git
```

## Usage
Projeyi clone ettikten sonra VSCode progamını açınız.

Linux için:

```linux
cd kodluyoruz ilk repo
code .
```

## Contributing
Pull requestler kabul edilir. Büyük değişiklikler için, lütfen önce neyi değiştirmek istediğinizi tartışmak için bir konu açınız.

# Ödev - 2 (Algoritmalar Çalışması)

# Insertion Sort Projesi - Proje 1

## **1️⃣ \[22,27,16,2,18,6] → Insertion Sort adımları**

**Insertion Sort mantığı:**
Her adımda, soldaki kısmı sıralı tutarız ve sıradaki elemanı uygun konuma yerleştiririz.

**Başlangıç:**
`[22, 27, 16, 2, 18, 6]`

**Adım 1:** (27, 22’den büyük → yer değiştirme yok)
`[22, 27, 16, 2, 18, 6]`

**Adım 2:** (16, 27’den küçük → sola kaydır; 16, 22’den küçük → tekrar kaydır)
`[16, 22, 27, 2, 18, 6]`

**Adım 3:** (2, 27’den küçük → sola kaydır; 2, 22’den küçük → kaydır; 2, 16’dan küçük → kaydır)
`[2, 16, 22, 27, 18, 6]`

**Adım 4:** (18, 27’den küçük → kaydır; 18, 22’den küçük → kaydır; 18, 16’dan büyük → buraya yerleşir)
`[2, 16, 18, 22, 27, 6]`

**Adım 5:** (6, 27’den küçük → kaydır; 6, 22’den küçük → kaydır; 6, 18’den küçük → kaydır; 6, 16’dan küçük → kaydır; 6, 2’den büyük → buraya yerleşir)
`[2, 6, 16, 18, 22, 27]`

**Son sıralı dizi:**
`[2, 6, 16, 18, 22, 27]`

---

## **2️⃣ Big-O gösterimi**

Insertion Sort’un genel durumu:

* **Worst case:** $O(n^2)$ → Ters sıralı dizide
* **Best case:** $O(n)$ → Zaten sıralı dizide
  Bu dizide **Big-O**: $O(n^2)$

---

## **3️⃣ 18 sayısı hangi case?**

Sıralandıktan sonra dizimiz:
`[2, 6, 16, 18, 22, 27]`
18 **ortada** yer alıyor → **Average Case**

---

## **4️⃣ \[7,3,5,8,2,9,4,15,6] → Selection Sort ilk 4 adım**

**Selection Sort mantığı:**
Her adımda minimumu bul, baştaki ile değiştir.

**Başlangıç:**
`[7, 3, 5, 8, 2, 9, 4, 15, 6]`

**Adım 1:** (min = 2, baştaki 7 ile yer değiştir)
`[2, 3, 5, 8, 7, 9, 4, 15, 6]`

**Adım 2:** (kalan \[3, 5, 8, 7, 9, 4, 15, 6], min = 3, zaten yerinde)
`[2, 3, 5, 8, 7, 9, 4, 15, 6]`

**Adım 3:** (kalan \[5, 8, 7, 9, 4, 15, 6], min = 4 → 5 ile yer değiştir)
`[2, 3, 4, 8, 7, 9, 5, 15, 6]`

**Adım 4:** (kalan \[8, 7, 9, 5, 15, 6], min = 5 → 8 ile yer değiştir)
`[2, 3, 4, 5, 7, 9, 8, 15, 6]`

---


# Merge Sort - Proje 2
## 1️⃣ \[16, 21, 11, 8, 12, 22] → Merge Sort aşamaları

**Merge Sort**:

* Diziyi sürekli ortadan ikiye böler (divide)
* Alt dizileri tek tek sıralar (conquer)
* Sonra sıralı alt dizileri birleştirir (merge)

---

### Adım 1: Diziyi ikiye böl

`[16, 21, 11]` ve `[8, 12, 22]`

---

### Adım 2: Sol alt dizi `[16, 21, 11]`'i böl

`[16]` ve `[21, 11]`

### Adım 3: `[21, 11]`'i böl

`[21]` ve `[11]`

### Adım 4: Tek elemanlar zaten sıralı

`[16]`, `[21]`, `[11]`

### Adım 5: `[21]` ve `[11]`'i sırala ve birleştir

`[11, 21]`

### Adım 6: `[16]` ve `[11, 21]`'i sırala ve birleştir

* Karşılaştır: 16 ve 11 → 11
* 16 ve 21 → 16
* Geri kalan → 21
  Sonuç: `[11, 16, 21]`

---

### Adım 7: Sağ alt dizi `[8, 12, 22]`'yi böl

`[8]` ve `[12, 22]`

### Adım 8: `[12, 22]`'yi böl

`[12]` ve `[22]`

### Adım 9: Tek elemanlar zaten sıralı

`[8]`, `[12]`, `[22]`

### Adım 10: `[12]` ve `[22]`'yi sırala ve birleştir

`[12, 22]`

### Adım 11: `[8]` ve `[12, 22]`'yi sırala ve birleştir

* Karşılaştır: 8 ve 12 → 8
* Geri kalan → 12, 22
  Sonuç: `[8, 12, 22]`

---

### Adım 12: Son olarak `[11, 16, 21]` ve `[8, 12, 22]`'yi sırala ve birleştir

* 11 ve 8 → 8
* 11 ve 12 → 11
* 16 ve 12 → 12
* 16 ve 22 → 16
* 21 ve 22 → 21
* Kalan → 22

Sonuç: `[8, 11, 12, 16, 21, 22]`

---

## 2️⃣ Big-O gösterimi (Merge Sort)

* **Worst case:** $O(n \log n)$
* **Average case:** $O(n \log n)$
* **Best case:** $O(n \log n)$

---


# Binary Search Tree Projesi - Proje 3
## BST oluşturma adımları:

**Başlangıç:**
Dizi sırasıyla elemanları ekleyeceğiz. İlk eleman **root** olur.

---

1. **Root 7**’dir.
2. 5 eklenir: 5 < 7 → **7’nin soluna** eklenir.
3. 1 eklenir: 1 < 7 → sola, 1 < 5 → 5’in soluna.
4. 8 eklenir: 8 > 7 → **7’nin sağına**.
5. 3 eklenir: 3 < 7 → sola, 3 < 5 → sola, 3 > 1 → 1’in sağına.
6. 6 eklenir: 6 < 7 → sola, 6 > 5 → 5’in sağına.
7. 0 eklenir: 0 < 7 → sola, 0 < 5 → sola, 0 < 1 → 1’in soluna.
8. 9 eklenir: 9 > 7 → sağa, 9 > 8 → 8’in sağına.
9. 4 eklenir: 4 < 7 → sola, 4 < 5 → sola, 4 > 1 → sağa, 4 > 3 → 3’ün sağına.
10. 2 eklenir: 2 < 7 → sola, 2 < 5 → sola, 2 > 1 → sağa, 2 < 3 → 3’ün soluna.

---

## Sonuç olarak ağaç yapısı şöyle olur:

* **Root:** 7
  * **Sol:** 5
    * Sol: 1
      * Sol: 0
      * Sağ: 3
        * Sol: 2
        * Sağ: 4
    * Sağ: 6
  * **Sağ:** 8
    * Sağ: 9

## Licence
[MIT](https://choosealicense.com/licenses/mit/)
