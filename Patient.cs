public class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; } // in KG
    public double Height { get; set; } // in Centimeters

    // Custom Constructor
    public Patient(string firstName, string lastName, double weight, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
    }

    // Method to calculate blood pressure
    public string CalculateBloodPressure(int systolic, int diastolic)
    {
        if (systolic < 120 && diastolic < 80)
            return "NORMAL";
        else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            return "ELEVATED";
        else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
        else if (systolic >= 140 || diastolic >= 90)
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
        else if (systolic > 180 || diastolic > 120)
            return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
        else
            return "Blood pressure values not in the defined range.";
    }

    // Method to calculate BMI
    public double CalculateBMI()
    {
        double heightInMeter = Height / 100; // Convert height to meters
        return Weight / (heightInMeter * heightInMeter);
    }

    // Method to output patient information
    public void PrintPatientInfo(int systolic, int diastolic)
    {
        Console.WriteLine($"Patient Information:");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Weight: {Weight} KG");
        Console.WriteLine($"Height: {Height} CM");
        Console.WriteLine($"Blood Pressure: {CalculateBloodPressure(systolic, diastolic)}");

        double bmi = CalculateBMI();
        Console.WriteLine($"BMI: {bmi}");

        if (bmi >= 25.0)
            Console.WriteLine("BMI Status: Overweight");
        else if (bmi >= 18.5 && bmi <= 24.9)
            Console.WriteLine("BMI Status: Normal (In the healthy range)");
        else
            Console.WriteLine("BMI Status: Underweight");
    }
}