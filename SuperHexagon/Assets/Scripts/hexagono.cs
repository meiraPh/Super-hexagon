using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagono : MonoBehaviour
{
    [SerializeField]
    private float _velocidade = 8f;

    SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        transform.Rotate(new Vector3(1,1,Random.Range(0f,360f)));
        
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
    }

    void Update()
    {
        transform.localScale -= Vector3.one * _velocidade * Time.deltaTime;

        if(transform.localScale.y <= 0.2){
            Destroy(gameObject);
        }
    }
}
