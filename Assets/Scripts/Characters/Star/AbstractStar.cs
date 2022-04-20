using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractStar : MonoBehaviour
{
    public int energy = 3;
    public float spd = 0.05f;
    public int status = 0; 

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
