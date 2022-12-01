using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// ��ܸ��
    /// </summary>
    [CreateAssetMenu(menuName = "Blythe/Dialogue Data", fileName = "New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("��ܪ̦W��")]
        public string dialogueName;

        [Header("��ܪ̤��e"),TextArea(2,10)]
        public string[] dialogueContents;
    }
}
