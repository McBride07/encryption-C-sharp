using System;
using System.Text;
using System.Collections.Generic;
using System.Transactions;
using System.Data.SqlTypes;

class Program {

    // Main Method
    public static void Main(String[] args)
    {

        Console.WriteLine("Main Method");
        string input = "apple";
        var encrypt = new MD4();
        encrypt.MD4func(input);
        

    }
}


class MD4 {
    public byte[] bytes = new byte[512];
        public void MD4func(string input)
    {
       byte[] bytes  = Encoding.ASCII.GetBytes(input);
        foreach ( byte b in bytes)
        {
            Console.Write(b);        }
            int[] PADDING = [
                        128, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ];
        int messagelength = input.Length;
        int index = messagelength % 64;
        if(index < 56)
        {
            int temp = 56 - index;
            for(int i = bytes.Length; i < bytes.Length + temp; i++)
            {
                bytes[i] = Convert.ToByte(PADDING[i]);
                Console.Write(bytes[i]);
            }
        }
                        

    }


        

    
}
      
        


