// This if just for fun. The author is boring since VNPT mess his work

namespace conversations
{
    class talk
    {
        public static int RanGenerator(int number)
        {
            Random rand = new Random();
            return rand.Next(number);
        }
        public static string[] no =
        {
            "Come on man! Do waste my time!",
            "You sure you don't want to ask me anything",
            "I know you are shy but feel free to ask me anything",
            "JUST TYPE F***ING YES PLEASE",
            "Do not be shy, just type YES please!",
            "Damn coward"
        };

        public static string yes =
            "Thanks for choosing me! let's move forward to the next step!";

        public static string[] blank =
        {
            "Come on man! Type something!",
            "Sorry I'm not smart enough to understand the meaning behind of your NULL response!",
            "Maybe you mistyped! Let's try again!",
            "Don't be rude man! At least talk back when someone is trying to be gentle to you!",
        };
    }
}