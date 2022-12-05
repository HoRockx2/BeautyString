using BeautyString.Model;

namespace BeautyString
{
    public partial class Form1 : Form
    {
        private List<BeautyRuleModel> rules = new List<BeautyRuleModel>();

        public Form1()
        {
            InitializeComponent();
            InitRule();

            listBox1.DataSource = rules;
            listBox1.DisplayMember = "RuleName";
        }

        private void InitRule()
        {
            var rule = new BeautyRuleModel
            {
                RuleName = "GameHomeData",
                Rules = {
                    new KeyValuePair<string, string> ("\\n", ""),
                    new KeyValuePair<string, string> (" ", ""),
                    new KeyValuePair<string, string> ("\\\"", "\"")
                }
            };

            var rule2 = new BeautyRuleModel
            {
                RuleName = "SearchData",
                Rules = {
                    new KeyValuePair<string, string> ("\\n", ""),
                    new KeyValuePair<string, string> (" ", ""),
                    new KeyValuePair<string, string> ("\\\"", "\"")
                }
            };

            rules.Add(rule);
            rules.Add(rule2);
        }

        private void OnBeautyButtonClick(object sender, EventArgs e)
        {
            afterTextBox.Text = beforeTextBox.Text.Replace("\\n", "").Replace(" ", "").Replace("\\\"", "\"");
        }
    }
}