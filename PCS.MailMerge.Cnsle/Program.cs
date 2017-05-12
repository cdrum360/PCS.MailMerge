using PCS.MailMerge.Services;

namespace PCS.MailMerge.Cnsle
{
    public class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\temp";

            PlanMerger planMerger = new PlanMerger();
            planMerger.Merge(source);

            System.Console.WriteLine("\nProgram ended, hit any key to continue...");
            System.Console.ReadKey();
        }
    }
}
