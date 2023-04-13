Console.WriteLine("ÖĞRENCİLERİN ORTALAMA HESAPLAMA ARACI");
int girlstudentcounter, boystudentcounter, girlmasscounter, boymasscounter, boymassanswer, girlmassanswer, boyaverage, girlaverage;
girlmasscounter = 0; boymasscounter = 0;
boystudentcounter = 0; girlstudentcounter = 0;
RETURN:
Console.WriteLine("ÖĞRENCİ ERKEK Mİ KIZ MI? K YADA E");
char gender = Convert.ToChar(Console.ReadLine());

if (gender == 'e' || gender == 'E')
{
    Console.WriteLine("ERKEK ÖĞRENCİNİN KİLO BİLGİSİNİ GİRİNİZ");
    boymassanswer = Convert.ToInt32(Console.ReadLine());
    boymasscounter = boymasscounter + boymassanswer;
    boystudentcounter = boystudentcounter + 1;
    Console.WriteLine("BAŞKA ÖĞRENCİ EKLEMEK İSTERMİSİN EVET İÇİN 'D' HAYIR İÇİN 'Y' YAZINIZ");
    char anotheranswer = Convert.ToChar(Console.ReadLine());
    if (anotheranswer == 'd' || anotheranswer == 'D')
    {
        goto RETURN;
    }
    else
    {
       
        if (girlstudentcounter == 0)
        {
            Console.WriteLine("KIZ ÖĞRENCİ YOKTUR");
            boyaverage = (boymasscounter / boystudentcounter);

            Console.WriteLine("ERKEK ÖĞRENCİ SAYISI:" + boystudentcounter + "ERKEK KİLO ORTALAMA:" +" "+ boyaverage);
        }
        else
        {
            girlaverage = (girlmasscounter / girlstudentcounter);
            boyaverage = (boymasscounter / boystudentcounter);
            Console.WriteLine("ERKEK ÖĞRENCİ SAYISI:" +" "+ boystudentcounter + "ERKEK KİLO ORTALAMA:" + boyaverage);
            Console.WriteLine("KIZ ÖĞRENCİ SAYISI:" + girlstudentcounter + "KIZ KİLO ORTALAMA:" + girlaverage);
        }

    }
}
else if (gender == 'k' || gender == 'K')
{
    Console.WriteLine("KIZ ÖĞRENCİNİN KİLO BİLGİSİNİ GİRİNİZ");
    girlmassanswer = Convert.ToInt32(Console.ReadLine());
    girlmasscounter = girlmasscounter + girlmassanswer;
    girlstudentcounter = girlstudentcounter + 1;
    Console.WriteLine("BAŞKA ÖĞRENCİ EKLEMEK İSTERMİSİN EVET İÇİN 'D' HAYIR İÇİN 'Y' YAZINIZ");
    char anotheranswer = Convert.ToChar(Console.ReadLine());
    if (anotheranswer == 'd' || anotheranswer == 'D')
    {
        goto RETURN;
    }
    else
    {
        if (boymasscounter == 0)
        {

            Console.WriteLine("ERKEK ÖĞRENCİ YOKTUR");
            girlaverage = (girlmasscounter / girlstudentcounter);

            Console.WriteLine("KIZ ÖĞRENCİ SAYISI:" + girlstudentcounter + "KIZ KİLO ORTALAMA:" + girlaverage);

        }
        else
        {
            Console.WriteLine("ERKEK ÖĞRENCİ YOKTUR");
            girlaverage = (girlmasscounter / girlstudentcounter);

            Console.WriteLine("KIZ ÖĞRENCİ SAYISI:" + girlstudentcounter + "KIZ KİLO ORTALAMA:" + girlaverage);

        }

    }

}
Console.ReadLine();