using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.User_Interface
{
    public class MainMenu : MonoBehaviour
    {
        public void OnClick_Play()
        {
            MenuManager.ChangeMenuState(Menu.MAIN_MENU, MenuState.CLOSE);

            GameplayStateManager.Instance.SetState(GameplayState.Gameplay);
        }

        public void OnClick_Credits()
        {
            MenuManager.ChangeMenuState(Menu.CREDITS_MENU, MenuState.OPEN, gameObject);
        }

        public void OnClick_Quit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}