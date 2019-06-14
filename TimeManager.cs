using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace BamBamGames {
    /// <summary>
    /// This script allows you to manage time in your games.
    /// </summary>
    public class TimeManager : MonoBehaviour {        
        [Header("Time Manager")]
        public float totalTime = 60f; //total game time
        public Text TimeText; //Text UI for time

        void Update() {
            totalTime -= Time.deltaTime;
            if (totalTime <= 0) {
                //Debug.Log("total time end we can destroy player!");
            }
        }

        public void UpdateLevelTimer(float totalSeconds)
        {
            int minutes = Mathf.FloorToInt(totalSeconds / 60f);
            int seconds = Mathf.RoundToInt(totalSeconds % 60f);
            string formatedSeconds = seconds.ToString();
            if (seconds == 60)
            {
                seconds = 0;
                minutes += 1;
            }
            TimeText.text = minutes.ToString("00") + ":" + seconds.ToString("00");    
        }
    }
}