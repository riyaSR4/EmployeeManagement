using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class TaskParallelLibrary
    {
        public void TaskParallelOperation()
        {
            string[] words = CreateWordArray(@"https://gutenberg.org/files/54700/54700-0.txt");
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin First Task");
                GetLongestWords(words);
            },
            () =>
            {
                Console.WriteLine("Begin Second Task");
                GetFirstWords(words);
            },
            () =>
            {
                Console.WriteLine("Begin Third Task");
                GetWordsWithLength(words);
            });
        }
        private void GetWordsWithLength(string[] words)
        {
            var result = words.Where(x => x.Length > 6).Take(10);
            foreach (var data in result)
            {
                Console.WriteLine(data);
            }
        }
        private void GetFirstWords(string[] words)
        {
            var result = words.Take(10);
            foreach (var data in result)
            {
                Console.WriteLine(data);
            }
        }
        private void GetLongestWords(string[] words)
        {
            Array.Sort(words);
            Console.WriteLine("Longest: " + words[words.Length-1]);
        }
        public string[] CreateWordArray(string url)
        {
            string data = new WebClient().DownloadString(url);
            return data.Split(new char[] {' ', ',', '-', '_', '/', '.'},
                StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
