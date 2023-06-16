using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;


public class chatHandler : MonoBehaviour
{
    public Animator animatorModel;
    public Transform bubbleChat;
    public controlHandler control;
    private void Start()
    {
        bubbleChat.localScale = Vector3.zero;
    }
    public void BubbleChatAppear()
    {
        soundManager soundManager_variable = FindObjectOfType<soundManager>();
        bubbleChat.LeanScale(Vector3.one, .25f).setEaseOutBack().delay = .2f;
        control.enabled = !control.enabled;
        //Debug.Log("appeared");
        if (soundManager_variable.isPlaying("sound bubble appear") == false)
        {
            soundManager_variable.play("sound bubble appear");
        }
    }
    public void BubbleChatDisappear()
    {
        bubbleChat.LeanScale(Vector3.zero, .25f);
        control.enabled = !control.enabled;
    }

    public void headClicked()
    {
        soundManager soundManager_variable = FindObjectOfType<soundManager>();
        if ((soundManager_variable.isPlaying("flick Head 00") == false) &&
            (soundManager_variable.isPlaying("flick Head 01") == false))
        {
            animatorModel.SetTrigger("flick head");
            if (Random.Range(0, 2) == 0)
            {
                animatorModel.SetInteger("random state", 0);
                soundManager_variable.play("flick Head 00");
            }
            else
            {
                animatorModel.SetInteger("random state", 1);
                soundManager_variable.play("flick Head 01");
            }
        }
    }
    public void bodyClicked()
    {
        soundManager soundManager_variable = FindObjectOfType<soundManager>();
        if ((soundManager_variable.isPlaying("tap body 00") == false)
         && (soundManager_variable.isPlaying("tap body 01") == false)
         && (soundManager_variable.isPlaying("tap body 02") == false))
        {
            animatorModel.SetTrigger("tap body");
            if (Random.Range(0, 3) == 0)
            {
                animatorModel.SetInteger("random state", 0);
                soundManager_variable.play("tap body 00");
            }
            else if (Random.Range(0, 3) == 1)
            {
                animatorModel.SetInteger("random state", 1);
                soundManager_variable.play("tap body 01");
            }
            else
            {
                animatorModel.SetInteger("random state", 2);
                soundManager_variable.play("tap body 02");
            }
        }

    }
}
