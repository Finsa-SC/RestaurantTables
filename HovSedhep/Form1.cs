using HovSedhep.Helper;

namespace HovSedhep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadActivity(UserControl uc)
        {
            pnlActivity.Controls.Clear();
            pnlActivity.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private Button currentBtn = null;
        Color active = Color.DodgerBlue;
        Color defaultb = Color.DarkGray;
        private void ButtonHover(Button btn)
        {
            if(currentBtn != null) 
            { 
                currentBtn.BackColor = defaultb;
            }

            currentBtn = btn;
            currentBtn.BackColor = active;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            LoadActivity(new TableUC());
            ButtonHover((Button)sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadActivity(new MenuUC());
            ButtonHover((Button)sender);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadActivity(new HistoryUC());
            ButtonHover((Button)sender);
        }
    }
}
