using System;
using System.Windows.Forms;

namespace AutoTextBuilder
{
    public partial class MainForm : Form
    {
        private static readonly char[] ENLowcase = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '[', ']', '`', '\'', ';', ',', '.' };
        private static readonly char[] RULowcase = { 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'х', 'ъ', 'ё', 'э', 'ж', 'б', 'ю'  };
        private static readonly char[] HELowcase = { '/', '\'', 'ק', 'ר', 'א', 'ט', 'ו', 'ן', 'ם', 'פ', 'ש', 'ד', 'ג', 'כ', 'ע', 'י', 'ח', 'ל', 'ך', 'ז', 'ס', 'ב', 'ה', 'נ', 'מ', 'צ', ']', '[', ';', ',', 'ף', 'ת', 'ץ' };
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void TextBox_Input_TextChanged(object sender, EventArgs e)
        {
            TextBox_Output.Text = Replace(LanguageUsedInput.Text, LanguageUsedOutput.Text, TextBox_Input.Text);
        }
        private static char[] ArrayUpper(char[] array)
        {
            string builder = "";

            for (int i = 0; i < array.Length; i++)
            {
                builder += Char.ToUpper(array[i]);
            }
            return builder.ToCharArray();
        }

        private string Replace(string langin, string langout, string ToChange)
        {
            char[] ArrayLowcaseInput = new char[34];
            char[] ArrayLowcaseOutput = new char[34];

            switch (langin)
            {
                case "English":
                    Array.Copy(ENLowcase, ArrayLowcaseInput, ENLowcase.Length);
                    break;
                case "Russian":
                    Array.Copy(RULowcase, ArrayLowcaseInput, RULowcase.Length);
                    break;
                case "Hebrew":
                    Array.Copy(HELowcase, ArrayLowcaseInput, HELowcase.Length);
                    break;
                default:
                    return "Error, select language input";
            }
            switch (langout)
            {
                case "English":
                    Array.Copy(ENLowcase, ArrayLowcaseOutput, ENLowcase.Length);
                    break;
                case "Russian":
                    Array.Copy(RULowcase, ArrayLowcaseOutput, RULowcase.Length);
                    break;
                case "Hebrew":
                    Array.Copy(HELowcase, ArrayLowcaseOutput, HELowcase.Length);
                    break;
                default:
                    return "Error, select language output";
            }

            char[] ArrayUpcaseInput = ArrayUpper(ArrayLowcaseInput);
            char[] ArrayUpcaseOutput = ArrayUpper(ArrayLowcaseOutput);
            string build = "";

            for (int i = 0; i < ToChange.Length; i++)
            {
                int index;
                char builder;
                index = Array.IndexOf(ArrayLowcaseInput, ToChange[i]);
                if (index == -1)
                {
                    index = Array.IndexOf(ArrayUpcaseInput, ToChange[i]);
                    if (index == -1)
                        builder = ToChange[i];
                    else
                        builder = ArrayUpcaseOutput[index];
                }
                else
                    builder = ArrayLowcaseOutput[index];

                build += builder;
            }
            return build;
        }

        private void LanguageUsedInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_Input_TextChanged(this, new EventArgs());
        }

        private void LanguageUsedOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_Input_TextChanged(this, new EventArgs());
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If the program doesn't \"translate\" correctly " +
                "the text (or doesn't translate at all), make sure that you " +
                "selected the correct input/output language!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}