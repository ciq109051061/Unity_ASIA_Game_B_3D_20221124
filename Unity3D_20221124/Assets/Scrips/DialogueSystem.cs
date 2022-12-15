using UnityEngine;
using TMPro;
using System.Collections;

namespace Blythe
{
    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {

        #region 資料區域
        [SerializeField,Header("對話間隔"),Range(0,0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField,Header("開頭對話")]
        private DialogueData dialogueOpening;
        [SerializeField, Header("對話按鍵")]
        private KeyCode dialogueKey = KeyCode.Space;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);
        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;

        #endregion

        #region 事件
        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("對話完成圖示");
            goTriangle.SetActive(false);

            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect());
        }

        #endregion

        /// <summary>
        /// 淡入淡出群組物件
        /// </summary>
        /// <returns></returns>
        private IEnumerator FadeGroup(bool fadeIn = true)
        {
            //三源運算子?:
            //語法:
            //布林值 ? 布林值為true : 布林值為false;
            //true ? 1 : 10; 結果為1
            //false ? 1 : 10; 結果為10
            float increase = fadeIn ? +0.1f : -0.1F;

            for (int i = 0; i < 10; i++)
            {
                groupDialogue.alpha += increase;
                yield return new WaitForSeconds(0.04f);

            }
        }

        private IEnumerator TypeEffect()
        {
            textName.text = dialogueOpening.dialogueName;
          
            
            for (int j = 0; j < dialogueOpening.dialogueContents.Length; j++)
            {
                textContent.text = "";

                string dialogue = dialogueOpening.dialogueContents[j];

                for (int i = 0; i < dialogue.Length; i++)
                {
                    textContent.text += dialogue[i];
                    yield return dialogueInterval;
                }

                goTriangle.SetActive(true);
                
                while (!Input.GetKeyDown(dialogueKey))
                {
                    yield return null;
                }

                print("玩家按下按鍵");

            }

            StartCoroutine(FadeGroup(false));
        }
    }


}
