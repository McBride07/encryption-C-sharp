using System;
using System.Text;
using System.Collections.Generic;
using System.Transactions;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
class Program {

    // Main Method
    public static void Main(String[] args)
    {

        Console.WriteLine("Main Method");
        string input = "testing this thing";
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
       int lengtharray = bytes.Count * 8;
       string binary = Convert.ToString(lengtharray,2);
       Console.WriteLine(binary + "<--------- this is the binary thing");
        char[] temparray  = binary.ToCharArray();
        
        

        for(int i = 8; i <  temparray.Length; i ++)
        {
            if(temparray[i] == '0')
            {
                bytes.Add(0);
                
            }
            else
            {
                bytes.Add(1);
                
            }

           
           
        }

         for(int i = 0; i <  7; i ++)
        {
           
           if(temparray[i] == '0')
            {
                bytes.Add(0);
                
            }
            else
            {
                bytes.Add(1);
                
            }
        }
        
       int total = 0;
       for(int i = 0; i < bytes.Count; i ++)
       {
        
        Console.Write(bytes[i]);
        total =total +1;
         }
        



       string word_A = "0x67452301";
        string word_B = "0xefcdab89";
       string  word_C = "0x98badcfe";
        string word_D = "0x10325476";
    }
                        

    }


        

    

      
        


//byte[] bytes = Encoding.ASCII.GetBytes(input);
        //foreach ( byte b in bytes)
        //{
           // Console.Write(b);        }
           // int[] PADDING = [
                     //   128, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                     //   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                     //   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                      //  0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ];
      //  int messagelength = input.Length;
       // int index = messagelength % 64;
       // if(index < 56)
       // {
          //  int temp = 56 - index;
           // for(int i = bytes.Length; i < bytes.Length + temp; i++)
           // {
           //     bytes[i] = Convert.ToByte(PADDING[i]);
           //     Console.Write(bytes[i]);
           // }