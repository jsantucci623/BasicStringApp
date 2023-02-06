// Basic Strings
// Jeff Santucci
// 02/02/2023

// 1. Description
// Prompt the user to enter a sentence.  Split the sentence into individual words and display each word on its own line.

using System.Diagnostics.Metrics;

string completeSentence;
bool isTrue;

do
{
    Console.Write("Enter a sentence: ");
    completeSentence = Console.ReadLine();

    string[] splitResult = completeSentence.Split(' ');

    for (int i = 0; i < splitResult.Length; i++)
    {
        Console.WriteLine(splitResult[i]);
    }
    Console.Write("Would you like to continue? (y/n) ");
    string answer = Console.ReadLine();
    answer = answer.ToLower();

    if (answer == "y")
    {
        isTrue = true;
    }
    else
    {
        isTrue = false;
    }    

} while (isTrue);
Console.WriteLine("Goodbye!");

// 2. Repeatedly prompt the user to enter a string.
//    Store the string in a list and display the contents of the list with each element separated by a space.

// ToList Demo
// string animalsString = "dog, cat, mouse, ardvark, butterfly, bee";
// string[] arrayOfAnimals = animalsString.Split(", ");

// List<string> LargeAnimalList = arrayOfAnimals.ToList();

// List<string>LargeAnimalLIst  = animalsString.Split(", ").ToList();  All in one line what happens in the two lines above.
/*
Example
>> Enter some text: << The
<< You have entered: The
Would you like to continue (y/n)? << y
>> Enter some text: << cow
<< You have entered: The cow
Would you like to continue (y/n)? << y
>> Enter some text: << jumped...
<< You have entered: The cow jumped...
Would you like to continue (y/n)? << n
>> Goodbye!
*/

List<string> words = new List<string>();

string answer2;
bool isAnswer;

do
{
    
    Console.WriteLine("Enter some text: ");
    words.Add(Console.ReadLine());
    Console.Write("You have entered: ");
    
    foreach (string word in words)
    {
        Console.Write(word + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue (y/n)? ");
    answer2 = Console.ReadLine();
    
    answer2 = answer2.ToLower();
    if (answer2 == "y") 
    {
        isAnswer = true;
    }
    else
    {
        isAnswer = false;
    }

} while (isAnswer);
Console.WriteLine("Goodbye!");