using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    public static int goalnum = 0;
    Text goals;
    // Start is called before the first frame update
    void Start()
    {
        goals = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        goals.text = "Goals: " + goalnum;
    }
}
