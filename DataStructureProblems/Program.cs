using DataStructureProblems.BalancedParanthesis;
using DataStructureProblems.OrderedList;
using DataStructureProblems.UnorderedList;

public class Program
{
    static string unorderedFilepath = @"E:\Bridgelabz\DataStructureProblems\DataStructureProblems\DataStructureProblems\UnorderedList\UnorderedList.txt";
    static string orderedFilepath = @"E:\Bridgelabz\DataStructureProblems\DataStructureProblems\DataStructureProblems\OrderedList\OrderedList.txt";
    static string stackFilepath = @"E:\Bridgelabz\DataStructureProblems\DataStructureProblems\DataStructureProblems\BalancedParanthesis\BalancedParanthesisText.txt";
    private static void Main(string[] args)
    {
        //UnorderedListOperations operations = new UnorderedListOperations();
        //operations.ReadFileAndPerformOperation(unorderedFilepath);
        //OrderedListOperations operations = new OrderedListOperations();
        //operations.ReadAndPerformOperation(orderedFilepath);
        BalancedParanthesisOperation operation = new BalancedParanthesisOperation();
        operation.ReadAndPerformOperation(stackFilepath);
    }
}