﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            Form1 f = new Form1();

            f.CaputreScreen(); //some method to capture screen

            Console.ReadLine();


            ;
        }
    }
}
