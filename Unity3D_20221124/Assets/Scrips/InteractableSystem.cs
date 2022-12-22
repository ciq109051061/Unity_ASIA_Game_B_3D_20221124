using UnityEngine;
using UnityEngine.Events;

namespace Blythe
{

    /// <summary>
    /// ���ʨt�ΡA�������a�O�_�i�J�åB���椬�ʦ欰
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField,Header("��ܸ��")]
        private DialogueData dataDialogue;
        [SerializeField,Header("��ܵ����᪺�ƥ�")]
        private UnityEvent onDialogueFinish;

        [SerializeField,Header("�ҰʹD��")]
        private GameObject propActive;

        [SerializeField,Header("�Ұʫ᪺��ܸ��")]
        private DialogueData dataDialogueAvtive;
        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;
        // 3D ����A��
        // ��ӸI�����󥲶��䤤�@�ӤĿ� Is Tigger
        //�I���}�l

        private void Awake()
        {
            dialogueSystem=GameObject.Find("�e����ܨt��").GetComponent<DialogueSystem>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                print(other.name);

                //�p�G ���ݭn�ҰʹD�� �Ϊ� �ҰʹD��O��ܪ��N����Ĥ@�q���
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueAvtive);
                }
                
            }
           
        }

        //�I������
        private void OnTriggerExit(Collider other)
        {
            
        }

        //�I������
        private void OnTriggerStay(Collider other)
        {
            
        }

        /// <summary>
        /// ���ê���
        /// </summary>
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }

    }

    
}
