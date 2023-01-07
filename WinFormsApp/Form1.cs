namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        List<string> todo = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string currenttask = tToDoAdd.Text;
            todo.Add(currenttask);
            tToDoAdd.Clear();
        }

        private void tToDoAdd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}