using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            foreach (var word in text.Split(' '))
            {
                _words.Add(new Word(word));
            }
        }

        public string DisplayScripture() // Method to display the scripture
        {
            var displayText = _reference.Display() + "\n";
            foreach (var word in _words)
            {
                displayText += word.IsHidden ? "___ " : word.Text + " ";
            }
            return displayText.Trim();
        }

        public void HideRandomWords()
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words[index].IsHidden = true; // Hide a random word
        }
    }
}
