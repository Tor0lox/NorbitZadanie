internal class Zadanie1
{
    public static string CalculateCompoundInterest(double initial_deposit, int years, double interest_rate)
    {
        string result = "";
        double sum = initial_deposit;

        for (int i = 1; i <= years; i++)
        {
            sum = sum + sum * interest_rate / 100;
            result += $"Год {i}: {sum:F2} руб.\n";
        }

        return result;
    }
}