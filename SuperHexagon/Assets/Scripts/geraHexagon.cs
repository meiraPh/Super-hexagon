using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geraHexagon : MonoBehaviour
{   
    [SerializeField]
    private float _velocidadeGeracao = 2f;
    [SerializeField]
    private GameObject _hexagono;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("geraHexagono", 1, _velocidadeGeracao);       
    }

    public void geraHexagono()
    {
        Instantiate(_hexagono);        
    }
}
