using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    private Button Button;
    bool musicIsOn;
    public Text text;
    void Start()
    {
        musicIsOn = true;
        text.text = "Stop music";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeState()
    {
        if (musicIsOn)
        {
            musicIsOn = false;
            text.text = "Play music";
        }
        else
        {
            musicIsOn = true;
            text.text = "Stop music";
        }
    }
}
