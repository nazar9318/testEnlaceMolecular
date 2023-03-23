using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EnlaceMolecular.Models {
    public class WordCounter {
        private string text;
        
        public WordCounter(string text) {
            this.text = text;
        }

        private string removeSpecialCharacters(string str) {
            string result = str.Replace(",", "");
            result = result.Replace(".", "");
            result = result.Replace("?", "");
            result = result.Replace("!", "");
            result = result.Replace("'", "");
            result = result.Replace("~", "");
            result = result.Replace("^", "");
            result = result.Replace(":", "");
            result = result.Replace("@", "");
            result = result.Replace("#", "");
            result = result.Replace("$", "");
            result = result.Replace("%", "");
            result = result.Replace("&", "");
            result = result.Replace("*", "");
            return result;
        }

        public string getCount() {
            string result = "";
            if (!string.IsNullOrWhiteSpace(this.text)) {
                string[] words = this.text.Split(' ');
                Dictionary<string, int> wordCount = new Dictionary<string, int>();
                int val;
                for (int i = 0; i < words.Length; i++) {
                    words[i] = removeSpecialCharacters(words[i]);
                    if (!wordCount.TryGetValue(words[i].ToUpper(), out val)) {
                        wordCount.Add(words[i].ToUpper(), 1);
                    } else {
                        wordCount[words[i].ToUpper()]++;
                    }                
                }
                foreach (var w_count in wordCount) {
                    if (!string.IsNullOrWhiteSpace(w_count.Key)) {
                        result += w_count.Key + ": " + w_count.Value + "\n";
                    }
                }
            }
            return result;
        }

    }
}
