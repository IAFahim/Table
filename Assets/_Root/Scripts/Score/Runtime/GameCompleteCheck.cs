using _Root.Scripts.Elements.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Root.Scripts.Score.Runtime
{
    public class GameCompleteCheck : MonoBehaviour
    {
        [SerializeField] private SelectedElementsScriptableObject selectedElementsScriptableObject;

        [SerializeField] private CounterScriptableObject protonCounterScriptableObject;
        [SerializeField] private CounterScriptableObject neutronCounterScriptableObject;
        [SerializeField] private CounterScriptableObject electronCounterScriptableObject;

        [SerializeField]private ElementScriptableObject currentScriptableObject;
        [SerializeField] private string sceneName;

        private void OnEnable()
        {
            ResetCounter();
            currentScriptableObject = selectedElementsScriptableObject.GetCurrentElement();
            
        }


        private void ResetCounter()
        {
            protonCounterScriptableObject.count = 0;
            neutronCounterScriptableObject.count = 0;
            electronCounterScriptableObject.count = 0;
        }

        private void Update()
        {
            OverFlowCheck();
            ExactCheck();
        }

        private void ExactCheck()
        {
            if (currentScriptableObject.protons == protonCounterScriptableObject.count &&
                currentScriptableObject.neutrons == neutronCounterScriptableObject.count &&
                currentScriptableObject.electrons == electronCounterScriptableObject.count)
            {
                
                NextLevel();
            }
        }

        private void OverFlowCheck()
        {
            if (currentScriptableObject.protons < protonCounterScriptableObject.count) NextLevel();
            if (currentScriptableObject.neutrons < neutronCounterScriptableObject.count) NextLevel();
            if (currentScriptableObject.electrons < electronCounterScriptableObject.count) NextLevel();
        }

        public void NextLevel()
        {
            selectedElementsScriptableObject.NextLevel();
            SceneManager.LoadScene(sceneName);
        }
    }
}