using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.GetComponent<PlayerScript>().currentFood ++;
            if (other.GetComponent<PlayerScript>().currentFood > 6)
            {
                other.GetComponent<PlayerScript>().currentFood = 6;
            }

            if (other.GetComponent<PlayerScript>().currentFood == 1)
            {
                other.GetComponent<PlayerScript>().level = 1;
            } else if (other.GetComponent<PlayerScript>().currentFood == 3)
            {
                other.GetComponent<PlayerScript>().level = 2;
            } else if (other.GetComponent<PlayerScript>().currentFood == 6)
            {
                other.GetComponent<PlayerScript>().level = 3;
            }
            Destroy(gameObject);
        }
    }
}
