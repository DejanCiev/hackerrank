namespace TimeConversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            string[] partOfTime = s.Split(":".ToCharArray());

            var format = partOfTime[2].Substring(partOfTime[2].Length - 2);
            partOfTime[2] = partOfTime[2].Replace(format, "");
            if (partOfTime[0] == "12")
            {
                if (format == "AM")
                {
                    partOfTime[0] = "00";
                }
            }
            if (format == "PM" && partOfTime[0] != "12")
            {
                var hour = int.Parse(partOfTime[0]) + 12;
                partOfTime[0] = hour.ToString("00");
            }

            return $"{partOfTime[0]}:{partOfTime[1]}:{partOfTime[2]}";
        }
        static void Main(string[] args)
        {

            string s = "07:05:45PM";//Console.ReadLine();

            string result = timeConversion(s);
        }
    }
}
