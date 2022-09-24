// Onsdag 21 September
using _21Sept;
using _21Sept.Party.Furniture;









//övning 1 party nedan, försök lägg in metoderna i en egna filer
// gick inte att komma åt när jag provade, är det för att jag inte använt "using" och refererat till just det namespacet? using _21Sept.Party?

IGuest[] guestList = new IGuest[] { new Collegue("Joel", 45, false), new Friend("Janne", 54, false), new Neighbor("Jens", 31, true), new Friend("Jessica", 23, false), new Collegue("Johanna", 43, true) };
IFurniture[] furniture = new IFurniture[] { new Chair("blue", 5423.23m, "Ikea"), new Table("red", 432.34m, "Mio"), new Lamp("black", 125.5m, "Bosch") };


void DisplayFurniture()
{
    Console.WriteLine("Furniture:\n" +
                      "------------------");
    foreach (var item in furniture)
    {
        Console.WriteLine($"Type: {item.ItemType}\n" +
                          $"Price: {item.Price} sek\n" +
                          $"Brand: {item.Brand}\n" +
                          $"Color: {item.Color}\n" +
                          $"---------------------");
    }
}

/// <summary>
/// metod som startar festen
/// </summary>
void StartParty()
{
    foreach (var guest in guestList)
    {
        Random random = new Random();

        switch (random.Next(1, 6))
        {
            case 1:
                guest.GoToBalcony();
                break;

            case 2:
                guest.Drink();
                break;

            case 3:
                guest.Dance();
                break;

            case 4:
                guest.Talk();
                break;

            case 5:
                guest.Eat();
                break;

            default:
                break;
        }
    }
}


DisplayFurniture();
StartParty();

