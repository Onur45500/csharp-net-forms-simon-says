namespace csharp_net_forms_simon_says
{
    public partial class Form1 : Form
    {
        int blocksX = 160;
        int blocksY = 80;
        int score = 0;
        int level = 3;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<PictureBox> choseBoxes = new List<PictureBox>();
        Random rand = new Random();

        Color temp;

        int index = 0;
        int tries = 0;

        int timeLimit = 0;
        bool selectingColours = false;

        string correctOrder = string.Empty;
        string playerOrder = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void SetUpBlock()
        {

        }
    }

}
