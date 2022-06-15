using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomStringApp
{
    public partial class CustomStringForm : Form
    {

        CustomString str1;
        CustomString str2;

        public CustomStringForm()
        {
            InitializeComponent();
        }

        private void String1ReadJSONButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "JSON files (*.json)|*.json";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(OpenFileDialog.FileName);

                if (string.IsNullOrEmpty(json))
                {
                    MessageBox.Show("File Is Empty");
                    return;
                }

                str1 = (CustomString)JsonSerializer.Deserialize(json, typeof(CustomString));
                String1TextBox.Text = str1.ToString();
            }
        }

        private void String2ReadJSONButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "JSON files (*.json)|*.json";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(OpenFileDialog.FileName);

                if (string.IsNullOrEmpty(json))
                {
                    MessageBox.Show("File Is Empty");
                    return;
                }

                str2 = (CustomString)JsonSerializer.Deserialize(json, typeof(CustomString));
                String2TextBox.Text = str2.ToString();
            }
        }

        private void String1SaveJSONButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "JSON files (*.json)|*.json";

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (str1 is not null || str1.Length != 0)
                    File.WriteAllText(SaveFileDialog.FileName, JsonSerializer.Serialize(str1, typeof(CustomString)));
                else
                    MessageBox.Show("Custom String 1 Is Empty");
            }
        }

        private void String2SaveJSONButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "JSON files (*.json)|*.json";

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (str2 is not null || str2.Length != 0)
                    File.WriteAllText(SaveFileDialog.FileName, JsonSerializer.Serialize(str2, typeof(CustomString)));
                else
                    MessageBox.Show("Custom String 2 Is Empty");
            }
        }

        private void ComparisonOperatorLabel_Click(object sender, EventArgs e)
        {
            if (ComparisonOperatorLabel.Text == "==")
                ComparisonOperatorLabel.Text = ">";
            else if (ComparisonOperatorLabel.Text == ">")
                ComparisonOperatorLabel.Text = "<";
            else
                ComparisonOperatorLabel.Text = "==";
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            if (ComparisonOperatorLabel.Text == "==")
                MessageBox.Show((str1 == str2).ToString());
            else if(ComparisonOperatorLabel.Text == ">")
                MessageBox.Show((str1 > str2).ToString());
            else
                MessageBox.Show((str1 < str2).ToString());

        }

        private void String1TextBox_TextChanged(object sender, EventArgs e)
        {
            str1 = new CustomString(String1TextBox.Text.ToCharArray());
        }

        private void String2TextBox_TextChanged(object sender, EventArgs e)
        {
            str2 = new CustomString(String2TextBox.Text.ToCharArray());
        }

        private void ConcatenateButton_Click(object sender, EventArgs e)
        {
            ConcatenationResultTextBox.Text = (str1 + str2).ToString();
        }
    }
}
