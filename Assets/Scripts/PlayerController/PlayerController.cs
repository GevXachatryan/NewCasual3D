using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Код привязан на Player

    [SerializeField] private float speed;
    static float moveX;
    static float moveZ;
    bool movStart = true;
    static int pointCount = 1;

  
    private void Awake()      // Обнуление перемен
    {
        moveX = 0;
        moveZ = 0;
        pointCount = 1;
        ToucheController.movePosX.RemoveRange(0, ToucheController.movePosX.Count);
        ToucheController.movePosZ.RemoveRange(0, ToucheController.movePosZ.Count);
        PlayGame.playGame = false;
        movStart = true;
        
    }

    private void FixedUpdate()    
    {
        if (PlayGame.playGame == true && movStart == true)
        {
            OnMovePos();
        }
        Move();
    }


    void Move()
    {

          Vector3 vek1;
          vek1.x = moveX;
          vek1.y = 0;
          vek1.z = moveZ;
          transform.position = Vector3.MoveTowards(transform.position, vek1, speed * Time.deltaTime);

    }


    void OnMovePos()                          // Игрок идет по координатам первого Point
    {
            moveX = ToucheController.movePosX[0];
            moveZ = ToucheController.movePosZ[0];
    }


    private void OnTriggerEnter(Collider other)    // Останавливает метод  OnMovePos()  и передает методу  Move  новые координаты с помощью переменной pointCount
    {
        if (other.tag == "Point" && pointCount < ToucheController.movePosX.Count)  
        {
            movStart = false;
           
                moveX = ToucheController.movePosX[pointCount];
                moveZ = ToucheController.movePosZ[pointCount];
                pointCount++;

            Destroy(other.gameObject);
        }

        if (other.tag == "EndGame")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (other.tag == "PostProcessing")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            PlayerPrefs.SetInt("lvCount", SceneManager.GetActiveScene().buildIndex + 1);
         
        }
    }

  


































    //[SerializeField] private float speed;

    //private Rigidbody rb;


    //[SerializeField] GameObject obj;


    //private void Start()
    //{

    //    rb = GetComponent<Rigidbody>();
    //}



    //private void FixedUpdate()
    //{

    //    if(PlayGame.playGame == true)
    //    {
    //        Move();
    //    }


    //}


    //void Move()
    //{
    //    if (PlayGame.playGame == true)
    //    {


    //        Vector3 vek1;
    //        //  vek1.x = 0;
    //        vek1.y = 0;
    //        //  vek1.z = 0;

    //        for (int i = 0; i < ToucheController.hitCount; i++)
    //        {
    //            vek1.x = ToucheController.movePosX[i];
    //            vek1.z = ToucheController.movePosZ[i];
    //            transform.position = Vector3.MoveTowards(transform.position, vek1, speed * Time.deltaTime);
    //        }

    //        //  transform.position = Vector3.MoveTowards(transform.position, vek1, speed * Time.deltaTime);

    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Point")
    //    {

    //        Debug.Log("     POINT");
    //    }


    //}





}
