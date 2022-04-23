using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLaser : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem ray;
    [SerializeField]
    private TextMeshProUGUI output;
    [SerializeField]
    private TextMeshProUGUI input;
    public bool isRed;
    [SerializeField]
    private Image redButton;
    [SerializeField]
    private Image greenButton;

    public void OnActivateLaserGreen()
    {
        isRed = false;
        input.text = "0 Äæ";
        output.text = "0 ìÄæ";
        ray.Stop();
        greenButton.color = Color.green;
        redButton.color = Color.white;
    }
    public void OnActivateLaserRed()
    {
        isRed = true;
        input.text = "0 Äæ";
        output.text = "0 ìÄæ";
        ray.Stop();
        greenButton.color = Color.white;
        redButton.color = Color.red;
    }
    public void StartGreenLaser()
    {
        var main = ray.main;
        main.startColor = Color.green;
        ray.Play();
    }
    public void StartRedLaser()
    {
        var main = ray.main;
        main.startColor = Color.red;
        ray.Play();
    }
    public void StopLaser()
    {
        ray.Stop();
    }
}
