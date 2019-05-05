using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private FBClient client = new FBClient();

        private ObservableCollection<string> messages = new ObservableCollection<string>();

        public string MessageContent {
            get { return messageContent; }
            set { messageContent = value; PropertyChanged(this, new PropertyChangedEventArgs("MessageContent")); }
        }

        public ObservableCollection<string> Messages
        {
            get
            {
                return messages;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void InitFB()
        {
            var logged_in = await client.DoLogin("xxx", "xxx");

            if (logged_in)
            {
                var users = await client.fetchAllUsers();
                foreach (var user in users)
                {
                    Console.WriteLine("{0} {1}", user.name, user.uid);
                }
            }
            else
            {
                Console.WriteLine("Error logging in");
            }
        }

        ~ConversationModel()
        {
            client.DoLogout();
        }

        public ConversationModel()
        {
            InitFB();
        }



        internal async void SendMessage()
        {
            System.Console.WriteLine(MessageContent);
            await client.SendMessage(MessageContent, thread_id: "100000672971086");
            
            Messages.Add(MessageContent);
            MessageContent = "";
        }
    }
}
