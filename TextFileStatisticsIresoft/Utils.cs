using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileStatisticsIresoft
{
    public static class Utils
    {

        private static string diactritics = "ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝßàáâãäåçèéêëìíîïñòóôõöùúûüýÿĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĶķĸĹĺĻļĽľĿŀŁłŃńŅņŇňŉŊŋŌōŎŏŐőŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰűŲųŴŵŶŷŸŹźŻżŽžſ";
        
        private static string nonDiacritics = "AAAAAACEEEEIIIINOOOOOUUUUYsaaaaaaceeeeiiiinooooouuuuyyAaAaAaCcCcCcCcDdDdEeEeEeEeEeGgGgGgGgHhHhIiIiIiIiIiKkkLlLlLlLlLlNnNnNnNnNOoOoOoRrRrRrSsSsSsSsTtTtTtUuUuUuUuUuUuWwYyYZzZzZzs";

        public static void FormatTextFile(FileWriter writer, FileReader reader)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            writer.CreateFile();

            foreach (string line in reader.ReadLineByLine())
            {
                if (line.Length <= 0)
                {
                    continue;
                }
                var l = String.Join("", line.ToLower().Split(new char[] { ' ', '?', ',', '!', '.', '/', '\\' })
                    .Where(x => x.Length > 0)
                    .Select(x => CapitalizeFirstLetter(x)))
                    .ToCharArray();
                for (int i = 0; i < l.Length; i++)
                {
                    if (diactritics.Contains(l[i]))
                    {
                        l[i] = nonDiacritics[diactritics.IndexOf(l[i])];
                    }
                }
                writer.WriteLine(new string(l));
            }
        }

        public static string CapitalizeFirstLetter(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            if (s.Length == 1)
                return s.ToUpper();
            return s.Remove(1).ToUpper() + s.Substring(1);
        }
    }
}
