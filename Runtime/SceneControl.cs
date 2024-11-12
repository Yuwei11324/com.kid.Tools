using UnityEngine;
using UnityEngine.SceneManagement;
namespace KID.Tools
{
    /// <summary>
    /// 場景控制，提供載入場景與退出遊戲功能
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="scenecName">要載入的場景名稱</param>
        public void LoadScene(string scenecName)
        {
            //場景管理器 的 載入場景(場景名稱)
            SceneManager.LoadScene(scenecName);
        }

        private Rigidbody2D rig;
        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void QuitGame()
        {
            //應用程式 的 離開()
            Application.Quit();
        }
    }
}
