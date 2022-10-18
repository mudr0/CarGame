using Profile;
using UnityEngine;
using Tool;
using Object = UnityEngine.Object;

namespace Ui
{
    internal class OptionsMenuController : BaseController
    {
        private readonly ResourcePath _resourcePath = new ResourcePath("Prefabs/OptionsMenu");
        private readonly ProfilePlayer _profilePlayer;
        private readonly OptionsMenuView _view;


        public OptionsMenuController(Transform placeForUI, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUI);
            _view.Init(OpenMenu);
        }

        private OptionsMenuView LoadView(Transform placeForUI)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
            GameObject objectView = GameObject.Instantiate(prefab, placeForUI, false);
            AddGameObject(objectView);

            return objectView.GetComponent<OptionsMenuView>();
        }

        private void OpenMenu() => 
            _profilePlayer.CurrentState.Value = GameState.Start;
    }
}
