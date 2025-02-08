using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Buff_Github_Viewer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL of profile: ");
            string url = Console.ReadLine();
            if (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("Invalid URL.");
                return;
            }
            xNet_Helper Req = new xNet_Helper("", "", "", 0);
            do
            {
                string ReadResp = Req.RequestGet(url).ToString();
                Regex regex = new Regex(@"<text [^>]*>(\d[\d,]*)</text>");

                MatchCollection matches = regex.Matches(ReadResp);

                if (matches.Count > 0)
                {
                    string profileViews = matches[matches.Count - 1].Groups[1].Value;
                    Console.WriteLine($"Profile view: {profileViews}");
                }
                else
                {
                    Console.WriteLine("View failed.");
                }
            }
            while (true);
        }
    }
}
