using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApoiterAngle : MonoBehaviour
{
    public Transform star;
    public Vector3 direction = new Vector3(0f,0f,0f);
    public float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalcularDistancia();
        
    }

    void CalcularDistancia()
    {
        direction = transform.position - star.position;
        distance = direction.magnitude;
    }
}
