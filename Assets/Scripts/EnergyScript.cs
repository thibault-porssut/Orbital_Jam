using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
