namespace Windows_Calculator
{
    public partial class Calculator : Form

    {
        double number1;
        string operation;
        bool clearScreen = false;
        bool virgulkullanildi = false;
        int i = 25;
        bool minuskullanildi= false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (clearScreen)
            {
                screenLabel.Text = "";
                clearScreen = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            {
                screenLabel.Text += button.Text;
                minuskullanildi = false;
            }
            if (screenLabel.Text.Length > 12)
            {
                screenLabel.Font = new Font(screenLabel.Font.FontFamily, i--, screenLabel.Font.Style);
            }
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            screenLabel.Font = new Font(screenLabel.Font.FontFamily, 25, screenLabel.Font.Style);

            clearScreen = true;

            virgulkullanildi = false;

            var button = (Button)sender;

            number1 = Convert.ToDouble(screenLabel.Text);

            operation = button.Text;

            info.Text = button.Text;

            minuskullanildi = false;

        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            var number2 = Convert.ToDouble(screenLabel.Text);

            info.Text += " " + number2;

            switch (operation)
            {
                case "+":
                    screenLabel.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    screenLabel.Text = (number1 - number2).ToString();
                    break;
                case "x":
                    screenLabel.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    screenLabel.Text = (number1 / number2).ToString();
                    break;
            }

            clearScreen = true;
            minuskullanildi=false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            info.Text = "";
            screenLabel.Text = "0";
            virgulkullanildi = false;
            screenLabel.Font = new Font(screenLabel.Font.FontFamily, 25, screenLabel.Font.Style);
            minuskullanildi = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            if (!virgulkullanildi && !clearScreen && minuskullanildi == false)
            {
                screenLabel.Text += ",";
                virgulkullanildi = true;

            }
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (!clearScreen)
            {
                if (screenLabel.Text.Length - 1 == screenLabel.Text.IndexOf(',')) virgulkullanildi = false;

                if (screenLabel.Text.Length - 1 == screenLabel.Text.IndexOf('-')) minuskullanildi = false;

                if (screenLabel.Text.Length > 1) screenLabel.Text = screenLabel.Text.Substring(0, screenLabel.Text.Length - 1);


                else screenLabel.Text = "0";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (clearScreen || screenLabel.Text == "0" && minuskullanildi == false)
            {
                screenLabel.Text = "-";
                clearScreen = false;
                minuskullanildi = true;
            }
        }
    }
}



