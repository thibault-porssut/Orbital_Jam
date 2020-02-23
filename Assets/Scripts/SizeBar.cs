using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeBar : MonoBehaviour
{
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }

    public void SetInitialLevel(int level)
    {
        //slider.value = level;
    }

public void SetMaxLevel(int level)
    {
        //slider.maxValue = level;
        //slider.value = level;
    }

    public void SetLevel(int level)
    {
        //slider.value = level;
    }
}
