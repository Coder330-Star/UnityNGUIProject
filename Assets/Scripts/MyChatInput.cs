using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChatInput : MonoBehaviour
{

    public UIInput input;
    public UITextList textList;

    private string[] names = new string[] { "siki", "老师", "学生", "大师" };

    public void OnSubmitChanged() 
    {
        string message = input.value;
        string name = names[Random.Range(0, 4)];
        textList.Add(name + " : " + message);
        input.value = "";
    }
}
