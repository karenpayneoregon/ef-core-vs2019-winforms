using System.Windows.Forms;

namespace WpfDialogs
{
    public static class CommonDialogs
    {
        /// <summary>
        /// For asking confirmation with option title
        /// </summary>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool Question(string text, string title = "Question") =>
            (MessageBox.Show(
                text, 
                title, 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes);
    }
}
