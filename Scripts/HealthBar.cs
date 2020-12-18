using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    //public Gradient gradient;
   

    //Function to set max possible health so that it doesn't have to be set in Unity every time
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }
    //Function that allows user to set health so that it isn't manually done in Unity
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    
}
