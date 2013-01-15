using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToborRising.Assets.Scripts.Utils;

namespace ToborRising.Assets.Scripts.Game
{
	public class GamePropertys
	{
        private static GamePropertys instance = null;
        private Lang language;

        private GamePropertys()
        {
            language = Lang.ES;
        }

        public static GamePropertys getInstance()
        {           
            if (instance == null)
                instance = new GamePropertys();
            return instance;           
        }

        public Lang Language
        {
            get 
            {
                return language;
            }
        }
	}

}
