using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public int maxEnergy = 100;
    public int currentEnergy;
    public int maxFood = 6;
    public int currentFood;
    public int level = 1; //Size

    public EnergyBar energyBar;
    public SizeBar sizeBar;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);

        //sizeBar.SetMaxLevel(4);
        //sizeBar.SetInitialLevel(1);

        GetComponentInChildren<Light>().innerSpotAngle = 50;
    }

    // Update is called once per frame
    void Update()
    {
        Move(moveSpeed);

        if(level == 1)
        {
            GetComponentInChildren<Light>().spotAngle = 50;
        } else if (level == 2)
        {
            GetComponentInChildren<Light>().spotAngle = 65;
        } else if (level == 3)
        {
            GetComponentInChildren<Light>().spotAngle = 80;
        } else if (level == 4)
        {
            GetComponentInChildren<Light>().spotAngle = 100;
        }
    }

    private void Move(float Speed)
    {
        //transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f); //Movement only horizontally
        transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
    }
}
