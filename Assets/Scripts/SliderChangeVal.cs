using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderChangeVal : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI sliderVal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderVal.text=slider.value.ToString();
    }
}
