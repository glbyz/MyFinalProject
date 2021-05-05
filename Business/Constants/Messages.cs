using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme başarılı";
        public static string NameInvalid = "Gecersiz isim";
        public static string Listed="Listelendi";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductCountOfCategoryError = "Categorideki ürün sayısı 10'u geçmemeli";
        public static string Updated = "Güncellendi";
        public static string ProductNameAlreadyExists= "Bu İsimde Zaten Başka Bir Ürün Var";
        public static string CategoryLimitExceded="Kategori Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz Yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
