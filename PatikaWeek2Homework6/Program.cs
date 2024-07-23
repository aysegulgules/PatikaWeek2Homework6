using System.ComponentModel.Design;
using System.Threading.Tasks.Dataflow;


//1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın ?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın ?");


//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
Console.Write("\n-----------------------------------------------------------\n");
string myText = "Ben patika bootcamp başladım";
int myIndex = 100;
Console.WriteLine("Bir metin....: "+myText);
Console.WriteLine("Bir sayı...: " +myIndex);


//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Console.Write("\n-----------------------------------------------------------\n");
Random numberRandom = new Random();
Console.WriteLine($"Rastgele üretilmiş bir sayı :{numberRandom.Next()}");



//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Console.Write("\n-----------------------------------------------------------\n");
int divided = numberRandom.Next();
int remainder = divided % 3;
Console.WriteLine($"Rastgele üretilmiş {divided} sayısının 3 bölümünden kalan..:{remainder}");



//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("\n-----------------------------------------------------------\n");
Console.Write("Yaşınızı giriniz...:");
int age=int.Parse(Console.ReadLine());
if(age >18 )
    Console.WriteLine($"{age} yaş 18 den büyük..:+");
else if(age < 18)
    Console.WriteLine($"{age} yaş 18 den küçük..:-");
else
    Console.WriteLine($"{age} yaş 18'e eşit");


//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
Console.Write("\n-----------------------------------------------------------\n");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i}-Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}



//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.Write("\n-----------------------------------------------------------\n");
Console.WriteLine("Alt alta iki metinsel değer giriniz");
string text1=Console.ReadLine();
string text2=Console.ReadLine();
text1 = text1.Replace(text1, "Gülse Birsel");
text2 = text2.Replace(text2, "Demet Evgar");

Console.WriteLine("Birinci metin değişikliği...:"+text1 + "\nikinci metin değişikliği....: " + text2);


//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
Console.Write("\n-----------------------------------------------------------\n");
BenDegerDondurmem();

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}



//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
Console.Write("\n-----------------------------------------------------------\n");
Console.WriteLine("Alt alta iki sayı giriniz..:");
int number1=Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number1} ile {number2} sayılarının toplamı...: {TwoNumbers(number1,number2)}");

int TwoNumbers(int number1,int number2)
{ 
    return number1 + number2;
}

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
Console.Write("\n-----------------------------------------------------------\n");
string sonuc = TrueOrFalseToString();
Console.WriteLine("Sonuc..:"+sonuc);

string TrueOrFalseToString()
{
    while (true)
    {
        Console.Write(" 'true' veya 'false' değeri giriniz: ");
        string entry = Console.ReadLine().ToLower();
        bool entryBool;

        if (bool.TryParse(entry, out entryBool))
        {

            return (entryBool) ? "Girdiğiniz değer doğru." : "Girdiğiniz değer yanlış.";

        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen 'true' veya 'false' girin.");
            
        }
    }
}





// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.Write("\n-----------------------------------------------------------\n");
Console.Write("1. kişinin yaşını giriniz...:");
int age1=int.Parse(Console.ReadLine());
Console.Write("2. kişinin yaşını giriniz...:");
int age2=int.Parse(Console.ReadLine());
Console.Write("3. kişinin yaşını giriniz...:");
int age3=int.Parse(Console.ReadLine());

Console.WriteLine($"EN yaşlı olanın yaşı...:{AgeOld(age1,age2,age3)} ");
int AgeOld(in int age1,in int age2,in int age3)
{
    return Math.Max( Math.Max(age1,age2), age3);
}


//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
Console.Write("\n-----------------------------------------------------------\n");
int largestNumber = LasgestNumbers();
Console.Write($"En büyük sayı...{largestNumber}");
int LasgestNumbers()
{ 
        int largestNumber=0,numbers;

         while(true)
        {
            Console.Write("Bir sayı girin veya işlemden çıkmak 'E' tuşuna basın..:");
            string entry=Console.ReadLine();
            if (entry == "E")
            { break;
            }
            else
            {
                if (int.TryParse(entry, out numbers))
                {
                    largestNumber=Math.Max(largestNumber, numbers);//büyük sayı belirleniyor.
                }
                else
                {
                    Console.Write("Lütfen geçerli bir sayı değeri girin\n");
            
                }

            }
        
        }
  return largestNumber;
}
//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.Write("\n-----------------------------------------------------------\n");
ChangeName(out string name_1, out string name_2);


Console.WriteLine($"Yerleri değiştirilmiş isim1..:{name_1} \nisim2..:{name_2}");

void ChangeName(out string name1, out string name2)
{
    Console.WriteLine("İki isim giriniz...:");
    name1 = Console.ReadLine();
    name2 = Console.ReadLine();
    string change = name1;
    name1 = name1.Replace(name1, name2);
    name2 = change;

}




//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.Write("\n-----------------------------------------------------------\n");
Console.WriteLine("Bir sayı giriniz...:");
int numberOddEven=int.Parse(Console.ReadLine());
bool oddEven = NumberOddEven(numberOddEven);
Console.WriteLine($"Sayı tek ise false çift ise true döner...:{oddEven}");

bool NumberOddEven(int number)
{
    return (number % 2 == 0)? true: false ;
}

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.Write("\n-----------------------------------------------------------\n");
Console.Write("Yol hesabı için hız bilgisini giriniz..:");
int fast1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Yol hesabı için saat bilgisini giriniz..:");
int time1= Convert.ToInt32(Console.ReadLine());

int road = 0;
RouteCalculation(ref road,fast1,time1);

Console.WriteLine($"Yol ..:{road} km");
void RouteCalculation(ref int road,int fast,int time1)
{
    road = fast * time1;
}



//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.Write("\n-----------------------------------------------------------\n");
CircleArea();

void CircleArea()
{ 
Console.Write("Dairenin yarıçapını giriniz...:");
int radius=int.Parse(Console.ReadLine());
double circleArea=Math.Pow(radius, 2)*3.14; // Dairenin alanı A = π*r² , π sayısı 3.14 alındı
Console.WriteLine($"Dairenin alanı...:{circleArea}");
}


//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
Console.Write("\n-----------------------------------------------------------\n");
string sentenceUpper=("Zaman bir GeRi SayIm").ToUpper();
Console.WriteLine("Cümle büyük harfe çevrildi..:"+sentenceUpper);
string sentenceLower= ("Zaman bir GeRi SayIm").ToLower();
Console.WriteLine("Cümle küçük harfe çevrildi..:" + sentenceLower);




//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
Console.Write("\n-----------------------------------------------------------\n");
string helloWord=("    Selamlar   ").Trim();
Console.WriteLine(helloWord);