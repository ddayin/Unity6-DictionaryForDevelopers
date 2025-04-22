using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net.Http.Headers;

namespace AssembleWords
{
    public enum CategoryButtonState
    {
        Idle = 0,
        Locked,
        Unlocked
    }

    public class ButtonCategory : MonoBehaviour
    {
        public Category category = Category.Language;
        public CategoryButtonState state = CategoryButtonState.Idle;

        private Button button;
        private TextMeshPro text;

        public Sprite spriteLocked;
        public Sprite spriteUnlocked;
        private Image imageSprite;
        private Image imageIcon;

        private void Awake()
        {
            button = GetComponent<Button>();
            text = GetComponentInChildren<TextMeshPro>();
            imageSprite = GetComponent<Image>();
            imageIcon = GetComponentInChildren<Image>();

            button.onClick.AddListener(OnClickCategory);
        }

        void Init()
        {
            
        }

        void OnClickCategory()
        {

        }

        public void SetState(CategoryButtonState _state)
        {
            state = _state;
            switch (state)
            {
                case CategoryButtonState.Idle:
                    imageIcon.sprite = null;
                    break;
                case CategoryButtonState.Locked:
                    imageIcon.sprite = spriteLocked;
                    break;
                case CategoryButtonState.Unlocked:
                    imageIcon.sprite = spriteUnlocked;
                    break;
                default:
                    imageIcon.sprite = null;
                    break;
            }
        }
    }
}