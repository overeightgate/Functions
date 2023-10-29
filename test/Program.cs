 Console.WriteLine("Enter the temperature:");
double userTemperature = double.Parse(Console.ReadLine());

Console.WriteLine("Do you want to convert to Celsius or Fahrenheit?");
string userInput = Console.ReadLine();

if (userInput.Equals("Celsius", StringComparison.OrdinalIgnoreCase))
        {
            ConvertToFahrenheit(userTemperature);
        }
else if (userInput.Equals("Fahrenheit", StringComparison.OrdinalIgnoreCase))
        {
            ConvertToCelsius(userTemperature);
        }
else
        {
            Console.WriteLine("Invalid choice. Please select Celsius or Fahrenheit.");
        }


static void ConvertToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine($"Fahrenheit: {fahrenheit:0}°F");
    }

static void ConvertToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Celsius: {celsius:0}°C");
    }

