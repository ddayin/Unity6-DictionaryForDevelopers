using UnityEngine;
using UnityEngine.UI;

namespace Dictionary
{
    public class TitleController : MonoBehaviour
    {
        public Button buttonCategory;
        public Button buttonSearch;

        private void Awake()
        {
            buttonCategory.onClick.AddListener(OnClickCategory);
            buttonSearch.onClick.AddListener(OnClickSearch);
        }

        void OnClickCategory()
        {
            SceneController.instance.LoadScene(SceneName.Category);
        }

        void OnClickSearch()
        {

        }
    }
}