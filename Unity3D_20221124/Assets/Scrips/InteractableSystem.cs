using UnityEngine;

namespace Blythe
{

    /// <summary>
    /// ���ʨt�ΡA�������a�O�_�i�J�åB���椬�ʦ欰
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField,Header("��ܸ��")]
        private DialogueData dataDialogue;
        private string nameTarget = "PlayerCapsule";
        // 3D ����A��
        // ��ӸI�����󥲶��䤤�@�ӤĿ� Is Tigger
        //�I���}�l
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
        }

        //�I������
        private void OnTriggerExit(Collider other)
        {
            
        }

        //�I������
        private void OnTriggerStay(Collider other)
        {
            
        }

    }
}
