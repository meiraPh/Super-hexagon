using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class player : MonoBehaviour
{
    private float _velocidade = 500f;
    public CameraShake CameraShake;


    // Update is called once per frame
    void Update()
    {
        var lado = Input.GetAxisRaw("Horizontal");
        transform.RotateAround(Vector3.zero, Vector3.forward, lado * _velocidade * Time.deltaTime * -1); 
    }

    void OnTriggerEnter2D(Collider2D collision)//Player dies
    {   
        StartCoroutine(CameraShake.Shake(.001f, .1f));
        FindObjectOfType<audioManager>().Play("PlayerDeath");
        SceneManager.LoadScene(0);
    }

}