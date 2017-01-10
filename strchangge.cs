using System;
using System.Collections.Generic;
using System.Text;
namespace Demo
{
    class Program
    {      
        public static void getstrt(string str){
                char[] chars;
                int count = 0;
                chars = new char[str.Length];
                foreach (char c in str)
                {
                chars[count] = c;
                count++;
                }
             for(int i=0 ; i<str.Length; i++){
                 if(i%2!=0){
                  
                  	Console.WriteLine(chars[i]);
                 }
              }
            
        }
        static void Main(string[] args)
        {
            string test ="23131231546543";

           // string c = null;
            
            getstrt(test);
            // c =getstr(test);
            // 	Console.WriteLine(c);

        }
    }
}