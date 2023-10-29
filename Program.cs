//READ ALL TEXT
// string text = File.ReadAllText("textfile.txt");
// Console.WriteLine(text);


//__________________________________________________
//READ ALL LINES
// string[] text = File.ReadAllLines("textfile.txt");

// foreach (string t in text)
// {
//     Console.WriteLine(t);
// }


//__________________________________________________
//WRITE ALL LINES
// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// File.WriteAllLines("newfile.txt", names);


//__________________________________________________
//WRITE ALL TEXT
// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// File.WriteAllLines("newfile.txt", names);

// string newString = "I am a terrific programmer!";
// File.WriteAllText("newtext.txt", newString);


//__________________________________________________
//STREAMWRITER USING METHOD
// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// using (StreamWriter file = new StreamWriter("myNewFile.txt")){
//     // Code to be added
// }


//__________________________________________________
//STREAMWRITER WRITELINE METHOD
// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// using (StreamWriter file = new StreamWriter("myNewFile.txt")){
//     foreach(string name in names){
//         file.WriteLine(name);
//     }
// }


//__________________________________________________
//USING WITH BOOLEAN TRUE
// string[] names = { 
//     "Kadria",
//     "Johnny",
//     "Sarah", 
//     "Josh"
// };

// using (StreamWriter file = new StreamWriter("myNewFile.txt", true)) {
//     foreach (string name in names) {
//         file.WriteLine(name);
//     }
// }


//__________________________________________________
//RANDOM NEXT METHODS
// System.Random random = new System.Random();
// Console.WriteLine(random.Next());
// Console.WriteLine(random.Next(50));
// Console.WriteLine(random.Next(10, 50));


// //__________________________________________________
// //DATETIME CLASS
// // Initialize a specific date as a DateTime variable
// DateTime date1 = new DateTime(2020, 7, 15, 18, 30, 45);

// // Output 07 15 20 18:30:45
// Console.WriteLine(date1.ToString("MM dd yy HH:mm:ss"));

// // Outputs Wednesday July, 2020 06:30:45 PM
// Console.WriteLine(date1.ToString("dddd MMMM, yyyy hh:mm:ss tt"));

// // Outputs 07/15/2020
// Console.WriteLine(date1.ToString("MM/dd/yyyy"));

// // Outputs 06:30:45 PM
// Console.WriteLine(date1.ToString("hh:mm:ss tt"));


//__________________________________________________
//STRING LENGTH, CONTAINS(), AND INDEXOF()
// string testString = "It's raining cats and dogs";
// Console.WriteLine(testString.Length); // 26
// Console.WriteLine(testString.Contains('x')); // false
// Console.WriteLine(testString.IndexOf("cat")); // 13


//__________________________________________________
//SPLIT() STRING METHOD
// string testString = "It's raining cats and dogs";
// string[] words = testString.Split(" ");


//__________________________________________________
//JOIN() STRING METHOD
// string[] words = {"It's", "raining", "cats", "and", "dogs"};
// string result = String.Join("***", words);


//__________________________________________________
//CONCAT() STRING METHOD
// string[] words = {"It's", "raining", "cats", "and", "dogs"};
// string result = String.Concat(words);


//__________________________________________________
//ISNULLEMPTY AND ISNULLWHITESPACE STRING METHODS
// string myString = "";

// if (String.IsNullOrEmpty(myString)) {
//     // Do something important with the String
// }


//__________________________________________________
//LINQ
using System.Linq;
// public bool GreaterThanZero(int num) {
//     return num > 0;
// }
// public class Student {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public int ID { get; set; }
//     public double GPA { get; set; }

//     public Student(string first, string last, int id, double gpa) {
//         FirstName = first;
//         LastName = last;
//         ID = id;
//         GPA = gpa;
//     }
// }


//__________________________________________________
//WHERE() METHOD TO FILTER NUMBERS
// int[] numbers = { 4, 52, 7, 11, 29 };
// var largeNumbers = numbers.Where(x => x > 12); // [52, 29]


//__________________________________________________
//MORE WHERE() METHOD TO ADD STUDENT
// List<Student> studentList = new List<Student>();
// studentList.Add(new Student("Spongebob", "Squarepants", 20312, 3.4));
// studentList.Add(new Student("Patrick", "Star", 20346, 3.1));
// studentList.Add(new Student("Sandy", "Cheeks", 21137, 4.0));
// studentList.Add(new Student("Squidward", "Tentacles", 12345, 3.8));
//  var sStudents = studentList.Where(s => s.LastName.IndexOf('S') == 0);
//  foreach (Student s in sStudents) {
//     Console.WriteLine(s.FirstName + " " + s.LastName);
// }
