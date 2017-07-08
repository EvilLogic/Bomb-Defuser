using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BombDefuser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (((TextBox)sender).Text.Length != 6)
                {
                    MessageBox.Show("It needs to be 6 characters!");
                    ((TextBox)sender).Focus();
                    return;
                }
                switch (((TextBox)sender).Tag.ToString())
                {
                    case "1":
                        textBox2.Focus();
                        break;
                    case "2":
                        textBox3.Focus();
                        break;
                    case "3":
                        textBox4.Focus();
                        break;
                    case "4":
                        textBox5.Focus();
                        break;
                    case "5":
                        decrypt();
                        break;
                }
            }
        }

        private void decrypt()
        {
            String[] words = {"about", "after",	"again", "below", "could", 
                                 "every", "first", "found", "great", "house", 
                                 "large", "learn", "never", "other", "place",
                                 "plant", "point", "right", "small", "sound",
                                 "spell", "still", "study",	"their", "there",
                                 "these", "thing", "think",	"three", "water",
                                 "where", "which", "world",	"would", "write"};
            Char[] one = textBox1.Text.ToCharArray();
            //Char[] first = { 'a', 'b', 'c', 'e', 'f', 'g', 'h', 'l', 'n', 'o', 'p', 'r', 's', 't', 'w'};
            Char[] two = textBox2.Text.ToCharArray();
            //Char[] second = { 'a', 'b', 'g', 'e', 'o', 'v', 'i', };
            Char[] three = textBox3.Text.ToCharArray();
            Char[] four = textBox4.Text.ToCharArray();
            Char[] five = textBox5.Text.ToCharArray();
            for (int a = 0; a < 6; a++)
                for (int b = 0; b < 6; b++)
                    for (int c = 0; c < 6; c++)
                        for (int d = 0; d < 6; d++)
                            for (int e = 0; e < 6; e++)
                                for (int f = 0; f < 35; f++)
                                    if (charCombine(one[a], two[b], three[c], four[d], five[e]).Equals(words[f]))
                                        lblPass.Text = (charCombine(one[a], two[b], three[c], four[d], five[e]));
        }

        private static string charCombine(char c0, char c1, char c2, char c3, char c4)
        {
            // Combine chars into array
            char[] arr = new char[5];
            arr[0] = c0;
            arr[1] = c1;
            arr[2] = c2;
            arr[3] = c3;
            arr[4] = c4;
            // Return new string key
            return new string(arr);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var words = new Dictionary<string, double>{
                {"shell", 3.505}, {"halls", 3.515}, {"slick", 3.522},
                {"trick", 3.532}, {"boxes", 3.535}, {"leaks", 3.542},
                {"strobe", 3.545}, {"bistro", 3.552}, {"flick", 3.555},
                {"bombs", 3.565}, {"break", 3.572}, {"brick", 3.575},
                {"steak", 3.582}, {"sting", 3.592}, {"vector", 3.595},
                {"beats", 3.600}
            };
            var morse = new Dictionary<string, char>{
                {"0-", 'a'}, {"-000", 'b'}, {"-0-0", 'c'}, {"-00", 'd'},
                {"0", 'e'}, {"00-0", 'f'}, {"--0", 'g'}, {"0000", 'h'},
                {"00", 'i'}, {"0---", 'j'}, {"-0-", 'k'}, {"0-00", 'l'},
                {"--", 'm'}, {"-0", 'n'}, {"---", 'o'}, {"0--0", 'p'},
                {"--0-", 'q'}, {"0-0", 'r'}, {"000", 's'}, {"-", 't'},
                {"00-", 'u'}, {"000-", 'v'}, {"0--", 'w'}, {"-00-", 'x'},
                {"-0--", 'y'}, {"--00", 'z'}, {"0----", '1'}, {"00---", '2'},
                {"000--", '3'}, {"0000-", '4'}, {"00000", '5'}, {"-0000", '6'},
                {"--000", '7'}, {"---00", '8'}, {"----0", '9'}, {"-----", '0'}
            };
            String[] split = textBox6.Text.Split();
            String answer = "";
            try
            {
                foreach (string i in split)
                    answer += morse[i];
                lblMorse.Text = answer;
                lblMHz.Text = words[answer].ToString();
            }
            catch (Exception ex) { }
        }
    }
}
