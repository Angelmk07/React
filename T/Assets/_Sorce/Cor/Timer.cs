using TMPro;
using UnityEngine;

namespace Assets._Sorce.Cor
{
    internal class Timer : MonoBehaviour
    {
        private float _time = 0f;
        private float _bestTime;
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private TextMeshProUGUI best;

        public void StartTimer()
        {
            _bestTime = PlayerPrefs.GetFloat("BestTime", 0f); 
            UpdateBestTimeText();
            InvokeRepeating(nameof(UpdateTimer), 0, 0.1f); 
        }

        private void UpdateTimer()
        {
            _time += 0.1f; 
            text.text = FormatTime(_time);
        }

        public void EndTimer()
        {
            CancelInvoke(nameof(UpdateTimer)); 
            if (_time > _bestTime)
            {
                _bestTime = _time;
                PlayerPrefs.SetFloat("BestTime", _bestTime); 
                UpdateBestTimeText();
            }
        }

        private void UpdateBestTimeText()
        {
            best.text = FormatTime(_bestTime);
        }

        private string FormatTime(float time)
        {
            int minutes = Mathf.FloorToInt(time / 60f);
            int seconds = Mathf.FloorToInt(time % 60f);
            int milliseconds = Mathf.FloorToInt((time * 100) % 100);
            return $"{minutes:D2}:{seconds:D2}:{milliseconds:D2}";
        }
    }
}
