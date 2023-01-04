using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float movement = 0;
    public float tocdo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            movement = 1;
        else if (Input.GetKey(KeyCode.A))
            movement = -1;
        else movement = 0;
        transform.Translate(Vector3.right * tocdo * movement * Time.deltaTime);
    }
}
