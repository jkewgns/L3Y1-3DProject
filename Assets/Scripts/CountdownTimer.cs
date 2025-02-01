using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 4f;

    [SerializeField] TMP_Text countdownText;

    private CarController carController;
    private Canvas canvas;

    void Start()
    {
        GameObject car = GameObject.Find("Car");
        carController = car.GetComponent<CarController>();
        carController.enabled = false;

        canvas = GetComponent<Canvas>();

        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;

            carController.enabled = true;

            canvas.enabled = false;
        }
    }
}
