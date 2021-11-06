using System;
using System.IO;

namespace TENDENCIASX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buscando leer.json");
            string text = File.ReadAllText("leer.json");
            Console.WriteLine("Convirtiendo...");
            (int, int)[] data = TextDivider(text);
            Console.WriteLine("Procesando...");
            string[] information = PosTeller(data);
            Console.WriteLine($"Su respuesta es:");
            foreach (string KarimAbunaba in information)
            {
                Console.WriteLine(KarimAbunaba);
            }
            Console.ReadLine();
        }

        public static (int, int)[] TextDivider(string text)
        {
            string[] text_divided = text.Split("),");
            (int, int)[] ins = new (int, int)[text_divided.Length];
            int it = 0;
            foreach (string valuable in text_divided)
            {
                string temp_1 = valuable.Remove(0, 1);
                string[] temp = temp_1.Split(',');
                if (it == text_divided.Length - 1 && temp[1].Contains(')'))
                {
                    temp[1] = temp[1].Remove(temp[1].IndexOf(')'));
                }
                ins[it] = (int.Parse(temp[0]), int.Parse(temp[1]));
                it++;
            }
            return ins;
        }

        public static string[] PosTeller((int, int)[] asd)
        {
            string[] res = new string[asd.Length];
            int iter = 0;
            foreach (var item in asd)
            {
                res[iter] = EvalPos(item);
                iter++;
            }
            return res;
        }

        public static string EvalPos((int, int) coords)
        {
            string[] positions = { "Sup-Der", "Sup-Iz", "Inf-Iz", "Inf-Der", "Derecha", "Arriba", "Izquierda", "Abajo", "Centro" };
            if (coords.Item1 != 0 && coords.Item2 != 0)
            {
                if (coords.Item1 < 0 && coords.Item2 > 0)
                {
                    return positions[1];
                }
                else if (coords.Item1 > 0 && coords.Item2 > 0)
                {
                    return positions[0];
                }
                else if (coords.Item1 < 0 && coords.Item2 < 0)
                {
                    return positions[2];
                }
                else
                {
                    return positions[3];
                }
            }
            else if (coords.Item1 != 0)
            {
                if (coords.Item1 < 0)
                {
                    return positions[6];
                }
                else
                {
                    return positions[4];
                }
            }
            else if (coords.Item2 != 0)
            {
                if (coords.Item2 > 0)
                {
                    return positions[5];
                }
                else
                {
                    return positions[7];
                }
            }
            else
            {
                return positions[8];
            }
        }
    }
}
