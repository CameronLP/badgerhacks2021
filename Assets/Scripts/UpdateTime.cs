using System;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTime : MonoBehaviour
{
    public Text time;
    private DateTime startTime;

    public void Start()
    {
        startTime = DateTime.Now;
    }

    void Update()
    {
        TimeSpan ts = DateTime.Now.Subtract(startTime);

        float minutes = ts.Minutes;
        float seconds = ts.Seconds;
        float milliseconds = ts.Milliseconds;

        // Calculates minutes
        string min = Math.Round((minutes / 100), 2).ToString();
        if (min.Length == 3)
            min += "0";

        if (min == "0" || min == "1")
            min = "0.00";

        min = min.Substring(1, 3);
        min = min.Replace(".", "");
        min = min.Replace(":", "");

        // Calculates seconds
        string s = Math.Round((seconds / 100), 2).ToString();
        if (s.Length == 3)
            s += "0";

        if (s == "0" || s == "1")
            s = "0.00";

        s = s.Substring(1, 3);
        s = s.Replace(".", "");

        // Calulates milliseconds
        string m = Math.Round((milliseconds / 1000), 2).ToString();
        if (m.Length == 3)
            m += "0";

        if (m == "0" || m == "1")
            m = "0.00";

        m = m.Substring(1, 3);
        m = m.Replace(".", "");

        time.text = min + ":" + s + ":" + m;
    }
}
