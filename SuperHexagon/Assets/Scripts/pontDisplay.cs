using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pontDisplay : MonoBehaviour
{
    public Text pontText;
    public static int pontuation = 0;

    // Start is called before the first frame update
    void Start()
    {
        pontuation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pontText.text = "" + pontuation;
        
    }
}
