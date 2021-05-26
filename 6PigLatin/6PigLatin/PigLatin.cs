using System;


namespace _6PigLatin
{
    class PigLatin
    {
        private string phrase;

        public string Phrase
        {
            get => phrase;
            set
            {
                phrase = value;
            }
        }
        #region
        /// <summary>
        /// This method checks the position of vowel and applies the special conditions for translating the word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string VowelCheck(string word)
        {
            string phrase;
            string newWord;
            string fstLtr = word.Substring(0, 1);
            // char array used to find instances of vowels using .IndexOfAny
            char [] vowel = { 'a', 'e', 'i', 'o', 'u', 'y',
                                'A', 'E', 'I', 'O', 'U', 'Y' };
            // if the 1st letter of the word is a vowel or y (has special conditions)
            if ((fstLtr == "a" ) || (fstLtr == "e") || (fstLtr == "i") || 
                (fstLtr == "o") || (fstLtr == "u") || (fstLtr == "y"))
            {
                // if the 1st letter is a y condition
                if (fstLtr == "y")
                {
                    string y = word.Substring(1); // find second instance of vowel instead
                    int dexNum = y.IndexOfAny(vowel); // Index of vowel
                    if (dexNum == -1) // if no vowels are found 
                    {
                        phrase = y.Substring(1) + fstLtr;
                        newWord = AddPigLatin(phrase, 0); // completed word is processed
                        return newWord;
                            
                    }
                    // second vowel instance found
                    string newPrefix = y.Substring(0, dexNum);
                    string newSuffix = y.Substring(dexNum);
                    phrase = String.Concat(newSuffix, newPrefix, fstLtr);
                    newWord = AddPigLatin(phrase, 0); 
                    return newWord;
                }
                else
                {
                    // if not y its normal add -way
                    phrase = word.ToString();
                    newWord = AddPigLatin(phrase, 1);
                    return newWord;
                }
            }
            else
            {
                // if 1st letter isn't vowel 
                int dexNum = word.IndexOfAny(vowel); // find vowel
                //if word has no vowel
                if (dexNum == -1)
                {
                    phrase = word.ToString();
                    newWord = AddPigLatin(phrase, 0);
                    return newWord;
                }
                // vowel located word is chopped up and reordered
                string newPrefix = word.Substring(0, dexNum);
                string newSuffix = word.Substring(dexNum);
                phrase =  newSuffix + newPrefix;
                newWord = AddPigLatin(phrase, 0);
                return newWord;
            }
        }


        /// <summary>
        /// New altered phrase is passed along with a count that applies the special suffix for the needed contdition
        /// </summary>
        /// <param name="altFrase"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string AddPigLatin(string altFrase, int count)
        {
           if (count == 0)
            {
                return altFrase + "ay";
            }
            else
            {
                return altFrase + "way";
            }
        }
        #endregion
    }
}