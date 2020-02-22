using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public int energy = 0;
    public int food = 0;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        Move(moveSpeed);

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Food : " + food);
        GUI.Label(new Rect(10, 30, 100, 20), "Energy : " + energy);
    }

    private void Move(float Speed)
    {
        //transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f); //Movement only horizontally
        transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
