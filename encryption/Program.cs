using System;
using System.Text;
using System.Collections.Generic;
using System.Transactions;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
class Program {

    // Main Method
    public static void Main(String[] args)
    {

        Console.WriteLine("Main Method");
        string input = "The saddest aspect of life right now is that science gathers knowledge faster than society gathers wisdom.";
        var encrypt = new MD4();
        encrypt.MD4func(input);
        

    }
}


class MD4 {
    
        public void MD4func(string input)
    {
       List<byte> bytes = Encoding.ASCII.GetBytes(input).ToList();
        int bitCount = bytes.Count * 8 ;
        bytes.Add(128);
        while (bytes.Count % 64 != 56)
        {
            bytes.Add(0);
        }
       int lengtharray = bitCount; 
       Console.WriteLine(lengtharray+ "this is the length");
       string binary = Convert.ToString(lengtharray,2);
       binary = binary.PadLeft(64, '0');
       Console.WriteLine(binary + "<--------- this is the binary thing");
       
       
       
      string[]  substrings = new string[8];
       for(int i = 0; i <8; i++)
       {
            substrings[i]  = binary.Substring((8 * i), 8);
       }
        int[] intsubstrings = new int[8];
        for(int i = 0; i <8; i++)
       {
            intsubstrings[i] = Convert.ToInt32(substrings[i],2);
            Console.WriteLine(intsubstrings[i]);
       }
        Array.Sort(intsubstrings);
        Array.Reverse(intsubstrings);

        for(int i = 0; i <8; i++)
        {
            var temp = intsubstrings[i];
            var stringtemp = Convert.ToString(intsubstrings[i]);
            stringtemp = stringtemp.PadLeft(8, '0');
            intsubstrings[i] = Convert.ToInt32(stringtemp);
        }

         for(int i = 0; i < intsubstrings.Length; i ++)
        {
            bytes.Add(Convert.ToByte(intsubstrings[i]));
        }

        
       

       
       
   
       
        
       
       
   
        
       
       for(int i = 0; i < bytes.Count; i ++)
       {
        
        Console.Write(bytes[i]);
        
         }
        
        



        uint word_A = 0x67452301;
        uint word_B = 0xefcdab89;
        uint  word_C = 0x98badcfe;
        uint word_D = 0x10325476;
    

    }
                        

    }


        

    

      
        


