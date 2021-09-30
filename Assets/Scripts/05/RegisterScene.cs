using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterScene : MonoBehaviour
{

    public UIInput ageInput;


    public void OnAgeValueChanged ()
    {
        //逻辑判断
        if (int.TryParse(ageInput.value,out int age))
        {
            if (age<18)
            {
                ageInput.value = "18";
            }

            else if (age>120)
            {
                ageInput.value = "120";
            }
        }
        
    }
}
