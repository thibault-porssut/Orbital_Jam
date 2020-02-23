using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{

    public PlayerScript player;
    public GameObject world;

    public AudioSource[] audioSources;



    // Start is called before the first frame update
    void Start()
    {
        audioSources = world.GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        levelPower();

    }

    void levelPower()
    {
        float powerPer = 200;//(player.food / 10)*100;

        if (powerPer<=50|| Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Increase Vision of 50%

            //Decrease energy -

            //Set Music for low size
            audioSources[0].mute = false;
            audioSources[1].mute = true;
            audioSources[2].mute = true;
            audioSources[3].mute = true;

            Debug.Log(1);

        }
        else if((powerPer > 50 && powerPer<=65) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Increase Vision of 65%

            //Decrease energy --

            //Set Music for mid size
            audioSources[0].mute = true;
            audioSources[1].mute = false;
            audioSources[2].mute = true;
            audioSources[3].mute = true;
            Debug.Log(2);
        }
        else if ((powerPer > 65 && powerPer <= 80) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Increase Vision of 80%

            //Decrease energy ---

            //Set Music for mid size
            audioSources[0].mute = true;
            audioSources[1].mute = true;
            audioSources[2].mute = false;
            audioSources[3].mute = true;
        }
        else if ((powerPer > 80 && powerPer <= 100) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            //Increase Vision of 100%

            //Decrease energy ---

            //Set Music for mid size
            audioSources[0].mute = true;
            audioSources[1].mute = true;
            audioSources[2].mute = true;
            audioSources[3].mute = false;
            Debug.Log(4);
        }
        else if(LoseManager.isLost && !LoseManager.isEnd )
        {
            audioSources[0].mute = true;
            audioSources[1].mute = true;
            audioSources[2].mute = true;
            audioSources[3].mute = true;
            audioSources[4].Play();
            LoseManager.isEnd = true;

        }

    }

}
