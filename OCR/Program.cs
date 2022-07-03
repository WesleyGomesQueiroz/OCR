using System;
using IronOcr;

namespace OCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new IronTesseract().Read(@"images\teste.jpg").Text);
        }
    }
}
