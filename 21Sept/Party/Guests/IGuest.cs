namespace _21Sept
{
    public interface IGuest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Glad { get; set; }

        public void Speech();
        public void Talk();
        public void Eat();
        public void Dance();
        public void GoToBalcony();
        public void Drink();

    }
}
