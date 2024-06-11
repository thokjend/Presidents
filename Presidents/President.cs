using System.Linq;

namespace Presidents
{
    internal class President
    {
        public string Name { get; }
        public string Party { get; }
        public int YearFrom { get; }
        public int? YearTo { get; }
        public President(string name, string party, string years)
        {
            Name = name;
            Party = party;
            var parts = years.Replace("*", string.Empty).Split('-', '–');
            var yearFrom = parts[0];
            YearFrom = Convert.ToInt32(yearFrom);
            if (parts.Length < 2)
            {
                if (!years.Contains('-') && !years.Contains('–'))
                {
                    YearTo = YearFrom;
                }
                return;
            }
            var yearTo = parts[1];
            if (yearTo.Length == 0) return;
            yearTo = yearFrom.Substring(0, 4 - yearTo.Length) + yearTo;
            YearTo = Convert.ToInt32(yearTo);

        }

        public void Show(int inputYearFrom, int inputYearTo)
        {
            if (inputYearFrom <= YearFrom && inputYearTo >= YearTo)
            {
                var yearTo = YearTo.ToString() ?? "";
                Console.WriteLine($"{Name} ({Party}) {YearFrom} - {yearTo} ");
            }
        }

        public void Show()
        {
            var timePeriods = (YearTo - YearFrom) / 4;
            if (timePeriods > 1)
            {
                var yearTo = YearTo.ToString() ?? "";
                Console.WriteLine($"{Name} ({Party}) {YearFrom} - {yearTo} - {timePeriods} Periods");
            }

        }

        public void Search(string name)
        {
            if (Name.Contains(name))
            {
                Show();
            }

        }

        public void CountParty(Dictionary<string, int> partyCounts)
        {
            if (partyCounts.ContainsKey(Party))
            {
                partyCounts[Party]++;
            }
            else
            {
                partyCounts[Party] = 1;
            }
        }

    }
}
