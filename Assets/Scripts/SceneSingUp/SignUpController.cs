using UnityEngine;
using UnityEngine.UI;

namespace AssembleWords
{
    public class SignUpController : MonoBehaviour
    {
        public Button buttonCreate;

        private void Awake()
        {
            buttonCreate.onClick.AddListener(OnClickCreate);
        }

        void OnClickCreate()
        {
            SceneController.instance.LoadScene(SceneName.Title);
        }
    }
}