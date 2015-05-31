using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_l1
{
    interface IMessageService 
    {
        void ShowMessage(string message);
        void ShowCaution(string caution);
        void ShowError(string error);

    }

    class MessageService:IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message,"Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowCaution(string caution)
        {
            MessageBox.Show(caution, "Предупреждение!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
