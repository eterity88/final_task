//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// лучше обойтись исключительно массивами.


string[] M;
            Console.WriteLine("Введите массив строк через пробел");
            string stroka = Console.ReadLine();
            M = stroka.Split(' ');
            var result = new string[M .Length];
            var arrSize = 0;
            foreach (var value in M )
            {
                if (value.Length <= 3)
                {
                    result[arrSize] = value;
                    arrSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, arrSize));
            Console.ReadKey(true);
