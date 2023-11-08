namespace BreakContinueKeywords
{
    public partial class BreakContinueKeywordsClass
    {
        public void BreakContinueKeywordsDers()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 9)
                {
                    break;
                }
                System.Console.WriteLine("Sayac: " + i);
            }
        }
    }
}
