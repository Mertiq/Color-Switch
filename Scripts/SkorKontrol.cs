using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorKontrol : MonoBehaviour
{
    
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int a = TopKontrol.skor;
        txt.text = "SCORE\n" + a;
    }
}
