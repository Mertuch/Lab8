using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_script2 : MonoBehaviour
{
  


    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position);
        //print(transform.position.x);

        //transform.position = pozycja;
        //transform.position = new Vector3(5, 5, 5);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0);
        //transform.Translate(1, 0, 0);

        //transform.localScale += new Vector3(0.1f, 0, 0);

        //transform.Rotate(0, 0.5f, 0);
        transform.Rotate(2, 0, 0);
    }
}
