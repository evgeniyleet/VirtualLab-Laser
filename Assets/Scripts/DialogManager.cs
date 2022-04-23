using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private RectTransform _transform;
    [SerializeField]
    private string[] str;
    public GameObject panel;
    public Text dialog;
    [SerializeField]
    private int j = 0;

    private int changer = 9;

    public Animation Anim;

    void Start()
    {
        StartCoroutine(RuningText(j));
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R) && dialog.text.Length == str[j].Length && str.Length - 1 > j)
        {
            StartCoroutine(RuningText(++j));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            
            Anim.Play("CameraAnim1");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            gameObject.active = false;
            
        }


        if (j == changer && changer == 9)
        {
            Anim.Play("CameraAnim");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 10;
        }

        if (j == changer && changer == 10)
        {
            Anim.Play("CameraAnim1");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 11;
        }

        if (j == changer && changer == 11)
        {
            Anim.Play("CameraAnim2");
            changer = 12;
        }

        if (j == changer && changer == 12)
        {
            Anim.Play("CameraAnim3");
            _transform.transform.position = new Vector3(200, _transform.position.y, _transform.position.z);
            changer = 13;
        }

        if (j == changer && changer == 13)
        {
            Anim.Play("CameraAnim4");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 14;
        }

        if (j == changer && changer == 14)
        {
            Anim.Play("CameraAnim5");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 16;
        }

        if (j == changer && changer == 16)
        {
            Anim.Play("CameraAnim6");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 17;
        }

        if (j == changer && changer == 17)
        {
            Anim.Play("CameraAnim7");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 18;
        }

        if (j == changer && changer == 18)
        {
            Anim.Play("CameraAnim8");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 19;
        }

        if (j == changer && changer == 19)
        {
            Anim.Play("CameraAnim9");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 21;
        }

        if (j == changer && changer == 21)
        {
            Anim.Play("CameraAnim10");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            changer = 30;
        }
       
       /* if (j == changer && changer == 22)
        {
            Anim.Play("CameraAnim1");
            _transform.transform.position = new Vector3(1000, _transform.position.y, _transform.position.z);
            //changer = 30;
            gameObject.active = false;
        }*/
    }
    public IEnumerator RuningText(int j)
    {
        dialog.text = "";
        for (var i = 0; i < str[j].Length; i++)
        {
            char s = str[j][i];
            dialog.text += s;
            yield return new WaitForSeconds(0.0005f);
        }
    }
}
