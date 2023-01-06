/* Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.) */

Console.WriteLine("20 adet pozitif sayı giriniz: ");

int[] numbers= new int[20];

    for (int i = 0; i < 20; i++)
        numbers[i]=GetNumber();
Array.Sort(numbers);

double meanBiggest= (numbers[17] + numbers[18] + numbers[19])/3;
double meanSmallest= (numbers[0] + numbers[1] + numbers[2])/3;
Console.WriteLine("En büyük sayıların ortalaması: " + meanBiggest);
Console.WriteLine("En küçük sayıların ortalaması: " + meanSmallest);
Console.WriteLine("Ortalama toplamarı: "+ (meanBiggest+meanSmallest));

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