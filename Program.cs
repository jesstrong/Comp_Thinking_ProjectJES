using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Names the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here

            Console.WriteLine("What is your favorite number?");
            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your numerical birthdate?");
            int date = Convert.ToInt32(Console.ReadLine());

            if (answer == date)
            {
                Console.WriteLine("Wow, your birthday is the same as your favorite number!");
            }
                           
            if (answer != date)
            {
                Console.WriteLine("Thanks for the info!");
            }

                               

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            {
                int n;
                Console.WriteLine("Enter a number: ");
                n = Convert.ToInt32(Console.ReadLine());
                
                if (n % 2 == 0)
                {
                    Console.WriteLine(n + "is an even number");
                }
                    
                else
                {
                    Console.WriteLine(n + "is an odd number");
                }
                    

            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

        }

        static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Enter a letter of the alphabet between A and D: ".ToLower());
            string userLetter;
            userLetter = (Console.ReadLine());

            switch (userLetter)
            {
                case "a":
                    Console.WriteLine("The letter is a vowel");
                    break;
                case "e":
                    Console.WriteLine("The letter is a vowel");
                    break;
                case "i":
                    Console.WriteLine("The letter is a vowel");
                    break;
                case "o":
                    Console.WriteLine("The letter is a vowel");
                    break;
                case "u":
                    Console.WriteLine("The letter is a vowel");
                    break;
                default:
                    Console.WriteLine("The letter is a consonent");
                    break;

            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            int firstNumber, secondNumber;
            Console.WriteLine("Let's see who is older, your mom or dad:");
            Console.WriteLine("Enter your mom's age: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your dad's age: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber < secondNumber)
            {
                Console.WriteLine("Your mom is younger than your dad.");
            }
            else
            {
                Console.WriteLine("Your mom is older.");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            double userNumber;
            Console.WriteLine("Enter a number between 10 and 20 here: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber % 3 == 0)
            {
                Console.WriteLine("your number is divisible by 3.");
            }
            else
            {
                Console.WriteLine("your number is not divisible by 3.");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
            
            Console.WriteLine("Enter number of people who went to dinner.");
            int numbDiners = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What was the cost per dinner?");
            int costDiner = Convert.ToInt32(Console.ReadLine());

            double totalBill = costDiner * numbDiners; 
                                   
            if (totalBill > 50) 
            {
                double discount = totalBill * 0.10;
                totalBill = totalBill - discount;
                Console.WriteLine("Your total bill will be $"  + totalBill + ".");
            }
            else
            {
                double discount = totalBill * 0.05;
                totalBill = totalBill - discount; 

                Console.WriteLine("Your restaurant bill:$" + totalBill);
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
            // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here

            int agePerson;
            Console.WriteLine("Enter person's age: ");
            agePerson = Convert.ToInt32(Console.ReadLine());

            if (agePerson >= 0 && agePerson <= 2) 
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (agePerson >= 3 && agePerson <= 4) 
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (agePerson >= 5 && agePerson <= 11) 
            {
                Console.WriteLine("Elementary School");
            }
            else if (agePerson >= 11 && agePerson <= 15) 
            {
                Console.WriteLine("Middle School");
            }
            else if (agePerson >= 14 && agePerson <= 19) 
            {
                Console.WriteLine("High School");
            }
            else if (agePerson >= 18 && agePerson <= 23) 
            {
                Console.WriteLine("College");
            }
            else if (agePerson >= 22 && agePerson <= 66) 
            {
                Console.WriteLine("Working for the man");
            }
            else if (agePerson >= 65 && agePerson <= 101) 
            {
                Console.WriteLine("The Golden Years");
            }
            else if (agePerson < 0 || agePerson > 100)
            {
                Console.WriteLine("It might be an alien!");
            }

            else
            {
                Console.WriteLine("This program is for humans");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here

            Console.WriteLine("Type in a number in letters, choosing between zero to ten here: ");
            string digitForm = (Console.ReadLine());

            switch (digitForm)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("You've reached the end!");
                    break;
            }
                                      
        

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here
            Console.WriteLine("Enter your first name here: ");
            string firstName = Console.ReadLine();
                    
            Console.WriteLine("Enter your last name here: ");
            string lastName = Console.ReadLine();

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("First is longer.");
            }
            else if (firstName == lastName)
            {
                Console.WriteLine("Same-sies!");
            }
            
            else
            {
                Console.WriteLine("Last must be longer!");
            }
            


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.WriteLine("What is your mother's name? ");
            string userMotherName = Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            if (userMotherName == yourName)
                Console.WriteLine("The names are the same.");
            if (userMotherName != yourName)
                Console.WriteLine("The names are different.");



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.WriteLine("What is your first name?");
            string firstName; 
            firstName = Console.ReadLine();

            Console.WriteLine("Where were you born?");
            string birthPlace;
            birthPlace = Console.ReadLine();

            Console.WriteLine("Nice to meet you, "+ firstName + "!" + birthPlace + ", WOW I was born there too!");



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
