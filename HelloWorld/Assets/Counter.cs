using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {

    int counter = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 200, 50), "Counter: " + counter);
    }

    private void OnMouseOver()
    {
     //   counter++;
    }

    private void OnMouseExit()
    {
        counter++;
    }
}
