using System.Globalization;

namespace ConsoleApp3
{
    class Product
    {
        static void Main()
        {
            string[][] questionArr = new string[10][]{ 
                new string[]{ "Azərbaycanın paytaxtı haradır?", "A) Bakı", "B) Gəncə", "C) Şəki", "D) Qəbələ", "A" },
                new string[] { "Azərbaycanın rəsmi valyutası nədir?", "A) Manat", "B) Dollar", "C) Avro", "D) Rubl", "A" },
                new string[] { "Dünyanın ən böyük gölü hansıdır?", "A) Baykal", "B) Xəzər dənizi", "C) Viktoriya", "D) Superior", "B" },
                new string[] { "Nizami Gəncəvinin doğulduğu şəhər hansıdır?", "A) Bərdə", "B) Bakı", "C) Şamaxı", "D) Gəncə", "D" },
                new string[] { "Suyun kimyəvi formulu hansıdır?", "A) H2O", "B) CO2", "C) NaCl", "D) O2", "A" },
                new string[] { "Kompüterin 'beyni' sayılan qurğu hansıdır?", "A) RAM", "B) CPU (Prosessor)", "C) HDD", "D) Videokart", "B" },
                new string[] { "Xarıbülbül hansı şəhərimizin rəmzidir?", "A) Şuşa", "B) Ağdam", "C) Kəlbəcər", "D) Füzuli", "A" },
                new string[] { "Futbol üzrə 2022-ci il Dünya Çempionatı harada keçirilib?", "A) Braziliya", "B) Fransa", "C) Qətər", "D) Almaniya", "C" },
                new string[] { "Iphone telefonlarını hansı şirkət istehsal edir?", "A) Samsung", "B) Microsoft", "C) Google", "D) Apple", "D" },
                new string[] { "Göyqurşağında neçə rəng var?", "A) 6", "B) 7", "C) 8", "D) 5", "B" }
           };


            int point = 0;
            int CorrectAnswer = 0;
            int chefAnswer=0;
            for (int i = 0; i < questionArr.Length; i++)
            {
                for (int j = 0;  j<=4; j++)
                {
                    Console.WriteLine(questionArr[i][j]);
                }
                Console.Write("Cavab Daxil edin: ");
                string answer = Console.ReadLine().Trim().ToUpper();
                
                if (answer == questionArr[i][5])
                {
                    point += 100;
                    CorrectAnswer += 1;
                    Console.WriteLine($"Cavab Düzdür Xal Elave Olundu: {point}");
                    Console.WriteLine();
                    
                }
                else 
                {
                    point -= 100;
                    chefAnswer += 1;
                    Console.WriteLine($"Sef Cavab Xal Cixildi: {point}");
                    
                }
                
            }

            Console.WriteLine();
            Console.WriteLine($"Duz cavablar: {CorrectAnswer}");
            Console.WriteLine($"Sef cavablar: {chefAnswer}");
            Console.WriteLine($"Umumi Xal: {point}");
            
           

        }
    }
}



