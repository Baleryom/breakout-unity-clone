using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public int Score = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(800, 10, 100, 20), Score.ToString());
    }
}
