using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractStar : MonoBehaviour
{
    private int energy;
    private float spd;
    private int status; 

    // Start is called before the first frame update
    void Start()
    {
        energy = 3;
        spd = 0.05f;
        status = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
