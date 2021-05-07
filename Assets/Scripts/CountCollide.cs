using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCollide : MonoBehaviour
{
    public GameObject[] pins;
    public int numberOfCollide;
    bool ballIsOnRoad;
    float currenrTime;
    float lenghtOfRoad;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCollide = 0;
        currenrTime = 0;
        lenghtOfRoad = 10;
        ballIsOnRoad = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ballIsOnRoad)
        {
            currenrTime += Time.deltaTime;

            if (currenrTime >= lenghtOfRoad)
            {
                currenrTime = 0;
                ballIsOnRoad = false;
                Count();
            }
        }
    }

    void OnCollisionEnter(Collision sphere)
    {
        if (sphere.collider.tag == "Ball")
        {
            ballIsOnRoad = true;
        }
    }

    void Count()
    {
        foreach (GameObject pin in pins)
        {
            CheckCollide checkCollide = pin.GetComponent<CheckCollide>();
            bool isCollide = checkCollide.collide;
            if (isCollide)
            {
                numberOfCollide += 1;
            }
        }
        print(numberOfCollide);
    }
}
