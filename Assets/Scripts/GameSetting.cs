using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    public float volume = 1f;
    public GameGrade grade = GameGrade.NORMAL;
    public ControlType controlType = ControlType.KEYBOARD;
    public bool isFullScreen = true;

    public TweenPosition startPanelTween;
    public TweenPosition optionPanelTween;

    public void OnVolumeChanged() 
    {
        volume = UIProgressBar.current.value;
        Debug.Log("OnVolumeChanged:" + volume);
        
    }

    public void OnGameGradeChanged() 
    {
        var option = UIPopupList.current.value;
        switch (option.Trim())
        {
            case "简单":
                grade = GameGrade.EASY;
                break;
            case "一般":
                grade = GameGrade.NORMAL;
                break;
            case "困难":
                grade = GameGrade.DIFFICULT;
                break;
           
        }

    }

    public void OnControlTypeChanged() 
    {
        var option = UIPopupList.current.value;
        switch (option.Trim())
        {
            case "键盘":
                controlType = ControlType.KEYBOARD;
                break;
            case "触摸":
                controlType = ControlType.TOUCH;
                break;
            case "鼠标":
                controlType = ControlType.MOUSE;
                break;

        }
    }

    public void OnIsFullScreenChanged() 
    {
        //Debug.Log("OnIsFullScreenChanged");
        isFullScreen = UIToggle.current.value;
    }

    public void OnStartPanelButtonClick() 
    {
        startPanelTween.PlayForward();
        optionPanelTween.PlayForward();
        Debug.Log("选项");
    }
    public void OnOptionPanelButtonClick()
    {
        startPanelTween.PlayReverse();
        optionPanelTween.PlayReverse();
        Debug.Log("完成");
    }
}

public enum GameGrade
{
    EASY,
    NORMAL,
    DIFFICULT
}

public enum ControlType
{
    KEYBOARD,
    TOUCH,
    MOUSE,
}
