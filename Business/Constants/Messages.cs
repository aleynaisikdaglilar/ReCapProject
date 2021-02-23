using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarPriceInvalid = "Araç fiyatı 0'dan büyük olmalıdır";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        internal static string CarsListed = "Arabalar listelendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        internal static string BrandsListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        internal static string ColorsListed = "Renkler listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        internal static string CustomersListed = "Müşteriler listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        internal static string UsersListed = "Kullanıcılar listelendi";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        internal static string RentalsListed = "Kiralamalar listelendi";
        public static string RentalReturnDateNull = "Araç henüz teslim edilmedi";

        internal static string Maintenance="Sistem bakımda";
        
    }
}
