using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Dictionary
{
    public class SubController : MonoBehaviour
    {
        public CategoryController categoryController;

        public GameObject goCanvasMain;
        public GameObject goCanvasSub;

        public List<Button> buttonsLanguages;
        public List<Button> buttonsEnglish;
        public List<Button> buttonsEngines;
        public List<Button> buttonsFrontend;
        public List<Button> buttonsBackend;

        public Button buttonCrossword;
        public Button buttonMindMap;

        private void Awake()
        {
            categoryController = GetComponent<CategoryController>();

            for (int i = 0; i < buttonsLanguages.Count; i++)
            {
                int index = i;
                buttonsLanguages[i].onClick.RemoveAllListeners();
                buttonsLanguages[i].onClick.AddListener(() => OnClickLanguage(index));
            }
            for (int i = 0; i < buttonsEnglish.Count; i++)
            {
                int index = i;
                buttonsEnglish[i].onClick.RemoveAllListeners();
                buttonsEnglish[i].onClick.AddListener(() => OnClickEnglish(index));
            }
            for (int i = 0; i < buttonsEngines.Count; i++)
            {
                int index = i;
                buttonsEngines[i].onClick.RemoveAllListeners();
                buttonsEngines[i].onClick.AddListener(() => OnClickEngine(index));
            }
            for (int i = 0; i < buttonsFrontend.Count; i++)
            {
                int index = i;
                buttonsFrontend[i].onClick.RemoveAllListeners();
                buttonsFrontend[i].onClick.AddListener(() => OnClickFrontend(index));
            }
            for (int i = 0;i < buttonsBackend.Count; i++)
            {
                int index = i;
                buttonsBackend[i].onClick.RemoveAllListeners();
                buttonsBackend[i].onClick.AddListener(() => OnClickBackend(index));
            }

            buttonCrossword.onClick.AddListener(OnClickCrossword);
            buttonMindMap.onClick.AddListener(OnClickMindMap);
        }

        private void Start()
        {
            
        }

        void Init(Category _category)
        {
            

        }

        void OnClickLanguage(int index)
        {
            Languages language = (Languages)index;            
            categoryController.Activate(Category.Language);
        }

        void OnClickEnglish(int index)
        {
            English english = (English)index;
            categoryController.Activate(Category.English);
        }

        void OnClickEngine(int index)
        {
            GameEngines engine = (GameEngines)index;
            categoryController.Activate(Category.GameEngines);
        }

        void OnClickFrontend(int index)
        {
            Frontend frontend = (Frontend)index;
            categoryController.Activate(Category.Frontend);
        }

        void OnClickBackend(int index)
        {
            Backend backend = (Backend)index;
            categoryController.Activate(Category.Backend);
        }

        void OnClickCrossword()
        {
            SceneController.instance.LoadScene(SceneName.PuzzleGame);
        }

        void OnClickMindMap()
        {
            SceneController.instance.LoadScene(SceneName.MindMap);
        }
    }
}