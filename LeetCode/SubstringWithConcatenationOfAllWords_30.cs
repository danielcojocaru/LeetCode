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
        //private string S;
        private string[] Words;
        private int WordLen;

        Stopwatch WatchGlobal;
        Stopwatch WatchDebug;

        public SubstringWithConcatenationOfAllWords_30()
        {
            WatchGlobal = Stopwatch.StartNew();
            WatchDebug = Stopwatch.StartNew();

            var a = FindSubstring("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "good" });

            WatchGlobal.Stop();
            var elapsedMs = WatchGlobal.ElapsedMilliseconds;

            Console.WriteLine("Finish: " + elapsedMs);
        }

        class MatchObject
        {
            public List<int> MatchedIndexes { get; set; }
            public int Remaining { get; set; }
            public string Word { get; set; }

            public bool IsMatching(int index)
            {
                return Remaining > 0 && MatchedIndexes.Contains(index);
            }

            public static MatchObject Clone(MatchObject obj)
            {
                MatchObject clone = new MatchObject()
                {
                    MatchedIndexes = obj.MatchedIndexes,
                    Word = obj.Word,
                    Remaining = obj.Remaining,
                };

                return clone;
            }
        }

        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> toReturn = new List<int>();

            if (words.Length == 0) return toReturn;

            Words = words;
            WordLen = words[0].Length;

            GetMatches(s);

            //WatchGlobal.Stop();
            //var elapsedMs = WatchGlobal.ElapsedMilliseconds;

            List<MatchObject> objects = GetMatches(s).Select(x => x.Value).ToList();

            int wordsLettersCount = WordLen * Words.Length;
            int max = s.Length - wordsLettersCount + 1;

            Dictionary<string, IndexTwin> indexTwins = GetDistinctIndexes(s, wordsLettersCount);

            //foreach (var indexTwin in indexTwins)
            Parallel.ForEach(indexTwins, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, indexTwin =>
            {
                int i = indexTwin.Value.Index;

                List<MatchObject> clonedObjects = Clone(objects);

                string testingString = s.Substring(i, wordsLettersCount);

                if (Match(clonedObjects, i, count: 0))
                {
                    toReturn.Add(i);
                }
            }
            );

            AddTwins(toReturn, indexTwins);

            return toReturn;
        }

        private void AddTwins(IList<int> goodIndexes, Dictionary<string, IndexTwin> indexTwins)
        {
            List<int> goodIndexesList = goodIndexes as List<int>;
            List<int> newOnes = new List<int>();

            foreach (int index in goodIndexes)
            {
                newOnes.AddRange(indexTwins.First(x => x.Value.Index == index).Value.Twins);
            }

            goodIndexesList.AddRange(newOnes);
        }

        class IndexTwin
        {
            public int Index { get; set; }
            public List<int> Twins { get; set; } = new List<int>();
        }

        private Dictionary<string, IndexTwin> GetDistinctIndexes(string s, int wordsLettersCount)
        {
            Dictionary<string, IndexTwin> toReturn = new Dictionary<string, IndexTwin>();

            int max = s.Length - wordsLettersCount + 1;

            for (int i = 0; i < max; i++)
            {
                string currentString = s.Substring(i, wordsLettersCount);

                if (!toReturn.TryGetValue(currentString, out IndexTwin indexTwin))
                {
                    toReturn.Add(currentString, new IndexTwin() { Index = i });
                }
                else
                {
                    indexTwin.Twins.Add(i);
                }
            }

            return toReturn;
        }

        private List<MatchObject> Clone(List<MatchObject> matches)
        {
            List<MatchObject> clone = new List<MatchObject>();

            foreach (MatchObject obj in matches)
            {
                clone.Add(MatchObject.Clone(obj));
            }

            return clone;
        }

        private bool Match(List<MatchObject> matches, int i, int count)
        {
            int wordIndex = matches.FindIndex(x => x.IsMatching(i));

            if (wordIndex != -1)
            {
                matches[wordIndex].Remaining -= 1;
                ++count;
            }
            else
            {
                return false;
            }

            if (count == Words.Length)
            {
                return true;
            }
            else
            {
                return Match(matches, i + WordLen, count);
            }
        }

        private List<bool> CreateCompletedList()
        {
            List<bool> toReturn = new List<bool>();
            for (int i = 0; i < Words.Length; i++)
            {
                toReturn.Add(false);
            }
            return toReturn;
        }

        private Dictionary<string, MatchObject> GetMatches(string s)
        {
            Dictionary<string, MatchObject> dic = new Dictionary<string, MatchObject>();

            for (int i = 0; i < Words.Length; i++)
            {
                string word = Words[i];

                if (!dic.TryGetValue(word, out MatchObject theObj))
                {
                    MatchObject m = new MatchObject()
                    {
                        Word = word,
                        MatchedIndexes = AllIndexesOf(s, word),
                        Remaining = 1,
                    };

                    dic.Add(word, m);
                }
                else
                {
                    theObj.Remaining++;
                }
            }

            return dic;
        }

        public List<int> AllIndexesOf(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            //for (int index = 0; ; index += value.Length)
            for (int index = 0; ; index++)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                {
                    return indexes;
                }
                indexes.Add(index);
            }
        }
    }
}
