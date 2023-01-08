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
            try
            {
                int numberdel = Int32.Parse(tToDoAdd.Text);
                todo.RemoveAt(numberdel-1);
                MessageBox.Show($"Task number {numberdel} was succesfully deleted!");
                tToDoAdd.Clear();
            }
            catch (System.FormatException) 
            { 
                MessageBox.Show("Please, enter task number");
                tToDoAdd.Clear();
            }
            catch(System.ArgumentOutOfRangeException) 
            {
                MessageBox.Show("There is no task under this number! \nAdd one or try another number");
                tToDoAdd.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the number of task you would like to delete and then press this button");
        }

        private void bShow_Click(object sender, EventArgs e)
        {
         string allTasks = string.Join("\n", todo);
         MessageBox.Show(allTasks);
        }
    }
}