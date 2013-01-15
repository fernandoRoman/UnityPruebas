using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.NetworkInformation;
using ToborRising.Assets.Scripts.Game;

using HtmlAgilityPack;


namespace ToborRising.Assets.Scripts.Utils
{
    
	public class Language
	{
        
        private static Language instance = null;
        private string currentFile;
        private Lang currentLang;
        HtmlDocument doc;
        private Language()
        {
            doc = new HtmlDocument();
            currentFile = "";
        }

        public static Language getInstance()
        {
            if (instance == null)
                instance = new Language();
            return instance;
        }

        public string getText(string id, string file)
        {
            if (currentLang != GamePropertys.getInstance().Language || currentFile != file) { loadLang(file); }
            return doc.GetElementbyId(id).InnerText;
        }

        private void loadLang(string file)
        {
            currentLang = GamePropertys.getInstance().Language;
            doc.Load("Assets/Lang/"+ file + currentLang + ".lang");
            
        }
	}

    public enum Lang
    {
        ES = 0,
        ENG,
    }
}
