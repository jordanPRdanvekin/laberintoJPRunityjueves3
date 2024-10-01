using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectordecolision : MonoBehaviour
{
    [SerializeField]
    Material materialbase;

    [SerializeField]
    Material materialtocado;

    bool tocar = false;

    float tiempo = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tocar == true)
        {
            tiempo = tiempo - Time.deltaTime;
            if (tiempo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialbase;
                tocar = false;
                tiempo = 5f;
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialtocado;
            tocar = true;
        }
    }
}
