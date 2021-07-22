using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txt;
    public float timeFlow;
    System.Text.StringBuilder append;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = "Timer : ";
        timeFlow = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeFlow = Time.deltaTime;

        append = new StringBuilder();
        append.Append(txt.text);
        append.Append(timeFlow);
        txt.text = append.ToString();
    }
}
