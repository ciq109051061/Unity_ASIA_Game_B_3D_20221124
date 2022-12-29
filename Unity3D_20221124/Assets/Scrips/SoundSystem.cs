using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 音效系統
    /// </summary>
    /// 要求元件: 在第一次套用此腳本時會添加裡面指定的元件
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound">要撥放的音效</param>
        public void PlaySound(AudioClip sound)
        {
            aud.PlayOneShot(sound);
        }

    }
}
