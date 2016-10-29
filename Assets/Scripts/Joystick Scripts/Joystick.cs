using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Joystick : MonoBehaviour,IPointerUpHandler,IPointerDownHandler {

    private PlayerScript player;

    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        if (gameObject.name == "Left")
        {
            player.SetMoveLeft(true);
        }else
        {
            player.SetMoveLeft(false);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        player.StopMoving();
    }

}
