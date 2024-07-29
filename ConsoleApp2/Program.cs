using System.IO;
using System.Text;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("We are creating the chessboard HTML using Console application at "+ Directory.GetCurrentDirectory()+ " Path");
            StringBuilder sbChessHtml = new StringBuilder();
            sbChessHtml.Append("<HTML><Head><style>td {width: 30px;height: 30px;}.black {background-color: #000;}.white {background-color: #fff;}</style></Head>");
            sbChessHtml.Append("<Body><table cellpadding='0'; cellspacing='0'; border='1'; width: 270px;><tbody>");
            
           
            for (int i = 1; i <= 8; i++)
            {
                sbChessHtml.Append("<tr>");
                for (int j = 1; j <= 8; j++)
                {
                    if ((i+j) % 2 == 0 ) { sbChessHtml.Append("<td class='white'></td>"); }
                    else { sbChessHtml.Append("<td class='black'></td>"); }
                }
                sbChessHtml.Append("</tr>");
            }            
            
            sbChessHtml.Append("</tbody></table></Body></HTML>");
            File.WriteAllText("Chessborad.html", sbChessHtml.ToString());
            Console.ReadLine();
        }
    }
}
