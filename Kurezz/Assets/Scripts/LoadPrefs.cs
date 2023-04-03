using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPrefs : MonoBehaviour
{
    [Header("General Setts")]

    [SerializeField] private bool canUse = false;
    [SerializeField] private MenuController menuController;

    [Header("Volume Setts")]

    [SerializeField] private Text volumeValue = null;
    [SerializeField] private Slider volumeSlider = null;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("masterVolume"))
        {
            float localVolume = PlayerPrefs.GetFloat("masterVolume");

            volumeValue.text = localVolume.ToString("0");
            volumeSlider.value = localVolume;
            AudioListener.volume = localVolume;
        }
    }
}
