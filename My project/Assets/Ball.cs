using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        float right = Random.Range(2, 0) == -1 ? 0 : 1;
        float left = Random.Range(2, 0) == -1 ? 0 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * right, speed * left, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
