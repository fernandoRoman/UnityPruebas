using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ToborRising.Assets.Scripts.Utils;

namespace ToborRising.Assets.Scripts.Models
{
	public class Line
	{
        string textID, textFile, text;
        
        public Line(string textID, string textFile)
        {
            this.textID = textID;
            this.textFile = textFile;
			text = Language.getInstance().getText(textID, textFile);
        }

        public string TextID 
        {
            get
            {
                return textID;
            }
        }

        public string TextFile
        {
            get 
            {
                return textFile;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
        }

	}
}
