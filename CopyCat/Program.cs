using HtmlAgilityPack;
using System;

namespace CopyCat
{
    class Program
    {
        static void Main(string[] args)
        {

            #region example

            var path = @"test.html";

            var doc = new HtmlDocument();
            doc.Load(path);

            var node = doc.DocumentNode.SelectSingleNode("//body");

            Console.WriteLine(node.OuterHtml);

            #endregion
        }
    }
}
