using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public bool cube;

    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cube)
        
        {

         transform.Translate(0f, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f);
        }
        else

        {
            transform.Translate(0f, Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0f);
        }

    }
}
