using CartQuantityCalculation;

var urunler = new List<Liste>();

urunler.Add(new Liste
{
    Urun = "Bizim Yağ",
    Fiyat = 100
});

urunler.Add(new Liste
{
    Urun = "Yoğurt",
    Fiyat = 50,
});

urunler.Add(new Liste
{
    Urun = "Ekmek",
    Fiyat = 11,
});

urunler.Add(new Liste
{
    Urun = "Makarna",
    Fiyat = 15,
});

urunler.Add(new Liste
{
    Urun = "Mayonez",
    Fiyat = 30,
});

int toplam = 0;
foreach (var urun in urunler)
{
    
    Console.WriteLine($"Ürün: {urun.Urun}   fiyat: {urun.Fiyat}TL");
    toplam += urun.Fiyat ;
}

Console.WriteLine($"Toplam: {toplam}TL");