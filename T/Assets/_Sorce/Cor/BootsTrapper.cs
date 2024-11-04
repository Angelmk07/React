using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
namespace Assets._Sorce
{
    public class BootsTrapper : MonoBehaviour
    {
        [SerializeField]
        private ResourceMechanic[] resourceMechanic;
        [SerializeField] private Cor.Timer timer;
        [SerializeField] private GameObject End;
        private void Start()
        {
            StartGame();
        }
        private void StartGame()
        {
            timer.StartTimer();
            foreach (ResourceMechanic resource in resourceMechanic)
            {
                resource.decay.YouDead += EndGame;
            }
        }
        private void EndGame()
        {
            End.SetActive(true);
            timer.EndTimer();
            foreach (var resource in resourceMechanic)
            {
                resource.decay.YouDead -= EndGame;
            }
        }
    }

}