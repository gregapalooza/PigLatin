using System;
using System.Windows.Forms;

namespace _6PigLatin
{
    public partial class Form1 : Form
    {
        PigLatin thisTranslation = new PigLatin();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Translate_Click(object sender, EventArgs e)
        {
            Translate();
        }

        private void Translate()
        {
            string[] noSpaces = tB_EnglishFrase.Text.Split(' '); //User input is taken split by spaces and stored in noSpaces

            //Loops through the user input to translate each word then added back into the textbox
            for (int i = 0; i < noSpaces.Length; i++)
            {
                string translation = "";
                thisTranslation.Phrase = noSpaces[i];
                translation += PigLatin.VowelCheck(thisTranslation.Phrase);
                rTBPigFrase.Text += translation + " ";
            }

        }
    }
}
