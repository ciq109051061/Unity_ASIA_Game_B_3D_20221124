using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// �{�Ѱj��:���ư���{��
    /// for�Bwhile�Bdo�Bwhile�Bforeach
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            //for �j��y�k
            //for (��l�ȡF���L�� ���� �F �j�鵲������ϰ�) { �{���϶� }

            for (int i = 0; i<10; i++)
            {
                print("for �j�餺�e" + i);
            }
            for (int number = 0; number < 10; number++)
            {
                print("for �j�餺�e" + number);
            }
            if(true)
            {
                print("�P�_��");
            }

            int count = 0;

            while (count<5)
            {
                print("()�������L�Ȭ�true�N�|�������");
                print("while �j��Ʀr :"+count);
                count++;
            }
        }
    }
}
