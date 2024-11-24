using System.Collections;
using UnityEngine;

namespace Assets.Scripts.User_Interface
{
    public class CreditsMenu : MonoBehaviour
    {
        public void OnClick_Back()
        {
            MenuManager.ChangeMenuState(Menu.MAIN_MENU, MenuState.OPEN, gameObject);
        }
    }
}