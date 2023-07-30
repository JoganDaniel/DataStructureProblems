using DataStructureProblems.UnorderedList;

public class Program
{
    static string unorderedFilepath = @"E:\Bridgelabz\DataStructureProblems\DataStructureProblems\DataStructureProblems\UnorderedList\UnorderedList.txt";
    private static void Main(string[] args)
    {
        UnorderedListOperations operations = new UnorderedListOperations();
        operations.ReadFileAndPerformOperation(unorderedFilepath);
    }
}