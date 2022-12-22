namespace RC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Cipher_Click(object sender, EventArgs e)
        {
            char[] byteKey = Key.Text.ToCharArray();
            RC4 encoder = new(byteKey);
            char[] inputData = input.Text.ToCharArray();
            char[] result = encoder.Encode(inputData, inputData.Length);
            output.Text = CharArrToString(result);
        }
        public static string CharArrToString(char[] arr)
        {
            string res = "";
            for (int i = 0; i < arr.Length; i++) res += arr[i];
            return res;
        }
    }
}