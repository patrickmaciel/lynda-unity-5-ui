using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{

    public Slider sliderInstance;

	// Use this for initialization
	void Start ()
	{
	    sliderInstance.minValue = 0;
	    sliderInstance.maxValue = 100;
	    sliderInstance.wholeNumbers = true;
	    sliderInstance.value = 50;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnValueChanged(float value)
    {
        Debug.Log("New value " + value);
    }
}
