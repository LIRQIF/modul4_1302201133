using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var haloUser = new HaloGeneric();
            haloUser.SapaUser<String>("fiqril");

            var dataGeneric = new DataGeneric<String>("1302201133");
            dataGeneric.PrintData();

        }
    }
}