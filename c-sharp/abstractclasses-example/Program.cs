public class Program
{
    public static void Main()
    {
        var tCard=new TradingCard();

        var theDerivedType=tCard.GetType();
        bool isCorrectBaseType=theDerivedType.BaseType==typeof(Card);
    }

    public class Answer
    {
        public static bool ShowExectedResult=true;
        public static bool ShowHints=true;
    }

    public class TradingCard:Card
    {
        public override global::System.Double GetSalePrice()
        {
            return 0;
        }
    }

    public abstract class Card
    {
        public abstract double GetSalePrice();
    }
}