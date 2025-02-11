using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public int audioType; // 0 = music, 1 = sfx

    SaveSettings saveSettings;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        saveSettings = GameObject.Find("Settings").GetComponent<SaveSettings>();
    }

    // Update is called once per frame
    void Update()
    {
        if (audioType == 0)
        {
            audioSource.volume = saveSettings.musicVolume;
            // audioSource.volume = saveSettings.globalVolume;
        }
        if (audioType == 1)
        {
            audioSource.volume = saveSettings.sfxVolume;
        }
    }
}
