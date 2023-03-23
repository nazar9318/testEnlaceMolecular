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

        public string getCount() {
            string[] words = this.text.Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            int val;
            for (int i = 0; i < words.Length; i++) {
                if (!wordCount.TryGetValue(words[i], out val)) {
                    wordCount.Add(words[i], 1);
                } else {
                    wordCount[words[i]]++;
                }                
            }
            string result = "";
            foreach (var w_count in wordCount) {
                result += w_count.Key + ": " + w_count.Value + "\n";
            }
            return result;
        }

    }
}
