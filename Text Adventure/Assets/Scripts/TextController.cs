using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text myText;

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1 };

    States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        if (myState == States.cell)
        {
            Cell();
        }


    }

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape. " +
                "\nThere are some dirty sheets on the bed, a mirror on the wall," +
                "and the door is locked from the outside.\n\n" +
                "Press S to view the Sheets, M to view the Mirror and L to " +
                "view the Lock.";
        if (Input.GetKeyDown(KeyCode.S)){       myState = States.sheets_0;}

        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.mirror; }

        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_0; }
    }

    void Sheets_0()
    {
        myText.text = "These are very dirty sheets! They really need to be changed!" +
            "\n\n Press on R to return to the cell!";

        if (Input.GetKeyDown(KeyCode.R)){       myState = States.cell;}
    }
}
