using UnityEngine;
using UnityEngine.UI;

namespace Dictionary
{
    public class LoginController : MonoBehaviour
    {
        public Button buttonLogin;
        public Button buttonSignUp;
        public Button buttonGuestLogin;
        

        private void Awake()
        {
            buttonLogin.onClick.AddListener(OnClickLogin);            
            buttonSignUp.onClick.AddListener(OnClickSignUp);
            buttonGuestLogin.onClick.AddListener(OnClickGuest);
        }

        void OnClickLogin()
        {
            SceneController.instance.LoadScene(SceneName.Title);
        }

        void OnClickSignUp()
        {
            SceneController.instance.LoadScene(SceneName.SignUp);
        }

        void OnClickGuest()
        {
            SceneController.instance.LoadScene(SceneName.Title);
        }
    }
}