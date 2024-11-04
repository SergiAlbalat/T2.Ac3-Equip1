using System;
namespace Grup1{
    public class Super4{
        public static int NameSelect(int namepj, ref int vocal){
            int i = 0;
            for (i = 0; i < namepj; i++){
                if (namepj[i] == "A" || "E" || "I" || "O" || "U" || "a" || "e" || "i" || "o" || "u"){
                    vocal = vocal + 1;
                }
            }
            return i;
        }

        static void vocales(int vocal, ref double fuerzasuper4, ref int maldadpj){
            if (vocal >= 2){
                fuerzasuper4 = maldadpj / 4.0; // Calcular la fuerza como un double
                maldadpj = maldadpj % 4; 
            }else{
                fuerzasuper4 = maldadpj * 0.05; // Fuerza basada en el 5% de maldad
            }
        }

        public static void Main(){
            const string PJSELECT = "Select your character (1-4):";
            const string NAMESELECT = "Select your name:";
            const string PJMALDADSELECT = "Select your evilness level:";
            
            int numberpj;
            string namepj;
            int maldadpj;
            int vocal = 0;
            double fuerzasuper4 = 0;

            do{
                Console.WriteLine(PJSELECT);
                numberpj = int.Parse(Console.ReadLine());
            }while(numberpj > 4 || numberpj < 1);

            do{
                Console.WriteLine(NAMESELECT);
                namepj=Console.ReadLine();
            }while (nameselect(namepj) > 25 || nameselect(namepj) < 2);

            do{
                Console.WriteLine(PJMALDADSELECT);
                maldadpj = int.Parse(Console.ReadLine());
            }while(maldad > 50000 || maldad < 1000);
            vocales(vocal,ref fuerzasuper4, ref maldad);
        }
    }
}
