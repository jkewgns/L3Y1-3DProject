using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Timer")]
    public float timer;
    public TMP_Text timerText;

    private bool isTimerRunning = false;  // To track if the timer should be running

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine to wait 4 seconds before starting the timer
        StartCoroutine(StartTimerAfterDelay(4f));
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerRunning)
        {
            GameTimer();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    // Coroutine to wait for 4 seconds before starting the timer
    IEnumerator StartTimerAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Start the timer after the delay
        isTimerRunning = true;
        Debug.Log("Timer started after 4 seconds!");
    }

    // Method to update the timer
    void GameTimer()
    {
        timerText.text = timer.ToString("F3");
        timer += Time.deltaTime;
    }
}
