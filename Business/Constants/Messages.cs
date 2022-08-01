using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olablir";
        public static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded = "15 den fazla categori mevcut";
    }
}
