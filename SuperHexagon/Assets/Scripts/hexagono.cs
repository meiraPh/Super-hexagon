using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagono : MonoBehaviour
{
    [SerializeField]
    private float _velocidade = 8f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(1,1,Random.Range(0f,360f)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * _velocidade * Time.deltaTime;

        if(transform.localScale.y <= 0.2){
            Destroy(gameObject);
        }
    }
}
