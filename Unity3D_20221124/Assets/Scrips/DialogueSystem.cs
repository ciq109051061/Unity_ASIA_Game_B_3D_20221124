using UnityEngine;
using TMPro;
using System.Collections;

namespace Blythe
{
    /// <summary>
    /// ��ܨt��
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {

        #region ��ưϰ�
        [SerializeField,Header("��ܶ��j"),Range(0,0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField,Header("�}�Y���")]
        private DialogueData dialogueOpening;
        [SerializeField, Header("��ܫ���")]
        private KeyCode dialogueKey = KeyCode.Space;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);
        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;

        #endregion

        #region �ƥ�
        private void Awake()
        {
            groupDialogue = GameObject.Find("�e����ܨt��").GetComponent<CanvasGroup>();
            textName = GameObject.Find("��ܪ̦W��").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("��ܤ��e").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("��ܧ����ϥ�");
            goTriangle.SetActive(false);

            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect());
        }

        #endregion

        /// <summary>
        /// �H�J�H�X�s�ժ���
        /// </summary>
        /// <returns></returns>
        private IEnumerator FadeGroup(bool fadeIn = true)
        {
            //�T���B��l?:
            //�y�k:
            //���L�� ? ���L�Ȭ�true : ���L�Ȭ�false;
            //true ? 1 : 10; ���G��1
            //false ? 1 : 10; ���G��10
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

                print("���a���U����");

            }

            StartCoroutine(FadeGroup(false));
        }
    }


}
