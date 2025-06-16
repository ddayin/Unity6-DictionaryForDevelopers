using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Dictionary
{
    public class ButtonSub : MonoBehaviour
    {
        private Button button;
        private TextMeshPro text;

        private void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnClickSub);
            text = GetComponentInChildren<TextMeshPro>();
        }

        void Init()
        {
            text.text = "Unity";
        }

        void OnClickSub()
        {
            SceneController.instance.LoadScene(SceneName.Description);
        }
    }
}