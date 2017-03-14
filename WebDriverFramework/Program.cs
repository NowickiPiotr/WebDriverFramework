using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("http://www.bisnode.pl/");
            
            var ClassNodes = document.DocumentNode.Descendants("div").Where(d =>
            d.Attributes.Contains("class"));
            string pathAndFile = Directory.GetCurrentDirectory() + "\\classesOnSite.txt";
            Console.Write(Directory.GetCurrentDirectory()+"\\log.txt");



            File.Delete(pathAndFile);

                foreach (var item in ClassNodes)
            {
                Console.Write(item.GetAttributeValue("class", string.Empty));
                using (StreamWriter writer =
                new StreamWriter(@pathAndFile, true))
                {
                    writer.WriteLine("[FindsBy(How = How.ClassName, Using = \"{0}\")]", item.GetAttributeValue("class", string.Empty));
                    writer.WriteLine("public IWebElement {0}_ClassName  {{ get; set; }} \n", item.GetAttributeValue("class", string.Empty));
                }

            }
            Console.Read();
        }

    
    }
}
