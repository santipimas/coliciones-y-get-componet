﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

        }   
    }

    void ResetearVehiculos()
    {

    }
    void activarcartelespromomenosde4ruedas() 
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {

            vehiculos[i].CartelPromo.SetActive(false);
        }
    }
}
