class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Patient Information System!");
        Console.Write("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the patient information:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Weight (in KG): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Height (in Centimeters): ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the patient's blood pressure (SYSTOLIC mm Hg and DIASTOLIC mm Hg):");
        Console.Write("SYSTOLIC: ");
        int systolic = int.Parse(Console.ReadLine());
        Console.Write("DIASTOLIC: ");
        int diastolic = int.Parse(Console.ReadLine());

        Patient patient = new Patient(firstName, lastName, weight, height);
        patient.PrintPatientInfo(systolic, diastolic);
    }
}
