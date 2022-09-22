// Onsdag 21 September
using _21Sept;


IGuest[] guestList = new IGuest[] { new Collegue("Joel"), new Friend("Janne"), new Neighbor("Jens"), new Friend("Jessica"), new Collegue("Johanna") };
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