using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.GetComponent<PlayerScript>().currentEnergy += 80;
            if(other.GetComponent<PlayerScript>().currentEnergy > 100)
            {
                other.GetComponent<PlayerScript>().currentEnergy = 100;
            }
            Destroy(gameObject);
        }
    }
}
