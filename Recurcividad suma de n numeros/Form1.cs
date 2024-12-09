using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Recurcividad_suma_de_n_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int number =Convert.ToInt32( TextNum.Text);
            ListViewDataRecurcive.Items.Add("Result: " + Convert.ToString(RecurciveSum(number))).BackColor = Color.LightGreen;
        }

        private int RecurciveSum(int x)
        {
            if (x == 0) return 0;
            int result = x + RecurciveSum(x - 1);
            ListViewDataRecurcive.Items.Add(Convert.ToString(x));
            return result ;
        }
    }
}
