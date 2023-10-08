using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] private Slider senseSlider;
    [SerializeField] private Text senseText;

    [SerializeField] private Slider volumeSlider;
    [SerializeField] private Text volumeText;

    [SerializeField] private Slider fovSlider;
    [SerializeField] private Text fovText;

    private void Awake()
    {
        senseSlider.value = (StaticData.mouseSensitivity.x - 1) / 79 / 5;
        volumeSlider.value = StaticData.volume / 100f;
        fovSlider.value = (StaticData.fov - 60) / 30f;

        senseText.text = (senseSlider.value * 79).ToString("0");
        volumeText.text = (volumeSlider.value * 100).ToString("0") + "%";
        fovText.text = (30 * fovSlider.value + 60).ToString("0");
    }

    public void Sensitivity()
    {
        StaticData.mouseSensitivity = (new Vector2(senseSlider.value, senseSlider.value) * 79 + new Vector2(1, 1)) * 5;
        senseText.text = (senseSlider.value * 79 + 1).ToString("0");
    }

    public void Volume()
    {
        StaticData.volume = (int)volumeSlider.value;
        volumeText.text = (volumeSlider.value * 100).ToString("0") + "%";
    }

    public void FOV() {
        StaticData.fov = (int)(0.3 * fovSlider.value + 60);
        fovText.text = (30 * fovSlider.value + 60).ToString("0");
    }

    private void Update()
    {
        
    }
}
