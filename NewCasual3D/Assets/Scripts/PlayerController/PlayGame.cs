using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayGame : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Код привязан на  Prefab  PlayGame

    public static bool playGame;
    public void OnPointerDown(PointerEventData eventData)
    {
    }

   
    public void OnPointerUp(PointerEventData eventData) // Если в игре нажать на префаб игра начнется  
    {
        playGame = true;     
    }

   

  
}
