using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

using ToborRising.Assets.Scripts.Utils;
using ToborRising.Assets.Scripts.Models;

namespace ToborRising.Assets.Scripts
{
    public class Commands
    {
		/// <summary>
        /// Write a text in a label.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="location"></param>
        public static void writeLine(Line line, Rect location)
        {
			GUI.Label(location, line.Text);
           
        }
		
        /// <summary>
        /// Write a text in a label.
        /// </summary>
        /// <param name="textId"></param>
        /// <param name="textFile"></param>
        /// <param name="location"></param>
        public static void writeLine(string textId, string textFile, Rect location)
        {
             writeLine(new Line(textId, textFile), location);
        }

        /// <summary>
        /// Write a text in a label.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="location"></param>
        public static void writeLine(Line line, TextLocation location)
        {
            int textLength = line.Text.Length;
            switch (location)
            {
                case TextLocation.Up:
				    writeLine(line, new Rect(
				             (Screen.width - GUI.skin.label.fontSize / 2 * textLength) / 2,
                              0, 
				              Screen.width, 
				              GUI.skin.label.fontSize * 2
				    ));
                    break;
                case TextLocation.Middle:
                    writeLine(line, new Rect(
				             (Screen.width - GUI.skin.label.fontSize / 2 * textLength) / 2,
                              Screen.height / 2 - GUI.skin.label.fontSize, 
				              Screen.width, 
				              GUI.skin.label.fontSize * 2
				    ));
                    break;
                case TextLocation.Down:
				    writeLine(line, new Rect(
				             (Screen.width - GUI.skin.label.fontSize / 2 * textLength) / 2,
                              Screen.height - GUI.skin.label.fontSize * 2, 
				              Screen.width, 
				              GUI.skin.label.fontSize * 2
				    ));
                    break;
            }
        }

        /// <summary>
        /// Write a text in a label.
        /// </summary>
        /// <param name="textId"></param>
        /// <param name="textFile"></param>
        /// <param name="location"></param>
        public static void writeLine(string textId, string textFile,TextLocation location)
        {
            writeLine(new Line(textId,textFile), location);
        }

        /// <summary>
        /// Write some lines into a label. 
        /// </summary>
        /// <param name="lines">
        /// A <see cref="Line[]"/>
        /// </param>
        /// <param name="location">
        /// A <see cref="Rect"/>
        /// </param>
        /// <param name="margin">
        /// A <see cref="System.Int32"/>
        /// </param>
        public static void writeLine(Line[] lines, Rect location, int margin)
        {
            for (int i = 0; i < lines.Length; i++ )
                writeLine(lines[i], new Rect(
                    location.x, 
                    location.y + location.height / 2 * i + margin * i ,
                    location.width, 
                    location.height
                ));            
        }

        /// <summary>
        ///Write some lines into a label. 
        /// </summary>
        /// <param name="lines">
        /// A <see cref="Line[]"/>
        /// </param>
        /// <param name="location">
        /// A <see cref="Rect"/>
        /// </param>
        public static void writeLine(Line[] lines, Rect location)
        {
            writeLine(lines, location, 3);
        }
		
		/// <summary>
		///Write some lines into a label. 
		/// </summary>
		/// <param name="lines">
		/// A <see cref="Line[]"/>
		/// </param>
		/// <param name="location">
		/// A <see cref="TextLocation"/>
		/// </param>
        public static void writeLine(Line[] lines, TextLocation location, int margin)
        {
			int maxSize = 0;
			for(int i = 0; i < lines.Length; i++)		
			{
				if(lines[i].Text.Length > maxSize) maxSize = lines[i].Text.Length;
			}
			
			switch (location)
            {
                case TextLocation.Up:
				    writeLine(lines, new Rect(
				             (Screen.width - GUI.skin.label.fontSize / 2 * maxSize) / 2,
                              0, 
				              Screen.width, 
				              GUI.skin.label.fontSize * 2
				    ), margin);
                    break;
                case TextLocation.Middle:
                    writeLine(lines, new Rect(
				             (Screen.width - GUI.skin.label.fontSize / 2 * maxSize) / 2,
                             (Screen.height - GUI.skin.label.fontSize * (lines.Length + 1)) / 2 - margin, 
				              Screen.width, 
				              GUI.skin.label.fontSize * 2
				    ), margin);
                    break;
                case TextLocation.Down:
				    writeLine(lines, new Rect(
				             (Screen.width - GUI.skin.label.fontSize / 2 * maxSize) / 2,
                              Screen.height - GUI.skin.label.fontSize * (lines.Length + 1) - margin, 
				              Screen.width, 
				              GUI.skin.label.fontSize * 2
				    ), margin);
                    break;
            }
        }
		
		/// <summary>
		///Write some lines into a label. 
		/// </summary>
		/// <param name="lines">
		/// A <see cref="Line[]"/>
		/// </param>
		/// <param name="location">
		/// A <see cref="TextLocation"/>
		/// </param>
        public static void writeLine(Line[] lines, TextLocation location)
        {
			writeLine(lines, location, 3);
        }
		
    }

    public enum TextLocation
    {
        Up = 0,
        Middle,
        Down,
    }
}