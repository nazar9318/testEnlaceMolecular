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
    }
}
