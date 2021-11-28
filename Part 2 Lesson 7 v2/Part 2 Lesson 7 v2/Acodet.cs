using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part_2_Lesson_7_v2
{
    class Acodet : ICoder
    {
        public Dictionary<int, char> keys { get; set; }
        public string sas { get; set; }
        public string revs { get; set; }
        public Acodet()
        {
            keys = new Dictionary<int, char>();
            keys[0] = 'a';
            keys[1] = 'b';
            keys[2] = 'c';
            keys[3] = 'd';
            keys[4] = 'g';
            keys[5] = 'f';
        }
        public void Decode(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                bool ses;
                ses = keys.ContainsValue(s[i]);
                for (int g = keys.Count-1; g > 0; g--)
                {
                    if (ses)
                    {

                        revs = s.Replace(s[i], keys[g]);
                    }
                }
            }
        }


        public void Encode(string s)
        {
            bool ses;
            for (int i = 0; i < s.Length; i++)
            {
                ses = keys.ContainsValue(s[i]);
                if (ses)
                    {
                  sas=  s.Replace(s[i], keys[i + 1]);
                }
            }
        }

      
    }
}
