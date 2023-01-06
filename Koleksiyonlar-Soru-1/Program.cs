
/* Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın. */

using System.Collections;

Console.WriteLine("20 adet pozitif sayı giriniz:");

ArrayList asalList = new ArrayList();
ArrayList notAsalList = new ArrayList();

CollectData ( asalList, notAsalList);

asalList.Sort();
notAsalList.Sort();

asalList.Reverse();
notAsalList.Reverse();

Console.WriteLine("********Asal Sayılar***********");
foreach (var item in asalList)
    Console.WriteLine(item);

Console.WriteLine("********Asal Olmayan Sayılar***********");
foreach (var item in notAsalList)
    Console.WriteLine(item);

Console.WriteLine("Asal sayıların miktarı: {0}", asalList.Count);
Console.WriteLine("Asal sayıların ortalaması: " + GetMeanValue(asalList));

Console.WriteLine("Asal olmayan sayıların miktarı: {0}", notAsalList.Count);
Console.WriteLine("Asal olmayan sayıların ortalaması: " + GetMeanValue(notAsalList));

double GetMeanValue (ArrayList list){

double result=0;
foreach (var item in list)
{
    result+=Convert.ToDouble(item);
}
result = result/list.Count;

return result;
}
void CollectData ( ArrayList asalList,  ArrayList notAsalList){

    int sayi;
    for (int i = 0; i < 20; i++)
    {
        sayi=GetNumber();
        if (CheckIfPrime(sayi))
            asalList.Add(sayi);
        else
            notAsalList.Add(sayi); 
    }
}

bool CheckIfPrime ( int sayi){


    if (sayi<=1) return false;

    if (sayi==2) return true;

    int limit = (int) Math.Ceiling(Math.Sqrt(sayi)); 

    for (int i = 2; i <= limit; ++i)  
       if (sayi % i == 0)  
           return false;
    return true;
}

int GetNumber(){
  int sayi;
  while (true){
            try
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi<0)
                {
                    Console.Write("Pozitif sayı giriniz: ");
                }
                else 
                    break;
            }
            catch (System.Exception)
            {
                Console.Write("Pozitif sayı giriniz: ");
            }
        }



   return sayi; 
}