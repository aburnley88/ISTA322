using System;
using System.Threading;

namespace ISTA322Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;


            PrintWheel();
            Thread.Sleep(1000);
            SpinWheel();



        }

        static void PrintWheel()
        {
            string[] slots = new string[] { "0", "00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" };
            string[] colors = new string[] { "Green", "Green", "Black", "Red", "Red", "Black", "Black", "Black", "Red", "Black", "Red", "Red", "Red", "Red", "Red", "Black", "Black", "Red", "Red", "Black", "Black", "Black", "Black", "Black", "Black", "Red", "Red", "Red", "Red", "Black", "Black", "Black", "Black", "Red", "Red", "Black", "Red", "Black", };

            Console.WriteLine("Here is the Wheel:");
            for (int i = 0; i < 38; i++)
            {
                Console.WriteLine($"Slot {slots[i]} - {colors[i]}");
                Thread.Sleep(0250);
            }
            Console.WriteLine("\n\n");
        }
        static void SpinWheel()
        {
            string[] slots = new string[] { "0", "00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" };
            string[] colors = new string[] { "Green", "Green", "Black", "Red", "Red", "Black", "Black", "Black", "Red", "Black", "Red", "Red", "Red", "Red", "Red", "Black", "Black", "Red", "Red", "Black", "Black", "Black", "Black", "Black", "Black", "Red", "Red", "Red", "Red", "Black", "Black", "Black", "Black", "Red", "Red", "Black", "Red", "Black", };

            Console.WriteLine("Time to spin the wheel and see where the ball lands!!!!\n");
            Thread.Sleep(0700);
            Console.WriteLine("...rolling and spinning...\n\n");
            Thread.Sleep(1000);

            Random r = new Random();
            for (int i = 0; i<1; i++)
            {
                string color = "";
                int temp = r.Next(0, 37);
                Console.WriteLine($"The ball landed on Slot {slots[temp]} - {colors[temp]}");
                color = colors[temp];
                WinningNumber(temp);
                WinningColor(color);
                OddEven(temp);
                LowHigh(temp);
                Dozens(temp);
                RowWinner(temp);
                StWinners(temp);
                SixNumbersWinner(temp);
                SplitWinner(temp);
                CornerWinner(temp);
            }         
        }
        static void WinningNumber(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;
            Console.WriteLine($"The winning number is: {temp}");
        }
        static void WinningColor(string color)
        {
            Console.WriteLine($"The winning color is {color}");

        }
        static void OddEven(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;
            if (temp % 2 == 0)
            
                Console.WriteLine("The winner is Even");
            else
                Console.WriteLine("The winner is Odd");         
        }
        static void LowHigh(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;
            if (temp <= 18)
            
                Console.WriteLine("The winner is low");
            else
                Console.WriteLine("The winner is high");          
        }
        static void Dozens(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;
            if (temp <= 12)
                Console.WriteLine("The winner is dozen 1 (1-12)");
            if (temp >12 && temp <= 24)
                Console.WriteLine("The winner is dozen 2 (13-24)");
            if (temp >24 && temp <=36)
                Console.WriteLine("The winner is dozen 3 (25-36)");
        }
        static void RowWinner(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;
            int[] row1 = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] row2 = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] row3 = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            bool alpha = Array.Exists(row1, element => element == temp);
            bool bravo = Array.Exists(row2, element => element == temp);
            bool charlie = Array.Exists(row3, element => element == temp);

            if (alpha)          
                Console.WriteLine("The row winner is row 1 (1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34)");        
            if (bravo)
                Console.WriteLine("The row winner is 2 (2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35)");
            if (charlie)
                Console.WriteLine("The row winner is row 3 (3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36) ");
        }
    static void StWinners (int temp)
        {
            if (temp == 0)
                temp++;
            temp--;
            int[] st1 = new int[] { 1, 2, 3 };
            int[] st2 = new int[] { 4,5,6 };
            int[] st3 = new int[] { 7,8,9};
            int[] st4 = new int[] { 10, 11, 12 };
            int[] st5 = new int[] { 13,14,15 };
            int[] st6 = new int[] { 16,17,18};
            int[] st7 = new int[] { 19,20,21 };
            int[] st8 = new int[] { 22,23,24 };
            int[] st9 = new int[] { 25,26,27};
            int[] st10 = new int[] { 28,29,30 };
            int[] st11 = new int[] { 31,32,33 };
            int[] st12= new int[] { 34,35,36 };
            int[] st13 = new int[] { 0, 00 };

            bool S1 = Array.Exists(st1, element => element == temp);
            bool S2 = Array.Exists(st2, element => element == temp);
            bool S3 = Array.Exists(st3, element => element == temp);
            bool S4 = Array.Exists(st4, element => element == temp);
            bool S5 = Array.Exists(st5, element => element == temp);
            bool S6 = Array.Exists(st6, element => element == temp);
            bool S7 = Array.Exists(st7, element => element == temp);
            bool S8 = Array.Exists(st8, element => element == temp);
            bool S9 = Array.Exists(st9, element => element == temp);
            bool S10 = Array.Exists(st10, element => element == temp);
            bool S11 = Array.Exists(st11, element => element == temp);
            bool S12 = Array.Exists(st12, element => element == temp);
            bool S13 = Array.Exists(st13, element => element == temp);

            if (S1) Console.WriteLine("The winning street is 1/2/3");
            if (S2) Console.WriteLine("The winning street is 4/5/6");
            if (S3) Console.WriteLine("The winning street is 7/8/9");
            if (S4) Console.WriteLine("The winning street is 10/11/12");
            if (S5) Console.WriteLine("The winning street is 13/14/15");
            if (S6) Console.WriteLine("The winning street is 16/17/18");
            if (S7) Console.WriteLine("The winning street is 19/20/21");
            if (S8) Console.WriteLine("The winning street is 22/23/24");
            if (S9) Console.WriteLine("The winning street is 25/26/27");
            if (S10) Console.WriteLine("The winning street is 28/29/30");
            if (S11) Console.WriteLine("The winning street is 31/32/33");
            if (S12) Console.WriteLine("The winning street is 34/35/36");
            if (S13) Console.WriteLine("The winning street is 0/ /00");
        }  
        static void SplitWinner(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;

            int[] splitA = new int[] { 1, 2 };
            int[] splitB = new int[] { 2, 3 };
            int[] splitC = new int[] { 1, 4 };
            int[] splitD= new int[] { 2, 5 };
            int[] splitE= new int[] { 3, 6 };
            int[] splitF = new int[] { 4, 5 };
            int[] splitG = new int[] { 5, 6};
            int[] splitH = new int[] {4,7};
            int[] splitI = new int[] { 5, 8 };
            int[] splitJ = new int[] { 6, 9 };
            int[] splitK = new int[] { 7, 8 };
            int[] splitL = new int[] { 8, 9 };
            int[] splitM = new int[] { 7, 10};
            int[] splitN = new int[] { 8, 11 };
            int[] splitO = new int[] {9, 12 };
            int[] splitP = new int[] { 10, 11 };
            int[] splitQ = new int[] { 11, 12 };
            int[] splitR = new int[] { 10, 13};
            int[] splitS = new int[] { 11, 14 };
            int[] splitT = new int[] { 12, 13};
            int[] splitU = new int[] { 13, 14 };
            int[] splitV = new int[] { 14, 15 };
            int[] splitW = new int[] { 13, 16 };
            int[] splitX = new int[] { 14, 17};
            int[] splitY = new int[] { 15, 18 };
            int[] splitZ = new int[] { 16, 17};
            int[] splitAA = new int[] { 17, 18 };
            int[] splitAB = new int[] { 16, 19 };
            int[] splitAC = new int[] { 17, 20 };
            int[] splitAD = new int[] { 18, 21};
            int[] splitAE = new int[] { 19, 20 };
            int[] splitAF = new int[] { 20, 21 };
            int[] splitAG = new int[] { 19, 22 };
            int[] splitAH= new int[] { 20, 23 };
            int[] splitAI = new int[] { 21, 24 };
            int[] splitAJ = new int[] { 22, 23 };
            int[] splitAK = new int[] { 23, 24 };
            int[] splitAL = new int[] { 22, 25 };
            int[] splitAM = new int[] { 23, 26 };
            int[] splitAN = new int[] { 24, 27 };
            int[] splitAO= new int[] { 25, 26 };
            int[] splitAP = new int[] { 26, 27 };
            int[] splitAQ = new int[] { 25, 28 };
            int[] splitAR = new int[] { 26, 29 };
            int[] splitAS = new int[] { 27, 30 };
            int[] splitAT = new int[] { 28, 29 };
            int[] splitAU= new int[] { 29, 30 };
            int[] splitAV = new int[] { 28, 31};
            int[] splitAW = new int[] {  29, 32 };
            int[] splitAX = new int[] { 30, 33 };
            int[] splitAY = new int[] { 31, 32 };
            int[] splitAZ = new int[] { 32, 33 };
            int[] splitBB = new int[] { 31, 34 };
            int[] splitBC = new int[] { 32, 35 };
            int[] SplitBD = new int[] { 33, 36 };
            int[] splitBE = new int[] { 34, 35 };
            int[] splitBF= new int[] { 35, 36 };
            int[] splitBG = new int[] { 00, 3 };
            int[] splitBH = new int[] { 0, 1 };

            bool SP1 = Array.Exists(splitA, element => element == temp);
            bool SP2 = Array.Exists(splitB, element => element == temp);
            bool SP3 = Array.Exists(splitC, element => element == temp);
            bool SP4 = Array.Exists(splitD, element => element == temp);
            bool SP5 = Array.Exists(splitE, element => element == temp);
            bool SP6 = Array.Exists(splitF, element => element == temp);
            bool SP7 = Array.Exists(splitG, element => element == temp);
            bool SP8 = Array.Exists(splitH, element => element == temp);
            bool SP9 = Array.Exists(splitI, element => element == temp);
            bool SP10 = Array.Exists(splitJ, element => element == temp);
            bool SP11 = Array.Exists(splitK, element => element == temp);
            bool SP12 = Array.Exists(splitL, element => element == temp);
            bool SP13 = Array.Exists(splitM, element => element == temp);
            bool SP14 = Array.Exists(splitN, element => element == temp);
            bool SP15 = Array.Exists(splitO, element => element == temp);
            bool SP16 = Array.Exists(splitP, element => element == temp);
            bool SP17 = Array.Exists(splitQ, element => element == temp);
            bool SP18 = Array.Exists(splitR, element => element == temp);
            bool SP19 = Array.Exists(splitS, element => element == temp);
            bool SP20 = Array.Exists(splitT, element => element == temp);

            bool SP21 = Array.Exists(splitU, element => element == temp);
            bool SP22 = Array.Exists(splitV, element => element == temp);
            bool SP23 = Array.Exists(splitW, element => element == temp);
            bool SP24 = Array.Exists(splitX, element => element == temp);
            bool SP25 = Array.Exists(splitY, element => element == temp);
            bool SP26 = Array.Exists(splitZ, element => element == temp);
            bool SP27 = Array.Exists(splitAA, element => element == temp);
            bool SP28 = Array.Exists(splitAB, element => element == temp);
            bool SP29 = Array.Exists(splitAC, element => element == temp);
            bool SP30 = Array.Exists(splitAD, element => element == temp);
            bool SP31 = Array.Exists(splitAE, element => element == temp);
            bool SP32 = Array.Exists(splitAF, element => element == temp);
            bool SP33 = Array.Exists(splitAG, element => element == temp);
            bool SP34 = Array.Exists(splitAH, element => element == temp);
            bool SP35 = Array.Exists(splitAI, element => element == temp);
            bool SP36 = Array.Exists(splitAJ, element => element == temp);
            bool SP37 = Array.Exists(splitAK, element => element == temp);
            bool SP38 = Array.Exists(splitAL, element => element == temp);
            bool SP39 = Array.Exists(splitAM, element => element == temp);
            bool SP40 = Array.Exists(splitAN, element => element == temp);

            bool SP41 = Array.Exists(splitAO, element => element == temp);
            bool SP42 = Array.Exists(splitAP, element => element == temp);
            bool SP43 = Array.Exists(splitAQ, element => element == temp);
            bool SP44 = Array.Exists(splitAR, element => element == temp);
            bool SP45 = Array.Exists(splitAS, element => element == temp);
            bool SP46 = Array.Exists(splitAT, element => element == temp);
            bool SP47 = Array.Exists(splitAU, element => element == temp);
            bool SP48 = Array.Exists(splitAV, element => element == temp);
            bool SP49 = Array.Exists(splitAW, element => element == temp);
            bool SP50 = Array.Exists(splitAX, element => element == temp);
            bool SP51 = Array.Exists(splitAY, element => element == temp);
            bool SP52 = Array.Exists(splitAZ, element => element == temp);
            bool SP53 = Array.Exists(splitBB, element => element == temp);
            bool SP54 = Array.Exists(splitBC, element => element == temp);
            bool SP55 = Array.Exists(SplitBD, element => element == temp);
            bool SP56 = Array.Exists(splitBE, element => element == temp);
            bool SP57 = Array.Exists(splitBF, element => element == temp);
            bool SP58 = Array.Exists(splitBG, element => element == temp);
            bool SP59 = Array.Exists(splitBH, element => element == temp);

            if (SP1) Console.WriteLine($"The winning split is: 1|2 ");
            if (SP2) Console.WriteLine($"The winning split is: 2|3 ");
            if (SP3) Console.WriteLine($"The winning split is: 1|4  ");
            if (SP4) Console.WriteLine($"The winning split is: 2|5 ");
            if (SP5) Console.WriteLine($"The winning split is: 3|6 ");
            if (SP6) Console.WriteLine($"The winning split is: 4|5 ");
            if (SP7) Console.WriteLine($"The winning split is: 5|6 ");
            if (SP8) Console.WriteLine($"The winning split is: 4|7 ");
            if (SP9) Console.WriteLine($"The winning split is: 5|8 ");
            if (SP10) Console.WriteLine($"The winning split is: 6|9 ");
            if (SP11) Console.WriteLine($"The winning split is: 7|8 ");
            if (SP12) Console.WriteLine($"The winning split is: 8|9 ");
            if (SP13) Console.WriteLine($"The winning split is: 7|10 ");
            if (SP14) Console.WriteLine($"The winning split is: 8|11 ");
            if (SP15) Console.WriteLine($"The winning split is: 9|12 ");
            if (SP16) Console.WriteLine($"The winning split is: 10|11 ");
            if (SP17) Console.WriteLine($"The winning split is: 11|12 ");
            if (SP18) Console.WriteLine($"The winning split is: 10|13 ");
            if (SP19) Console.WriteLine($"The winning split is: 11|14 ");
            if (SP20) Console.WriteLine($"The winning split is: 12|13 ");
            if (SP21) Console.WriteLine($"The winning split is 13|14 ");
            if (SP22) Console.WriteLine($"The winning split is 14|15 ");
            if (SP23) Console.WriteLine($"The winning split is 13|16 ");
            if (SP24) Console.WriteLine($"The winning split is 14|17 ");
            if (SP25) Console.WriteLine($"The winning split is 15|18 ");
            if (SP26) Console.WriteLine($"The winning split is 16|17 ");
            if (SP27) Console.WriteLine($"The winning split is 17|18 ");
            if (SP28) Console.WriteLine($"The winning split is 16|19 ");
            if (SP29) Console.WriteLine($"The winning split is 17|20 ");
            if (SP30) Console.WriteLine($"The winning split is 18|21 ");
            if (SP31) Console.WriteLine($"The winning split is 19|20 ");
            if (SP32) Console.WriteLine($"The winning split is 20|21 ");
            if (SP33) Console.WriteLine($"The winning split is 19|22 ");
            if (SP34) Console.WriteLine($"The winning split is 20|23 ");
            if (SP35) Console.WriteLine($"The winning split is 21|24 ");
            if (SP36) Console.WriteLine($"The winning split is 22|23 ");
            if (SP37) Console.WriteLine($"The winning split is 23|24 ");
            if (SP38) Console.WriteLine($"The winning split is 22|25 ");
            if (SP39) Console.WriteLine($"The winning split is 23|26 ");
            if (SP40) Console.WriteLine($"The winning split is 24|27 ");
            if (SP41) Console.WriteLine($"The winning split is 26|26 ");
            if (SP42) Console.WriteLine($"The winning split is 26|27 ");
            if (SP43) Console.WriteLine($"The winning split is 25|28 ");
            if (SP44) Console.WriteLine($"The winning split is 26|29 ");
            if (SP45) Console.WriteLine($"The winning split is 27|30 ");
            if (SP46) Console.WriteLine($"The winning split is 28|29 ");
            if (SP47) Console.WriteLine($"The winning split is 29|30 ");
            if (SP48) Console.WriteLine($"The winning split is 28|31 ");
            if (SP49) Console.WriteLine($"The winning split is 29|32 ");
            if (SP50) Console.WriteLine($"The winning split is 30|33 ");
            if (SP51) Console.WriteLine($"The winning split is 31|32 ");
            if (SP52) Console.WriteLine($"The winning split is 32|33 ");
            if (SP53) Console.WriteLine($"The winning split is 31|34 ");
            if (SP54) Console.WriteLine($"The winning split is 32|35 ");
            if (SP55) Console.WriteLine($"The winning split is 33|36 ");
            if (SP56) Console.WriteLine($"The winning split is 34|35 ");
            if (SP57) Console.WriteLine($"The winning split is 35|36 ");
            if (SP58) Console.WriteLine("The winning split is 00|3");
            if (SP59) Console.WriteLine("The winning split is 0|1");
        }
        static void SixNumbersWinner(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;

            int[] grp1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] grp2 = new int[] { 4, 5, 6, 7, 8, 9 };
            int[] grp3 = new int[] { 7, 8, 9, 10, 11, 12 };
            int[] grp4 = new int[] { 10, 11, 12, 13, 14, 15 };
            int[] grp5 = new int[] { 13, 14, 15, 16, 17, 18 };
            int[] grp6 = new int[] { 16, 17, 18, 19, 20, 21 };
            int[] grp7 = new int[] { 19, 21, 22, 23, 24 };
            int[] grp8 = new int[] { 22, 23, 24, 25, 26, 27 };
            int[] grp9 = new int[] { 25, 26, 27, 28, 29, 30 };
            int[] grp10 = new int[] { 28, 29, 30, 31, 32, 33 };
            int[] grp11 = new int[] { 31, 32, 33, 34, 35, 36 };

            bool Grp1 = Array.Exists(grp1, element => element == temp);
            bool Grp2 = Array.Exists(grp2, element => element == temp);
            bool Grp3 = Array.Exists(grp3, element => element == temp);
            bool Grp4 = Array.Exists(grp4, element => element == temp);
            bool Grp5 = Array.Exists(grp5, element => element == temp);
            bool Grp6 = Array.Exists(grp6, element => element == temp);
            bool Grp7 = Array.Exists(grp7, element => element == temp);
            bool Grp8 = Array.Exists(grp8, element => element == temp);
            bool Grp9 = Array.Exists(grp9, element => element == temp);
            bool Grp10 = Array.Exists(grp10, element => element == temp);
            bool Grp11 = Array.Exists(grp11, element => element == temp);

            if (Grp1) Console.WriteLine("The winning 6 is: 1, 2, 3, 4, 5, 6 ");
            if (Grp2) Console.WriteLine("The winning 6 is: 4, 5, 6, 7, 8, 9 ");
            if (Grp3) Console.WriteLine("The winning 6 is:  7, 8, 9, 10, 11, 12");
            if (Grp4) Console.WriteLine("The winning 6 is: 10, 11, 12, 13, 14, 15");
            if (Grp5) Console.WriteLine("The winning 6 is:13, 14, 15, 16, 17, 18 ");
            if (Grp6) Console.WriteLine("The winning 6 is:  16, 17, 18, 19, 20, 21");
            if (Grp7) Console.WriteLine("The winning 6 is: 19, 21, 22, 23, 24 ");
            if (Grp8) Console.WriteLine("The winning 6 is:  22, 23, 24, 25, 26, 27 ");
            if (Grp9) Console.WriteLine("The winning 6 is: 25, 26, 27, 28, 29, 30  ");
            if (Grp10) Console.WriteLine("The winning 6 is: 28, 29, 30, 31, 32, 33 ");
            if (Grp11) Console.WriteLine("The winning 6 is: 31, 32, 33, 34, 35, 36 ");
        }
        static void CornerWinner(int temp)
        {
            if (temp == 0)
                temp++;
            temp--;

            int[] set1 = new int[] { 1, 2, 4, 5 };
            int[] set2 = new int[] { 2,3,5,6 };
            int[] set3 = new int[] { 4,5, 7, 8 };
            int[] set4 = new int[] { 5, 6, 8, 9 };
            int[] set5 = new int[] { 7, 8, 10, 11 };
            int[] set6 = new int[] { 8, 9, 11, 12 };
            int[] set7 = new int[] { 10, 11, 13, 14 };
            int[] set8 = new int[] { 11, 12, 13, 14 };
            int[] set9 = new int[] { 13, 14, 16, 17 };
            int[] set10 = new int[] { 14, 15, 17, 18 };
            int[] set11 = new int[] { 16, 17, 19, 20 };
            int[] set12 = new int[] { 17, 18, 20, 21 };
            int[] set13 = new int[] { 19, 20, 22, 23 };
            int[] set14 = new int[] { 20, 21, 23, 24 };
            int[] set15 = new int[] { 22, 23, 25, 26 };
            int[] set16 = new int[] { 23, 24, 26, 27 };
            int[] set17 = new int[] { 25, 26, 28, 29 };
            int[] set18 = new int[] { 26, 27, 29, 30 };
            int[] set19 = new int[] { 28, 29, 31, 32 };
            int[] set20 = new int[] { 29, 30, 32, 33 };
            int[] set21 = new int[] { 31, 32, 34, 35 };
            int[] set22 = new int[] { 32, 33, 35, 36 };

            bool Set1 = Array.Exists(set1, element => element == temp);
            bool Set2 = Array.Exists(set2, element => element == temp);
            bool Set3 = Array.Exists(set3, element => element == temp);
            bool Set4 = Array.Exists(set4, element => element == temp);
            bool Set5 = Array.Exists(set5, element => element == temp);
            bool Set6 = Array.Exists(set6, element => element == temp);
            bool Set7 = Array.Exists(set7, element => element == temp);
            bool Set8 = Array.Exists(set8, element => element == temp);
            bool Set9 = Array.Exists(set9, element => element == temp);
            bool Set10 = Array.Exists(set10, element => element == temp);
            bool Set11 = Array.Exists(set11, element => element == temp);
            bool Set12 = Array.Exists(set12, element => element == temp);
            bool Set13 = Array.Exists(set13, element => element == temp);
            bool Set14 = Array.Exists(set14, element => element == temp);
            bool Set15 = Array.Exists(set15, element => element == temp);
            bool Set16 = Array.Exists(set16, element => element == temp);
            bool Set17 = Array.Exists(set17, element => element == temp);
            bool Set18 = Array.Exists(set18, element => element == temp);
            bool Set19 = Array.Exists(set19, element => element == temp);
            bool Set20 = Array.Exists(set20, element => element == temp);
            bool Set21 = Array.Exists(set21, element => element == temp);
            bool Set22 = Array.Exists(set22, element => element == temp);

            if (Set1) Console.WriteLine("The corner winner is : 1, 2, 4, 5" );
            if (Set2) Console.WriteLine("The corner winner is : 2, 3, 5, 6");
            if (Set3) Console.WriteLine("The corner winner is: 4,5, 7, 8");
            if (Set4) Console.WriteLine("The corner winner is : 5, 6, 8, 9");
            if (Set5) Console.WriteLine("The corner winner is : 7, 8, 10, 11");
            if (Set6) Console.WriteLine("The corner winner is : 8, 9, 11, 12");
            if (Set7) Console.WriteLine("The conrner winner is: 10, 11, 13, 14");
            if (Set8) Console.WriteLine("The corner winner is: 11, 12, 13, 14");
            if (Set9) Console.WriteLine("The corner winner is: 13, 14, 16, 17");
            if (Set10) Console.WriteLine("The corner winner is: 14, 15, 17, 18");
            if (Set11) Console.WriteLine("The corner winner is : 16, 17, 19, 20");
            if (Set12) Console.WriteLine("THe corner winner is: 17, 18, 20, 21");
            if (Set13) Console.WriteLine("The corner winner is: 19, 20, 22, 23");
            if (Set14) Console.WriteLine("The corner winner is: 20, 21, 23, 24");
            if (Set15) Console.WriteLine("The corner winner is: 22, 23, 25, 26");
            if (Set16) Console.WriteLine("The corner winner is: 23, 24, 26, 27");
            if (Set17) Console.WriteLine("The corner winner is:  25, 26, 28, 29 ");
            if (Set18) Console.WriteLine("The corner winner is: 26, 27, 29, 30");
            if (Set19) Console.WriteLine("The corner winner is: 28, 29, 31, 32");
            if (Set20) Console.WriteLine("The corner winner is:  29, 30, 32, 33");
            if (Set21) Console.WriteLine("The corner winner is: 31, 32, 34, 35");
            if (Set22) Console.WriteLine("The corner winner is: 32, 33, 35, 36");

        }
    }
}
