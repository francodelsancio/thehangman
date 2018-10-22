using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3E00
{
    public static class Message
    {
        public static void Success(string message)
        {
            MessageBox.Show(message,"Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Error(string message)
        {
            if (message == string.Empty) return;
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GameOver(string message)
        {
            MessageBox.Show(message, "Lo siento", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
