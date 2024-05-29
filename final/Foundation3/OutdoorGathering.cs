class OutdoorGathering : Event
{
    public string Weather { get; private set; }

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
    }
}
