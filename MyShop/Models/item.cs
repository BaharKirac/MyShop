using System;
namespace MyShop.Models
{
    public class Item
    {
        public int ItemId { get; set; }  // benzersiz Id
        public string Name { get; set; } = string.Empty; // zorunlu alan, boş başlamasın diye default değer
        public decimal Price { get; set; } // para için decimal
        public string? Description { get; set; } //istege basli nullable
        public string? ImageUrl { get; set; } //istege bagli nullable
    }
}

/*Notlar

PascalCase (baş harf büyük) kuralı: ItemId, Name, Price…

{ get; set; } otomatik özellik (property).

string Name … = string.Empty; ⇒ zorunlu alanı null bırakmamak için varsayılan değer.

string? … ⇒ alan opsiyonel (nullable) demektir. 

Eğer Name için = string.Empty; koymazsan ya da Name’i string? yapmazsan 
şu uyarıyı alırsın: CS8618 (nullable warning). 
Çözüm: ya = string.Empty; bırak, ya da string? Name yap (opsiyonel olsun).
*/