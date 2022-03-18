using System.Windows;

namespace CalcSum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //we need to have an instance of this object live as long as the MainWindow lives
        Calc calc;

        public MainWindow()
        {
            InitializeComponent();

            //create an instance of the ViewModel object
            calc = new Calc();
            //assign the ViewModel object to the View
            DataContext = calc;
        }

        //handles the click of the Calculate button
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            //the MVVM way
            calc.Add();

            //MessageBox.Show("hello");

            /* the non-mvvm way
            string operand1 = tbxOperand1.Text;
            string operand2 = tbxOperand2.Text;

            int operand1int;
            if (!int.TryParse(operand1, out operand1int))
                operand1int = 0;

            int operand2int;
            try{
                operand2int = int.Parse(operand2);
            } catch {
                operand2int = 0;
            }

            int sum = operand1int + operand2int;

            //tbResult.Text = operand1 + operand2;
            tbResult.Text = sum.ToString();
            */
        }
    }
}
