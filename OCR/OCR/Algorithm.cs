using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    /// <Author>
    /// Erwin Bonnet
    /// </Author>
    public abstract class Algorithm
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        public Algorithm(String name)
        {
            _name = name;
        }

        public abstract Dictionary<string, int> DoAlgorithm(System.Drawing.Bitmap b);
    }
}