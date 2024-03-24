
Console.WriteLine("Hello, Records!");

var exchangeRate1 = new ExchangeRate
{
    BaseCurrency = "PLN",
    TargetCurrency = "USD",
    Rate = 4,
};

var exchangeRate2 = new ExchangeRate
{
    BaseCurrency = "PLN",
    TargetCurrency = "USD",
    Rate = 4,
};

Console.WriteLine(exchangeRate1);
Console.WriteLine(exchangeRate2);

Console.WriteLine($"exchangeRate1 == exchangeRate2: {exchangeRate1 == exchangeRate2}");
Console.WriteLine($"object.ReferenceEquals(exchangeRate1, exchangeRate2): {object.ReferenceEquals(exchangeRate1, exchangeRate2)}");

public class ExchangeRate
{
    public string BaseCurrency { get; set; }
    public string TargetCurrency { get; set; }
    public decimal Rate { get; set; }

    public override string ToString()
    {
        return $"ExchangeRate: {{ BaseCurrency = {BaseCurrency}, TargetCurrency = {TargetCurrency}, Rate = {Rate} }}";
    }

    /* TODO: Uncomment
     
    public static bool operator ==(ExchangeRate rate1, ExchangeRate rate2)
    {
        if (ReferenceEquals(rate1, rate2))
            return true;

        if (rate1 is null || rate2 is null)
            return false;

        return rate1.Equals(rate2);
    }

    public static bool operator !=(ExchangeRate rate1, ExchangeRate rate2)
    {
        return !(rate1 == rate2);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(BaseCurrency, TargetCurrency, Rate);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        ExchangeRate other = (ExchangeRate)obj;
        return BaseCurrency == other.BaseCurrency &&
               TargetCurrency == other.TargetCurrency &&
               Rate == other.Rate;
    }

    */

}