using System;
using System.Text.RegularExpressions;
using System.Linq;

class MainClass {
  public static string LongestWord(string sen) { 
      
            Regex rgx = new Regex(@"[^\w\s]");
            sen = rgx.Replace(sen,"");
            string[] words = sen.Split(' ');
        Console.Write("Your longest word is : ");
            return words.OrderByDescending(x => x.Length).First();  
  }

  static void Main() {  
    Console.WriteLine("Enter your favourite sentence :");
    Console.WriteLine(LongestWord(Console.ReadLine()));
  } 
   
}
