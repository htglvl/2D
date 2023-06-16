using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlHandler : MonoBehaviour
{
    public GameObject model;
    public Image bubbleChatDetector;
    public Transform bubbleChat;
    public Transform headCollider;
    public Transform bodyCollider;
    public float scale;
    public float modelColliderScale;
    public float moveScale;
    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                print(bubbleChatDetector.color.a);
                if (bubbleChatDetector.color.a == 1)
                {
                    bubbleChatDetector.color = new Color(bubbleChatDetector.color.r,
                                                         bubbleChatDetector.color.g,
                                                         bubbleChatDetector.color.b,
                                                         0);
                    //Debug.Log("turned to 0");
                }
                else
                {
                    bubbleChatDetector.color = new Color(bubbleChatDetector.color.r,
                                                         bubbleChatDetector.color.g,
                                                         bubbleChatDetector.color.b,
                                                         1);
                    //Debug.Log("turned to 0");
                }
                model.SetActive(!model.activeSelf);
                // Debug.Log("disappear/appear model");
            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                soundManager soundManager_variable = FindObjectOfType<soundManager>();
                string[] arrayOfVoice = { "flick Head 00", "flick Head 01", "tap body 00", "tap body 01", "tap body 02" };
                if (soundManager_variable.isVoiceMuting())
                {
                    soundManager_variable.unmuteVoice(arrayOfVoice);
                    //Debug.Log("unmuteVoice");
                }
                else
                {
                    soundManager_variable.muteVoice(arrayOfVoice);
                    //Debug.Log("muteVoice");
                }
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                soundManager soundManager_variable = FindObjectOfType<soundManager>();
                string[] arrayOfSfx = { "sound bubble appear" };
                if (soundManager_variable.isSfxMuting())
                {
                    soundManager_variable.unmuteSfx(arrayOfSfx);
                    //Debug.Log("unmuteSfx");
                }
                else
                {

                    soundManager_variable.muteSfx(arrayOfSfx);
                    //Debug.Log("muteSfx");
                }

            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                //model.SetActive(!model.activeSelf);
                model.transform.position = new Vector3(
                    model.transform.position.x - 0.1f,
                    model.transform.position.y,
                    model.transform.position.z);

                bubbleChat.position = new Vector3(
                    bubbleChat.position.x - moveScale,
                    bubbleChat.position.y,
                    bubbleChat.position.z);

                headCollider.position = new Vector3(
                    headCollider.position.x - moveScale,
                    headCollider.position.y,
                    headCollider.position.z);

                bodyCollider.position = new Vector3(
                    bodyCollider.position.x - moveScale,
                    bodyCollider.position.y,
                    bodyCollider.position.z);
                // Debug.Log("move left");
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //model.SetActive(!model.activeSelf);
                model.transform.position = new Vector3(
                    model.transform.position.x + 0.1f,
                    model.transform.position.y,
                    model.transform.position.z);

                bubbleChat.position = new Vector3(
                    bubbleChat.position.x + moveScale,
                    bubbleChat.position.y,
                    bubbleChat.position.z);

                headCollider.position = new Vector3(
                    headCollider.position.x + moveScale,
                    headCollider.position.y,
                    headCollider.position.z);

                bodyCollider.position = new Vector3(
                    bodyCollider.position.x + moveScale,
                    bodyCollider.position.y,
                    bodyCollider.position.z);
                // Debug.Log("move right");
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                //model.SetActive(!model.activeSelf);
                model.transform.position = new Vector3(
                    model.transform.position.x,
                    model.transform.position.y + 0.1f,
                    model.transform.position.z);

                bubbleChat.position = new Vector3(
                    bubbleChat.position.x,
                    bubbleChat.position.y + moveScale,
                    bubbleChat.position.z);

                headCollider.position = new Vector3(
                    headCollider.position.x,
                    headCollider.position.y + moveScale,
                    headCollider.position.z);

                bodyCollider.position = new Vector3(
                    bodyCollider.position.x,
                    bodyCollider.position.y + moveScale,
                    bodyCollider.position.z);
                // Debug.Log("move up");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                //model.SetActive(!model.activeSelf);
                model.transform.position = new Vector3(
                    model.transform.position.x,
                    model.transform.position.y - 0.1f,
                    model.transform.position.z);

                bubbleChat.position = new Vector3(
                    bubbleChat.position.x,
                    bubbleChat.position.y - moveScale,
                    bubbleChat.position.z);

                headCollider.position = new Vector3(
                    headCollider.position.x,
                    headCollider.position.y - moveScale,
                    headCollider.position.z);

                bodyCollider.position = new Vector3(
                    bodyCollider.position.x,
                    bodyCollider.position.y - moveScale,
                    bodyCollider.position.z);
                // Debug.Log("move down");
            }
            if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Plus))
            {
                //model.SetActive(!model.activeSelf);
                model.transform.localScale = new Vector3(
                    model.transform.localScale.x + 0.1f,
                    model.transform.localScale.y + 0.1f,
                    model.transform.localScale.z + 0.1f);

                bubbleChat.localScale = new Vector3(
                    bubbleChat.localScale.x + scale,
                    bubbleChat.localScale.y + scale,
                    bubbleChat.localScale.z + scale);

                headCollider.localScale = new Vector3(
                    headCollider.localScale.x + modelColliderScale,
                    headCollider.localScale.y + modelColliderScale,
                    headCollider.localScale.z + modelColliderScale);

                bodyCollider.localScale = new Vector3(
                    bodyCollider.localScale.x + modelColliderScale,
                    bodyCollider.localScale.y + modelColliderScale,
                    bodyCollider.localScale.z + modelColliderScale);
                // Debug.Log("size up");
            }
            if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
            {
                //model.SetActive(!model.activeSelf);
                model.transform.localScale = new Vector3(
                    model.transform.localScale.x - 0.1f,
                    model.transform.localScale.y - 0.1f,
                    model.transform.localScale.z - 0.1f);
                // Debug.Log("size down");

                bubbleChat.localScale = new Vector3(
                    bubbleChat.localScale.x - scale,
                    bubbleChat.localScale.y - scale,
                    bubbleChat.localScale.z - scale);

                headCollider.localScale = new Vector3(
                    headCollider.localScale.x - modelColliderScale,
                    headCollider.localScale.y - modelColliderScale,
                    headCollider.localScale.z - modelColliderScale);

                bodyCollider.localScale = new Vector3(
                    bodyCollider.localScale.x - modelColliderScale,
                    bodyCollider.localScale.y - modelColliderScale,
                    bodyCollider.localScale.z - modelColliderScale);
            }
        }
    }
}
