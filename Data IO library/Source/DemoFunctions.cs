using static System.Console;


namespace GyroscopicDataLibrary
{
    internal class DemoFunctions
    {
        //-----------------------------  For demo only functions  ----------------------------------------------------//

        static public void WaitForAnyKey(bool clearAfter = false,
            bool engLang = true, string margin = "\t",
            string startLine = "\n", string endLine = "\n\n")
        {
            //  Write the newline and margin (optional)
            Write(startLine + margin);

            //  Write the message
            if (engLang) Write("Press any key to continue ");
            else Write("Нажмите любую клавишу для продолжения ");

            //  Wait for the user input
            ReadKey();

            //  Clearing the console (optional)
            if (clearAfter) Clear();

            //  Write the endline (optional)
            Write(endLine);
        }
             //  Demo function, waits for any user key to continue

        static public bool GetLanguage()
        {
            string userInput = "";
            bool firstTry = true;

            //  Write newline for a better error output
            Clear();
            Write("\n\n");

            while (userInput != "e" && userInput != "en" && userInput != "eng" && userInput != "english"
                && userInput != "r" && userInput != "ru" && userInput != "rus" && userInput != "russian")
            {
                //  If we havent exited the loop
                //  - its either our first try
                //  - or the user input was invalid
                //
                //  So this is a simplified error detection output logic
                if (!firstTry) Write("\n\t[!]  - Invalid input, please try again\n");

                //  Ask for input
                Write("\n\t[?]  - Enter the language for the demo info output:");
                Write("\n\t          > English (e / en / eng / english)");
                Write("\n\t          > Russian (r / ru / rus / russian)\n");
                Write("\n\t[->] - Choice: ");
                userInput = ReadLine().ToLower().Replace(" ", "");

                //  Clear the info output console
                Clear();

                //  Set to not first try anymore
                firstTry = false;
            }
            Write("\n");

            //  Funny way to determine the chosen language
            //  Because the only user input possible are
            //  > english-russian and shorter versions of them
            //  
            //  And we know for sure that the russian version doesnt have an "e" in it
            return userInput.Contains("e");
        }
             //  Demo function - gets the language for the demo output

    }
}