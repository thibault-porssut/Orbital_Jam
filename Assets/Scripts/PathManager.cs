using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public List<GameObject> pathBlocks;
    public GameObject pilluleEnergy;
    public GameObject pilluleSize;
    public GameObject wall;
    public Transform reference;
    public float speedLevel;
    public Transform TEST;

    public static int score;

    GameObject[] activePath;
    GameObject[] spawnActive;
    float wallSize;
    bool flag;

    // Start is called before the first frame update
    void Start()
    {
        activePath = new GameObject[3];
        wallSize = wall.transform.localScale.x;
        activePath[0]=Instantiate(pathBlocks[0], reference);
        activePath[1]= Instantiate(pathBlocks[1], reference);
        activePath[1].transform.position+=new Vector3(wallSize, 0, 0);
        activePath[2]=Instantiate(pathBlocks[2], reference);
        activePath[2].transform.position += new Vector3(-wallSize, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PathGoForward();
        ControlAndDestroy();

    }

    void PathGoForward()
    {
        activePath[0].transform.position += Vector3.right * Time.deltaTime * speedLevel;
        activePath[1].transform.position += Vector3.right * Time.deltaTime * speedLevel;
        activePath[2].transform.position += Vector3.right * Time.deltaTime * speedLevel;
    }

    void ControlAndDestroy()
    {
        if( (-Camera.main.transform.position.x +activePath[0].transform.position.x)> 1.250f*wallSize)
        {
            Destroy(activePath[0]);
            int nbEnergy=Random.Range(0, 6);
            int nbSize=Random.Range(0, 6);

            int randomBlock = 0;
            if (!flag)
            {
                randomBlock = Random.Range(0, pathBlocks.Count);
                flag = true;

            }
            else
                flag = false;

            activePath[0] = Instantiate(pathBlocks[randomBlock], reference);
            activePath[0].transform.position += new Vector3(-1.50f * wallSize, 0, 0);
            SpawnPoint(0);

            // Debug.Log("w1");
        }

        if ((-Camera.main.transform.position.x + activePath[1].transform.position.x) > 1.250f * wallSize)
        {

            Destroy(activePath[1]);
            int randomBlock = 0;
            if (!flag)
            {
                randomBlock = Random.Range(0, pathBlocks.Count);
                flag = true;

            }
            else
                flag = false;

            activePath[1] = Instantiate(pathBlocks[randomBlock], reference);
            activePath[1].transform.position += new Vector3(-1.50f * wallSize, 0, 0);
            //Debug.Log("w2");
            SpawnPoint(1);


        }

        if ((-Camera.main.transform.position.x + activePath[2].transform.position.x) > 1.250f * wallSize)
        {

            Destroy(activePath[2]);
            int randomBlock = 0;
            if (!flag)
            {
                randomBlock = Random.Range(0, pathBlocks.Count);
                flag = true;

            }
            else
                flag = false;
            activePath[2] = Instantiate(pathBlocks[randomBlock], reference);
            activePath[2].transform.position += new Vector3(-1.500f * wallSize, 0, 0);
            //Debug.Log("w3");
            SpawnPoint(2);

        }


    }

    void SpawnPoint(int nbPath)
    {
        int nbEnergy = Random.Range(0, 6);
        int nbSize = Random.Range(0, 6);

        for (int i = 0; i <= nbEnergy; i++)
        {
            int rand = Random.Range(0, 8);
            Transform spawnPoint = activePath[nbPath].transform.Find("SpawnPoint");
            TEST = spawnPoint;
            if (spawnPoint!= null)
                Instantiate(pilluleEnergy, spawnPoint.GetChild(rand).transform);
        }

        for (int i = 0; i <= nbSize; i++)
        {
            int rand = Random.Range(0, 8);
            Transform spawnPoint = activePath[nbPath].transform.Find("SpawnPoint");
            TEST = spawnPoint;
            //if (spawnPoint.GetChild(rand) == null)
            if (spawnPoint != null)
                Instantiate(pilluleSize, spawnPoint.GetChild(rand).transform);
        }

        score += 1;
    }
}
