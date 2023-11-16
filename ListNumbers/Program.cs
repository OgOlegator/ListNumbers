using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ListNumbers
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine(GetSumIndexes(OpenAndReadFile().Split(',').Select(x => int.Parse(x)).ToArray()));

            //Чтобы не закрывалась сразу
            Console.ReadLine();
        }

        static string OpenAndReadFile()
        {
            var result = string.Empty;

            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "(*.txt)|*.txt";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = fileDialog.FileName;
                    var fileStream = fileDialog.OpenFile();

                    using (var reader = new StreamReader(fileStream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }

            return result;
        }

        static long GetSumIndexes(int[] numbers)
        {
            long result = 0;
            var sumBeforeIndex = 0;
            var sumAfterIndex = numbers.Sum(x => x);

            for (int idx = 0; idx < numbers.Length; idx++)
            {
                //Текущий элемент массива не учитываем
                sumAfterIndex -= numbers[idx];

                if (sumBeforeIndex == sumAfterIndex)
                    result += idx;

                sumBeforeIndex += numbers[idx];
            }

            return result;
        }
    }
}
