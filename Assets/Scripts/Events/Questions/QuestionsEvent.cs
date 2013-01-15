using UnityEngine;
using System.Collections;

using ToborRising.Assets.Scripts;
using ToborRising.Assets.Scripts.Models;

public class QuestionsEvent : MonoBehaviour {

    // Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    private void OnGUI()
    {
        GUI.skin.label.fontSize = 13;
        Commands.writeLine(new Line[] {
            new Line("q1-1", "Questions"),
            new Line("q1-2", "Questions"),
			new Line("q1r1","Questions"),
			new Line("q1r2","Questions"),
			new Line("q1r3", "Questions")
		}, TextLocation.Middle);
    }

    private void OnApplicationQuit()
    {
        ToborRising.Assets.Scripts.Utils.Log log = ToborRising.Assets.Scripts.Utils.Log.getInstance();
        log.writeLine("Game event QuestionsEvent closed");
		log.close();
    }
}