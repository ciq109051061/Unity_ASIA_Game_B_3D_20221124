using UnityEngine;
using TMPro;

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
        }

        #endregion
    }


}
