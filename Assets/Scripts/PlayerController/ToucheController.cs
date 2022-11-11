using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToucheController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Код привязан на Lv...  и на Prefab PlayGame

    private RaycastHit hit;
    public static int hitCount;


   public static List<float> movePosX = new List<float>();     
   public static List<float> movePosZ = new List<float>();   




    public void OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("Privet");
    }

    private void Start()
    {
        hitCount = 0;
        
    }



    public void OnPointerUp(PointerEventData eventData)     // Метод принимает координаты от touch и внедряет влист
    {

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            if (hit.collider == null) return;

            GameObject newTarget = Instantiate(Resources.Load("Point"), hit.point, Quaternion.identity) as GameObject;

        }
      
        movePosX.Insert(hitCount, hit.point.x);       
        movePosZ.Insert(hitCount, hit.point.z);
        hitCount++;


    }

}
