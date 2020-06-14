using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
        GameObject[] kule = GameObject.FindGameObjectsWithTag("do_usuniecia");
        for (int i = 0; i < kule.Length; i++)
        {
            Destroy(kule[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
