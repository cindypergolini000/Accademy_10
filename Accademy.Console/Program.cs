
using Accademy.GeometryAbstract;
using Accademy.Helper;
using HumanResources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Accademy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSplit();
            //TestReadFile();
            //TestHR();
            //TestGeometry();
            //TestGeometryAbstract();
            //TestLoops();
            //try
            //{
            //    TestRandom();
            //}
            //catch (RandomArgumentsException excp)
            //{
            //    throw;
            //}

            // TestGeneric();
            // Testuni00();
            TestUni2();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void TestUni2()
        {
            string b = "10000101";
            int converted_binary = Accademy.Helper.Helper.ConvertBinarytoInt(b) ;
            System.Console.WriteLine(converted_binary);
        }

        private static void Testuni00()
        { int length = 10;
            int[] firstarray = new int[length];
            int[] secondarray = new int[length];
            for (int i=0; i< length; i++)
            {
                firstarray[i] =Accademy.Helper. Helper.GetRandomInt(0,100);
                secondarray[i] = Accademy.Helper.Helper.GetSameInt(2);
            }
            bool barray1=Accademy.Helper.Helper.CheckElementsArrayDifferent(firstarray);
            bool barray2=Accademy.Helper.Helper.CheckElementsArrayDifferent(secondarray);
            if (barray1) System.Console.WriteLine("tuttidiversi"); else System.Console.WriteLine("non tutti diversi");
            if (barray2) System.Console.WriteLine("tuttidiversi"); else System.Console.WriteLine("non tutti diversi");
        }

        private static void TestGeneric()
        {
            List<int> lst_int = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            if (lst_int.Contains(3))
                System.Console.WriteLine("3 is in List");

            List<Persona> lst_persona = new List<Persona>();
            Persona mario = new Persona("Mario", "Rossi");
            Persona maria = new Persona("Maria", "Bianchi");
            Persona gianni = new Persona("Gianni", "Giallo");

            lst_persona.Add(mario);
            lst_persona.Add(maria);
            lst_persona.Add(gianni);

            Persona p = new Persona("Mario", "Rossi");

            if (lst_persona.Contains(p))
                System.Console.WriteLine("Persona is in List");
            else
                System.Console.WriteLine("Persona is NOT in List");

            System.Console.WriteLine(p.Equals(mario));
            System.Console.WriteLine(p.GetHashCode());
            System.Console.WriteLine(mario.GetHashCode());

            

            Persona sosia_mario = mario;

            //System.Console.WriteLine(sosia_mario.GetHashCode());
            //System.Console.WriteLine(mario.GetHashCode());


        }

        private static void TestRandom()
        {
            String dir = @"D:\temp";
            String filename = "accademy_random.txt";
            String path = System.IO.Path.Combine(dir, filename);

            int min = 1001;
            int max = 1000;
            
            System.IO.StreamWriter accademy_randomFile = new System.IO.StreamWriter(path);                     
            for (int i = 0; i < 50; i++)
            {

                //int r = Accademy.Helper.Helper.GetRandomInt(min, max);
                //accademy_randomFile.WriteLine(r);
                try
                {
                    int r = Accademy.Helper.Helper.GetRandomInt(min, max);
                    accademy_randomFile.WriteLine(r);
                }
                catch (RandomArgumentsException excp)
                {
                    System.Console.WriteLine(excp.Message);
                    break;
                }
                finally
                {
                    //................
                }
            }

            accademy_randomFile.Close();
            
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                int randomInt = 0;
                try
                {
                    randomInt = Int32.Parse(line);
                }
                catch (FormatException excp)
                {
                    System.Console.WriteLine(excp.Message);
                }
                System.Console.WriteLine(randomInt + 1000);
            }
            file.Close();
            //System.Console.ReadLine();
        }
        private static void TestLoops()
        {
            // declare string s ="lkjljlkj"
            // transform s in char array
            // use 'for' loop to invert array chars
            // transform the new array in string
            // console writeline the new string

            string s = "1234567890";

            char[] arrayName = s.ToCharArray();
            int length = arrayName.Length;
            char[] newArr = new char[length];


            

            for (int i = 0; i < length; i++)
            {
                newArr[length - 1 - i] = arrayName[i];
            }        

            List<char> charList = new List<char>();
            /* 0) dichairazione di una lista di char
             * 1) Ciclo for di 10 iterazioni per inserire nella lista una serie di caratteri
             * 2) dichiarare un array di char della stessa lunghezza della lista
             * 3) ciclo foreach sulla lista e inserimento inverso nell'array 
             * 4) trasformare l'array in una lista
             * 5) ciclo foreach sulla seconda lista (con la stringa in ordine inverso) per stampare i char
             */

            // 1)
            for (int i = 64; i < 74; i++)
            {
                charList.Add(Convert.ToChar(i));
            }

            // 2)
            char[] newCharArrray = new char[charList.Count];

            // 3)
            int j = charList.Count - 1;
            foreach (char c in charList)
            {
                newCharArrray[j] = c;
                j--;
            }

            // 4)
            List<char> newList = newCharArrray.ToList();

            // 5)
            foreach (char c in newList)
            {
                System.Console.WriteLine(c);
                
            }


            for (int i = 0; i < newList.Count; i++)
            {
                System.Console.WriteLine(newList.ElementAt(i));
            }
        }
        private static void TestGeometryAbstract()
        {
            GeometryAbstract.Quadrato q1 = new GeometryAbstract.Quadrato(11.009);
            GeometryAbstract.Cerchio c1 = new GeometryAbstract.Cerchio(9.25);

            PrintFiguraAbstract(q1);
            PrintFiguraAbstract(c1);

        }
        private static void PrintFiguraAbstract(GeometryAbstract.FiguraGeometrica f)
        {
            string s = f.GetDescription();
            System.Console.WriteLine(s);
        }
        private static void TestGeometry()
        {
            Accademy.Geometry.Quadrato q1 = new Accademy.Geometry.Quadrato(12.98);
            Accademy.Geometry.Cerchio c1 = new Accademy.Geometry.Cerchio(11.75);
            Accademy.Geometry.Rettangolo r1 = new Accademy.Geometry.Rettangolo(11.77, 33.99);
            Accademy.Geometry.Triangolo t1 = new Accademy.Geometry.Triangolo(3, 4, 5);
            //System.Console.WriteLine("Area {0}, Perimetro {1}", q1.GetArea(), q1.GetPerimetro());
            //System.Console.WriteLine("Area {0}, Perimetro {1}", c1.GetArea(), c1.GetPerimetro());

            //PrintQuadrato(q1);
            //PrintCerchio(c1);

            PrintFigura(q1);
            PrintFigura(c1);
            PrintFigura(r1);
            PrintFigura(t1);
        }
        private static void PrintFigura(Accademy.Geometry.IFiguraGeometrica f)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", f.GetArea(), f.GetPerimetro());
        }
        private static void PrintCerchio(Accademy.Geometry.Cerchio c1)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", c1.GetArea(), c1.GetPerimetro());
        }
        private static void PrintQuadrato(Accademy.Geometry.Quadrato q1)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", q1.GetArea(), q1.GetPerimetro());
        }
        private static void TestHR()
        {

            Persona mario = new Persona("Mario", "Rossi");
            
           
            Impiegato imp = new Impiegato();

            //System.Console.WriteLine(mario.ToString());

            String s1 = "";
            s1 = String.Empty;
            
            String s2 = "aaaa";
            String s3 = String.Concat(s1, s2);

            System.Console.WriteLine(s3.Length);
            

            //System.Console.WriteLine("Istanza mario: {0}, {1}", mario.Nome, mario.Cognome);
            System.Console.ReadLine();
        }
        private static void TestSplit()
        {
            // using String[] Split(char[] separator, StringSplitOptions options);
            string s = "25.67\t998.41";
            char[] chararray = new char[1];
            chararray[0] = '\t'; // ascii code  0x09 

            char carriageReturn = '\r'; // ascii code 0x13

            char lineFeed = '\n';  // ascii code 0x10

            char a = 'a'; // ascii code 0x61 -> 00100101
            char b = 'b'; // ascii code 0x62
            char c = 'c'; // ascii code 0x63

            String[] resultArray = s.Split(chararray);

            string temperature = resultArray[0];
            string pressure = resultArray[1];

            float temp_float = float.Parse(temperature, CultureInfo.InvariantCulture);
            float press_float = float.Parse(pressure, CultureInfo.InvariantCulture);

            System.Console.WriteLine("Temperatura {0} Pressione {1}", temp_float, press_float);
            System.Console.ReadLine();
        }
        private static void TestReadFile()
        {
            String dir = @"D:\temp";
            String filename = "pressione.txt";
            String path = dir + @"\" + filename;

            String out_temp = "temperature.txt";
            String out_press = "pressure.txt";

            System.IO.StreamWriter tempOutputFile = new System.IO.StreamWriter(
                                    System.IO.Path.Combine(dir, out_temp));

            System.IO.StreamWriter pressOutputFile = new System.IO.StreamWriter(
                                    System.IO.Path.Combine(dir, out_press));

            int var1 = 1000;
            string s1 = "aaaaaa";

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            float max_float = float.MaxValue;
            float min_float = float.MinValue;

            float min_temp = max_float;
            float min_press = max_float;

            float max_temp = min_float;
            float max_press = min_float;

            float sum_temp = 0;
            float sum_press = 0;

            char[] chararray = new char[1];
            chararray[0] = '\t'; // ascii code  0x09 

            while ((line = file.ReadLine()) != null)
            {
                if (counter > 0)
                {
                    String[] resultArray = line.Split(chararray);

                    tempOutputFile.WriteLine(resultArray[0]);
                    pressOutputFile.WriteLine(resultArray[1]);

                    float temp_float = float.Parse(resultArray[0], CultureInfo.InvariantCulture);
                    float press_float = float.Parse(resultArray[1], CultureInfo.InvariantCulture);

                    if (temp_float > max_temp)
                        max_temp = temp_float;                       
                    if (temp_float < min_temp)
                        min_temp = temp_float;

                    if (press_float > max_press)
                        max_press = press_float;
                    if (press_float < min_press)
                        min_press = press_float;

                    sum_temp = sum_temp + temp_float;
                    sum_press += press_float;

                }
                counter++;
            }
            file.Close();
            tempOutputFile.Close();
            pressOutputFile.Close();

            float media_temp = sum_temp / (counter - 1);
            float media_press = sum_press / (counter - 1);

            System.Console.WriteLine(media_temp);
            System.Console.WriteLine(media_press);

            System.Console.WriteLine("There were {0} lines. {1} and {2}", counter, var1, s1);
            System.Console.WriteLine("Max temperature {0}, Min Temperature {1}", max_temp, min_temp);
            System.Console.WriteLine("Max pressure {0}, Min pressure {1}", max_press, min_press);
            System.Console.ReadLine();
        }
    }
}
