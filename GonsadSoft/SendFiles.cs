using System;
using System.Windows.Forms;
using System.IO;


namespace GonsadSoft
{
    public partial class SendFiles : Form
    {
        public SendFiles()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the file name and path
                string fileName = openFileDialog1.FileName;

                // Create a new thread to perform the upload
                System.Threading.Thread thread = new System.Threading.Thread(() => UploadFile(fileName));
                thread.Start();

                // Show the progress bar
                progressBar1.Visible = true;

                // Disable the upload button
                btnUpload.Enabled = false;
            }
        }

        private void UploadFile(string fileName)
        {
            try
            {
                // Open the file and read the bytes
                byte[] fileBytes = File.ReadAllBytes(fileName);

                // Upload the file bytes to the server (this is just an example)
                // Replace this code with your own file upload logic
                for (int i = 0; i < 100; i++)
                {
                    // Simulate a delay
                    System.Threading.Thread.Sleep(100);

                    // Update the progress bar
                    UpdateProgress(i + 1);
                }

                // Show a message box when the upload is complete
                MessageBox.Show("Upload complete!");

                // Hide the progress bar
                progressBar1.Visible = false;

                // Enable the upload button
                btnUpload.Enabled = true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the upload process
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateProgress(int value)
        {
            // Invoke the progress bar update on the UI thread
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateProgress), value);
                return;
            }

            // Update the progress bar value
            progressBar1.Value = value;
        }
    }
}
