

string[] names = new string[] { "Tad", "Carlo", "Tom" };

bool validNumber = false;

do
{
    Console.WriteLine("Hello select the number (1 thru 3) of the person you're looking for");
    string numText = Console.ReadLine();
    if (int.TryParse(numText, out int num) && num >=1 && num <=3)
    {
        validNumber = true;
        Console.WriteLine($"You selected the student {names[num-1]}");
    }
    else
    {
        Console.WriteLine("Invalid response, please choose a number 1 thru 3 to select a student");
    }

} while (!validNumber);