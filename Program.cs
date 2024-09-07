using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // قراءة عدد الأغاني
        int N = int.Parse(Console.ReadLine());

        // قاموس لتخزين عدد الأغاني لكل مغني
        Dictionary<long, int> singerCount = new Dictionary<long, int>();
        long singer;
        int maxCount = 0;

        // قراءة المغنيين وحساب عدد الأغاني لكل مغني
        for (int i = 0; i < N; i++)
        {
            singer = long.Parse(Console.ReadLine());

            if (singerCount.ContainsKey(singer))
                singerCount[singer]++;
            else
                singerCount[singer] = 1;

            // تحديث القيمة القصوى للأغاني
            if (singerCount[singer] > maxCount)
                maxCount = singerCount[singer];
        }

        // حساب عدد المغنيين المفضلين
        int favouriteSingers = 0;
        foreach (var count in singerCount.Values)
        {
            if (count == maxCount)
                favouriteSingers++;
        }

        // طباعة النتيجة
        Console.WriteLine(favouriteSingers);
    }
}

