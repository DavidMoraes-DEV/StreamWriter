using System;
using System.IO;

namespace _StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * STREAMWRITER:
             - É uma stream capaz de escrever caracteres a partir de uma stream binária (ex: FileStream)
             - Suporte a dados no formato de texto.
             - Instanciação: Several Constructors
             - File / FileInfo (CreateText(path), AppendText(String)
             */

            string sourcePath = @"C:\ProgramasCSharp\ConceitoDeStreamWriter\StreamWriter\File1.txt";
            string targetPath = @"C:\ProgramasCSharp\ConceitoDeStreamWriter\StreamWriter\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper()); //Converte para letra maiúscula
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
