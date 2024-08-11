using Factory; // araba sınıfını kullanabilmel için ekledik
List<Car> carsList = new List<Car>(); // bir liste oluşturuyoruz elemanları car nesnesi olan
User user = new User(); // özel hata fırlatabilmek için oluşturduğumuz sınıf user adında bir ınstancesini oluşturduk 
do
{
    System.Console.WriteLine("Araba üretmek istiyorsanız 'e' istemiyorsanız 'h' yazınız");
    Loop: // hata yapıldığında dönülen satır
    string input = Console.ReadLine().ToLower(); // kullanıcıdan veri alınıyor

    if (input == "h") // h ise direkt döngüden çıkar
    {
        break;
    }

    try // kullanıcıdan alınan veri kontrol ediliyor ve duruma göre hata fırlatıyoruz
    { 
        user.RightInput(input);
    }
    catch(CharcterException)
    {
        goto Loop; // kullanıcı e veya h harfi yazmazsa tekrar kullanıcıdan harf istiyoruz
    }

    Car firstCar = new Car(); // kullanıcı bir car nesnesi oluşturmak istiği için bir nesne üretiyoruz

    System.Console.Write("Lütfen arabanın seri numarasını giriniz: "); 
    firstCar.SeriNumber = Console.ReadLine(); // kullanıcıdan alına bilgi değişkenlere atanıyor
    System.Console.Write("Lütfen arabanın markasını yazınız: ");
    firstCar.Brand = Console.ReadLine(); // kullanıcıdan alına bilgi değişkenlere atanıyor
    System.Console.Write("Lütfen arabanın modelini yazınız: ");
    firstCar.Model = Console.ReadLine(); // kullanıcıdan alına bilgi değişkenlere atanıyor
    KapiSayisi: // kapı sayısı yanlış girilirse kod buraya dönüyor
    System.Console.Write("Lütfen arabanın kapı sayısını giriniz: ");
 
    try
    {
        firstCar.DoorCount = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan alınan değer kontrol ediliyor
    }
    catch (FormatException ex) // format hatası yapılırsa bura hata gönderilir
    {
        System.Console.WriteLine("Hatalı format \n" + ex); 
        goto KapiSayisi; // hata olursa tekrar kapı sayısı istenmesi için kod ilgili satıra döner
    }
    catch(Exception ex) // genel bir hata yapıldıysa bu hatayı fırlatır
    {
        System.Console.WriteLine("Genel bir hata oldu \n" + ex);
        goto KapiSayisi; // hata olursa tekrar kapı sayısı istenmesi için kod ilgili satıra döner
    }

    carsList.Add(firstCar); // hata olmazsa car listeye eklenir

} while (true);

foreach (var item in carsList) // kullanıcı oluşturduğu nesnelerin seri numarası ve markaları teker teker yazırılır
{
    System.Console.WriteLine($"Arabanın seri numarası {item.SeriNumber} ve markası {item.Brand} ");
}

