using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public Transform topunTransformu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(topunTransformu.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, topunTransformu.position.y, transform.position.z);
        } 
    }
}



