using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SubstringWithConcatenationOfAllWords_30
    {
        Stopwatch WatchGlobal;
        Stopwatch WatchDebug;

        public SubstringWithConcatenationOfAllWords_30()
        {
            WatchGlobal = Stopwatch.StartNew();
            WatchDebug = Stopwatch.StartNew();

            var a = FindSubstring("abababab", new string[] { "a", "b", "a" });

            WatchGlobal.Stop();
            var elapsedMs = WatchGlobal.ElapsedMilliseconds;

            //Console.WriteLine("Finish: " + elapsedMs);
        }

        public IList<int> FindSubstring(string s, string[] words)
        {
            var output = new List<int>();
            var wordsLength = 0;
            var wordLength = 0;
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!dict.ContainsKey(words[i]))
                {
                    dict.Add(words[i], 0);
                }
                dict[words[i]]++;
                wordLength = words[i].Length;
                wordsLength += wordLength;
            }

            Dictionary<string, BoolSteps> found = new Dictionary<string, BoolSteps>();

            for (int i = 0; i < wordLength; i++)
            {
                var index = i;
                while (index + wordsLength <= s.Length)
                {
                    var hashSet = new Dictionary<string, int>(dict);
                    var endIndex = index + wordsLength;
                    var hasNotFound = false;

                    string entire = s.Substring(index, wordsLength);

                    if (!found.TryGetValue(entire, out BoolSteps bs))
                    {
                        while (endIndex > index)
                        {
                            var temp = s.Substring(endIndex - wordLength, wordLength);
                            if (!hashSet.ContainsKey(temp) || hashSet[temp] <= 0)
                            {
                                hasNotFound = true;
                                break;
                            }

                            hashSet[temp]--;
                            endIndex -= wordLength;
                        }

                        int stepsFuther = endIndex - index;
                        found.Add(entire, new BoolSteps(hasNotFound, stepsFuther));

                        if (hasNotFound)
                        {
                            index += stepsFuther;
                            continue;
                        }

                        output.Add(index);
                        index += wordLength;
                    }
                    else
                    {
                        if (bs.HasNotFound)
                        {
                            index += bs.StepsFuther;
                            continue;
                        }

                        output.Add(index);
                        index += wordLength;
                    }
                }
            }

            return output;
        }

        class BoolSteps
        {
            public BoolSteps(bool isFound, int stepsFuther)
            {
                HasNotFound = isFound;
                StepsFuther = stepsFuther;
            }

            public bool HasNotFound { get; set; }
            public int StepsFuther { get; set; }
        }

    }
}
