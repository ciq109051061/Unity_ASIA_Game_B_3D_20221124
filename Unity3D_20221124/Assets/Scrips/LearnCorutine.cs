using UnityEngine;
using System.Collections;

namespace Blythe
{

    /// <summary>
    /// �ǲߨ�P�{�ǡA²�٨�{ Corutine
    /// �ت�:���������d�F�쵥�ݪ��ĪG
    /// </summary>
    public class LearnCorutine : MonoBehaviour
    {
        //�ϥΨ�P���|�ӱ���
        // 1. �ޥΩR�W�Ŷ� System.Collections
        // 2. �w�q�@�ӶǦ^ IEnumerator ����k
        // 3. ��k�������ϥ� yield return (����)
        // 4. �ϥ�startCorutine �Ұ�

        // �r�� string �� char �}�C
        private string testDialogue = "�ڬO��?�ڦb��?";

        private void Awake()
        {
            StartCoroutine(Test());

            print("���o���չ�ܪ��Ĥ@�Ӧr:" + testDialogue[0]);

            StartCoroutine(ShowDialogue());

            StartCoroutine(ShowDialogueUseFor());
        }
        private IEnumerator Test()
        {
            print("<color=#33ff33>�Ĥ@��{��</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>�ĤG��{��</color>");
            yield return new WaitForSeconds(4);
            print("<color=blue>�ڪ��{�� </color>");

        }

        private IEnumerator ShowDialogue()
        {
            print(testDialogue[0]);
            yield return new WaitForSeconds(0.2f);
            print(testDialogue[1]);
            yield return new WaitForSeconds(0.2f);
            print(testDialogue[2]);
            yield return new WaitForSeconds(0.2f);
        }

        private IEnumerator ShowDialogueUseFor()
        {
            for (int i = 0; i < testDialogue.Length; i++)
            {
                print(testDialogue[i]);
                yield return new WaitForSeconds(0.2f);

            }
        }    
        
    }
}
