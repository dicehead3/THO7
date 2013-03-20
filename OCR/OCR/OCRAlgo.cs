using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    public class OCRAlgo : Algorithm
    {
        public OCRAlgo(string name)
            : base(name)
        {

        }

        public override Dictionary<string, int> DoAlgorithm(System.Drawing.Bitmap bmp)
        {
            ShellImage si = new ShellImage(bmp);
            Dictionary<string, int> dic = new Dictionary<string, int>();

            int[] percentages = new int[36];
            for (int i = 0; i < 36; i++)
                percentages[i] = 0;

            for(int y = 0; y < si.Height; y++)
                for (int x = 0; x < si.WidthX3 - 2; x += 3)
                {
                    for (int i = 0; i < 36; i++)
                    {
                        if (CharData.Data.Characters[i].ContainsKey(new Point(x / 3, y)))
                        {
                            bool b = CharData.Data.Characters[i][new Point(x / 3, y)];
                            byte rgbVal = si.Get(x, y);
                            if (rgbVal > 127 && b == false)
                            {
                                percentages[i] += 5;
                            }
                            else if (rgbVal <= 127 && b == true)
                            {
                                percentages[i] += 5;
                            }
                        }
                    }
                }
            int j = 0;
            dic.Add("A", percentages[j]); j++;
            dic.Add("B", percentages[j]); j++;
            dic.Add("C", percentages[j]); j++;
            dic.Add("D", percentages[j]); j++;
            dic.Add("E", percentages[j]); j++;
            dic.Add("F", percentages[j]); j++;
            dic.Add("G", percentages[j]); j++;
            dic.Add("H", percentages[j]); j++;
            dic.Add("I", percentages[j]); j++;
            dic.Add("J", percentages[j]); j++;
            dic.Add("K", percentages[j]); j++;
            dic.Add("L", percentages[j]); j++;
            dic.Add("M", percentages[j]); j++;
            dic.Add("N", percentages[j]); j++;
            dic.Add("O", percentages[j]); j++;
            dic.Add("P", percentages[j]); j++;
            dic.Add("Q", percentages[j]); j++;
            dic.Add("R", percentages[j]); j++;
            dic.Add("S", percentages[j]); j++;
            dic.Add("T", percentages[j]); j++;
            dic.Add("U", percentages[j]); j++;
            dic.Add("V", percentages[j]); j++;
            dic.Add("W", percentages[j]); j++;
            dic.Add("X", percentages[j]); j++;
            dic.Add("Y", percentages[j]); j++;
            dic.Add("Z", percentages[j]); j++;

            dic.Add("0", percentages[j]); j++;
            dic.Add("1", percentages[j]); j++;
            dic.Add("2", percentages[j]); j++;
            dic.Add("3", percentages[j]); j++;
            dic.Add("4", percentages[j]); j++;
            dic.Add("5", percentages[j]); j++;
            dic.Add("6", percentages[j]); j++;
            dic.Add("7", percentages[j]); j++;
            dic.Add("8", percentages[j]); j++;
            dic.Add("9", percentages[j]); j++;

            return dic;
        }
    }
}
