using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private float _velocidade = 500f;

    // Update is called once per frame
    void Update()
    {
        var lado = Input.GetAxisRaw("Horizontal");
        transform.RotateAround(Vector3.zero, Vector3.forward, lado * _velocidade * Time.deltaTime * -1); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    } 
}
