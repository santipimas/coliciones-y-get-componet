using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisoscript : MonoBehaviour
{
    public int resistencia;
    public esferascript esfera;

    //cuando un objeto colisione con este debe escribirse en la cnsola la palabra contacto
    private void OnCollisionEnter(Collision collision)
    {
        esfera = collision.gameObject.GetComponent<esferascript>();
        Debug.Log("contacto con una esfera que pesa" + esfera.peso);
    }

}
