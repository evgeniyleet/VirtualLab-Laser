using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LaserPerformance: MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI output;
    [SerializeField]
    private TextMeshProUGUI input;
    public int i = 0;
    public int j = 0;
    private Conformity conformity = new Conformity();
    public ChangeLaser laser;

    public void OnClickPlus()
    {
        if (laser.isRed)
        {
            if (i < 20)
                i++;
            ShowTextLaserRed();
            if (int.Parse(conformity.NumberMJouleRedLaser(i)) == 11)
                laser.StartRedLaser();
            j = 0;
        }
        if (!laser.isRed)
        {
            if (j < 18)
                j++;
            ShowTextLaserGreen();
            if (float.Parse(conformity.NumberMJouleGreenLaser(j)) == 3.4f)
                laser.StartGreenLaser();
            i = 0;
        }
    }
    public void OnClickMines()
    {
        if (laser.isRed)
        {
            if (i > 0)
                i--;
            ShowTextLaserRed();
            if (int.Parse(conformity.NumberMJouleRedLaser(i)) < 11)
                laser.StopLaser();
        }
        if (!laser.isRed)
        {
            if (j > 0)
                j--;
            ShowTextLaserGreen();
            if (float.Parse(conformity.NumberMJouleGreenLaser(j)) < 3.4f)
                laser.StopLaser();
        }  
    }

    void ShowTextLaserRed()
    {
        input.text =  $"{conformity.NumberJouleRedLaser(i)} Äæ";
        output.text = $"{conformity.NumberMJouleRedLaser(i)} ìÄæ";
    }
    void ShowTextLaserGreen()
    {
        input.text = $"{conformity.NumberJouleGreenLaser(j)} Äæ";
        output.text = $"{conformity.NumberMJouleGreenLaser(j)} ìÄæ";
    }
}
