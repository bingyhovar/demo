
using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        //System.Console.WriteLine("Hello Benji");
        ////int* a;
        ////char* c;

        //int i = 55;
        //int j = 20;
        //double d = 55555555555.123456; // 555555.21321321321
        //float number = 40.2F; // 33.33
        //char c;

        ////int double k = 10 // X NOT ALLOWED

        //Console.WriteLine(i);
        //Console.WriteLine(d);
        //Console.WriteLine(number);

        //i = 10;
        //Console.WriteLine(i);
        ////&& AND || OR



        //// If and else statements


        ///*
        //    if(condition) {

        //         The code to be executed if the condition is TRUE
        //}
        // */

        //Console.Write(i == 10); // True

        //Console.WriteLine("\n"); // to break a line in Console

        //if(i == 10)
        //{
        //    Console.WriteLine("Hi there");
        //}else
        //{
        //    Console.WriteLine("Bye");
        //}

        //// // to find out if the number is even or odd

        //int myNum = 10;

        ////Console.WriteLine(3 % 2);

        //if (myNum % 2 == 0)
        //{
        //    Console.WriteLine("The number is Even");
        //} else
        //{
        //    Console.WriteLine("The number is Odd");
        //}


        /*
         Store two numbers in different integers, 1 and 10
        if the nnumber is 1 print Huzaifa
         if the nnumber is 10 print Benji
        Other wise if the number is any number execpt 1 and 10 print Not Found
         */

        //int firstNum = 1;
        //int secondNum = 10;
        //int myLuckyNum = 5;

        //if(firstNum == 2)
        //{
        //    Console.WriteLine( "Huzaifa" );
        //    if(myLuckyNum == 5)
        //    {
        //        Console.WriteLine("I am lucky today");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("NotFound");
        //}


        //if (secondNum == 10)
        //{
        //    Console.WriteLine("Benji");
        //}else
        //{
        //    Console.WriteLine("NotFound");
        //}

        // To take input from the user and convert it into a number
        //int num = Convert.ToInt32(Console.ReadLine());


        // Take two input and add them together e.g 4 + 5 = 9

        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());

        //int result = num1 + num2;


        //Console.WriteLine(result);


        Console.WriteLine("Enter Something");


        /*
         * HW
            Take input from the user and check wether that number is even or odd
         */

        // // Else if ladder concept

        //String myFruit = "Cherry";

        //if (myFruit == "Mango")
        //{
        //    Console.WriteLine("I love Mangoes");

        //}
        //else if (myFruit == "Apple")
        //{
        //    Console.WriteLine("I love apples");
        //}
        //else if (myFruit == "Cherry")
        //{
        //    Console.WriteLine("I love Cherry");
        //}
        //else if (myFruit == "Bananna")
        //{
        //    Console.WriteLine("I love Bannanna");
        //}
        //else
        //{
        //    Console.WriteLine("NOT THE FRUIT WE WERE EXPECTING");
        //}
        //Console.WriteLine(myFruit);


        /*
         * There is a student he got 80 / 100
         * Check if the marks are 100 then its A grade
         * Check if the marks are 80 then its B grade
         * Check if the marks are 70 then its C grade
         * Check if the marks are 60 then its D grade
         * Check if the marks are 50 then its F grade
         * 
         */

        //int Agrades = 100;
        //int Bgrades = 80;
        //int Cgrades = 70;
        //int Dgrades = 60;
        //int Fgrades = 50;





        //int studentMarks = 49;
        //if (studentMarks >= 90)
        //{
        //    Console.WriteLine("A Grade");
        //}
        //else if (studentMarks >= 80)
        //{
        //    Console.WriteLine("B grade");
        //}
        //else if (studentMarks >= 70)
        //{
        //    Console.WriteLine("C grade");
        //}
        //else if (studentMarks >= 60)
        //{
        //    Console.WriteLine("D grade");
        //}
        //else if (studentMarks <= 50)
        //{
        //    Console.WriteLine("F grade");
        //}
        //else
        //{
        //    Console.WriteLine("Not graded");

        //}



        /*
          * Logical Conditions in C#
          *  && AND (if both sides are true then return true) 0 * 1 = 0 , 1 * 1 = 1
          *  || OR (if any side is true then overall return true) 0 + 1 = 1, 1 + 1 = 1

          */

        //bool myBool1 = false;
        //bool myBool2 = false;

        //if(myBool1 == true && myBool2 == true)
        //{
        //    Console.Write("We made it");
        //}else
        //{
        //    Console.Write("Bye");
        //}

        //if (myBool1 == true ||  myBool2 == true)
        //{
        //    Console.Write("We made it");
        //}
        //else
        //{
        //    Console.Write("Bye");
        //}



        int studentMarks = 32;

        if (studentMarks < 0 || studentMarks > 100)
        {
            Console.WriteLine("NOT a valid number");
        }
        else if (studentMarks >= 90 && studentMarks <= 100) // true
        {
            Console.WriteLine("A grade");
        }
        else if (studentMarks >= 80 && studentMarks <= 89) // Create a limit of 80 - 89 and give B grade
        {
            Console.WriteLine("B grade");
        }
        else if (studentMarks >= 70 && studentMarks <= 79)
        {
            Console.WriteLine("C grade");
        }
        else if (studentMarks <= 50 && studentMarks >= 0)
        {
            Console.WriteLine("F grade");
        }
        else
        {
            Console.WriteLine("Not graded");

        }

        int myNum = 22;

        switch (myNum)
        {
            case 10:
                Console.WriteLine("It 10!");
                break;
            case 20:
                Console.WriteLine("It 20!");
                break;
            case 30:
                Console.WriteLine("It 30!");
                break;
            default:
                Console.WriteLine("Num does not matches");
                break;


        }

        //Console.WriteLine("Enter the fruit");

        //String myFruit = Console.ReadLine();

        //switch (myFruit)
        //{
        //    case "banana":
        //        Console.WriteLine("i dont like it");
        //        break;
        //    case "mango":
        //        Console.WriteLine("i dont like it");
        //        break;
        //    case "apple":
        //        Console.WriteLine("i like it");
        //        break;
        //    default:
        //        Console.WriteLine("i dont know");
        //        break;
        //}

        // // to make an array we have to specify the data type
        int[] primeNumbers = { 2, 3, 5, 7, 11 };
        Console.WriteLine(primeNumbers);
        Console.WriteLine(primeNumbers[1]);

        string[] friendLists = { "James", "John", "Paul" };
        Console.WriteLine(friendLists);
        Console.WriteLine(friendLists[1]);

        // // Loops
        /*
         for(initializing statement; condition; increment){
        
                    // // code that needs to be looped...
        }
         */

        //int i = 1;

        //// // the 3 lines below have same meaning, they are all incrementing
        //i++; // 2
        //i = i + 1; // 3
        //i += 1; // 4
        //// // i-- to decrement
        //i--; // 3


        //i += 3; // 6
        //Console.WriteLine(i); // 3
        // 3 // 4 // 5

        //for (int i = 3; i < 5; i++)
        //{
        //    Console.WriteLine("I am sorry");
        //}

        //Console.WriteLine("Hey");

        // // infinite loop
        //for (; ; )
        //{
        //    Console.WriteLine("I am sorry");
        //}




        // // Debugging Process
        /*
            
         */


        int[] randomNum = { 22, 36, 29, 66, 99 };
        Console.WriteLine(randomNum);

        //for (int i = 0; i < 5; i++)
        //{
        //    //Console.WriteLine("Hello");
        //    //Console.WriteLine(i);
        //    //Console.WriteLine(randomNum[0]);
        //    Console.WriteLine(randomNum[i]);
        //}

        //string[] randomNames = { "Benji", "Huzaifa", "Adam", "Bob", "James" };
        //Console.WriteLine(randomNames);
        //for (int a = 0; a < 5; a++)
        //{
        //    Console.WriteLine("Benji");
        //    Console.WriteLine( "value of a", a);
        //    Console.WriteLine(randomNames[a]);  



        //}

        /*
         Homework:

        Make an array of random numbers
        display the even numbers 
        display the odd numbers

         */


        //int[] randNum = {1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13,14,15, 18};

        //Console.WriteLine(randNum.Length);

        //Console.WriteLine(randNum[15]);


        //for (int a = 0; a < randNum.Length; a++)
        //{
        //    //Console.WriteLine("Hi Benji");
        //    //Console.WriteLine(randNum[a]);

        //    if (randNum[a] % 2 == 0)
        //    {
        //        Console.WriteLine(randNum[a] + " Num is even");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Num is odd " + randNum[a]);
        //    }
        //}

        // // nested loop

        //for(int first = 0; first < 5; first++)
        //{
        //    for(int second = 0; second < 3; second++)
        //    {
        //        Console.WriteLine("first: " + first + " " + "second: " + second);
        //    }
        //}





        //Console.WriteLine(randNum);
        //    for (int a = 0; a < 4; a++)
        //    { 
        //        Console.WriteLine(randNum[5]);

        //    Console.WriteLine(randNum % 2);

        //    if (randNum % 2 == 0)
        //        {
        //            Console.WriteLine("The number is Even");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number is Odd");
        //    }
        //}



        // // While loop
        //int i = 0;
        //while (i < 10)// 10 false
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}


        //int[] randNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 18 };

        //// // using while loops show the even and odd numbers from the array above
        //int b = 0;
        //while (b < randNum.Length)
        //{

        //    //Console.WriteLine(randNum[b]);
        //    if (randNum[b] % 2 == 0)
        //    {
        //        Console.WriteLine(randNum[b] + " The num is even" + '\t');
        //        Console.WriteLine(" ");
        //    }
        //   else
        //    {
        //        Console.Write(randNum[b] + " The num is oddd");
        //    }
        //    b++;



        //}






        //int a = 0;
        //while(a < randNum.Length)
        //{
        //    Console.WriteLine(randNum[5]);
        //    a++;
        //}



        // // Homework:
        /*
         Do research on for and while loops in c# practice scenarios
        Show me 3 practical example of each
         */


        // // do while Loops

        //int loop = 1;

        //do
        //{
        //    Console.WriteLine("Loop no: " + loop);
        //    loop++;

        //} while (loop <= 10);


        int[] randNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 18 };
        int c = 0;
        do
        {
            //Console.WriteLine( randNum[c]);
            if (randNum[c] % 2 == 0 ) 
                Console.WriteLine(randNum[c] + " is even number");
               

            else
            {
                Console.WriteLine(randNum[c] + " is odd number");
            }
            c++;
        } while (c < randNum.Length);   


        // // Break statements

        /*
            The c# break is used to break the loop or switch statement
        it breaks the flow of the program at the given condition
         */


        for(int myLoop = 1; myLoop < 11; myLoop++)
        {
            
            Console.WriteLine(myLoop);
            if (myLoop == 5)
            {
                break;
            }
        }


        /**
       * 
       * Regular expressions in C# are used for :
                       * string matching
                       * searching
                       * manipulating text bassed on patterns
       */

        //string pattern = @"\d+"; // matches one or more digits


        //string input = "THere are 123 apples and 456 mat 512 678 123.";

        //Regex regex = new Regex(pattern);
        //Match match = regex.Match(input);

        //while(match.Success)
        //{
        //    Console.WriteLine("FOUND: " + match.Value);
        //    match = match.NextMatch();
        //}

        /**
         *  ^ string starts from
         *  . means any letter can be inserted
         *  $ end with this letter
         *  [] specifies the set of characters we want to match [a-c] abc
         *  * Period which specifies single characters
         *  + this symbol matches one or more occurrences of the pattern
         *  ? this symbol matches zero or one occurrence of the pattern left to it
         *  | OR symbol a|b means all a's and b's
         *  () is used to group the sub patterns (x|y)xy
         *  
         */

        //string pattern = "^....ung$"; // matches one or more digits
        //string pattern = "[a-z]"; // matches one or more digits


        //Regex myReg = new Regex(pattern);

        //if (myReg.IsMatch("bbbbbb")){
        //    Console.WriteLine("String matches the pattern");
        //} else
        //{
        //    Console.WriteLine("String doesn't match");
        //}




        //string pattern = @"m*"; // zero, m and any consecutive m's together
        //string pattern = @"^m"; // starts with m
        //string pattern = @"m$"; // ends with m
        //string pattern = @"ca*t"; // Matches c followed by zero or more a's followed by t
        //string pattern = @"ze+p"; // matches z followed by e then end with p
        //string pattern = @"pe?n"; // matches p followed by only e or no character then n
        //string pattern = @"sun"; // 
        //string pattern = @"a{2,3}"; // finding all sets of 2 a's and 3 a's which are consecutive
        //string pattern = @"aa|b|c"; // finds all two a's together (aa) b's and c's
        //string pattern = @"(1|x)ab"; // finds allwith x or y ending with ab

        //Regex myReg = new Regex(pattern);

        //string input = "xab yab xxab yyab 1ab ab ";
        ///// find matches
        //MatchCollection matches = myReg.Matches(input);

        //// display the matches
        //Console.WriteLine("Matches found...");
        //foreach(Match match in matches)
        //{
        //    if (!string.IsNullOrEmpty(match.Value))
        //    {
        //        Console.WriteLine($"{match.Value} at position {match.Index}");
        //    }
        //}


        // Practice down here !!!!
        //string pattern = "Ben";
        //Console.WriteLine("Ben Jamin:" + Regex.IsMatch(input:"Ben",pattern));
        //Console.WriteLine("benj Jamin:" + Regex.IsMatch(input:"benj",pattern));
        //Console.WriteLine("Benja Jamin:" + Regex.IsMatch(input:"Benja",pattern));
        //Console.WriteLine("Rebending:" + Regex.IsMatch(input: "Rebending", pattern));


        string pattern = "[Bb]en";
        Console.WriteLine("Ben Jamin:" + Regex.IsMatch(input: "Ben", pattern));
        Console.WriteLine("benj Jamin:" + Regex.IsMatch(input: "benj", pattern));
        Console.WriteLine("Benja Jamin:" + Regex.IsMatch(input: "Benja", pattern));
        Console.WriteLine("Rebending:" + Regex.IsMatch(input: "Rebending", pattern));



    }
}



/*
 C# Data Types

Value Data Types: int, char, float, double, boolean, short
Pointers & (is a address operator which determine the address of a variable) * (it is a indrect operator and it can access the value of an address)
References Data Types: String, Class, Object, Interface


 */



