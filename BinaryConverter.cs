using System; 
public class BinaryConverter { 
  public static void Main(string[] args) {
    int number = 80; 
    string binaryRepresentation = Convert.ToString(number,2); 
    Console.WriteLine(binaryRepresentation);
  }
}
