using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseManager : MonoBehaviour
{

    public GameObject player;
    public GameObject losePoint;
    public GameObject scoreText;
    public GameObject gameoverText;
    public GameObject Image;


    public static bool isLost;
    public static bool isEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((-player.transform.position.x + losePoint.transform.position.x) < 0 && !isLost)
        {
            isLost = true;

        }


        LoseMod(isLost);
    }

    void LoseMod(bool lost)
    {
        if (lost && !isEnd)
        {

            StartCoroutine(LoseCoroutine());

        }

    }

    IEnumerator LoseCoroutine()
    {
        gameoverText.SetActive(true);
        Image.SetActive(true);
        yield return new WaitForSeconds(3);
        gameoverText.SetActive(false);
        scoreText.GetComponent<UnityEngine.UI.Text>().text="Your Score= "+PathManager.score.ToString();
        scoreText.SetActive(true);
        player.SetActive(false);
    }
}
