using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public float movx;
    public float movy;
    public float movz;
    public float vel = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movx = Input.GetAxis("Horizontal") * Time.deltaTime * vel;
        movz = Input.GetAxis("Vertical")* Time.deltaTime * vel;
        transform.Translate(movx, movy, movz);
    }
}
