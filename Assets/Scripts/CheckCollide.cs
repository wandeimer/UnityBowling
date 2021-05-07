using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollide : MonoBehaviour
{
    // Start is called before the first frame update
    public bool collide;
    void Start()
    {
        collide = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionExit(Collision other)
    {
        collide = true;
    }
}
