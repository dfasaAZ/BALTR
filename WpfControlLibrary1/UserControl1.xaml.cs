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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public delegate void TextChangedEventHandler(object sender, string newValue);
    public delegate void ClickEventHandler();

    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public event TextChangedEventHandler TextChanged;
        public event ClickEventHandler Click;

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(UserControl1), new FrameworkPropertyMetadata("¬вод", new PropertyChangedCallback(OnTextChanged)));

        private static void OnTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            (obj as UserControl1).UpdateText(args.NewValue.ToString());
        }

        private void UpdateText(string NewText)
        {
            textBox1.Text = NewText;
            TextChanged(this, NewText);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetValue(TextProperty, textBox1.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Click();
        }
    }

}