
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets._Sorce.End
{
    internal class EndRestart : MonoBehaviour
    {
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.R)) 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
