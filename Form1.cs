namespace ApeirophobiaCodeCracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string? result;

        #region MY_FUNCTIONS
        private void CheckForInvalidInput(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                wrongInputErrorProvider.SetError(errorLabel, "Invalid input received.");
                errorLabel.Text = "Only input numeric values!";
            }
            else
            {
                wrongInputErrorProvider.SetError(errorLabel, "");
                errorLabel.Text = "";
            }
        }

        private void CalculateResult()
        {
            //store textbox inputs as strings (duh)
            string red = redTextBox.Text;
            string green = greenTextBox.Text;
            string blue = blueTextBox.Text;
            string grey = greyTextBox.Text;
            string yellow = yellowTextBox.Text;
            string purple = purpleTextBox.Text;
            string orange = orangeTextBox.Text;

            #region COLOR_PRIORITIES
            /* COLOR TYPE PRIORITIES
             * 
             * RED    - 1
             * GREEN  - 2
             * BLUE   - 3
             * GREY   - 4
             * YELLOW - 5
             * PURPLE - 6
             * ORANGE - 7
            */
            #endregion

            //actual logic (calculate result)
            CalculationLogic.RedPhase(red);
            CalculationLogic.GreenPhase(green);
            CalculationLogic.BluePhase(blue);
            CalculationLogic.GreyPhase(grey);
            CalculationLogic.YellowPhase(yellow);
            CalculationLogic.PurplePhase(purple);
            CalculationLogic.OrangePhase(orange);
            CalculationLogic.FinishResultCalculation();
            if(result != "")
            {
                codeIntroLabel.Text = "Code:";
                resultCodeLabel.Text = result;
                copyButton.Visible = true;
            }
            else
            {
                errorLabel.Text = "At least one text box must contain a number that isn't 0.";
            }
        }
        #endregion

        #region VISUAL_STUDIO_FUNCTIONS

        #region CHECK_FOR_NON_NUMERIC_INPUTS
        private void redTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForInvalidInput(e);
        }

        private void greenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForInvalidInput(e);
        }

        private void blueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForInvalidInput(e);
        }

        private void greyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForInvalidInput(e);
        }

        private void yellowTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForInvalidInput(e);
        }

        private void purpleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForInvalidInput(e);
        }

        private void orangeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForInvalidInput(e);
        }
        #endregion

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateResult();
            //errorLabel.Text = "button clicked!";              //debug test
            //resultCodeLabel.Text = "(Code will appear here)"; //also a debug test
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result);
        }
        #endregion
    }
}