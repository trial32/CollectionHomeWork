// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.


Console.WriteLine("Bir cümle giriniz: ");
string s= Console.ReadLine();
List<char> sesliHarfler = new List<char>();

for (int i = 0; i <s.Length; i++)
{
    if (s[i]=='a'||s[i]=='e'||s[i]=='ı'||s[i]=='i'||s[i]=='o'||s[i]=='ö'||s[i]=='u'||s[i]=='ü'||
         s[i]=='A'||s[i]=='E'||s[i]=='I'||s[i]=='İ'||s[i]=='O'||s[i]=='Ö'||s[i]=='U'||s[i]=='Ü' )
        sesliHarfler.Add(s[i]);
}

sesliHarfler.ForEach(harf=>Console.WriteLine(harf));

