// Onsdag 21 September
using _21Sept;


IGuest[] guestList = new IGuest[] { new Collegue("Joel", 45, false), new Friend("Janne", 54, true), new Neighbor("Jens", 31, true), new Friend("Jessica", 23, false), new Collegue("Johanna", 43, true) };

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

StartParty();

