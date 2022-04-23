using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conformity : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem raySystem;
    [SerializeField]
    private int[] jouleArrayLaserRed = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    [SerializeField]
    private int[] mJouleArrayLaserRed = new[] { 0, 0, 0, 0, 0, 0, 0, 11, 25, 38, 62, 75, 90, 112, 125, 145, 162, 175, 185, 200, 220 };
    [SerializeField]
    private float[] jouleArrayLaserGreen = new[] { 0, 0.05f, 0.1f, 0.15f, 0.2f, 0.25f, 0.3f, 0.35f, 0.4f, 0.45f, 0.5f, 0.55f, 0.6f, 0.65f, 0.7f, 0.75f, 0.8f, 0.85f, 0.95f };
    [SerializeField]
    private float[] mJouleArrayLaserGreen = new[] { 0, 0, 0, 0, 0, 3.4f, 5f, 6.4f, 8.2f, 9.8f, 11.6f, 13f, 14f, 15.6f, 16.8f, 19.2f, 20.4f, 22, 23.4f};



    public string NumberJouleRedLaser(int i) => jouleArrayLaserRed[i].ToString();

    public string NumberMJouleRedLaser(int i) => mJouleArrayLaserRed[i].ToString();

    public string NumberJouleGreenLaser(int j) => jouleArrayLaserGreen[j].ToString();

    public string NumberMJouleGreenLaser(int j) => mJouleArrayLaserGreen[j].ToString();

}
