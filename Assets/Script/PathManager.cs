using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public List<GameObject> pathBlocks;
    public GameObject wall;
    public Transform reference;
    public float speedLevel;


    GameObject[] activePath;
    float wallSize;

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
    void Update()
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
        if( (-Camera.main.transform.position.x +activePath[0].transform.position.x)> 0.90f*wallSize)
        {
            Destroy(activePath[0]);
            activePath[0] = Instantiate(pathBlocks[0], reference);
            activePath[0].transform.position += new Vector3(-1.90f * wallSize, 0, 0);
            Debug.Log("w1");
        }

        if ((-Camera.main.transform.position.x + activePath[1].transform.position.x) > 0.90f * wallSize)
        {
            Destroy(activePath[1]);
            activePath[1] = Instantiate(pathBlocks[1], reference);
            activePath[1].transform.position += new Vector3(-1.90f * wallSize, 0, 0);
            Debug.Log("w2");
        }

        if ((-Camera.main.transform.position.x + activePath[2].transform.position.x) > 0.90f * wallSize)
        {
            Destroy(activePath[2]);
            activePath[2] = Instantiate(pathBlocks[2], reference);
            activePath[2].transform.position += new Vector3(-1.90f * wallSize, 0, 0);
            Debug.Log("w3");
        }
    }
}
