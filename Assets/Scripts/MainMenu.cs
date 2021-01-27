using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Button findImage;
    public Button marioSurprise;

    void OnEnable()
    {
        //Register Button Events
        findImage.onClick.AddListener(() => buttonCallBack(findImage));
        marioSurprise.onClick.AddListener(() => buttonCallBack(marioSurprise));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == findImage)
        {
            Application.LoadLevel(1);
        }

        if (buttonPressed == marioSurprise)
        {
            Application.LoadLevel(2);
        }
    }

    void OnDisable()
    {
        //Un-Register Button Events
        findImage.onClick.RemoveAllListeners();
        marioSurprise.onClick.RemoveAllListeners();
    }
}

