using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    void Start()
    {
        text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        GameObject road = GameObject.FindWithTag("Road3");
        CountCollide countCollide = road.GetComponent<CountCollide>();
        float score = countCollide.numberOfCollide;
        text.text = score.ToString();
    }
}
