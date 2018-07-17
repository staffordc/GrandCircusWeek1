using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool LoopRunProgram = true;
            while (LoopRunProgram == true)
            {


                Console.WriteLine("Welcome to the Grand Circus' Room Calculator");
                //Enter Length
                double Length = GetLength();


                //Enter Width
                double Width = GetWidth();

                //Enter Height
                double Height = GetHeight();

                
                //Show Area (LxW)
                var Area = CalculateArea(Length, Width);
                Console.WriteLine("Here's the area:");
                Console.WriteLine(Area);


                //Show Perimeter 2(L+W)
                var Perimeter = CalculatePerimeter(Length, Width);
                Console.WriteLine("Here's your perimeter:");
                Console.WriteLine(Perimeter);

                //Show Volume Area*Height
                var Volume = CalculateVolume(Height, Length, Width);
                if (Height == 0)
                {
                    Console.WriteLine("I see you didn't put a height in, no volume for you");
                }
                else
                {
                    Console.WriteLine("Woah, you kicked it up a notch, here's your volume");
                    Console.WriteLine(Volume);
                }


                //Continue? (Y/N) (maybe put in something about not choosing those two)
                Console.WriteLine("Was that fun for you? I hope so... Do you want put in more measurements?");
                var Result = Console.ReadLine();
                if ("y" == Result)
                {

                }
                else
                {
                    LoopRunProgram = false;
                }
            }
        }

        private static double CalculatePerimeter(double length, double width)
        {
            return (2 * (length + width));
        }

        private static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        private static double CalculateVolume(double length, double width, double height)
        {
            return (height * (length + width));
        }

        public static double GetWidth()
        {
            Console.WriteLine("What's another arbitrary side of the room in feet?");

            double myNum;
            bool NumLoopCheckWidth = true;
            String inputWidth;
            double resultWidth = 0;
            while (NumLoopCheckWidth == true)
            {
                inputWidth = Console.ReadLine();

                if (Double.TryParse(inputWidth, out myNum))
                {
                    Console.WriteLine("Wicked good number bro");
                    NumLoopCheckWidth = false;
                    resultWidth = double.Parse(inputWidth);

                }
                else
                {
                    Console.WriteLine("Look, I don't want to put you on the spot, but that's not a number. Just make something up, c'mon");
                }
            }

            //Width is a number?
            return resultWidth;
        }

        public static double GetHeight()
        {
            Console.WriteLine("Let's step it up a notch, wanna give me the height?");

            double myNum;
            //is the Height a Number?
            bool NumLoopCheckHeight = true;
            String inputHeight;
            double resultHeight = 0;
            while (NumLoopCheckHeight == true)
            {
                inputHeight = Console.ReadLine();

                if (Double.TryParse(inputHeight, out myNum))
                {
                    Console.WriteLine("Alright: here are your results");
                    NumLoopCheckHeight = false;
                    resultHeight = double.Parse(inputHeight);

                }
                else if ("no" == inputHeight)
                {
                    Console.WriteLine("aw, you're no fun");
                    NumLoopCheckHeight = false;

                }
                else
                {
                    Console.WriteLine("You don't have to be difficult, you know? Any number will do");
                }
            }
          
            return resultHeight;
        }

        public static double GetLength()
        {
            Console.WriteLine("Could I have one of the rooms measurements in feet?");
            //Length is a number?

            double myNum = 0;
            bool NumLoopCheckLength = true;
            String inputLength;
            double resultLength = 0;
            while (NumLoopCheckLength == true)
            {
                inputLength = Console.ReadLine();

                if (Double.TryParse(inputLength, out myNum))
                {
                    Console.WriteLine("Nice, nice, let's keep this roll up");
                    NumLoopCheckLength = false;
                    resultLength = double.Parse(inputLength);

                }
                else
                {
                    Console.WriteLine("Ha ha, good one, but could you try to put a number in instead you goof?");
                }
            }


            return resultLength;

        }
    }
}