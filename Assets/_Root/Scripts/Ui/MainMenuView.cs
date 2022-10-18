using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonOptions;

        public void Init(UnityAction startGame, UnityAction openOptions)
        {
            _buttonStart.onClick.AddListener(startGame);
            _buttonOptions.onClick.AddListener(openOptions);
        }

        public void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonOptions.onClick.RemoveAllListeners();
        }
    }
}
