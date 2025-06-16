using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

namespace Dictionary
{
    public class CategoryController : MonoBehaviour
    {
        public TMP_Text textCategoryTitle;

        public GameObject goMain;
        public GameObject goSub;

        public GameObject goLanguage;
        public GameObject goEnglish;
        public GameObject goGameEngines;
        public GameObject goFrontend;
        public GameObject goBackend;

        public List<Button> buttonsList;


        private void Awake()
        {
            for (int i = 0; i < buttonsList.Count; i++)
            {
                int index = i;
                buttonsList[i].onClick.RemoveAllListeners();
                buttonsList[i].onClick.AddListener(() => OnClickCategory(index));
            }
        }

        public void Activate(Category _category)
        {
            goMain.SetActive(false);
            goSub.SetActive(true);

            goLanguage.SetActive(false);
            goEnglish.SetActive(false);
            goGameEngines.SetActive(false);
            goFrontend.SetActive(false);
            goBackend.SetActive(false);

            switch (_category)
            {
                case Category.Language:
                    goLanguage.SetActive(true);
                    textCategoryTitle.text = "Programming Language";
                    break;
                case Category.English:
                    goEnglish.SetActive(true);
                    textCategoryTitle.text = "English";
                    break;
                case Category.GameEngines:
                    goGameEngines.SetActive(true);
                    textCategoryTitle.text = "Game Engines";
                    break;
                case Category.Frontend:
                    goFrontend.SetActive(true);
                    textCategoryTitle.text = "Frontend";
                    break;
                case Category.Backend:
                    goBackend.SetActive(true);
                    textCategoryTitle.text = "Backend";
                    break;
                default:
                    break;
            }
        }

        void OnClickCategory(int _index)
        {
            Category category = (Category)_index;
            Debug.Log("Category : " + category);
            
            Activate(category);
        }
    }
}