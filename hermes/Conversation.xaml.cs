using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hermes
{
    /// <summary>
    /// Interaction logic for Conversation.xaml
    /// </summary>
    public partial class Conversation : UserControl
    {
        readonly ConversationModel model = new ConversationModel();

        public Conversation()
        {
            InitializeComponent();
            model.Messages.Add("Hi");
            model.Messages.Add("Hi");
            model.Messages.Add("What's up?");
            model.Messages.Add("Nothing");

            this.DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.SendMessage();
        }
    }
}
