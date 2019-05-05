using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace hermes
{
    class ConversationModel : INotifyPropertyChanged
    {
        private string messageContent;

        public string MessageContent {
            get { return messageContent; }
            set { messageContent = value; PropertyChanged(this, new PropertyChangedEventArgs("MessageContent")); }
        }
        public List<string> Messages { get; set; } = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        internal void SendMessage()
        {
            System.Console.WriteLine(MessageContent);
            Messages.Add(MessageContent);
            MessageContent = "";
        }
    }
}
