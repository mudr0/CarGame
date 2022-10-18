using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

public class OptionsMenuView : MonoBehaviour
{
    [SerializeField] private Button _buttonBack;

    public void Init(UnityAction goMenu) => 
        _buttonBack.onClick.AddListener(goMenu); 


    public void OnDestroy() => 
        _buttonBack.onClick.RemoveAllListeners();
        

}
