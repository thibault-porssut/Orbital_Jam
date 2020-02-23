using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour

{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0f, Speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
