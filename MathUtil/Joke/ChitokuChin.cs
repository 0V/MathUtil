using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using MathUtil.Random;
namespace MathUtil.Joke
{
    public class ChitokuChin
    {
        private static readonly string chars = "ちとくちん";
        private static MT19937 mt;

        public static void StartChitokuChin()
        {
            mt = new MT19937((uint)(DateTime.Now.ToFileTimeUtc() % uint.MaxValue));
            
            var chitoq = new Queue<char>();

            foreach (var c in GetRandomString(5))
                chitoq.Enqueue(c);
            int count = 1;
            while (true)
            {
                if (chitoq.SequenceEqual("ちとくちん"))
                {
                    foreach(var c in chitoq)
                        Console.Write(c);

                    Console.WriteLine("\r\n\r\n\r\nちとくちんち～～～～ん！！！{0}回目でちとくちん", count + 4);
                    break;
                }
                count++;
                Console.Write(chitoq.Dequeue());
                chitoq.Enqueue(GetRandomString(1)[0]);
            }
        }

        private static string GetRandomString(int length)
        {
            var sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
                sb.Append(chars[GetRandomNumber()]);
            return sb.ToString();
        }

        private static int GetRandomNumber()
        {
            return Math.Abs((int)mt.GetInt32() % chars.Length);
            /*
                var rng = new RNGCryptoServiceProvider();
                rng.GetBytes(bs);
                var num = BitConverter.ToInt32(bs, 0);
                return Math.Abs(num % chars.Length);
            */
        }
    }
}
