using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredmovil : MonoBehaviour
{
    public float rotar = 2; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotar * Time.deltaTime, 0f);
    }
}
