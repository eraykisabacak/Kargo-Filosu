# Kargo-Filosu

Bir kargo şirketinin ulaştırma filosundaki araçların birer nesne ile ifade edilebildiği bir kütüphane
olduğunu düşünelim. Bu kütüphane içerisindeki fonksiyonelliklerden biriside, araçların uydu
sistemleri yardımıyla düzenli olarak izlenmesi ve güncel koordinat, anlık hız gibi bilgilerinin elde
edilmesi olduğunu varsayalım.

Araçların belirlenen hız limitlerini aşmaları sonrasında oluşacak durumların söz konusu
kütüphaneyi kullanan uygulamalar tarafından, istenirse ele alınmalarını sağlamak amacıyla
gereken olayları (event) ve sınıfları yazmanız istenmektedir. Böylece söz konusu program, araç
hız limitini aştığı zaman neler yapmak istiyorsa bunları istediği şekilde ele alabilecektir.

Ödev kapsamında; sınıf, temsilci ve olay tanımlamalarını aşağıda bir bölümü verilen
Kaynak_Kod_2 çalıştırıldığında; verilen ekran çıktısını alabilecek şekilde projeyi geliştirmeniz
istenmektedir. CargoVehicle Kargo aracı nesnesi için tasarlanacak sınıfı, SpeedExceeded kargo
aracının hız bilgisinin değişmesi durumunda tetiklenecek olayı, SpeedHandler olay için kullanılan
temsilciyi göstermektedir. kargo_aracı_SpeedExceeded ise temsilciye bağlanacak metodun
ismidir. Hız limitinin varsayılan değeri olarak 110 alınmıştır.