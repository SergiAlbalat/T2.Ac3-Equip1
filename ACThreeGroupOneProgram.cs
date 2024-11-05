using System;
namespace Grup1
{
    public class Super4
    {
        public static int NameSelect(string namepj, ref int vocal)
        {
            int i = 0;
            char[] nameChar = namepj.ToCharArray();
            for (i = 0; i < namepj.Length; i++)
            {
                if (nameChar[i] == 'A' )
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'E')
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'I')
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'O')
                {

                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'U')
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'a')
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'e')
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'i')
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'o')
                {
                    vocal = vocal + 1;
                }
                else if (nameChar[i] == 'u')
                {
                    vocal = vocal + 1;
                }
            }
            return i;
        }

        static void vocales(int vocal, ref double fuerzasuper4, ref int maldadpj)
        {
            if (vocal >= 2)
            {
                fuerzasuper4 = maldadpj / 4.0; // Calcular la fuerza como un double
                maldadpj = maldadpj % 4;
            }
            else
            {
                fuerzasuper4 = maldadpj * 0.05; // Fuerza basada en el 5% de maldad
            }
        }

        public static void Main()
        {
            const string PJSELECT = "Select your character (1-4):";
            const string NAMESELECT = "Select your name:";
            const string PJMALDADSELECT = "Select your evilness level:";

            int numberpj;
            string namepj;
            int maldadpj;
            int vocal = 0;
            double fuerzasuper4 = 0;

            do
            {
                Console.WriteLine(PJSELECT);
                numberpj = int.Parse(Console.ReadLine());
            } while (numberpj > 4 || numberpj < 1); //error arreglat en la condicio del while en el que la segona condicio del or no estaba ben especificada

            do
            {
                Console.WriteLine(NAMESELECT);
                namepj = Console.ReadLine();
            } while (NameSelect(namepj, ref vocal) > 25 || NameSelect(namepj, ref vocal) < 2); //error arreglat en la condicio del while en el que la segona condicio del or no estaba ben especificada

            do
            {
                Console.WriteLine(PJMALDADSELECT);
                maldadpj = int.Parse(Console.ReadLine());
            } while (maldadpj > 50000 || maldadpj < 1000); //error arreglat en la condicio del while en el que la segona condicio del or no estaba ben especificada
            vocales(vocal, ref fuerzasuper4, ref maldadpj);
        }
    }
}
