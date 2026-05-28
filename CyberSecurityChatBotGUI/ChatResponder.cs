using System;
using System.Collections.Generic;

namespace CybersecurityChatbotGUI
{
    class ChatbotResponder
    {
        // Random responses for varied interaction
        private static readonly Random random = new Random();

        // Added 50 keywords responses with random selection
        private static readonly Dictionary<string, string[]> Responses =
            new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase)
        {
            { "hello",            new[] { "Hello! How can I help you stay safe online?",
                                          "Hi there! Ready to help with cybersecurity!",
                                          "Hey! What cybersecurity topic can I help with?" }},

            { "hi",               new[] { "Hi! How can I assist you today?",
                                          "Hello! Ask me anything about cybersecurity!" }},

            { "how are you",      new[] { "I am running securely and ready to help!",
                                          "All systems secure! How can I help you?" }},

            { "help",             new[] { "I can help with cybersecurity topics! Type 'list' to see all topics.",
                                          "Ask me about passwords, phishing, malware and more!" }},

            { "thank you",        new[] { "You are welcome! Stay safe online!",
                                          "Happy to help! Remember to stay vigilant!" }},

            { "thanks",           new[] { "No problem! Stay safe online!",
                                          "Anytime! Cybersecurity is important!" }},

            { "password",         new[] { "Use strong passwords with uppercase, lowercase, numbers and symbols!",
                                          "Never reuse passwords across different sites!",
                                          "Use a password manager like LastPass or Bitwarden!" }},

            { "weak password",    new[] { "Weak passwords are easy to crack! Use at least 12 characters!",
                                          "Avoid using names or birthdays as passwords!" }},

            { "strong password",  new[] { "A strong password has 12+ characters with mixed letters and symbols!",
                                          "Use a passphrase like: Coffee!Monkey$Tree2026" }},

            { "password manager", new[] { "Use LastPass or Bitwarden to store strong unique passwords!",
                                          "Password managers generate and store secure passwords for you!" }},

            { "phishing",         new[] { "Phishing emails mimic trusted sources. Always verify the sender!",
                                          "Never click suspicious links in emails!",
                                          "Check the email address carefully before clicking any links!" }},

            { "scam",             new[] { "Legitimate companies never ask for passwords via email!",
                                          "Be cautious of unsolicited calls asking for personal info!",
                                          "If it sounds too good to be true it probably is a scam!" }},

            { "fraud",            new[] { "Never share personal info with unverified sources!",
                                          "Report fraud to the South African Police Service immediately!" }},

            { "spam",             new[] { "Never click links inside spam emails!",
                                          "Mark spam emails and report them to your email provider!" }},

            { "fake website",     new[] { "Check the URL carefully for slight misspellings!",
                                          "Always look for HTTPS before entering personal information!" }},

            { "identity theft",   new[] { "Monitor your accounts regularly for suspicious activity!",
                                          "Enable 2FA on all accounts to prevent identity theft!" }},

            { "social engineering", new[] { "Always verify who you are speaking to before sharing info!",
                                            "Social engineers create urgency to trick you. Stay calm!" }},

            { "email",            new[] { "Always verify the sender before clicking email links!",
                                          "Never open attachments from unknown senders!" }},

            { "suspicious link",  new[] { "Hover over links first to see where they lead!",
                                          "When in doubt do not click suspicious links!" }},

            { "malware",          new[] { "Install reputable antivirus and keep it updated!",
                                          "Avoid downloading software from unknown sources!",
                                          "Scan your device regularly for malware!" }},

            { "virus",            new[] { "Keep your antivirus updated to protect against viruses!",
                                          "Never download files from untrusted websites!" }},

            { "ransomware",       new[] { "Always back up your data to prevent ransomware damage!",
                                          "Never open suspicious email attachments!" }},

            { "spyware",          new[] { "Install antivirus software to detect and remove spyware!",
                                          "Avoid clicking unknown links that could install spyware!" }},

            { "trojan",           new[] { "Only download software from trusted official sources!",
                                          "Trojans disguise themselves as legitimate software!" }},

            { "antivirus",        new[] { "Install reputable antivirus and keep it updated!",
                                          "Run regular scans to protect your device!" }},

            { "vpn",              new[] { "A VPN encrypts your internet connection. Use one on public WiFi!",
                                          "VPNs protect your privacy and hide your IP address!" }},

            { "firewall",         new[] { "Always keep your firewall enabled to block unauthorized access!",
                                          "A firewall monitors and controls network traffic!" }},

            { "wifi",             new[] { "Avoid using public WiFi for sensitive tasks!",
                                          "Always use a VPN on public WiFi networks!" }},

            { "public wifi",      new[] { "Public WiFi is dangerous! Use a VPN to stay protected!",
                                          "Never do online banking on public WiFi!" }},

            { "router",           new[] { "Change your router default password immediately!",
                                          "Keep your router firmware updated for security!" }},

            { "encryption",       new[] { "Encryption converts data into unreadable code to protect it!",
                                          "Use encrypted apps like Signal for sensitive communication!" }},

            { "backup",           new[] { "Use the 3-2-1 rule: 3 copies, 2 different media, 1 offsite!",
                                          "Back up your data regularly to prevent data loss!" }},

            { "data breach",      new[] { "Change your passwords immediately after a data breach!",
                                          "Enable 2FA on all accounts after a breach!" }},

            { "privacy",          new[] { "Review your app permissions regularly to protect privacy!",
                                          "Limit what personal information you share online!" }},

            { "two factor",       new[] { "Always enable 2FA for an extra layer of security!",
                                          "2FA makes it much harder for hackers to access your accounts!" }},

            { "2fa",              new[] { "Enable Two-Factor Authentication on all your accounts!",
                                          "Use an authenticator app like Google Authenticator for 2FA!" }},

            { "biometrics",       new[] { "Fingerprint and face ID add extra security to your devices!",
                                          "Biometric authentication is harder to fake than passwords!" }},

            { "update",           new[] { "Always keep software updated to patch security vulnerabilities!",
                                          "Enable automatic updates to stay protected!" }},

            { "hacker",           new[] { "Hackers exploit weak passwords and outdated software!",
                                          "Keep everything updated and use strong passwords!" }},

            { "dark web",         new[] { "Avoid the dark web as it is full of illegal activity!",
                                          "Never share personal information on the dark web!" }},

            { "social media",     new[] { "Be careful what you share on social media!",
                                          "Check your privacy settings on all social media accounts!" }},

            { "online banking",   new[] { "Always use 2FA for online banking!",
                                          "Never do online banking on public WiFi!" }},

            { "digital footprint",new[] { "Be mindful of what you post and share online!",
                                          "Your digital footprint can be used against you!" }},

            { "cybersecurity",    new[] { "Cybersecurity protects systems and networks from digital attacks!",
                                          "Stay informed about cybersecurity to protect yourself!" }},

            { "privacy",          new[] { "Limit what you share online and review app permissions!",
                                          "Use privacy settings on all your accounts!" }},

            { "cookie",           new[] { "Clear cookies regularly and only accept from trusted sites!",
                                          "Cookies track your browsing behaviour online!" }},

            { "https",            new[] { "Always look for HTTPS before entering personal information!",
                                          "HTTPS means the connection is encrypted and secure!" }},

            { "worried",          new[] { "I understand your concern. Let me help you stay safe online!",
                                          "It is completely normal to feel worried. Here are some tips to help!" }},

            { "curious",          new[] { "Great that you are curious about cybersecurity!",
                                          "Curiosity is the first step to staying safe online!" }},

            { "frustrated",       new[] { "I understand your frustration. Let me help you!",
                                          "Take it one step at a time. Cybersecurity can be overwhelming!" }}
        };

        // Get topic list
        public string GetTopicList()
        {
            return "Topics I can help with:\n" +
                   "passwords, phishing, malware, vpn,\n" +
                   "2fa, firewall, encryption, backup,\n" +
                   "scam, fraud, ransomware, spyware,\n" +
                   "social media, privacy, dark web,\n" +
                   "online banking, identity theft and more!";
        }

        // Get response
        public string GetResponse(string input, string userName, ref string favouriteTopic)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "I did not catch that. Could you rephrase?";

            // Sentiment detection
            if (input.ToLower().Contains("worried") ||
                input.ToLower().Contains("scared") ||
                input.ToLower().Contains("afraid"))
                return $"I understand you are worried {userName}. " +
                       "Let me help you stay safe online!";

            if (input.ToLower().Contains("frustrated") ||
                input.ToLower().Contains("angry") ||
                input.ToLower().Contains("upset"))
                return $"I understand your frustration {userName}. " +
                       "Take it one step at a time!";

            if (input.ToLower().Contains("happy") ||
                input.ToLower().Contains("great") ||
                input.ToLower().Contains("good"))
                return $"Glad to hear that {userName}! " +
                       "Keep up the good work staying safe online!";

            // Memory and recall
            if (input.ToLower().Contains("what do you remember") ||
                input.ToLower().Contains("what do you know about me"))
            {
                string memory = $"I remember your name is {userName}.";
                if (!string.IsNullOrEmpty(favouriteTopic))
                    memory += $" Your favourite topic is {favouriteTopic}.";
                return memory;
            }

            // Conversation flow
            if (input.ToLower().Contains("tell me more") ||
                input.ToLower().Contains("explain more") ||
                input.ToLower().Contains("give me another tip") ||
                input.ToLower().Contains("more info"))
            {
                if (!string.IsNullOrEmpty(favouriteTopic))
                    return GetRandomResponse(favouriteTopic);
                return "What topic would you like to know more about?";
            }

            // Check dictionary for keyword match
            foreach (var entry in Responses)
            {
                if (input.ToLower().Contains(entry.Key.ToLower()))
                {
                    favouriteTopic = entry.Key;
                    return GetRandomResponse(entry.Key);
                }
            }

            return "I did not quite understand that. " +
                   "Type 'list' to see all available topics.";
        }

        // Get random response from array
        private string GetRandomResponse(string key)
        {
            if (Responses.ContainsKey(key))
            {
                string[] responses = Responses[key];
                return responses[random.Next(responses.Length)];
            }
            return "I did not quite understand that.";
        }
    }
}