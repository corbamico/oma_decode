using System;

namespace oma_decode
{

    public class Decoding
    {
        static byte[] _map = System.Text.ASCIIEncoding.GetEncoding(0).GetBytes("JaGuHAoLCqWXNbZAyWp");


        public static bool Decode(string strFileName, string strOutFile)
        {
            //_map length is 19.
            var magic = "01-45-4B-02-1A";
            var buffer = new byte[19 * 100];
            int nRead;
            using (var outfs = System.IO.File.OpenWrite(strOutFile))
            using (var fs = System.IO.File.OpenRead(strFileName))
            {
                //file should be begin with '01 45 4B 02 1A'
                fs.Read(buffer, 0, 5);
                if (magic != BitConverter.ToString(buffer[0..5]))
                {
                    return false;
                }
                while ((nRead = fs.Read(buffer, 0, 19 * 100)) > 0)
                {
                    outfs.Write(decode_bytes(buffer[0..nRead]));
                }
            }
            return true;
        }
        public static void Decode(string strFileName)
        {
            //_map length is 19.
            var magic = "01-45-4B-02-1A";
            var buffer = new byte[19 * 100];
            int nRead;
            using (var fs = System.IO.File.OpenRead(strFileName))
            {
                //file should be begin with '01 45 4B 02 1A'
                fs.Read(buffer, 0, 5);
                if (magic != BitConverter.ToString(buffer[0..5]))
                {
                    Console.WriteLine("[error] {0} is not valid oma file.", strFileName);
                    return;
                }
                while ((nRead = fs.Read(buffer, 0, 19 * 100)) > 0)
                {
                    Console.Write(System.Text.Encoding.ASCII.GetString(decode_bytes(buffer[0..nRead])));
                }
            }
        }

        static byte[] decode_bytes(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                var index = i % _map.Length;
                bytes[i] = decode_byte(bytes[i], index);
            }
            return bytes;
        }

        static byte decode_byte(byte c, int index)
        {
            if (c >= _map[index])
            {
                return (byte)(c - _map[index]);
            }
            return (byte)(0x7F + c - _map[index]);
        }

    }
    public class Encoding
    {
        static byte[] _map = System.Text.ASCIIEncoding.GetEncoding(0).GetBytes("JaGuHAoLCqWXNbZAyWp");
        public static bool Encode(string strFileName, string strOutFile)
        {
            byte[] magic = { 0x01, 0x45, 0x4B, 0x02, 0x1A };
            var buffer = new byte[19 * 100];
            int nRead;
            using (var outfs = System.IO.File.OpenWrite(strOutFile))
            using (var infs = System.IO.File.OpenRead(strFileName))
            {
                //file should be begin with '01 45 4B 02 1A'
                outfs.Write(magic, 0, magic.Length);
                while ((nRead = infs.Read(buffer, 0, 19 * 100)) > 0)
                {
                    outfs.Write(encode_bytes(buffer[0..nRead]));
                }
            }
            return true;
        }
        static byte encode_byte(byte c, int index)
        {
            int result;
            result = c + _map[index];
            if (result <= 0x7F)
            {
                return (byte)(result);
            }
            return (byte)(result - 0x7F);
        }
        static byte[] encode_bytes(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                var index = i % _map.Length;
                bytes[i] = encode_byte(bytes[i], index);
            }
            return bytes;
        }
        static byte[] encode_string(string str)
        {
            byte[] bytes = System.Text.ASCIIEncoding.GetEncoding(0).GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                var index = i % _map.Length;
                bytes[i] = encode_byte(bytes[i], index);
            }
            return bytes;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            if ((args.Length == 2) && (args[0] == "-d") && (System.IO.File.Exists(args[1])))
            {
                Decoding.Decode(args[1]);
                return;
            }
            if ((args.Length == 3) && (args[0] == "-e") && (System.IO.File.Exists(args[1])))
            {
                Encoding.Encode(args[1], args[2]);
                return;
            }
            usage();
        }
        static void usage()
        {
            var lines = @"usage: oma_decode [-d <file.oma>|-e <file.omf> <file.oma>]";
            Console.WriteLine(lines);
            Environment.Exit(1);
        }
    }
}