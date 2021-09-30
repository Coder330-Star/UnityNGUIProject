using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_CD : MonoBehaviour
{    
    public UISprite maskSp;//冷却遮罩

    private float coldTime = 2f;
    private bool isCoding = false;//表public

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !isCoding)
        {
            maskSp.fillAmount = 1;
            isCoding = true;
        }

        if (isCoding)
        {
            maskSp.fillAmount -= (1f / coldTime) * Time.deltaTime;
            if (maskSp.fillAmount <= 0.05f)
            {
                maskSp.fillAmount = 0;
                isCoding = false;


            }
        }
    }
}
