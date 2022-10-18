using System;
int ff;
do
{
    Console.WriteLine("Введите координаты белого слона (1-8 ; 1-8) ");
    int a = Convert.ToInt32(Console.ReadLine());

    int b = Convert.ToInt32(Console.ReadLine());
    if (a >= 1 && a <= 8 && b >= 1 && b <= 8)
    {
        Console.WriteLine("Введите координаты черного слона, не совпадающие с координатами белого слона (1-8 ; 1-8) ");
        int c = Convert.ToInt32(Console.ReadLine());

        int d = Convert.ToInt32(Console.ReadLine());

        if (a >= 1 && a <= 8 && b >= 1 && b <= 8)
        {
            Console.WriteLine("Введите координаты поля для хода белого слона(1-8,1-8), не совпадающие с координатами черного слона: ");
            int e = Convert.ToInt32(Console.ReadLine());

            int f = Convert.ToInt32(Console.ReadLine());
            if (e >= 1 && e <= 8 && f >= 1 && f <= 8 && e != a || f != b)
            {
                Console.WriteLine("Белый слон        : " + a + " " + b);
                Console.WriteLine("Черый слон       : " + c + " " + d);
                Console.WriteLine("Поле для хода слона: " + e + " " + f);

                if (((a - e) == (b - f)) || ((a - e) == (f - b)))   // если ход слоном был сделан правильно по диагонали 
                {
                    if (((c == f) || (d == e)) == true)     //если белый слон и черый слон находятся на одной горизонтали
                    {
                        Console.WriteLine("Белый cлон может пойти на эти координаты но попадает под удар черного слона");

                    }
                    else
                    {
                        Console.WriteLine("Белый cлон пойти на эти координаты не попадая под удар черного слона");
                    }
                }
                else
                {
                    Console.WriteLine("Белый cлон не может так пойти");
                }
            }
        }


    }

    ff = Convert.ToInt32(Console.ReadLine());
} while (ff == 1);