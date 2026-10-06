Lili.cs 
using System;

namespace Lili
{
    public class LiliAssistant
    {
        public string Name => "Lili";

        public string Reply(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return "Haan boss, bolo 😊";

            string text = message.Trim().ToLowerInvariant();

            if (text.Contains("hello") || text.Contains("hi") || text.Contains("hii"))
                return "Hi boss 😎 Main Lili hoon. Bolo, kya karna hai?";

            if (text.Contains("kaise ho") || text.Contains("kesi ho"))
                return "Main bilkul ready hoon boss ❤️ Aap batao.";

            if (text.Contains("naam"))
                return "Mera naam Lili hai 😊";

            return "Haan boss, samajh gayi. Main aapki help karne ke liye ready hoon.";
        }
    }
}
